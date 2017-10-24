


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SubSonic.DataProviders;
using SubSonic.Extensions;
using System.Linq.Expressions;
using SubSonic.Schema;
using System.Collections;
using SubSonic;
using SubSonic.Repository;
using System.ComponentModel;
using System.Data.Common;

namespace Core
{
    
    
    /// <summary>
    /// A class which represents the BillOfLadingRequestedCarTypeAttribute table in the Core Database.
    /// </summary>
    public partial class BillOfLadingRequestedCarTypeAttribute: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<BillOfLadingRequestedCarTypeAttribute> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<BillOfLadingRequestedCarTypeAttribute>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<BillOfLadingRequestedCarTypeAttribute> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(BillOfLadingRequestedCarTypeAttribute item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                BillOfLadingRequestedCarTypeAttribute item=new BillOfLadingRequestedCarTypeAttribute();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<BillOfLadingRequestedCarTypeAttribute> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public BillOfLadingRequestedCarTypeAttribute(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                BillOfLadingRequestedCarTypeAttribute.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<BillOfLadingRequestedCarTypeAttribute>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public BillOfLadingRequestedCarTypeAttribute(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public BillOfLadingRequestedCarTypeAttribute(Expression<Func<BillOfLadingRequestedCarTypeAttribute, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<BillOfLadingRequestedCarTypeAttribute> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<BillOfLadingRequestedCarTypeAttribute> _repo;
            
            if(db.TestMode){
                BillOfLadingRequestedCarTypeAttribute.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<BillOfLadingRequestedCarTypeAttribute>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<BillOfLadingRequestedCarTypeAttribute> GetRepo(){
            return GetRepo("","");
        }
        
        public static BillOfLadingRequestedCarTypeAttribute SingleOrDefault(Expression<Func<BillOfLadingRequestedCarTypeAttribute, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            BillOfLadingRequestedCarTypeAttribute single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static BillOfLadingRequestedCarTypeAttribute SingleOrDefault(Expression<Func<BillOfLadingRequestedCarTypeAttribute, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            BillOfLadingRequestedCarTypeAttribute single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<BillOfLadingRequestedCarTypeAttribute, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<BillOfLadingRequestedCarTypeAttribute, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<BillOfLadingRequestedCarTypeAttribute> Find(Expression<Func<BillOfLadingRequestedCarTypeAttribute, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<BillOfLadingRequestedCarTypeAttribute> Find(Expression<Func<BillOfLadingRequestedCarTypeAttribute, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<BillOfLadingRequestedCarTypeAttribute> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<BillOfLadingRequestedCarTypeAttribute> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<BillOfLadingRequestedCarTypeAttribute> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<BillOfLadingRequestedCarTypeAttribute> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<BillOfLadingRequestedCarTypeAttribute> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<BillOfLadingRequestedCarTypeAttribute> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.billOfLadingID.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(BillOfLadingRequestedCarTypeAttribute)){
                BillOfLadingRequestedCarTypeAttribute compare=(BillOfLadingRequestedCarTypeAttribute)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.billOfLadingID.ToString();
                    }

        public string DescriptorColumn() {
            return "billOfLadingID";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "billOfLadingID";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _billOfLadingID;
        public int? billOfLadingID
        {
            get { return _billOfLadingID; }
            set
            {
                if(_billOfLadingID!=value){
                    _billOfLadingID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="billOfLadingID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _carTypeAttributeID;
        public int? carTypeAttributeID
        {
            get { return _carTypeAttributeID; }
            set
            {
                if(_carTypeAttributeID!=value){
                    _carTypeAttributeID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="carTypeAttributeID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<BillOfLadingRequestedCarTypeAttribute, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the CarType table in the Core Database.
    /// </summary>
    public partial class CarType: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<CarType> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<CarType>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<CarType> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(CarType item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                CarType item=new CarType();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<CarType> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public CarType(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                CarType.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CarType>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public CarType(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public CarType(Expression<Func<CarType, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<CarType> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<CarType> _repo;
            
            if(db.TestMode){
                CarType.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CarType>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<CarType> GetRepo(){
            return GetRepo("","");
        }
        
        public static CarType SingleOrDefault(Expression<Func<CarType, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            CarType single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static CarType SingleOrDefault(Expression<Func<CarType, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            CarType single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<CarType, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<CarType, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<CarType> Find(Expression<Func<CarType, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<CarType> Find(Expression<Func<CarType, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<CarType> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<CarType> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<CarType> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<CarType> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<CarType> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<CarType> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.shortName.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(CarType)){
                CarType compare=(CarType)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.shortName.ToString();
                    }

        public string DescriptorColumn() {
            return "shortName";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "shortName";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _shortName;
        public string shortName
        {
            get { return _shortName; }
            set
            {
                if(_shortName!=value){
                    _shortName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="shortName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _longName;
        public string longName
        {
            get { return _longName; }
            set
            {
                if(_longName!=value){
                    _longName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="longName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _description;
        public string description
        {
            get { return _description; }
            set
            {
                if(_description!=value){
                    _description=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="description");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _isDeleted;
        public bool isDeleted
        {
            get { return _isDeleted; }
            set
            {
                if(_isDeleted!=value){
                    _isDeleted=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isDeleted");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                         
             this.isDeleted=true;
            _repo.Update(this,provider);
                
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<CarType, bool>> expression) {
            var repo = GetRepo();
            
            
            List<CarType> items=repo.GetAll().Where(expression).ToList();
            items.ForEach(x=>x.isDeleted=true);
            repo.Update(items);
            
        }

                
        public static void Destroy(Func<CarType, bool> expression) {
            var repo = GetRepo();
            repo.Delete(expression);
        }
        
        public static void Destroy(object key) {
            var repo = GetRepo();
            repo.Delete(key);
        }
        
        public static void Destroy(object key, IDataProvider provider) {
        
            var repo = GetRepo();
            repo.Delete(key,provider);
            
        }        
        
        public void Destroy() {
            _repo.Delete(KeyValue());
        }        
        public void Destroy(IDataProvider provider) {
            _repo.Delete(KeyValue(), provider);
        }         
        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Settings table in the Core Database.
    /// </summary>
    public partial class Setting: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Setting> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Setting>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Setting> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(Setting item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Setting item=new Setting();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Setting> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public Setting(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Setting.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Setting>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Setting(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Setting(Expression<Func<Setting, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Setting> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<Setting> _repo;
            
            if(db.TestMode){
                Setting.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Setting>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Setting> GetRepo(){
            return GetRepo("","");
        }
        
        public static Setting SingleOrDefault(Expression<Func<Setting, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Setting single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Setting SingleOrDefault(Expression<Func<Setting, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Setting single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Setting, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Setting, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Setting> Find(Expression<Func<Setting, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Setting> Find(Expression<Func<Setting, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Setting> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Setting> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Setting> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Setting> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Setting> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Setting> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.name.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Setting)){
                Setting compare=(Setting)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.name.ToString();
                    }

        public string DescriptorColumn() {
            return "name";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "name";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if(_name!=value){
                    _name=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="name");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _value;
        public string value
        {
            get { return _value; }
            set
            {
                if(_value!=value){
                    _value=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="value");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Setting, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the SwitchListsLayouts table in the Core Database.
    /// </summary>
    public partial class SwitchListsLayout: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<SwitchListsLayout> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<SwitchListsLayout>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<SwitchListsLayout> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(SwitchListsLayout item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                SwitchListsLayout item=new SwitchListsLayout();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<SwitchListsLayout> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public SwitchListsLayout(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                SwitchListsLayout.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<SwitchListsLayout>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public SwitchListsLayout(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public SwitchListsLayout(Expression<Func<SwitchListsLayout, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<SwitchListsLayout> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<SwitchListsLayout> _repo;
            
            if(db.TestMode){
                SwitchListsLayout.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<SwitchListsLayout>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<SwitchListsLayout> GetRepo(){
            return GetRepo("","");
        }
        
        public static SwitchListsLayout SingleOrDefault(Expression<Func<SwitchListsLayout, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            SwitchListsLayout single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static SwitchListsLayout SingleOrDefault(Expression<Func<SwitchListsLayout, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            SwitchListsLayout single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<SwitchListsLayout, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<SwitchListsLayout, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<SwitchListsLayout> Find(Expression<Func<SwitchListsLayout, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<SwitchListsLayout> Find(Expression<Func<SwitchListsLayout, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<SwitchListsLayout> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<SwitchListsLayout> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<SwitchListsLayout> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<SwitchListsLayout> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<SwitchListsLayout> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<SwitchListsLayout> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.name.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(SwitchListsLayout)){
                SwitchListsLayout compare=(SwitchListsLayout)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.name.ToString();
                    }

        public string DescriptorColumn() {
            return "name";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "name";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if(_name!=value){
                    _name=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="name");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        byte[] _image;
        public byte[] image
        {
            get { return _image; }
            set
            {
                if(_image!=value){
                    _image=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="image");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _firstRowStart;
        public int? firstRowStart
        {
            get { return _firstRowStart; }
            set
            {
                if(_firstRowStart!=value){
                    _firstRowStart=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="firstRowStart");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _rowSpacing;
        public int? rowSpacing
        {
            get { return _rowSpacing; }
            set
            {
                if(_rowSpacing!=value){
                    _rowSpacing=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="rowSpacing");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _initialColumn;
        public int? initialColumn
        {
            get { return _initialColumn; }
            set
            {
                if(_initialColumn!=value){
                    _initialColumn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="initialColumn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _numberColumn;
        public int? numberColumn
        {
            get { return _numberColumn; }
            set
            {
                if(_numberColumn!=value){
                    _numberColumn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="numberColumn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _kindColumn;
        public int? kindColumn
        {
            get { return _kindColumn; }
            set
            {
                if(_kindColumn!=value){
                    _kindColumn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="kindColumn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _contentsColumn;
        public int? contentsColumn
        {
            get { return _contentsColumn; }
            set
            {
                if(_contentsColumn!=value){
                    _contentsColumn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="contentsColumn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _originColumn;
        public int? originColumn
        {
            get { return _originColumn; }
            set
            {
                if(_originColumn!=value){
                    _originColumn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="originColumn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _destinationColumn;
        public int? destinationColumn
        {
            get { return _destinationColumn; }
            set
            {
                if(_destinationColumn!=value){
                    _destinationColumn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="destinationColumn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _tonsColumn;
        public int? tonsColumn
        {
            get { return _tonsColumn; }
            set
            {
                if(_tonsColumn!=value){
                    _tonsColumn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="tonsColumn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _remarksColumn;
        public int? remarksColumn
        {
            get { return _remarksColumn; }
            set
            {
                if(_remarksColumn!=value){
                    _remarksColumn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="remarksColumn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _trainNoLocation;
        public string trainNoLocation
        {
            get { return _trainNoLocation; }
            set
            {
                if(_trainNoLocation!=value){
                    _trainNoLocation=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="trainNoLocation");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _engineNoLocation;
        public string engineNoLocation
        {
            get { return _engineNoLocation; }
            set
            {
                if(_engineNoLocation!=value){
                    _engineNoLocation=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="engineNoLocation");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _stationLocation;
        public string stationLocation
        {
            get { return _stationLocation; }
            set
            {
                if(_stationLocation!=value){
                    _stationLocation=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="stationLocation");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _timeLocation;
        public string timeLocation
        {
            get { return _timeLocation; }
            set
            {
                if(_timeLocation!=value){
                    _timeLocation=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="timeLocation");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _yearLocation;
        public string yearLocation
        {
            get { return _yearLocation; }
            set
            {
                if(_yearLocation!=value){
                    _yearLocation=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="yearLocation");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _dateLocation;
        public string dateLocation
        {
            get { return _dateLocation; }
            set
            {
                if(_dateLocation!=value){
                    _dateLocation=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="dateLocation");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _maxRows;
        public int? maxRows
        {
            get { return _maxRows; }
            set
            {
                if(_maxRows!=value){
                    _maxRows=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="maxRows");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _backRowStart;
        public int? backRowStart
        {
            get { return _backRowStart; }
            set
            {
                if(_backRowStart!=value){
                    _backRowStart=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="backRowStart");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _maxRowsFront;
        public int? maxRowsFront
        {
            get { return _maxRowsFront; }
            set
            {
                if(_maxRowsFront!=value){
                    _maxRowsFront=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="maxRowsFront");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<SwitchListsLayout, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the rfid table in the Core Database.
    /// </summary>
    public partial class rfid: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<rfid> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<rfid>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<rfid> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(rfid item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                rfid item=new rfid();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<rfid> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public rfid(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                rfid.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<rfid>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public rfid(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public rfid(Expression<Func<rfid, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<rfid> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<rfid> _repo;
            
            if(db.TestMode){
                rfid.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<rfid>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<rfid> GetRepo(){
            return GetRepo("","");
        }
        
        public static rfid SingleOrDefault(Expression<Func<rfid, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            rfid single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static rfid SingleOrDefault(Expression<Func<rfid, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            rfid single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<rfid, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<rfid, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<rfid> Find(Expression<Func<rfid, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<rfid> Find(Expression<Func<rfid, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<rfid> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<rfid> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<rfid> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<rfid> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<rfid> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<rfid> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.postdata.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(rfid)){
                rfid compare=(rfid)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.postdata.ToString();
                    }

        public string DescriptorColumn() {
            return "postdata";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "postdata";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _postdata;
        public string postdata
        {
            get { return _postdata; }
            set
            {
                if(_postdata!=value){
                    _postdata=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="postdata");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _scanner;
        public string scanner
        {
            get { return _scanner; }
            set
            {
                if(_scanner!=value){
                    _scanner=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="scanner");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _head;
        public string head
        {
            get { return _head; }
            set
            {
                if(_head!=value){
                    _head=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="head");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _tag;
        public string tag
        {
            get { return _tag; }
            set
            {
                if(_tag!=value){
                    _tag=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="tag");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _scannedAt;
        public DateTime? scannedAt
        {
            get { return _scannedAt; }
            set
            {
                if(_scannedAt!=value){
                    _scannedAt=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="scannedAt");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _lastScanned;
        public bool? lastScanned
        {
            get { return _lastScanned; }
            set
            {
                if(_lastScanned!=value){
                    _lastScanned=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="lastScanned");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<rfid, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the EmptyCarBill table in the Core Database.
    /// </summary>
    public partial class EmptyCarBill: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<EmptyCarBill> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<EmptyCarBill>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<EmptyCarBill> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(EmptyCarBill item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                EmptyCarBill item=new EmptyCarBill();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<EmptyCarBill> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public EmptyCarBill(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                EmptyCarBill.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<EmptyCarBill>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public EmptyCarBill(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public EmptyCarBill(Expression<Func<EmptyCarBill, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<EmptyCarBill> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<EmptyCarBill> _repo;
            
            if(db.TestMode){
                EmptyCarBill.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<EmptyCarBill>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<EmptyCarBill> GetRepo(){
            return GetRepo("","");
        }
        
        public static EmptyCarBill SingleOrDefault(Expression<Func<EmptyCarBill, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            EmptyCarBill single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static EmptyCarBill SingleOrDefault(Expression<Func<EmptyCarBill, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            EmptyCarBill single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<EmptyCarBill, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<EmptyCarBill, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<EmptyCarBill> Find(Expression<Func<EmptyCarBill, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<EmptyCarBill> Find(Expression<Func<EmptyCarBill, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<EmptyCarBill> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<EmptyCarBill> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<EmptyCarBill> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<EmptyCarBill> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<EmptyCarBill> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<EmptyCarBill> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.isForHome.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(EmptyCarBill)){
                EmptyCarBill compare=(EmptyCarBill)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.isForHome.ToString();
                    }

        public string DescriptorColumn() {
            return "isForHome";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "isForHome";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isForHome;
        public bool? isForHome
        {
            get { return _isForHome; }
            set
            {
                if(_isForHome!=value){
                    _isForHome=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isForHome");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _billedFromID;
        public int? billedFromID
        {
            get { return _billedFromID; }
            set
            {
                if(_billedFromID!=value){
                    _billedFromID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="billedFromID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _billedToVia;
        public int? billedToVia
        {
            get { return _billedToVia; }
            set
            {
                if(_billedToVia!=value){
                    _billedToVia=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="billedToVia");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _RollingStockID;
        public int? RollingStockID
        {
            get { return _RollingStockID; }
            set
            {
                if(_RollingStockID!=value){
                    _RollingStockID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RollingStockID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _billOfLadingID;
        public int? billOfLadingID
        {
            get { return _billOfLadingID; }
            set
            {
                if(_billOfLadingID!=value){
                    _billOfLadingID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="billOfLadingID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _canConfiscate;
        public bool? canConfiscate
        {
            get { return _canConfiscate; }
            set
            {
                if(_canConfiscate!=value){
                    _canConfiscate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="canConfiscate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _onSpotAtShipper;
        public int? onSpotAtShipper
        {
            get { return _onSpotAtShipper; }
            set
            {
                if(_onSpotAtShipper!=value){
                    _onSpotAtShipper=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="onSpotAtShipper");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _onSpotAtConsignee;
        public int? onSpotAtConsignee
        {
            get { return _onSpotAtConsignee; }
            set
            {
                if(_onSpotAtConsignee!=value){
                    _onSpotAtConsignee=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="onSpotAtConsignee");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _CreatedOn;
        public DateTime? CreatedOn
        {
            get { return _CreatedOn; }
            set
            {
                if(_CreatedOn!=value){
                    _CreatedOn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CreatedOn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            this.CreatedOn=CoreDB.DateTimeNowTruncatedDownToSecond();
            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<EmptyCarBill, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the ARRCodes table in the Core Database.
    /// </summary>
    public partial class ARRCode: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<ARRCode> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<ARRCode>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<ARRCode> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(ARRCode item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                ARRCode item=new ARRCode();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<ARRCode> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public ARRCode(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                ARRCode.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<ARRCode>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public ARRCode(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public ARRCode(Expression<Func<ARRCode, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<ARRCode> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<ARRCode> _repo;
            
            if(db.TestMode){
                ARRCode.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<ARRCode>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<ARRCode> GetRepo(){
            return GetRepo("","");
        }
        
        public static ARRCode SingleOrDefault(Expression<Func<ARRCode, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            ARRCode single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static ARRCode SingleOrDefault(Expression<Func<ARRCode, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            ARRCode single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<ARRCode, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<ARRCode, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<ARRCode> Find(Expression<Func<ARRCode, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<ARRCode> Find(Expression<Func<ARRCode, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<ARRCode> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<ARRCode> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<ARRCode> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<ARRCode> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<ARRCode> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<ARRCode> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.No.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(ARRCode)){
                ARRCode compare=(ARRCode)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.No.ToString();
                    }

        public string DescriptorColumn() {
            return "No";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "No";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _No;
        public string No
        {
            get { return _No; }
            set
            {
                if(_No!=value){
                    _No=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="No");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Carrier;
        public string Carrier
        {
            get { return _Carrier; }
            set
            {
                if(_Carrier!=value){
                    _Carrier=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Carrier");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Abbr;
        public string Abbr
        {
            get { return _Abbr; }
            set
            {
                if(_Abbr!=value){
                    _Abbr=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Abbr");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _isDeleted;
        public bool isDeleted
        {
            get { return _isDeleted; }
            set
            {
                if(_isDeleted!=value){
                    _isDeleted=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isDeleted");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                         
             this.isDeleted=true;
            _repo.Update(this,provider);
                
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<ARRCode, bool>> expression) {
            var repo = GetRepo();
            
            
            List<ARRCode> items=repo.GetAll().Where(expression).ToList();
            items.ForEach(x=>x.isDeleted=true);
            repo.Update(items);
            
        }

                
        public static void Destroy(Func<ARRCode, bool> expression) {
            var repo = GetRepo();
            repo.Delete(expression);
        }
        
        public static void Destroy(object key) {
            var repo = GetRepo();
            repo.Delete(key);
        }
        
        public static void Destroy(object key, IDataProvider provider) {
        
            var repo = GetRepo();
            repo.Delete(key,provider);
            
        }        
        
        public void Destroy() {
            _repo.Delete(KeyValue());
        }        
        public void Destroy(IDataProvider provider) {
            _repo.Delete(KeyValue(), provider);
        }         
        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the CarTypeAttributes table in the Core Database.
    /// </summary>
    public partial class CarTypeAttribute: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<CarTypeAttribute> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<CarTypeAttribute>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<CarTypeAttribute> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(CarTypeAttribute item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                CarTypeAttribute item=new CarTypeAttribute();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<CarTypeAttribute> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public CarTypeAttribute(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                CarTypeAttribute.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CarTypeAttribute>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public CarTypeAttribute(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public CarTypeAttribute(Expression<Func<CarTypeAttribute, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<CarTypeAttribute> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<CarTypeAttribute> _repo;
            
            if(db.TestMode){
                CarTypeAttribute.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CarTypeAttribute>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<CarTypeAttribute> GetRepo(){
            return GetRepo("","");
        }
        
        public static CarTypeAttribute SingleOrDefault(Expression<Func<CarTypeAttribute, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            CarTypeAttribute single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static CarTypeAttribute SingleOrDefault(Expression<Func<CarTypeAttribute, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            CarTypeAttribute single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<CarTypeAttribute, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<CarTypeAttribute, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<CarTypeAttribute> Find(Expression<Func<CarTypeAttribute, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<CarTypeAttribute> Find(Expression<Func<CarTypeAttribute, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<CarTypeAttribute> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<CarTypeAttribute> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<CarTypeAttribute> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<CarTypeAttribute> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<CarTypeAttribute> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<CarTypeAttribute> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.attribute.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(CarTypeAttribute)){
                CarTypeAttribute compare=(CarTypeAttribute)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.attribute.ToString();
                    }

        public string DescriptorColumn() {
            return "attribute";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "attribute";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _carTypeID;
        public int? carTypeID
        {
            get { return _carTypeID; }
            set
            {
                if(_carTypeID!=value){
                    _carTypeID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="carTypeID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _attribute;
        public string attribute
        {
            get { return _attribute; }
            set
            {
                if(_attribute!=value){
                    _attribute=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="attribute");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _isDeleted;
        public bool isDeleted
        {
            get { return _isDeleted; }
            set
            {
                if(_isDeleted!=value){
                    _isDeleted=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isDeleted");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                         
             this.isDeleted=true;
            _repo.Update(this,provider);
                
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<CarTypeAttribute, bool>> expression) {
            var repo = GetRepo();
            
            
            List<CarTypeAttribute> items=repo.GetAll().Where(expression).ToList();
            items.ForEach(x=>x.isDeleted=true);
            repo.Update(items);
            
        }

                
        public static void Destroy(Func<CarTypeAttribute, bool> expression) {
            var repo = GetRepo();
            repo.Delete(expression);
        }
        
        public static void Destroy(object key) {
            var repo = GetRepo();
            repo.Delete(key);
        }
        
        public static void Destroy(object key, IDataProvider provider) {
        
            var repo = GetRepo();
            repo.Delete(key,provider);
            
        }        
        
        public void Destroy() {
            _repo.Delete(KeyValue());
        }        
        public void Destroy(IDataProvider provider) {
            _repo.Delete(KeyValue(), provider);
        }         
        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the rollingStockAtrributes table in the Core Database.
    /// </summary>
    public partial class rollingStockAtrribute: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<rollingStockAtrribute> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<rollingStockAtrribute>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<rollingStockAtrribute> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(rollingStockAtrribute item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                rollingStockAtrribute item=new rollingStockAtrribute();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<rollingStockAtrribute> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public rollingStockAtrribute(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                rollingStockAtrribute.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<rollingStockAtrribute>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public rollingStockAtrribute(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public rollingStockAtrribute(Expression<Func<rollingStockAtrribute, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<rollingStockAtrribute> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<rollingStockAtrribute> _repo;
            
            if(db.TestMode){
                rollingStockAtrribute.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<rollingStockAtrribute>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<rollingStockAtrribute> GetRepo(){
            return GetRepo("","");
        }
        
        public static rollingStockAtrribute SingleOrDefault(Expression<Func<rollingStockAtrribute, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            rollingStockAtrribute single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static rollingStockAtrribute SingleOrDefault(Expression<Func<rollingStockAtrribute, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            rollingStockAtrribute single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<rollingStockAtrribute, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<rollingStockAtrribute, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<rollingStockAtrribute> Find(Expression<Func<rollingStockAtrribute, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<rollingStockAtrribute> Find(Expression<Func<rollingStockAtrribute, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<rollingStockAtrribute> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<rollingStockAtrribute> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<rollingStockAtrribute> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<rollingStockAtrribute> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<rollingStockAtrribute> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<rollingStockAtrribute> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.rollingStockID.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(rollingStockAtrribute)){
                rollingStockAtrribute compare=(rollingStockAtrribute)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.rollingStockID.ToString();
                    }

        public string DescriptorColumn() {
            return "rollingStockID";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "rollingStockID";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _rollingStockID;
        public int? rollingStockID
        {
            get { return _rollingStockID; }
            set
            {
                if(_rollingStockID!=value){
                    _rollingStockID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="rollingStockID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _carTypeAttrID;
        public int? carTypeAttrID
        {
            get { return _carTypeAttrID; }
            set
            {
                if(_carTypeAttrID!=value){
                    _carTypeAttrID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="carTypeAttrID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<rollingStockAtrribute, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Waybills table in the Core Database.
    /// </summary>
    public partial class Waybill: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Waybill> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Waybill>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Waybill> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(Waybill item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Waybill item=new Waybill();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Waybill> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public Waybill(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Waybill.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Waybill>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Waybill(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Waybill(Expression<Func<Waybill, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Waybill> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<Waybill> _repo;
            
            if(db.TestMode){
                Waybill.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Waybill>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Waybill> GetRepo(){
            return GetRepo("","");
        }
        
        public static Waybill SingleOrDefault(Expression<Func<Waybill, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Waybill single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Waybill SingleOrDefault(Expression<Func<Waybill, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Waybill single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Waybill, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Waybill, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Waybill> Find(Expression<Func<Waybill, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Waybill> Find(Expression<Func<Waybill, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Waybill> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Waybill> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Waybill> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Waybill> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Waybill> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Waybill> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.billOfLadingID.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Waybill)){
                Waybill compare=(Waybill)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.billOfLadingID.ToString();
                    }

        public string DescriptorColumn() {
            return "billOfLadingID";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "billOfLadingID";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _billOfLadingID;
        public int? billOfLadingID
        {
            get { return _billOfLadingID; }
            set
            {
                if(_billOfLadingID!=value){
                    _billOfLadingID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="billOfLadingID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _consigneeID;
        public int? consigneeID
        {
            get { return _consigneeID; }
            set
            {
                if(_consigneeID!=value){
                    _consigneeID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="consigneeID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _shipperID;
        public int? shipperID
        {
            get { return _shipperID; }
            set
            {
                if(_shipperID!=value){
                    _shipperID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="shipperID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _assignedRollingStockID;
        public int? assignedRollingStockID
        {
            get { return _assignedRollingStockID; }
            set
            {
                if(_assignedRollingStockID!=value){
                    _assignedRollingStockID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="assignedRollingStockID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _loadedAt;
        public DateTime? loadedAt
        {
            get { return _loadedAt; }
            set
            {
                if(_loadedAt!=value){
                    _loadedAt=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="loadedAt");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _unloadedAt;
        public DateTime? unloadedAt
        {
            get { return _unloadedAt; }
            set
            {
                if(_unloadedAt!=value){
                    _unloadedAt=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="unloadedAt");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _preIcedAt;
        public DateTime? preIcedAt
        {
            get { return _preIcedAt; }
            set
            {
                if(_preIcedAt!=value){
                    _preIcedAt=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="preIcedAt");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _initialIcedAt;
        public DateTime? initialIcedAt
        {
            get { return _initialIcedAt; }
            set
            {
                if(_initialIcedAt!=value){
                    _initialIcedAt=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="initialIcedAt");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isWeighed;
        public bool? isWeighed
        {
            get { return _isWeighed; }
            set
            {
                if(_isWeighed!=value){
                    _isWeighed=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isWeighed");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _weight;
        public int? weight
        {
            get { return _weight; }
            set
            {
                if(_weight!=value){
                    _weight=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="weight");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _onSpotAtShipper;
        public int onSpotAtShipper
        {
            get { return _onSpotAtShipper; }
            set
            {
                if(_onSpotAtShipper!=value){
                    _onSpotAtShipper=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="onSpotAtShipper");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _onSpotAtConsignee;
        public int onSpotAtConsignee
        {
            get { return _onSpotAtConsignee; }
            set
            {
                if(_onSpotAtConsignee!=value){
                    _onSpotAtConsignee=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="onSpotAtConsignee");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _isPerishableWaybill;
        public bool isPerishableWaybill
        {
            get { return _isPerishableWaybill; }
            set
            {
                if(_isPerishableWaybill!=value){
                    _isPerishableWaybill=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isPerishableWaybill");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _isLiveStockWaybill;
        public bool isLiveStockWaybill
        {
            get { return _isLiveStockWaybill; }
            set
            {
                if(_isLiveStockWaybill!=value){
                    _isLiveStockWaybill=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isLiveStockWaybill");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _isEmptyWayBill;
        public bool isEmptyWayBill
        {
            get { return _isEmptyWayBill; }
            set
            {
                if(_isEmptyWayBill!=value){
                    _isEmptyWayBill=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isEmptyWayBill");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _waybillOrder;
        public int? waybillOrder
        {
            get { return _waybillOrder; }
            set
            {
                if(_waybillOrder!=value){
                    _waybillOrder=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="waybillOrder");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isDeleted;
        public bool? isDeleted
        {
            get { return _isDeleted; }
            set
            {
                if(_isDeleted!=value){
                    _isDeleted=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isDeleted");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _createdOn;
        public DateTime? createdOn
        {
            get { return _createdOn; }
            set
            {
                if(_createdOn!=value){
                    _createdOn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="createdOn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _modifiedOn;
        public DateTime? modifiedOn
        {
            get { return _modifiedOn; }
            set
            {
                if(_modifiedOn!=value){
                    _modifiedOn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="modifiedOn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if (!_dirtyColumns.Any(x => x.Name.ToLower() == "modifiedon")) {
               this.modifiedOn=CoreDB.DateTimeNowTruncatedDownToSecond();
            }            
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                         
             this.isDeleted=true;
            _repo.Update(this,provider);
                
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Waybill, bool>> expression) {
            var repo = GetRepo();
            
            
            List<Waybill> items=repo.GetAll().Where(expression).ToList();
            items.ForEach(x=>x.isDeleted=true);
            repo.Update(items);
            
        }

                
        public static void Destroy(Func<Waybill, bool> expression) {
            var repo = GetRepo();
            repo.Delete(expression);
        }
        
        public static void Destroy(object key) {
            var repo = GetRepo();
            repo.Delete(key);
        }
        
        public static void Destroy(object key, IDataProvider provider) {
        
            var repo = GetRepo();
            repo.Delete(key,provider);
            
        }        
        
        public void Destroy() {
            _repo.Delete(KeyValue());
        }        
        public void Destroy(IDataProvider provider) {
            _repo.Delete(KeyValue(), provider);
        }         
        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Locations table in the Core Database.
    /// </summary>
    public partial class Location: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Location> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Location>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Location> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(Location item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Location item=new Location();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Location> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public Location(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Location.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Location>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Location(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Location(Expression<Func<Location, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Location> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<Location> _repo;
            
            if(db.TestMode){
                Location.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Location>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Location> GetRepo(){
            return GetRepo("","");
        }
        
        public static Location SingleOrDefault(Expression<Func<Location, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Location single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Location SingleOrDefault(Expression<Func<Location, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Location single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Location, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Location, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Location> Find(Expression<Func<Location, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Location> Find(Expression<Func<Location, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<Location> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<Location> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<Location> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Location> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Location> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Location> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.name.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(Location)){
                Location compare=(Location)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.name.ToString();
                    }

        public string DescriptorColumn() {
            return "name";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "name";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if(_name!=value){
                    _name=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="name");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _shortName;
        public string shortName
        {
            get { return _shortName; }
            set
            {
                if(_shortName!=value){
                    _shortName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="shortName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ScannerMAC;
        public string ScannerMAC
        {
            get { return _ScannerMAC; }
            set
            {
                if(_ScannerMAC!=value){
                    _ScannerMAC=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ScannerMAC");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ScannerHead;
        public string ScannerHead
        {
            get { return _ScannerHead; }
            set
            {
                if(_ScannerHead!=value){
                    _ScannerHead=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ScannerHead");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isRFIDRead;
        public bool? isRFIDRead
        {
            get { return _isRFIDRead; }
            set
            {
                if(_isRFIDRead!=value){
                    _isRFIDRead=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isRFIDRead");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isDeleted;
        public bool? isDeleted
        {
            get { return _isDeleted; }
            set
            {
                if(_isDeleted!=value){
                    _isDeleted=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isDeleted");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                         
             this.isDeleted=true;
            _repo.Update(this,provider);
                
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Location, bool>> expression) {
            var repo = GetRepo();
            
            
            List<Location> items=repo.GetAll().Where(expression).ToList();
            items.ForEach(x=>x.isDeleted=true);
            repo.Update(items);
            
        }

                
        public static void Destroy(Func<Location, bool> expression) {
            var repo = GetRepo();
            repo.Delete(expression);
        }
        
        public static void Destroy(object key) {
            var repo = GetRepo();
            repo.Delete(key);
        }
        
        public static void Destroy(object key, IDataProvider provider) {
        
            var repo = GetRepo();
            repo.Delete(key,provider);
            
        }        
        
        public void Destroy() {
            _repo.Delete(KeyValue());
        }        
        public void Destroy(IDataProvider provider) {
            _repo.Delete(KeyValue(), provider);
        }         
        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the ConsigneeShipper table in the Core Database.
    /// </summary>
    public partial class ConsigneeShipper: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<ConsigneeShipper> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<ConsigneeShipper>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<ConsigneeShipper> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(ConsigneeShipper item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                ConsigneeShipper item=new ConsigneeShipper();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<ConsigneeShipper> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public ConsigneeShipper(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                ConsigneeShipper.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<ConsigneeShipper>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public ConsigneeShipper(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public ConsigneeShipper(Expression<Func<ConsigneeShipper, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<ConsigneeShipper> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<ConsigneeShipper> _repo;
            
            if(db.TestMode){
                ConsigneeShipper.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<ConsigneeShipper>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<ConsigneeShipper> GetRepo(){
            return GetRepo("","");
        }
        
        public static ConsigneeShipper SingleOrDefault(Expression<Func<ConsigneeShipper, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            ConsigneeShipper single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static ConsigneeShipper SingleOrDefault(Expression<Func<ConsigneeShipper, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            ConsigneeShipper single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<ConsigneeShipper, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<ConsigneeShipper, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<ConsigneeShipper> Find(Expression<Func<ConsigneeShipper, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<ConsigneeShipper> Find(Expression<Func<ConsigneeShipper, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<ConsigneeShipper> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<ConsigneeShipper> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<ConsigneeShipper> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<ConsigneeShipper> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<ConsigneeShipper> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<ConsigneeShipper> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.name.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(ConsigneeShipper)){
                ConsigneeShipper compare=(ConsigneeShipper)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.name.ToString();
                    }

        public string DescriptorColumn() {
            return "name";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "name";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _locationID;
        public int? locationID
        {
            get { return _locationID; }
            set
            {
                if(_locationID!=value){
                    _locationID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="locationID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if(_name!=value){
                    _name=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="name");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _aarCodeID;
        public int? aarCodeID
        {
            get { return _aarCodeID; }
            set
            {
                if(_aarCodeID!=value){
                    _aarCodeID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="aarCodeID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<ConsigneeShipper, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the BillOfLading table in the Core Database.
    /// </summary>
    public partial class BillOfLading: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<BillOfLading> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<BillOfLading>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<BillOfLading> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(BillOfLading item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                BillOfLading item=new BillOfLading();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<BillOfLading> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public BillOfLading(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                BillOfLading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<BillOfLading>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public BillOfLading(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public BillOfLading(Expression<Func<BillOfLading, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<BillOfLading> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<BillOfLading> _repo;
            
            if(db.TestMode){
                BillOfLading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<BillOfLading>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<BillOfLading> GetRepo(){
            return GetRepo("","");
        }
        
        public static BillOfLading SingleOrDefault(Expression<Func<BillOfLading, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            BillOfLading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static BillOfLading SingleOrDefault(Expression<Func<BillOfLading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            BillOfLading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<BillOfLading, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<BillOfLading, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<BillOfLading> Find(Expression<Func<BillOfLading, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<BillOfLading> Find(Expression<Func<BillOfLading, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<BillOfLading> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<BillOfLading> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<BillOfLading> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<BillOfLading> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<BillOfLading> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<BillOfLading> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.noPackages.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(BillOfLading)){
                BillOfLading compare=(BillOfLading)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.noPackages.ToString();
                    }

        public string DescriptorColumn() {
            return "noPackages";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "noPackages";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _consigneeID;
        public int? consigneeID
        {
            get { return _consigneeID; }
            set
            {
                if(_consigneeID!=value){
                    _consigneeID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="consigneeID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _shipperID;
        public int? shipperID
        {
            get { return _shipperID; }
            set
            {
                if(_shipperID!=value){
                    _shipperID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="shipperID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _carTypeRequestedID;
        public int? carTypeRequestedID
        {
            get { return _carTypeRequestedID; }
            set
            {
                if(_carTypeRequestedID!=value){
                    _carTypeRequestedID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="carTypeRequestedID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _carLengthRequested;
        public int? carLengthRequested
        {
            get { return _carLengthRequested; }
            set
            {
                if(_carLengthRequested!=value){
                    _carLengthRequested=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="carLengthRequested");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _carCapacityRequested;
        public int? carCapacityRequested
        {
            get { return _carCapacityRequested; }
            set
            {
                if(_carCapacityRequested!=value){
                    _carCapacityRequested=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="carCapacityRequested");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _noPackages;
        public string noPackages
        {
            get { return _noPackages; }
            set
            {
                if(_noPackages!=value){
                    _noPackages=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="noPackages");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _descriptionOfArticles;
        public string descriptionOfArticles
        {
            get { return _descriptionOfArticles; }
            set
            {
                if(_descriptionOfArticles!=value){
                    _descriptionOfArticles=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="descriptionOfArticles");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _displayText;
        public string displayText
        {
            get { return _displayText; }
            set
            {
                if(_displayText!=value){
                    _displayText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="displayText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isPerishable;
        public bool? isPerishable
        {
            get { return _isPerishable; }
            set
            {
                if(_isPerishable!=value){
                    _isPerishable=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isPerishable");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isPreIce;
        public bool? isPreIce
        {
            get { return _isPreIce; }
            set
            {
                if(_isPreIce!=value){
                    _isPreIce=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isPreIce");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isInitialIce;
        public bool? isInitialIce
        {
            get { return _isInitialIce; }
            set
            {
                if(_isInitialIce!=value){
                    _isInitialIce=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isInitialIce");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _cps;
        public int? cps
        {
            get { return _cps; }
            set
            {
                if(_cps!=value){
                    _cps=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="cps");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isEmptyCarRequested;
        public bool? isEmptyCarRequested
        {
            get { return _isEmptyCarRequested; }
            set
            {
                if(_isEmptyCarRequested!=value){
                    _isEmptyCarRequested=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isEmptyCarRequested");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isLiveStock;
        public bool? isLiveStock
        {
            get { return _isLiveStock; }
            set
            {
                if(_isLiveStock!=value){
                    _isLiveStock=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isLiveStock");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isReverseRoute;
        public bool? isReverseRoute
        {
            get { return _isReverseRoute; }
            set
            {
                if(_isReverseRoute!=value){
                    _isReverseRoute=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isReverseRoute");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isReturnEmpty;
        public bool? isReturnEmpty
        {
            get { return _isReturnEmpty; }
            set
            {
                if(_isReturnEmpty!=value){
                    _isReturnEmpty=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isReturnEmpty");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        decimal? _requestedCarsPerDay;
        public decimal? requestedCarsPerDay
        {
            get { return _requestedCarsPerDay; }
            set
            {
                if(_requestedCarsPerDay!=value){
                    _requestedCarsPerDay=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="requestedCarsPerDay");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _timeToUnload;
        public int? timeToUnload
        {
            get { return _timeToUnload; }
            set
            {
                if(_timeToUnload!=value){
                    _timeToUnload=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="timeToUnload");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _timeToLoad;
        public int? timeToLoad
        {
            get { return _timeToLoad; }
            set
            {
                if(_timeToLoad!=value){
                    _timeToLoad=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="timeToLoad");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isDeleted;
        public bool? isDeleted
        {
            get { return _isDeleted; }
            set
            {
                if(_isDeleted!=value){
                    _isDeleted=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isDeleted");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _createdOn;
        public DateTime? createdOn
        {
            get { return _createdOn; }
            set
            {
                if(_createdOn!=value){
                    _createdOn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="createdOn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        DateTime? _modifiedOn;
        public DateTime? modifiedOn
        {
            get { return _modifiedOn; }
            set
            {
                if(_modifiedOn!=value){
                    _modifiedOn=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="modifiedOn");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if (!_dirtyColumns.Any(x => x.Name.ToLower() == "modifiedon")) {
               this.modifiedOn=CoreDB.DateTimeNowTruncatedDownToSecond();
            }            
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                         
             this.isDeleted=true;
            _repo.Update(this,provider);
                
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<BillOfLading, bool>> expression) {
            var repo = GetRepo();
            
            
            List<BillOfLading> items=repo.GetAll().Where(expression).ToList();
            items.ForEach(x=>x.isDeleted=true);
            repo.Update(items);
            
        }

                
        public static void Destroy(Func<BillOfLading, bool> expression) {
            var repo = GetRepo();
            repo.Delete(expression);
        }
        
        public static void Destroy(object key) {
            var repo = GetRepo();
            repo.Delete(key);
        }
        
        public static void Destroy(object key, IDataProvider provider) {
        
            var repo = GetRepo();
            repo.Delete(key,provider);
            
        }        
        
        public void Destroy() {
            _repo.Delete(KeyValue());
        }        
        public void Destroy(IDataProvider provider) {
            _repo.Delete(KeyValue(), provider);
        }         
        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the BillOfLadingPath table in the Core Database.
    /// </summary>
    public partial class BillOfLadingPath: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<BillOfLadingPath> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<BillOfLadingPath>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<BillOfLadingPath> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(BillOfLadingPath item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                BillOfLadingPath item=new BillOfLadingPath();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<BillOfLadingPath> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public BillOfLadingPath(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                BillOfLadingPath.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<BillOfLadingPath>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public BillOfLadingPath(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public BillOfLadingPath(Expression<Func<BillOfLadingPath, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<BillOfLadingPath> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<BillOfLadingPath> _repo;
            
            if(db.TestMode){
                BillOfLadingPath.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<BillOfLadingPath>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<BillOfLadingPath> GetRepo(){
            return GetRepo("","");
        }
        
        public static BillOfLadingPath SingleOrDefault(Expression<Func<BillOfLadingPath, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            BillOfLadingPath single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static BillOfLadingPath SingleOrDefault(Expression<Func<BillOfLadingPath, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            BillOfLadingPath single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<BillOfLadingPath, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<BillOfLadingPath, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<BillOfLadingPath> Find(Expression<Func<BillOfLadingPath, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<BillOfLadingPath> Find(Expression<Func<BillOfLadingPath, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<BillOfLadingPath> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<BillOfLadingPath> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<BillOfLadingPath> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<BillOfLadingPath> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<BillOfLadingPath> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<BillOfLadingPath> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.billOfLadingID.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(BillOfLadingPath)){
                BillOfLadingPath compare=(BillOfLadingPath)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.billOfLadingID.ToString();
                    }

        public string DescriptorColumn() {
            return "billOfLadingID";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "billOfLadingID";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _billOfLadingID;
        public int? billOfLadingID
        {
            get { return _billOfLadingID; }
            set
            {
                if(_billOfLadingID!=value){
                    _billOfLadingID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="billOfLadingID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _locationID;
        public int? locationID
        {
            get { return _locationID; }
            set
            {
                if(_locationID!=value){
                    _locationID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="locationID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _nextID;
        public int? nextID
        {
            get { return _nextID; }
            set
            {
                if(_nextID!=value){
                    _nextID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="nextID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isFirst;
        public bool? isFirst
        {
            get { return _isFirst; }
            set
            {
                if(_isFirst!=value){
                    _isFirst=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isFirst");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<BillOfLadingPath, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the RollingStock table in the Core Database.
    /// </summary>
    public partial class RollingStock: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<RollingStock> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<RollingStock>(new Core.CoreDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<RollingStock> testlist){
            SetTestRepo();
            foreach (var item in testlist)
            {
                _testRepo._items.Add(item);
            }
        }
        public static void Setup(RollingStock item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                RollingStock item=new RollingStock();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<RollingStock> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        Core.CoreDB _db;
        public RollingStock(string connectionString, string providerName) {

            _db=new Core.CoreDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                RollingStock.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<RollingStock>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public RollingStock(){
             _db=new Core.CoreDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public RollingStock(Expression<Func<RollingStock, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<RollingStock> GetRepo(string connectionString, string providerName){
            Core.CoreDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new Core.CoreDB();
            }else{
                db=new Core.CoreDB(connectionString, providerName);
            }
            IRepository<RollingStock> _repo;
            
            if(db.TestMode){
                RollingStock.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<RollingStock>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<RollingStock> GetRepo(){
            return GetRepo("","");
        }
        
        public static RollingStock SingleOrDefault(Expression<Func<RollingStock, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            RollingStock single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static RollingStock SingleOrDefault(Expression<Func<RollingStock, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            RollingStock single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<RollingStock, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<RollingStock, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<RollingStock> Find(Expression<Func<RollingStock, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<RollingStock> Find(Expression<Func<RollingStock, bool>> expression,string connectionString, string providerName) {

            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();

        }
        public static IQueryable<RollingStock> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
        public static IQueryable<RollingStock> All() {
            return GetRepo().GetAll();
        }
        
        public static PagedList<RollingStock> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<RollingStock> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<RollingStock> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<RollingStock> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ID";
        }

        public object KeyValue()
        {
            return this.ID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
                            return this.roadNumber.ToString();
                    }

        public override bool Equals(object obj){
            if(obj.GetType()==typeof(RollingStock)){
                RollingStock compare=(RollingStock)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ID;
        }
        
        public string DescriptorValue()
        {
                            return this.roadNumber.ToString();
                    }

        public string DescriptorColumn() {
            return "roadNumber";
        }
        public static string GetKeyColumn()
        {
            return "ID";
        }        
        public static string GetDescriptorColumn()
        {
            return "roadNumber";
        }
        
        #region ' Foreign Keys '
        #endregion
        

        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID!=value){
                    _ID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _roadNumber;
        public string roadNumber
        {
            get { return _roadNumber; }
            set
            {
                if(_roadNumber!=value){
                    _roadNumber=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="roadNumber");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _arrCodeID;
        public int? arrCodeID
        {
            get { return _arrCodeID; }
            set
            {
                if(_arrCodeID!=value){
                    _arrCodeID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="arrCodeID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _displayText;
        public string displayText
        {
            get { return _displayText; }
            set
            {
                if(_displayText!=value){
                    _displayText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="displayText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _length;
        public int? length
        {
            get { return _length; }
            set
            {
                if(_length!=value){
                    _length=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="length");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _capacityTonnage;
        public int? capacityTonnage
        {
            get { return _capacityTonnage; }
            set
            {
                if(_capacityTonnage!=value){
                    _capacityTonnage=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="capacityTonnage");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _carTypeID;
        public int? carTypeID
        {
            get { return _carTypeID; }
            set
            {
                if(_carTypeID!=value){
                    _carTypeID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="carTypeID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _locationID;
        public int? locationID
        {
            get { return _locationID; }
            set
            {
                if(_locationID!=value){
                    _locationID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="locationID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _RFID;
        public string RFID
        {
            get { return _RFID; }
            set
            {
                if(_RFID!=value){
                    _RFID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="RFID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _trainID;
        public int? trainID
        {
            get { return _trainID; }
            set
            {
                if(_trainID!=value){
                    _trainID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="trainID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isNotConfiscatable;
        public bool? isNotConfiscatable
        {
            get { return _isNotConfiscatable; }
            set
            {
                if(_isNotConfiscatable!=value){
                    _isNotConfiscatable=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isNotConfiscatable");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _nextRS;
        public int? nextRS
        {
            get { return _nextRS; }
            set
            {
                if(_nextRS!=value){
                    _nextRS=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="nextRS");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isFirst;
        public bool? isFirst
        {
            get { return _isFirst; }
            set
            {
                if(_isFirst!=value){
                    _isFirst=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isFirst");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isLast;
        public bool? isLast
        {
            get { return _isLast; }
            set
            {
                if(_isLast!=value){
                    _isLast=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isLast");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _isOutOfService;
        public bool? isOutOfService
        {
            get { return _isOutOfService; }
            set
            {
                if(_isOutOfService!=value){
                    _isOutOfService=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="isOutOfService");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0){
                _repo.Update(this,provider);
                _dirtyColumns.Clear();    
            }
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<RollingStock, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
}
