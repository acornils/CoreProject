


using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using SubSonic.DataProviders;
using SubSonic.Extensions;
using SubSonic.Linq.Structure;
using SubSonic.Query;
using SubSonic.Schema;
using System.Data.Common;
using System.Collections.Generic;

namespace Core
{
    public partial class CoreDB : IQuerySurface
    {

        public IDataProvider DataProvider;
        public DbQueryProvider provider;
        
        public static IDataProvider DefaultDataProvider { get; set; }

        public bool TestMode
		{
            get
			{
                return DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            }
        }

        public CoreDB() 
        {
            if (DefaultDataProvider == null) {
                DataProvider = ProviderFactory.GetProvider("Core");
            }
            else {
                DataProvider = DefaultDataProvider;
            }
            Init();
        }

        public CoreDB(string connectionStringName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionStringName);
            Init();
        }

		public CoreDB(string connectionString, string providerName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionString,providerName);
            Init();
        }

		public ITable FindByPrimaryKey(string pkName)
        {
            return DataProvider.Schema.Tables.SingleOrDefault(x => x.PrimaryKey.Name.Equals(pkName, StringComparison.InvariantCultureIgnoreCase));
        }

        public Query<T> GetQuery<T>()
        {
            return new Query<T>(provider);
        }
        
        public ITable FindTable(string tableName)
        {
            return DataProvider.FindTable(tableName);
        }
               
        public IDataProvider Provider
        {
            get { return DataProvider; }
            set {DataProvider=value;}
        }
        
        public DbQueryProvider QueryProvider
        {
            get { return provider; }
        }
        
        BatchQuery _batch = null;
        public void Queue<T>(IQueryable<T> qry)
        {
            if (_batch == null)
                _batch = new BatchQuery(Provider, QueryProvider);
            _batch.Queue(qry);
        }

        public void Queue(ISqlQuery qry)
        {
            if (_batch == null)
                _batch = new BatchQuery(Provider, QueryProvider);
            _batch.Queue(qry);
        }

        public void ExecuteTransaction(IList<DbCommand> commands)
		{
            if(!TestMode)
			{
                using(var connection = commands[0].Connection)
				{
                   if (connection.State == ConnectionState.Closed)
                        connection.Open();
                   
                   using (var trans = connection.BeginTransaction()) 
				   {
                        foreach (var cmd in commands) 
						{
                            cmd.Transaction = trans;
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    connection.Close();
                }
            }
        }

        public IDataReader ExecuteBatch()
        {
            if (_batch == null)
                throw new InvalidOperationException("There's nothing in the queue");
            if(!TestMode)
                return _batch.ExecuteReader();
            return null;
        }
			
        public Query<BillOfLadingRequestedCarTypeAttribute> BillOfLadingRequestedCarTypeAttributes { get; set; }
        public Query<CarType> CarTypes { get; set; }
        public Query<Setting> Settings { get; set; }
        public Query<BillOfLading> BillOfLadings { get; set; }
        public Query<SwitchListsLayout> SwitchListsLayouts { get; set; }
        public Query<Waybill> Waybills { get; set; }
        public Query<rfid> rfids { get; set; }
        public Query<EmptyCarBill> EmptyCarBills { get; set; }
        public Query<ARRCode> ARRCodes { get; set; }
        public Query<CarTypeAttribute> CarTypeAttributes { get; set; }
        public Query<rollingStockAtrribute> rollingStockAtrributes { get; set; }
        public Query<Location> Locations { get; set; }
        public Query<ConsigneeShipper> ConsigneeShippers { get; set; }
        public Query<BillOfLadingPath> BillOfLadingPaths { get; set; }
        public Query<RollingStock> RollingStocks { get; set; }

			

        #region ' Aggregates and SubSonic Queries '
        public Select SelectColumns(params string[] columns)
        {
            return new Select(DataProvider, columns);
        }

        public Select Select
        {
            get { return new Select(this.Provider); }
        }

        public Insert Insert
		{
            get { return new Insert(this.Provider); }
        }

        public Update<T> Update<T>() where T:new()
		{
            return new Update<T>(this.Provider);
        }

        public SqlQuery Delete<T>(Expression<Func<T,bool>> column) where T:new()
        {
            LambdaExpression lamda = column;
            SqlQuery result = new Delete<T>(this.Provider);
            result = result.From<T>();
            result.Constraints=lamda.ParseConstraints().ToList();
            return result;
        }

        public SqlQuery Max<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = DataProvider.FindTable(objectName).Name;
            return new Select(DataProvider, new Aggregate(colName, AggregateFunction.Max)).From(tableName);
        }

        public SqlQuery Min<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Min)).From(tableName);
        }

        public SqlQuery Sum<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Sum)).From(tableName);
        }

        public SqlQuery Avg<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Avg)).From(tableName);
        }

        public SqlQuery Count<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Count)).From(tableName);
        }

        public SqlQuery Variance<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Var)).From(tableName);
        }

        public SqlQuery StandardDeviation<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.StDev)).From(tableName);
        }

        #endregion

        void Init()
        {
            provider = new DbQueryProvider(this.Provider);

            #region ' Query Defs '
            BillOfLadingRequestedCarTypeAttributes = new Query<BillOfLadingRequestedCarTypeAttribute>(provider);
            CarTypes = new Query<CarType>(provider);
            Settings = new Query<Setting>(provider);
            BillOfLadings = new Query<BillOfLading>(provider);
            SwitchListsLayouts = new Query<SwitchListsLayout>(provider);
            Waybills = new Query<Waybill>(provider);
            rfids = new Query<rfid>(provider);
            EmptyCarBills = new Query<EmptyCarBill>(provider);
            ARRCodes = new Query<ARRCode>(provider);
            CarTypeAttributes = new Query<CarTypeAttribute>(provider);
            rollingStockAtrributes = new Query<rollingStockAtrribute>(provider);
            Locations = new Query<Location>(provider);
            ConsigneeShippers = new Query<ConsigneeShipper>(provider);
            BillOfLadingPaths = new Query<BillOfLadingPath>(provider);
            RollingStocks = new Query<RollingStock>(provider);
            #endregion


            #region ' Schemas '
        	if(DataProvider.Schema.Tables.Count == 0)
			{
            	DataProvider.Schema.Tables.Add(new BillOfLadingRequestedCarTypeAttributeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CarTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SettingsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new BillOfLadingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SwitchListsLayoutsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new WaybillsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new rfidTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new EmptyCarBillTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ARRCodesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CarTypeAttributesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new rollingStockAtrributesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LocationsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ConsigneeShipperTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new BillOfLadingPathTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new RollingStockTable(DataProvider));
            }
            #endregion
        }
        

        #region ' Helpers '
            
        internal static DateTime DateTimeNowTruncatedDownToSecond() {
            var now = DateTime.Now;
            return now.AddTicks(-now.Ticks % TimeSpan.TicksPerSecond);
        }

        #endregion

    }
}