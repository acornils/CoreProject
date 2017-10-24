


using System;
using SubSonic.Schema;
using System.Collections.Generic;
using SubSonic.DataProviders;
using System.Data;

namespace Core {
	
        /// <summary>
        /// Table: BillOfLadingRequestedCarTypeAttribute
        /// Primary Key: ID
        /// </summary>

        public class BillOfLadingRequestedCarTypeAttributeTable: DatabaseTable {
            
            public BillOfLadingRequestedCarTypeAttributeTable(IDataProvider provider):base("BillOfLadingRequestedCarTypeAttribute",provider){
                ClassName = "BillOfLadingRequestedCarTypeAttribute";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("billOfLadingID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("carTypeAttributeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn billOfLadingID{
                get{
                    return this.GetColumn("billOfLadingID");
                }
            }
				
   			public static string billOfLadingIDColumn{
			      get{
        			return "billOfLadingID";
      			}
		    }
            
            public IColumn carTypeAttributeID{
                get{
                    return this.GetColumn("carTypeAttributeID");
                }
            }
				
   			public static string carTypeAttributeIDColumn{
			      get{
        			return "carTypeAttributeID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: CarType
        /// Primary Key: ID
        /// </summary>

        public class CarTypeTable: DatabaseTable {
            
            public CarTypeTable(IDataProvider provider):base("CarType",provider){
                ClassName = "CarType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("shortName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("longName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("isDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn shortName{
                get{
                    return this.GetColumn("shortName");
                }
            }
				
   			public static string shortNameColumn{
			      get{
        			return "shortName";
      			}
		    }
            
            public IColumn longName{
                get{
                    return this.GetColumn("longName");
                }
            }
				
   			public static string longNameColumn{
			      get{
        			return "longName";
      			}
		    }
            
            public IColumn description{
                get{
                    return this.GetColumn("description");
                }
            }
				
   			public static string descriptionColumn{
			      get{
        			return "description";
      			}
		    }
            
            public IColumn isDeleted{
                get{
                    return this.GetColumn("isDeleted");
                }
            }
				
   			public static string isDeletedColumn{
			      get{
        			return "isDeleted";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Settings
        /// Primary Key: ID
        /// </summary>

        public class SettingsTable: DatabaseTable {
            
            public SettingsTable(IDataProvider provider):base("Settings",provider){
                ClassName = "Setting";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("value", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn name{
                get{
                    return this.GetColumn("name");
                }
            }
				
   			public static string nameColumn{
			      get{
        			return "name";
      			}
		    }
            
            public IColumn value{
                get{
                    return this.GetColumn("value");
                }
            }
				
   			public static string valueColumn{
			      get{
        			return "value";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: SwitchListsLayouts
        /// Primary Key: ID
        /// </summary>

        public class SwitchListsLayoutsTable: DatabaseTable {
            
            public SwitchListsLayoutsTable(IDataProvider provider):base("SwitchListsLayouts",provider){
                ClassName = "SwitchListsLayout";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("image", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Binary,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2147483647
                });

                Columns.Add(new DatabaseColumn("firstRowStart", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowSpacing", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("initialColumn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("numberColumn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("kindColumn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("contentsColumn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("originColumn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("destinationColumn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("tonsColumn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("remarksColumn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("trainNoLocation", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("engineNoLocation", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("stationLocation", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("timeLocation", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("yearLocation", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("dateLocation", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("maxRows", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("backRowStart", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("maxRowsFront", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn name{
                get{
                    return this.GetColumn("name");
                }
            }
				
   			public static string nameColumn{
			      get{
        			return "name";
      			}
		    }
            
            public IColumn image{
                get{
                    return this.GetColumn("image");
                }
            }
				
   			public static string imageColumn{
			      get{
        			return "image";
      			}
		    }
            
            public IColumn firstRowStart{
                get{
                    return this.GetColumn("firstRowStart");
                }
            }
				
   			public static string firstRowStartColumn{
			      get{
        			return "firstRowStart";
      			}
		    }
            
            public IColumn rowSpacing{
                get{
                    return this.GetColumn("rowSpacing");
                }
            }
				
   			public static string rowSpacingColumn{
			      get{
        			return "rowSpacing";
      			}
		    }
            
            public IColumn initialColumn{
                get{
                    return this.GetColumn("initialColumn");
                }
            }
				
   			public static string initialColumnColumn{
			      get{
        			return "initialColumn";
      			}
		    }
            
            public IColumn numberColumn{
                get{
                    return this.GetColumn("numberColumn");
                }
            }
				
   			public static string numberColumnColumn{
			      get{
        			return "numberColumn";
      			}
		    }
            
            public IColumn kindColumn{
                get{
                    return this.GetColumn("kindColumn");
                }
            }
				
   			public static string kindColumnColumn{
			      get{
        			return "kindColumn";
      			}
		    }
            
            public IColumn contentsColumn{
                get{
                    return this.GetColumn("contentsColumn");
                }
            }
				
   			public static string contentsColumnColumn{
			      get{
        			return "contentsColumn";
      			}
		    }
            
            public IColumn originColumn{
                get{
                    return this.GetColumn("originColumn");
                }
            }
				
   			public static string originColumnColumn{
			      get{
        			return "originColumn";
      			}
		    }
            
            public IColumn destinationColumn{
                get{
                    return this.GetColumn("destinationColumn");
                }
            }
				
   			public static string destinationColumnColumn{
			      get{
        			return "destinationColumn";
      			}
		    }
            
            public IColumn tonsColumn{
                get{
                    return this.GetColumn("tonsColumn");
                }
            }
				
   			public static string tonsColumnColumn{
			      get{
        			return "tonsColumn";
      			}
		    }
            
            public IColumn remarksColumn{
                get{
                    return this.GetColumn("remarksColumn");
                }
            }
				
   			public static string remarksColumnColumn{
			      get{
        			return "remarksColumn";
      			}
		    }
            
            public IColumn trainNoLocation{
                get{
                    return this.GetColumn("trainNoLocation");
                }
            }
				
   			public static string trainNoLocationColumn{
			      get{
        			return "trainNoLocation";
      			}
		    }
            
            public IColumn engineNoLocation{
                get{
                    return this.GetColumn("engineNoLocation");
                }
            }
				
   			public static string engineNoLocationColumn{
			      get{
        			return "engineNoLocation";
      			}
		    }
            
            public IColumn stationLocation{
                get{
                    return this.GetColumn("stationLocation");
                }
            }
				
   			public static string stationLocationColumn{
			      get{
        			return "stationLocation";
      			}
		    }
            
            public IColumn timeLocation{
                get{
                    return this.GetColumn("timeLocation");
                }
            }
				
   			public static string timeLocationColumn{
			      get{
        			return "timeLocation";
      			}
		    }
            
            public IColumn yearLocation{
                get{
                    return this.GetColumn("yearLocation");
                }
            }
				
   			public static string yearLocationColumn{
			      get{
        			return "yearLocation";
      			}
		    }
            
            public IColumn dateLocation{
                get{
                    return this.GetColumn("dateLocation");
                }
            }
				
   			public static string dateLocationColumn{
			      get{
        			return "dateLocation";
      			}
		    }
            
            public IColumn maxRows{
                get{
                    return this.GetColumn("maxRows");
                }
            }
				
   			public static string maxRowsColumn{
			      get{
        			return "maxRows";
      			}
		    }
            
            public IColumn backRowStart{
                get{
                    return this.GetColumn("backRowStart");
                }
            }
				
   			public static string backRowStartColumn{
			      get{
        			return "backRowStart";
      			}
		    }
            
            public IColumn maxRowsFront{
                get{
                    return this.GetColumn("maxRowsFront");
                }
            }
				
   			public static string maxRowsFrontColumn{
			      get{
        			return "maxRowsFront";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: rfid
        /// Primary Key: ID
        /// </summary>

        public class rfidTable: DatabaseTable {
            
            public rfidTable(IDataProvider provider):base("rfid",provider){
                ClassName = "rfid";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("postdata", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("scanner", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("head", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("tag", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("scannedAt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("lastScanned", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn postdata{
                get{
                    return this.GetColumn("postdata");
                }
            }
				
   			public static string postdataColumn{
			      get{
        			return "postdata";
      			}
		    }
            
            public IColumn scanner{
                get{
                    return this.GetColumn("scanner");
                }
            }
				
   			public static string scannerColumn{
			      get{
        			return "scanner";
      			}
		    }
            
            public IColumn head{
                get{
                    return this.GetColumn("head");
                }
            }
				
   			public static string headColumn{
			      get{
        			return "head";
      			}
		    }
            
            public IColumn tag{
                get{
                    return this.GetColumn("tag");
                }
            }
				
   			public static string tagColumn{
			      get{
        			return "tag";
      			}
		    }
            
            public IColumn scannedAt{
                get{
                    return this.GetColumn("scannedAt");
                }
            }
				
   			public static string scannedAtColumn{
			      get{
        			return "scannedAt";
      			}
		    }
            
            public IColumn lastScanned{
                get{
                    return this.GetColumn("lastScanned");
                }
            }
				
   			public static string lastScannedColumn{
			      get{
        			return "lastScanned";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: EmptyCarBill
        /// Primary Key: ID
        /// </summary>

        public class EmptyCarBillTable: DatabaseTable {
            
            public EmptyCarBillTable(IDataProvider provider):base("EmptyCarBill",provider){
                ClassName = "EmptyCarBill";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isForHome", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("billedFromID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("billedToVia", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RollingStockID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("billOfLadingID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("canConfiscate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("onSpotAtShipper", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("onSpotAtConsignee", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn isForHome{
                get{
                    return this.GetColumn("isForHome");
                }
            }
				
   			public static string isForHomeColumn{
			      get{
        			return "isForHome";
      			}
		    }
            
            public IColumn billedFromID{
                get{
                    return this.GetColumn("billedFromID");
                }
            }
				
   			public static string billedFromIDColumn{
			      get{
        			return "billedFromID";
      			}
		    }
            
            public IColumn billedToVia{
                get{
                    return this.GetColumn("billedToVia");
                }
            }
				
   			public static string billedToViaColumn{
			      get{
        			return "billedToVia";
      			}
		    }
            
            public IColumn RollingStockID{
                get{
                    return this.GetColumn("RollingStockID");
                }
            }
				
   			public static string RollingStockIDColumn{
			      get{
        			return "RollingStockID";
      			}
		    }
            
            public IColumn billOfLadingID{
                get{
                    return this.GetColumn("billOfLadingID");
                }
            }
				
   			public static string billOfLadingIDColumn{
			      get{
        			return "billOfLadingID";
      			}
		    }
            
            public IColumn canConfiscate{
                get{
                    return this.GetColumn("canConfiscate");
                }
            }
				
   			public static string canConfiscateColumn{
			      get{
        			return "canConfiscate";
      			}
		    }
            
            public IColumn onSpotAtShipper{
                get{
                    return this.GetColumn("onSpotAtShipper");
                }
            }
				
   			public static string onSpotAtShipperColumn{
			      get{
        			return "onSpotAtShipper";
      			}
		    }
            
            public IColumn onSpotAtConsignee{
                get{
                    return this.GetColumn("onSpotAtConsignee");
                }
            }
				
   			public static string onSpotAtConsigneeColumn{
			      get{
        			return "onSpotAtConsignee";
      			}
		    }
            
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ARRCodes
        /// Primary Key: ID
        /// </summary>

        public class ARRCodesTable: DatabaseTable {
            
            public ARRCodesTable(IDataProvider provider):base("ARRCodes",provider){
                ClassName = "ARRCode";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("No", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("Carrier", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Abbr", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("isDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn No{
                get{
                    return this.GetColumn("No");
                }
            }
				
   			public static string NoColumn{
			      get{
        			return "No";
      			}
		    }
            
            public IColumn Carrier{
                get{
                    return this.GetColumn("Carrier");
                }
            }
				
   			public static string CarrierColumn{
			      get{
        			return "Carrier";
      			}
		    }
            
            public IColumn Abbr{
                get{
                    return this.GetColumn("Abbr");
                }
            }
				
   			public static string AbbrColumn{
			      get{
        			return "Abbr";
      			}
		    }
            
            public IColumn isDeleted{
                get{
                    return this.GetColumn("isDeleted");
                }
            }
				
   			public static string isDeletedColumn{
			      get{
        			return "isDeleted";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: CarTypeAttributes
        /// Primary Key: ID
        /// </summary>

        public class CarTypeAttributesTable: DatabaseTable {
            
            public CarTypeAttributesTable(IDataProvider provider):base("CarTypeAttributes",provider){
                ClassName = "CarTypeAttribute";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("carTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("attribute", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("isDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn carTypeID{
                get{
                    return this.GetColumn("carTypeID");
                }
            }
				
   			public static string carTypeIDColumn{
			      get{
        			return "carTypeID";
      			}
		    }
            
            public IColumn attribute{
                get{
                    return this.GetColumn("attribute");
                }
            }
				
   			public static string attributeColumn{
			      get{
        			return "attribute";
      			}
		    }
            
            public IColumn isDeleted{
                get{
                    return this.GetColumn("isDeleted");
                }
            }
				
   			public static string isDeletedColumn{
			      get{
        			return "isDeleted";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: rollingStockAtrributes
        /// Primary Key: ID
        /// </summary>

        public class rollingStockAtrributesTable: DatabaseTable {
            
            public rollingStockAtrributesTable(IDataProvider provider):base("rollingStockAtrributes",provider){
                ClassName = "rollingStockAtrribute";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rollingStockID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("carTypeAttrID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn rollingStockID{
                get{
                    return this.GetColumn("rollingStockID");
                }
            }
				
   			public static string rollingStockIDColumn{
			      get{
        			return "rollingStockID";
      			}
		    }
            
            public IColumn carTypeAttrID{
                get{
                    return this.GetColumn("carTypeAttrID");
                }
            }
				
   			public static string carTypeAttrIDColumn{
			      get{
        			return "carTypeAttrID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Waybills
        /// Primary Key: ID
        /// </summary>

        public class WaybillsTable: DatabaseTable {
            
            public WaybillsTable(IDataProvider provider):base("Waybills",provider){
                ClassName = "Waybill";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("billOfLadingID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("consigneeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("shipperID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("assignedRollingStockID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("loadedAt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("unloadedAt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("preIcedAt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("initialIcedAt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isWeighed", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("weight", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("onSpotAtShipper", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("onSpotAtConsignee", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isPerishableWaybill", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isLiveStockWaybill", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isEmptyWayBill", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("waybillOrder", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("createdOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("modifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn billOfLadingID{
                get{
                    return this.GetColumn("billOfLadingID");
                }
            }
				
   			public static string billOfLadingIDColumn{
			      get{
        			return "billOfLadingID";
      			}
		    }
            
            public IColumn consigneeID{
                get{
                    return this.GetColumn("consigneeID");
                }
            }
				
   			public static string consigneeIDColumn{
			      get{
        			return "consigneeID";
      			}
		    }
            
            public IColumn shipperID{
                get{
                    return this.GetColumn("shipperID");
                }
            }
				
   			public static string shipperIDColumn{
			      get{
        			return "shipperID";
      			}
		    }
            
            public IColumn assignedRollingStockID{
                get{
                    return this.GetColumn("assignedRollingStockID");
                }
            }
				
   			public static string assignedRollingStockIDColumn{
			      get{
        			return "assignedRollingStockID";
      			}
		    }
            
            public IColumn loadedAt{
                get{
                    return this.GetColumn("loadedAt");
                }
            }
				
   			public static string loadedAtColumn{
			      get{
        			return "loadedAt";
      			}
		    }
            
            public IColumn unloadedAt{
                get{
                    return this.GetColumn("unloadedAt");
                }
            }
				
   			public static string unloadedAtColumn{
			      get{
        			return "unloadedAt";
      			}
		    }
            
            public IColumn preIcedAt{
                get{
                    return this.GetColumn("preIcedAt");
                }
            }
				
   			public static string preIcedAtColumn{
			      get{
        			return "preIcedAt";
      			}
		    }
            
            public IColumn initialIcedAt{
                get{
                    return this.GetColumn("initialIcedAt");
                }
            }
				
   			public static string initialIcedAtColumn{
			      get{
        			return "initialIcedAt";
      			}
		    }
            
            public IColumn isWeighed{
                get{
                    return this.GetColumn("isWeighed");
                }
            }
				
   			public static string isWeighedColumn{
			      get{
        			return "isWeighed";
      			}
		    }
            
            public IColumn weight{
                get{
                    return this.GetColumn("weight");
                }
            }
				
   			public static string weightColumn{
			      get{
        			return "weight";
      			}
		    }
            
            public IColumn onSpotAtShipper{
                get{
                    return this.GetColumn("onSpotAtShipper");
                }
            }
				
   			public static string onSpotAtShipperColumn{
			      get{
        			return "onSpotAtShipper";
      			}
		    }
            
            public IColumn onSpotAtConsignee{
                get{
                    return this.GetColumn("onSpotAtConsignee");
                }
            }
				
   			public static string onSpotAtConsigneeColumn{
			      get{
        			return "onSpotAtConsignee";
      			}
		    }
            
            public IColumn isPerishableWaybill{
                get{
                    return this.GetColumn("isPerishableWaybill");
                }
            }
				
   			public static string isPerishableWaybillColumn{
			      get{
        			return "isPerishableWaybill";
      			}
		    }
            
            public IColumn isLiveStockWaybill{
                get{
                    return this.GetColumn("isLiveStockWaybill");
                }
            }
				
   			public static string isLiveStockWaybillColumn{
			      get{
        			return "isLiveStockWaybill";
      			}
		    }
            
            public IColumn isEmptyWayBill{
                get{
                    return this.GetColumn("isEmptyWayBill");
                }
            }
				
   			public static string isEmptyWayBillColumn{
			      get{
        			return "isEmptyWayBill";
      			}
		    }
            
            public IColumn waybillOrder{
                get{
                    return this.GetColumn("waybillOrder");
                }
            }
				
   			public static string waybillOrderColumn{
			      get{
        			return "waybillOrder";
      			}
		    }
            
            public IColumn isDeleted{
                get{
                    return this.GetColumn("isDeleted");
                }
            }
				
   			public static string isDeletedColumn{
			      get{
        			return "isDeleted";
      			}
		    }
            
            public IColumn createdOn{
                get{
                    return this.GetColumn("createdOn");
                }
            }
				
   			public static string createdOnColumn{
			      get{
        			return "createdOn";
      			}
		    }
            
            public IColumn modifiedOn{
                get{
                    return this.GetColumn("modifiedOn");
                }
            }
				
   			public static string modifiedOnColumn{
			      get{
        			return "modifiedOn";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Locations
        /// Primary Key: ID
        /// </summary>

        public class LocationsTable: DatabaseTable {
            
            public LocationsTable(IDataProvider provider):base("Locations",provider){
                ClassName = "Location";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("shortName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ScannerMAC", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ScannerHead", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("isRFIDRead", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn name{
                get{
                    return this.GetColumn("name");
                }
            }
				
   			public static string nameColumn{
			      get{
        			return "name";
      			}
		    }
            
            public IColumn shortName{
                get{
                    return this.GetColumn("shortName");
                }
            }
				
   			public static string shortNameColumn{
			      get{
        			return "shortName";
      			}
		    }
            
            public IColumn ScannerMAC{
                get{
                    return this.GetColumn("ScannerMAC");
                }
            }
				
   			public static string ScannerMACColumn{
			      get{
        			return "ScannerMAC";
      			}
		    }
            
            public IColumn ScannerHead{
                get{
                    return this.GetColumn("ScannerHead");
                }
            }
				
   			public static string ScannerHeadColumn{
			      get{
        			return "ScannerHead";
      			}
		    }
            
            public IColumn isRFIDRead{
                get{
                    return this.GetColumn("isRFIDRead");
                }
            }
				
   			public static string isRFIDReadColumn{
			      get{
        			return "isRFIDRead";
      			}
		    }
            
            public IColumn isDeleted{
                get{
                    return this.GetColumn("isDeleted");
                }
            }
				
   			public static string isDeletedColumn{
			      get{
        			return "isDeleted";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ConsigneeShipper
        /// Primary Key: ID
        /// </summary>

        public class ConsigneeShipperTable: DatabaseTable {
            
            public ConsigneeShipperTable(IDataProvider provider):base("ConsigneeShipper",provider){
                ClassName = "ConsigneeShipper";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("locationID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("aarCodeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn locationID{
                get{
                    return this.GetColumn("locationID");
                }
            }
				
   			public static string locationIDColumn{
			      get{
        			return "locationID";
      			}
		    }
            
            public IColumn name{
                get{
                    return this.GetColumn("name");
                }
            }
				
   			public static string nameColumn{
			      get{
        			return "name";
      			}
		    }
            
            public IColumn aarCodeID{
                get{
                    return this.GetColumn("aarCodeID");
                }
            }
				
   			public static string aarCodeIDColumn{
			      get{
        			return "aarCodeID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: BillOfLading
        /// Primary Key: ID
        /// </summary>

        public class BillOfLadingTable: DatabaseTable {
            
            public BillOfLadingTable(IDataProvider provider):base("BillOfLading",provider){
                ClassName = "BillOfLading";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("consigneeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("shipperID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("carTypeRequestedID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("carLengthRequested", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("carCapacityRequested", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("noPackages", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("descriptionOfArticles", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("displayText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("isPerishable", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isPreIce", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isInitialIce", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("cps", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isEmptyCarRequested", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isLiveStock", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isReverseRoute", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isReturnEmpty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("requestedCarsPerDay", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("timeToUnload", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("timeToLoad", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("createdOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("modifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn consigneeID{
                get{
                    return this.GetColumn("consigneeID");
                }
            }
				
   			public static string consigneeIDColumn{
			      get{
        			return "consigneeID";
      			}
		    }
            
            public IColumn shipperID{
                get{
                    return this.GetColumn("shipperID");
                }
            }
				
   			public static string shipperIDColumn{
			      get{
        			return "shipperID";
      			}
		    }
            
            public IColumn carTypeRequestedID{
                get{
                    return this.GetColumn("carTypeRequestedID");
                }
            }
				
   			public static string carTypeRequestedIDColumn{
			      get{
        			return "carTypeRequestedID";
      			}
		    }
            
            public IColumn carLengthRequested{
                get{
                    return this.GetColumn("carLengthRequested");
                }
            }
				
   			public static string carLengthRequestedColumn{
			      get{
        			return "carLengthRequested";
      			}
		    }
            
            public IColumn carCapacityRequested{
                get{
                    return this.GetColumn("carCapacityRequested");
                }
            }
				
   			public static string carCapacityRequestedColumn{
			      get{
        			return "carCapacityRequested";
      			}
		    }
            
            public IColumn noPackages{
                get{
                    return this.GetColumn("noPackages");
                }
            }
				
   			public static string noPackagesColumn{
			      get{
        			return "noPackages";
      			}
		    }
            
            public IColumn descriptionOfArticles{
                get{
                    return this.GetColumn("descriptionOfArticles");
                }
            }
				
   			public static string descriptionOfArticlesColumn{
			      get{
        			return "descriptionOfArticles";
      			}
		    }
            
            public IColumn displayText{
                get{
                    return this.GetColumn("displayText");
                }
            }
				
   			public static string displayTextColumn{
			      get{
        			return "displayText";
      			}
		    }
            
            public IColumn isPerishable{
                get{
                    return this.GetColumn("isPerishable");
                }
            }
				
   			public static string isPerishableColumn{
			      get{
        			return "isPerishable";
      			}
		    }
            
            public IColumn isPreIce{
                get{
                    return this.GetColumn("isPreIce");
                }
            }
				
   			public static string isPreIceColumn{
			      get{
        			return "isPreIce";
      			}
		    }
            
            public IColumn isInitialIce{
                get{
                    return this.GetColumn("isInitialIce");
                }
            }
				
   			public static string isInitialIceColumn{
			      get{
        			return "isInitialIce";
      			}
		    }
            
            public IColumn cps{
                get{
                    return this.GetColumn("cps");
                }
            }
				
   			public static string cpsColumn{
			      get{
        			return "cps";
      			}
		    }
            
            public IColumn isEmptyCarRequested{
                get{
                    return this.GetColumn("isEmptyCarRequested");
                }
            }
				
   			public static string isEmptyCarRequestedColumn{
			      get{
        			return "isEmptyCarRequested";
      			}
		    }
            
            public IColumn isLiveStock{
                get{
                    return this.GetColumn("isLiveStock");
                }
            }
				
   			public static string isLiveStockColumn{
			      get{
        			return "isLiveStock";
      			}
		    }
            
            public IColumn isReverseRoute{
                get{
                    return this.GetColumn("isReverseRoute");
                }
            }
				
   			public static string isReverseRouteColumn{
			      get{
        			return "isReverseRoute";
      			}
		    }
            
            public IColumn isReturnEmpty{
                get{
                    return this.GetColumn("isReturnEmpty");
                }
            }
				
   			public static string isReturnEmptyColumn{
			      get{
        			return "isReturnEmpty";
      			}
		    }
            
            public IColumn requestedCarsPerDay{
                get{
                    return this.GetColumn("requestedCarsPerDay");
                }
            }
				
   			public static string requestedCarsPerDayColumn{
			      get{
        			return "requestedCarsPerDay";
      			}
		    }
            
            public IColumn timeToUnload{
                get{
                    return this.GetColumn("timeToUnload");
                }
            }
				
   			public static string timeToUnloadColumn{
			      get{
        			return "timeToUnload";
      			}
		    }
            
            public IColumn timeToLoad{
                get{
                    return this.GetColumn("timeToLoad");
                }
            }
				
   			public static string timeToLoadColumn{
			      get{
        			return "timeToLoad";
      			}
		    }
            
            public IColumn isDeleted{
                get{
                    return this.GetColumn("isDeleted");
                }
            }
				
   			public static string isDeletedColumn{
			      get{
        			return "isDeleted";
      			}
		    }
            
            public IColumn createdOn{
                get{
                    return this.GetColumn("createdOn");
                }
            }
				
   			public static string createdOnColumn{
			      get{
        			return "createdOn";
      			}
		    }
            
            public IColumn modifiedOn{
                get{
                    return this.GetColumn("modifiedOn");
                }
            }
				
   			public static string modifiedOnColumn{
			      get{
        			return "modifiedOn";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: BillOfLadingPath
        /// Primary Key: ID
        /// </summary>

        public class BillOfLadingPathTable: DatabaseTable {
            
            public BillOfLadingPathTable(IDataProvider provider):base("BillOfLadingPath",provider){
                ClassName = "BillOfLadingPath";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("billOfLadingID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("locationID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("nextID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isFirst", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn billOfLadingID{
                get{
                    return this.GetColumn("billOfLadingID");
                }
            }
				
   			public static string billOfLadingIDColumn{
			      get{
        			return "billOfLadingID";
      			}
		    }
            
            public IColumn locationID{
                get{
                    return this.GetColumn("locationID");
                }
            }
				
   			public static string locationIDColumn{
			      get{
        			return "locationID";
      			}
		    }
            
            public IColumn nextID{
                get{
                    return this.GetColumn("nextID");
                }
            }
				
   			public static string nextIDColumn{
			      get{
        			return "nextID";
      			}
		    }
            
            public IColumn isFirst{
                get{
                    return this.GetColumn("isFirst");
                }
            }
				
   			public static string isFirstColumn{
			      get{
        			return "isFirst";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: RollingStock
        /// Primary Key: ID
        /// </summary>

        public class RollingStockTable: DatabaseTable {
            
            public RollingStockTable(IDataProvider provider):base("RollingStock",provider){
                ClassName = "RollingStock";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("roadNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("arrCodeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("displayText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("length", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("capacityTonnage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("carTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("locationID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RFID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("trainID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isNotConfiscatable", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("nextRS", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isFirst", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isLast", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("isOutOfService", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
            
            public IColumn roadNumber{
                get{
                    return this.GetColumn("roadNumber");
                }
            }
				
   			public static string roadNumberColumn{
			      get{
        			return "roadNumber";
      			}
		    }
            
            public IColumn arrCodeID{
                get{
                    return this.GetColumn("arrCodeID");
                }
            }
				
   			public static string arrCodeIDColumn{
			      get{
        			return "arrCodeID";
      			}
		    }
            
            public IColumn displayText{
                get{
                    return this.GetColumn("displayText");
                }
            }
				
   			public static string displayTextColumn{
			      get{
        			return "displayText";
      			}
		    }
            
            public IColumn length{
                get{
                    return this.GetColumn("length");
                }
            }
				
   			public static string lengthColumn{
			      get{
        			return "length";
      			}
		    }
            
            public IColumn capacityTonnage{
                get{
                    return this.GetColumn("capacityTonnage");
                }
            }
				
   			public static string capacityTonnageColumn{
			      get{
        			return "capacityTonnage";
      			}
		    }
            
            public IColumn carTypeID{
                get{
                    return this.GetColumn("carTypeID");
                }
            }
				
   			public static string carTypeIDColumn{
			      get{
        			return "carTypeID";
      			}
		    }
            
            public IColumn locationID{
                get{
                    return this.GetColumn("locationID");
                }
            }
				
   			public static string locationIDColumn{
			      get{
        			return "locationID";
      			}
		    }
            
            public IColumn RFID{
                get{
                    return this.GetColumn("RFID");
                }
            }
				
   			public static string RFIDColumn{
			      get{
        			return "RFID";
      			}
		    }
            
            public IColumn trainID{
                get{
                    return this.GetColumn("trainID");
                }
            }
				
   			public static string trainIDColumn{
			      get{
        			return "trainID";
      			}
		    }
            
            public IColumn isNotConfiscatable{
                get{
                    return this.GetColumn("isNotConfiscatable");
                }
            }
				
   			public static string isNotConfiscatableColumn{
			      get{
        			return "isNotConfiscatable";
      			}
		    }
            
            public IColumn nextRS{
                get{
                    return this.GetColumn("nextRS");
                }
            }
				
   			public static string nextRSColumn{
			      get{
        			return "nextRS";
      			}
		    }
            
            public IColumn isFirst{
                get{
                    return this.GetColumn("isFirst");
                }
            }
				
   			public static string isFirstColumn{
			      get{
        			return "isFirst";
      			}
		    }
            
            public IColumn isLast{
                get{
                    return this.GetColumn("isLast");
                }
            }
				
   			public static string isLastColumn{
			      get{
        			return "isLast";
      			}
		    }
            
            public IColumn isOutOfService{
                get{
                    return this.GetColumn("isOutOfService");
                }
            }
				
   			public static string isOutOfServiceColumn{
			      get{
        			return "isOutOfService";
      			}
		    }
            
                    
        }
        
}