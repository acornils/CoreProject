using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Drawing;

namespace CoreWebService
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ICore : System.Web.Services.WebService
    {        
        public void writeEventLog(Exception e)
        {
            System.Diagnostics.EventLog appLog = new System.Diagnostics.EventLog();
            appLog.Source = "Core Web Service";
            appLog.WriteEntry(e.Message + " " + e.StackTrace + " " + e.Source + " " + e.InnerException + " " + e.TargetSite);
        }        

        [WebMethod]
        public CarTypeAttributeResponse addCarTypeAttribute(int carTypeID, string attribute)
        {
            try
            {
                if (Core.CarTypeAttribute.Exists(x => x.attribute == attribute && x.isDeleted == false && x.carTypeID == carTypeID))
                {
                    return new CarTypeAttributeResponse(2, "Duplicate");
                }
                else
                {
                    Core.CarTypeAttribute carTypeAttribute = new Core.CarTypeAttribute();
                    carTypeAttribute.carTypeID = carTypeID;
                    carTypeAttribute.attribute = attribute.Trim();
                    carTypeAttribute.Add();

                    return new CarTypeAttributeResponse(0, "Success", carTypeAttribute);
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new CarTypeAttributeResponse(1, "An Exption was created please check the event log.");
            }  
        }

        [WebMethod]
        public CarTypeAttributeResponse updateCarTypeAttribute(int id, string attribute)
        {           
            try
            {
                Core.CarTypeAttribute carTypeAttribute = Core.CarTypeAttribute.SingleOrDefault(x => x.ID == id);
                
                if (Core.CarTypeAttribute.Exists(x => x.attribute == attribute && x.isDeleted == false))
                {
                    return new CarTypeAttributeResponse(2, "Duplicate");
                }
                else
                {
                    carTypeAttribute.attribute = attribute.Trim();
                    carTypeAttribute.Update();

                    return new CarTypeAttributeResponse(0, "Success", carTypeAttribute);
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new CarTypeAttributeResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public CarTypeAttributeListResponse listCarTypeAttributes(int carTypeID)
        {
            try
            {
                List<Core.CarTypeAttribute> carTypeAttributes = Core.CarTypeAttribute.Find(x => x.carTypeID == carTypeID && x.isDeleted == false).ToList<Core.CarTypeAttribute>();

                return new CarTypeAttributeListResponse(0, "Success", carTypeAttributes);
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new CarTypeAttributeListResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public CarTypeAttributeResponse deleteCarTypeAttribute(int id)
        {
            try
            {
                Core.CarTypeAttribute carTypeAttribute = Core.CarTypeAttribute.SingleOrDefault(x => x.ID == id);

                if (carTypeAttribute != null)
                {
                    carTypeAttribute.isDeleted = true;
                    carTypeAttribute.Update();
                    return new CarTypeAttributeResponse(0, "Success", carTypeAttribute);
                }
                else
                {
                    return new CarTypeAttributeResponse(3, "No Result");
                }

                
            }
            catch(Exception e)
            {
                writeEventLog(e);

                return new CarTypeAttributeResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public CarTypeAttributeListResponse deleteCarTypeAttributeByCarType(int id)
        {
            try
            {
                List<Core.CarTypeAttribute> carTypeAttribute = Core.CarTypeAttribute.Find(x => x.carTypeID == id).ToList<Core.CarTypeAttribute>();

                if (carTypeAttribute != null)
                {
                    for (int i = 0; i < carTypeAttribute.Count; i++)
                    {
                        carTypeAttribute[i].isDeleted = true;
                        carTypeAttribute[i].Update();
                    }
                    return new CarTypeAttributeListResponse(0, "Success", carTypeAttribute);
                }
                else
                {
                    return new CarTypeAttributeListResponse(3, "No Result");
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new CarTypeAttributeListResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public CarTypeResponse addCarType(string shortName, string longName, string description)
        {
            try
            {
                if (Core.CarType.Exists(x => x.shortName == shortName && x.longName == longName && x.isDeleted == false))
                {
                    return new CarTypeResponse(2, "Duplicate");
                }
                else
                {
                    Core.CarType carType = new Core.CarType();
                    carType.shortName = shortName.Trim();
                    carType.longName = longName.Trim();
                    carType.description = description.Trim();
                    carType.Add();

                    return new CarTypeResponse(0, "Success", carType);
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new CarTypeResponse(1, "An Exption was created please check the event log.");
            }  
        }

        [WebMethod]
        public CarTypeResponse updateCarType(int id, string shortName, string longName, string description)
        {
            try
            {
                if (Core.CarType.Exists(x => x.shortName == shortName && x.longName == longName && x.ID != id && x.isDeleted == false))
                {
                    return new CarTypeResponse(2, "Duplicate");
                }
                else
                {
                    Core.CarType carType = Core.CarType.SingleOrDefault(x => x.ID == id);

                    carType.shortName = shortName.Trim();
                    carType.longName = longName.Trim();
                    carType.description = description.Trim();
                    carType.Update();

                    return new CarTypeResponse(0, "Success", carType);
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new CarTypeResponse(1, "An Exption was created please check the event log.");
            }  
        }

        [WebMethod]
        public CarTypeResponse getCarType(int id)
        {
            try
            {
                Core.CarType carType = Core.CarType.SingleOrDefault(x => x.ID == id);

                return new CarTypeResponse(0, "Success", carType);
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new CarTypeResponse(1, "An Exption was created please check the event log.");
            }  
        }

        [WebMethod]
        public CarTypeResponse deleteCarType(int id)
        {
            try
            {
                CarTypeAttributeListResponse response = deleteCarTypeAttributeByCarType(id);

                if (response.Status == 0)
                {
                    Core.CarType carType = Core.CarType.SingleOrDefault(x => x.ID == id);
                    carType.isDeleted = true;
                    carType.Update();

                    return new CarTypeResponse(0, "Success", carType);
                }
                else
                {
                    return new CarTypeResponse(response.Status, response.Message);
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new CarTypeResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public CarTypeListResponse listCarTypes()
        {
            try
            {
                List<Core.CarType> carTypes = Core.CarType.Find(x => x.isDeleted == false).ToList<Core.CarType>();

                return new CarTypeListResponse(0, "Success", carTypes);
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new CarTypeListResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public RollingStockAttributeResponse addRollingStockAttribute(int rollingStockID, int carTypeAttrID)
        {
            try
            {
                if (Core.rollingStockAtrribute.Exists(x => x.rollingStockID == rollingStockID && x.carTypeAttrID  == carTypeAttrID))
                {
                    return new RollingStockAttributeResponse(2, "Duplicate");
                }
                else
                {
                    Core.rollingStockAtrribute rollingStockAttribute = new Core.rollingStockAtrribute();
                    rollingStockAttribute.rollingStockID = rollingStockID;
                    rollingStockAttribute.carTypeAttrID = carTypeAttrID;
                    rollingStockAttribute.Add();

                    return new RollingStockAttributeResponse(0, "Success", rollingStockAttribute);
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new RollingStockAttributeResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public RollingStockAttributeResponse deleteRollingStockAttribute(int id)
        {
            try
            {
                Core.rollingStockAtrribute rollingStockAttribute = Core.rollingStockAtrribute.SingleOrDefault(x => x.ID == id);
                rollingStockAttribute.Delete();

                return new RollingStockAttributeResponse(0, "Success", rollingStockAttribute);
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new RollingStockAttributeResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public RollingStockAttributeListResponse deleteAllRollingStockAttribute(int rollingStockID)
        {
            try
            {
                List<Core.rollingStockAtrribute> rollingStockAttributes = Core.rollingStockAtrribute.Find(x => x.rollingStockID == rollingStockID).ToList<Core.rollingStockAtrribute>();

                for (int i = 0; i < rollingStockAttributes.Count; i++)
                {
                    rollingStockAttributes[i].Delete();
                }

                return new RollingStockAttributeListResponse(0, "Success", rollingStockAttributes);
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new RollingStockAttributeListResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public RollingStockAttributeListResponse listRollingStockAttribute(int rollingStockID)
        {
            try
            {
                List<Core.rollingStockAtrribute> rollingStockAttributes = Core.rollingStockAtrribute.Find(x => x.rollingStockID == rollingStockID).ToList<Core.rollingStockAtrribute>();

                return new RollingStockAttributeListResponse(0, "Success", rollingStockAttributes);
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new RollingStockAttributeListResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public RollingStockResponse addRollingStock(string roadNumber, int arrCodeID, int length, int capacityTonnage, int carTypeID, string RFID, string displayText)
        {
            try
            {
                if (Core.RollingStock.Exists(x => x.roadNumber == roadNumber && x.arrCodeID == arrCodeID))
                {
                    return new RollingStockResponse(2, "Duplicate");
                }
                else
                {
                    Core.RollingStock rollingStock = new Core.RollingStock();
                    rollingStock.roadNumber = roadNumber.Trim();
                    rollingStock.displayText = displayText.Trim();
                    rollingStock.arrCodeID = arrCodeID;
                    rollingStock.length = length;
                    rollingStock.capacityTonnage = capacityTonnage;
                    rollingStock.carTypeID = carTypeID;
                    rollingStock.RFID = RFID;
                    rollingStock.Add();

                    return new RollingStockResponse(0, "Success", rollingStock);
                }
                
            }
            catch(Exception e)
            {
                writeEventLog(e);

                return new RollingStockResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public RollingStockResponse updateRollingstock(int id, string roadNumber, int arrCodeID, int length, int capacityTonnage, int carTypeID, string RFID, string displayText)
        {
            try
            {
                if (Core.RollingStock.Exists(x => (x.roadNumber == roadNumber && x.arrCodeID == arrCodeID) && x.ID != id))
                {
                    return new RollingStockResponse(2, "Duplicate");
                }
                else
                {
                    Core.RollingStock rollingStock = Core.RollingStock.SingleOrDefault(x => x.ID == id);
                    rollingStock.roadNumber = roadNumber.Trim();
                    rollingStock.displayText = displayText.Trim();
                    rollingStock.arrCodeID = arrCodeID;
                    rollingStock.length = length;
                    rollingStock.capacityTonnage = capacityTonnage;
                    rollingStock.carTypeID = carTypeID;
                    rollingStock.RFID = RFID;
                    rollingStock.Update();

                    return new RollingStockResponse(0, "Success", rollingStock);
                }

            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new RollingStockResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public RollingStockResponse getRollingStock(int id)
        {
            Core.RollingStock rollingStock = Core.RollingStock.SingleOrDefault(x => x.ID == id);

            if (rollingStock != null)
            {
                try
                {
                    return new RollingStockResponse(0, "Success", rollingStock);
                }
                catch (Exception e)
                {
                    writeEventLog(e);

                    return new RollingStockResponse(1, "An Exption was created please check the event log.");
                }
            }
            else
            {
                return new RollingStockResponse(3, "No Results Returned");
            }
        }
        
        [WebMethod]
        public RollingStockResponse deleteRollingStock(int id)
        {
            Core.RollingStock rollingStock = Core.RollingStock.SingleOrDefault(x => x.ID == id);

            if (rollingStock != null)
            {
                try
                {
                    rollingStock.Delete();
                    deleteAllRollingStockAttribute(id);

                    return new RollingStockResponse(0, "Success", rollingStock);
                }
                catch (Exception e)
                {
                    writeEventLog(e);

                    return new RollingStockResponse(1, "An Exption was created please check the event log.");
                }
            }
            else
            {
                return new RollingStockResponse(3, "No Results Returned");
            }
        }

        [WebMethod]
        public RollingStockListResponse listRollingStockForWaybill(int billOfLadingID)
        {
            Core.BillOfLading billOfLading = Core.BillOfLading.SingleOrDefault(x => x.ID == billOfLadingID);
            List<Core.RollingStock> rollingStock = Core.RollingStock.Find(x => x.carTypeID == billOfLading.carTypeRequestedID).ToList<Core.RollingStock>();

            List<Core.BillOfLadingRequestedCarTypeAttribute> wayBillTemplateAttribures = Core.BillOfLadingRequestedCarTypeAttribute.Find(x => x.billOfLadingID == billOfLadingID).ToList<Core.BillOfLadingRequestedCarTypeAttribute>();

            if(wayBillTemplateAttribures.Count > 0)
            {
                for(int i = 0; i < rollingStock.Count; i++)
                {
                    List<Core.rollingStockAtrribute> rollingStockAttributes = Core.rollingStockAtrribute.Find(x => x.rollingStockID == rollingStock[i].ID).ToList<Core.rollingStockAtrribute>();
                    bool containsAllAttributes = true;
                    for (int r = 0; r < wayBillTemplateAttribures.Count; r++)
                    {
                        if (!rollingStockAttributes.Exists(x => x.carTypeAttrID == wayBillTemplateAttribures[r].carTypeAttributeID))
                        {
                            containsAllAttributes = false;
                        }
                    }

                    if(!containsAllAttributes)
                    {
                        rollingStock.Remove(rollingStock[i]);
                    }
                }

                return new RollingStockListResponse(0, "Success", rollingStock);
            }
            else
            {
                return new RollingStockListResponse(0, "Success", rollingStock);
            }
        }

        [WebMethod]
        public RollingStockListResponse listAllRollingStock(string search)
        {
            List<Core.RollingStock> rollingStock = Core.RollingStock.Find(x => x.displayText.Contains(search)).OrderBy(x => x.displayText).ToList<Core.RollingStock>();

            if (rollingStock != null)
            {
                try
                {
                    return new RollingStockListResponse(0, "Success", rollingStock);
                }
                catch (Exception e)
                {
                    writeEventLog(e);

                    return new RollingStockListResponse(1, "An Exption was created please check the event log.");
                }
            }
            else
            {
                return new RollingStockListResponse(3, "No Results Returned");
            }
        }

        [WebMethod]
        public LocationResponse addLocation(string name, string shortName, string scannerMAC, string scannerHead, bool isRFIDRead)
        {
            try
            {
                if (Core.Location.Exists(x => x.name == name || x.shortName == shortName))
                {
                    return new LocationResponse(2, "Duplicate");
                }
                else
                {
                    Core.Location location = new Core.Location();
                    location.name = name.Trim();
                    location.shortName = shortName.Trim();
                    location.isRFIDRead = isRFIDRead;
                    location.ScannerMAC = scannerMAC.Trim();
                    location.ScannerHead = scannerHead.Trim();
                    location.Add();
        
                    return new LocationResponse(0, "Success", location);
                }

            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new LocationResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public LocationResponse updateLocation(int id, string name, string shortName, string scannerMAC, string scannerHead, bool isRFIDRead)
        {
            Core.Location location = Core.Location.SingleOrDefault(x => x.ID == id);

            try
            {
                if (Core.Location.Exists(x => (x.name == name || x.shortName == shortName) && x.ID != id))
                {
                    return new LocationResponse(2, "Duplicate");
                }
                else
                {
                    location.name = name.Trim();
                    location.shortName = shortName.Trim();
                    location.isRFIDRead = isRFIDRead;
                    location.ScannerMAC = scannerMAC.Trim();
                    location.ScannerHead = scannerHead.Trim();
                    location.Update();

                    return new LocationResponse(0, "Success", location);
                }

            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new LocationResponse(1, "An Exption was created please check the event log.");
            }
        }
    
        [WebMethod]
        public LocationResponse getLocation(int id)
        {
            Core.Location location = Core.Location.SingleOrDefault(x => x.ID == id);

            try
            {
                if (location == null)
                {
                    return new LocationResponse(3, "No Results Returned");
                }
                else
                {
                    return new LocationResponse(0, "Success", location);
                }

            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new LocationResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public LocationResponse deleteLocation(int id)
        {
            Core.Location location = Core.Location.SingleOrDefault(x => x.ID == id);

            try
            {
                if (location == null)
                {
                    return new LocationResponse(3, "No Results Returned");
                }
                else
                {
                    location.isDeleted = true;
                    location.Update();

                    return new LocationResponse(0, "Success", location);
                }

            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new LocationResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public LocationListResponse listLocations(string search)
        {
            List<Core.Location> location = Core.Location.Find(x => x.name.Contains(search) || x.shortName.Contains(search)).ToList<Core.Location>();

            try
            {
                if (location == null)
                {
                    return new LocationListResponse(3, "No Results Returned");
                }
                else
                {
                    return new LocationListResponse(0, "Success", location);
                }

            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new LocationListResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public Core.Setting getSetting (string name)
        {
            return Core.Setting.SingleOrDefault(x => x.name == name);
        }

        [WebMethod]
        public Boolean setSetting (string name, string value)
        {
            Core.Setting setting = Core.Setting.SingleOrDefault(x => x.name.Equals(name));
            setting.value = value;
            setting.Update();
            return true;
        }

        [WebMethod]
        public Boolean addSwitchListTemplate(string name, byte[] image, int firstRowStart, int rowSpacing, int initialCol, int numberCol, int kindCol, int originCol, int destinationCol, int tonsColumn, int remarksCol, string trainNoLoc, string engineNoLoc, string stationLoc, string timeLoc, string yearLoc, string dateLoc, int maxRows, int backRowStart, int maxRowsBack, int contentsCol)
        {
            Core.SwitchListsLayout layout = new Core.SwitchListsLayout();
            layout.image = image;
            layout.name = name;
            layout.firstRowStart = firstRowStart;
            layout.rowSpacing = rowSpacing;
            layout.initialColumn = initialCol;
            layout.numberColumn = numberCol;
            layout.kindColumn = kindCol;
            layout.originColumn = originCol;
            layout.destinationColumn = destinationCol;
            layout.tonsColumn = tonsColumn;
            layout.engineNoLocation = engineNoLoc;
            layout.trainNoLocation = trainNoLoc;
            layout.stationLocation = stationLoc;
            layout.timeLocation = timeLoc;
            layout.yearLocation = yearLoc;
            layout.dateLocation = dateLoc;
            layout.maxRows = maxRows;
            layout.backRowStart = backRowStart;
            layout.maxRowsFront = maxRowsBack;
            layout.remarksColumn = remarksCol;
            layout.contentsColumn = contentsCol;
            layout.Add();
            return true;
        }

        [WebMethod]
        public Boolean updateSwitchListTemplate(int ID, string name, byte[] image, int firstRowStart, int rowSpacing, int initialCol, int numberCol, int kindCol, int originCol, int destinationCol, int tonsColumn, int remarksCol, string trainNoLoc, string engineNoLoc, string stationLoc, string timeLoc, string yearLoc, string dateLoc, int maxRows, int backRowStart, int maxRowsBack, int contentsCol)
        {
            Core.SwitchListsLayout layout = Core.SwitchListsLayout.SingleOrDefault(x => x.ID == ID);
            layout.image = image;
            layout.name = name;
            layout.firstRowStart = firstRowStart;
            layout.rowSpacing = rowSpacing;
            layout.initialColumn = initialCol;
            layout.numberColumn = numberCol;
            layout.kindColumn = kindCol;
            layout.originColumn = originCol;
            layout.destinationColumn = destinationCol;
            layout.tonsColumn = tonsColumn;
            layout.engineNoLocation = engineNoLoc;
            layout.trainNoLocation = trainNoLoc;
            layout.stationLocation = stationLoc;
            layout.timeLocation = timeLoc;
            layout.yearLocation = yearLoc;
            layout.dateLocation = dateLoc;
            layout.maxRows = maxRows;
            layout.backRowStart = backRowStart;
            layout.maxRowsFront = maxRowsBack;
            layout.remarksColumn = remarksCol;
            layout.contentsColumn = contentsCol;
            layout.Update();
            return true;
        }

        [WebMethod]
        public Boolean deleteSwitchListTemplate(int ID)
        {
            Core.SwitchListsLayout layout = Core.SwitchListsLayout.SingleOrDefault(x => x.ID == ID);
            layout.Delete();
            return true;
        }

        [WebMethod]
        public List<Core.SwitchListsLayout> listAllSwitchListTemplates()
        {
            return Core.SwitchListsLayout.All().ToList<Core.SwitchListsLayout>();
        }

        [WebMethod]
        public Core.SwitchListsLayout getSwitchListTemplate(int ID)
        {
            return Core.SwitchListsLayout.SingleOrDefault(x => x.ID == ID);
        }
        
        [WebMethod]
        public ArrCodeResponse addArrCode(string no, string carrier, string abbr)
        {
            try
            {
                if (Core.ARRCode.Exists(x => x.Carrier == carrier && x.isDeleted == false))
                {
                    return new ArrCodeResponse(2, "Duplicate");
                }
                else
                {
                    Core.ARRCode arrCode = new Core.ARRCode();
                    arrCode.No = no.Trim();
                    arrCode.Carrier = carrier.Trim();
                    arrCode.Abbr = abbr.Trim();
                    arrCode.Add();
                    
                    return new ArrCodeResponse(0, "Success", arrCode);
                }
            }
            catch(Exception e)
            {
                writeEventLog(e);

                return new ArrCodeResponse(1, "An Exption was created please check the event log.");
            }        
        }

        [WebMethod]
        public ArrCodeResponse updateArrCode(int id, string no, string carrier, string abbr)
        {
            Core.ARRCode arrCode = Core.ARRCode.SingleOrDefault(x => x.ID == id);

            try
            {
                if (Core.ARRCode.Exists(x => x.Carrier == carrier && !(x.ID == id)))
                {
                    return new ArrCodeResponse(2, "Duplicate");
                }
                else
                {                    
                    arrCode.No = no.Trim();
                    arrCode.Carrier = carrier.Trim();
                    arrCode.Abbr = abbr.Trim();
                    arrCode.Update();

                    return new ArrCodeResponse(0, "Success", arrCode);
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new ArrCodeResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public ArrCodeResponse deleteArrCode(int id)
        {
            Core.ARRCode arrCode = Core.ARRCode.SingleOrDefault(x => x.ID == id);

            try
            {
                arrCode.isDeleted = true;
                arrCode.Update();

                return new ArrCodeResponse(0, "Success");
            }
            catch(Exception e)
            {
                writeEventLog(e);

                return new ArrCodeResponse(1, "An Exption was created please check the event log.");
            }

        }

        [WebMethod]
        public ArrCodeResponse getArrCode(int id)
        {
            Core.ARRCode arrCode = Core.ARRCode.SingleOrDefault(x => x.ID == id);

            if (arrCode != null)
            {
                try
                {
                    return new ArrCodeResponse(0, "Success", arrCode);
                }
                catch (Exception e)
                {
                    writeEventLog(e);

                    return new ArrCodeResponse(1, "An Exption was created please check the event log.");
                }
            }
            else
            {
                return new ArrCodeResponse(3, "No Results Returned");
            }
        }

        [WebMethod]
        public ArrCodeListResponse listAllArrCode(string search)
        {
            List<Core.ARRCode> arrCode = Core.ARRCode.Find(x => (x.Carrier.Contains(search) || x.Abbr.Contains(search))&& x.isDeleted == false).OrderBy(x => x.Carrier).ToList<Core.ARRCode>();

            if (arrCode != null)
            {
                try
                {
                    return new ArrCodeListResponse(0, "Success", arrCode);
                }
                catch (Exception e)
                {
                    writeEventLog(e);

                    return new ArrCodeListResponse(1, "An Exption was created please check the event log.");
                }
            }
            else
            {
                return new ArrCodeListResponse(3, "No Results Returned");
            }
        }

        [WebMethod]
        public ConsigneeShipperResponse addConsigneeShipper(string name, int locationID, int arrCodeID)
        {
            try
            {
                if (Core.ConsigneeShipper.Exists(x => x.name == name))
                {
                    return new ConsigneeShipperResponse(2, "Duplicate");
                }
                else
                {
                    Core.ConsigneeShipper consigneeShipper = new Core.ConsigneeShipper();
                    consigneeShipper.name = name;
                    consigneeShipper.locationID = locationID;
                    consigneeShipper.aarCodeID = arrCodeID;
                    consigneeShipper.Add();

                    return new ConsigneeShipperResponse(0, "Success", consigneeShipper);
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new ConsigneeShipperResponse(1, "An Exption was created please check the event log.");
            }   
        }

        [WebMethod]
        public ConsigneeShipperResponse updateConsigneeShipper(int id, string name, int locationID, int arrCodeID)
        {
            try
            {
                if (Core.ConsigneeShipper.Exists(x => x.name == name && x.ID != id))
                {
                    return new ConsigneeShipperResponse(2, "Duplicate");
                }
                else
                {
                    Core.ConsigneeShipper consigneeShipper = Core.ConsigneeShipper.SingleOrDefault(x => x.ID == id);
                    consigneeShipper.name = name;
                    consigneeShipper.locationID = locationID;
                    consigneeShipper.aarCodeID = arrCodeID;
                    consigneeShipper.Update();

                    return new ConsigneeShipperResponse(0, "Success", consigneeShipper);
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new ConsigneeShipperResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public ConsigneeShipperResponse deleteConsigneeShipper(int id)
        {
            try
            {
                Core.ConsigneeShipper consigneeShipper = Core.ConsigneeShipper.SingleOrDefault(x => x.ID == id);
                consigneeShipper.Delete();

                return new ConsigneeShipperResponse(0, "Success", consigneeShipper);
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new ConsigneeShipperResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public ConsigneeShipperResponse getConsigneeShipper(int id)
        {
            try
            {
                Core.ConsigneeShipper consigneeShipper = Core.ConsigneeShipper.SingleOrDefault(x => x.ID == id);

                return new ConsigneeShipperResponse(0, "Success", consigneeShipper);
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new ConsigneeShipperResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public ConsigneeShipperListResponse listConsigneeShipper(string search)
        {
            try
            {
                List<Core.ConsigneeShipper> consigneeShipper = Core.ConsigneeShipper.Find(x => x.name.Contains(search)).OrderBy(x => x.name).ToList<Core.ConsigneeShipper>();

                if (consigneeShipper == null || consigneeShipper.Count <= 0)
                {
                    return new ConsigneeShipperListResponse(3, "No Result", consigneeShipper);
                }
                else
                {
                    return new ConsigneeShipperListResponse(0, "Success", consigneeShipper);
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new ConsigneeShipperListResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public BillOfLadingResponse addBillOfLading(int consigneeID, int shipperID, int carTypeRequestID, int carLengthRequested, int carCapacityRequested, string noPackages, string descriptionOfArticles, bool isPerishable, bool isPreIce, bool isInitialIce, int cps, bool isEmptyCarBill, bool isLiveStock, bool isReverseRoute, bool isReturnEmpty, bool isNextWaybill, int nextWaybill, decimal requestedCarsPerDay, int timeToUnload, int timeToLoad, string displayText, bool isActive)
        {
            try
            {
                Core.BillOfLading billOfLading = new Core.BillOfLading();

                billOfLading.consigneeID = consigneeID;
                billOfLading.shipperID = shipperID;
                billOfLading.carTypeRequestedID = carTypeRequestID;
                billOfLading.carLengthRequested = carLengthRequested;
                billOfLading.carCapacityRequested = carCapacityRequested;
                billOfLading.noPackages = noPackages;
                billOfLading.descriptionOfArticles = descriptionOfArticles;
                billOfLading.isPerishable = isPerishable;
                billOfLading.isPreIce = isPreIce;
                billOfLading.isInitialIce = isInitialIce;
                billOfLading.cps = cps;
                //billOfLading.isEmptyCarBill = isEmptyCarBill;
                billOfLading.isLiveStock = isLiveStock;
                billOfLading.isReverseRoute = isReverseRoute;
                billOfLading.isReturnEmpty = isReturnEmpty;
                billOfLading.isNextBillOfLading = isNextWaybill;
                billOfLading.nextBillOfLadingID = nextWaybill;
                billOfLading.requestedCarsPerDay = requestedCarsPerDay;
                billOfLading.timeToUnload = timeToUnload;
                billOfLading.timeToLoad = timeToLoad;
                //billOfLading.isActive = isActive;
                billOfLading.displayText = displayText;
                billOfLading.isDeleted = false;
                billOfLading.Add();

                return new BillOfLadingResponse(0, "Success", billOfLading);
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new BillOfLadingResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public BillOfLadingResponse updateBillOfLading(int id, int consigneeID, int shipperID, int carTypeRequestID, int carLengthRequested, int carCapacityRequested, string noPackages, string descriptionOfArticles, bool isPerishable, bool isPreIce, bool isInitialIce, int cps, bool isEmptyCarBill, bool isLiveStock, bool isReverseRoute, bool isReturnEmpty, bool isNextWaybill, int nextWaybill, decimal requestedCarsPerDay, int timeToUnload, int timeToLoad, string displayText, bool isActive)
        {
            try
            {
                Core.BillOfLading billOfLading = Core.BillOfLading.SingleOrDefault(x => x.ID == id);

                billOfLading.consigneeID = consigneeID;
                billOfLading.shipperID = shipperID;
                billOfLading.carTypeRequestedID = carTypeRequestID;
                billOfLading.carLengthRequested = carLengthRequested;
                billOfLading.carCapacityRequested = carCapacityRequested;
                billOfLading.noPackages = noPackages;
                billOfLading.descriptionOfArticles = descriptionOfArticles;
                billOfLading.isPerishable = isPerishable;
                billOfLading.isPreIce = isPreIce;
                billOfLading.isInitialIce = isInitialIce;
                billOfLading.cps = cps;
                //billOfLading.isEmptyCarBill = isEmptyCarBill;
                billOfLading.isLiveStock = isLiveStock;
                billOfLading.isReverseRoute = isReverseRoute;
                billOfLading.isReturnEmpty = isReturnEmpty;
                billOfLading.isNextBillOfLading = isNextWaybill;
                billOfLading.nextBillOfLadingID = nextWaybill;
                billOfLading.requestedCarsPerDay = requestedCarsPerDay;
                billOfLading.timeToUnload = timeToUnload;
                billOfLading.timeToLoad = timeToLoad;
                //billOfLading.isActive = isActive;
                billOfLading.displayText = displayText;
                billOfLading.Update();

                return new BillOfLadingResponse(0, "Success", billOfLading);
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new BillOfLadingResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public BillOfLadingResponse getBillOfLading(int id)
        {
            try
            {
                Core.BillOfLading billOfLading = Core.BillOfLading.SingleOrDefault(x => x.ID == id);

                if(billOfLading == null)
                {
                    return new BillOfLadingResponse(3, "No Result");
                }
                else
                {
                    return new BillOfLadingResponse(0, "Success", billOfLading);
                }               
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new BillOfLadingResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public BillOfLadingListResponse listBillOfLading(string search)
        {
            try
            {
                List<Core.BillOfLading> billOfLading = Core.BillOfLading.Find(x => x.displayText.Contains(search) && x.isDeleted == false).OrderBy(x => x.displayText).ToList<Core.BillOfLading>();

                if (billOfLading == null || billOfLading.Count == 0)
                {
                    return new BillOfLadingListResponse(3, "No Result");
                }
                else
                {
                    return new BillOfLadingListResponse(0, "Success", billOfLading);
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new BillOfLadingListResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public BillOfLadingResponse deleteBillOfLading(int id)
        {
            try
            {
                Core.BillOfLading billOfLading = Core.BillOfLading.SingleOrDefault(x => x.ID == id);
                billOfLading.isDeleted = true;
                //billOfLading.isActive = false;
                billOfLading.Update();

                if (billOfLading == null)
                {
                    return new BillOfLadingResponse(3, "No Result");
                }
                else
                {
                    return new BillOfLadingResponse(0, "Success", billOfLading);
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new BillOfLadingResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public BillOfLadingPathResponse addBillOfLadingPath(int billOfLadingID, int locationID, int nextLocationID, bool isFirst)
        {
            Core.BillOfLadingPath path = new Core.BillOfLadingPath();

            try
            {
                path.billOfLadingID = billOfLadingID;
                path.locationID = locationID;
                path.nextID = nextLocationID;
                path.isFirst = isFirst;
                path.Add();

                return new BillOfLadingPathResponse(0, "Success", path);
            }
            catch(Exception e)
            {
                writeEventLog(e);

                return new BillOfLadingPathResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public BillOfLadingPathResponse updateBillOfLadingPath(int id, int billOfLadingID, int nextLocationID)
        {
            Core.BillOfLadingPath path = Core.BillOfLadingPath.SingleOrDefault(x => x.ID == id);

            try
            {
                path.billOfLadingID = billOfLadingID;
                path.nextID = nextLocationID;
                path.Update();

                return new BillOfLadingPathResponse(0, "Success", path);
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new BillOfLadingPathResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public BillOfLadingPathListResponse deleteBillOfLadingPath(int billOfLadingID)
        {
            List<Core.BillOfLadingPath> pathList = Core.BillOfLadingPath.Find(x => x.billOfLadingID == billOfLadingID).ToList<Core.BillOfLadingPath>();

            try
            {
                for (int i = 0; i < pathList.Count; i++)
                {
                    pathList[i].Delete();
                }

                return new BillOfLadingPathListResponse(0, "Success");
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new BillOfLadingPathListResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public BillOfLadingPathListResponse listBillOfLadingPath(int billOfLadingID)
        {
            //List<Core.BillOfLadingPath> pathList = Core.BillOfLadingPath.Find(x => x.wayBillID == billOfLadingID).ToList<Core.BillOfLadingPath>();

            List<Core.BillOfLadingPath> pathList = new List<Core.BillOfLadingPath>();

            Core.BillOfLadingPath item = Core.BillOfLadingPath.SingleOrDefault(x => x.billOfLadingID == billOfLadingID && x.isFirst == true);

            if (item != null)
            {
                while (item.nextID != 0)
                {
                    pathList.Add(item);
                    item = Core.BillOfLadingPath.SingleOrDefault(x => x.ID == item.nextID);
                }

                pathList.Add(item);
            }

            try
            {
                if(pathList == null || pathList.Count <= 0)
                {
                    return new BillOfLadingPathListResponse(3, "No Results");
                }
                else
                {
                    return new BillOfLadingPathListResponse(0, "Success", pathList);
                }                
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new BillOfLadingPathListResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public BillOfLadingCarTypeAttributesResponse addBillOfLadingCartypeAttribute(int billOfLadingID, int carTypeAttributeID)
        {
            Core.BillOfLadingRequestedCarTypeAttribute carTypeAttribute = new Core.BillOfLadingRequestedCarTypeAttribute();

            try
            {
                carTypeAttribute.billOfLadingID = billOfLadingID;
                carTypeAttribute.carTypeAttributeID = carTypeAttributeID;
                carTypeAttribute.Add();

                return new BillOfLadingCarTypeAttributesResponse(0, "Success", carTypeAttribute);
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new BillOfLadingCarTypeAttributesResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public BillOfLadingCarTypeAttributesListResponse listBillOfLadingCartypeAttribute(int billOfLadingID)
        {
            List<Core.BillOfLadingRequestedCarTypeAttribute> carTypeAttribute = Core.BillOfLadingRequestedCarTypeAttribute.Find(x => x.billOfLadingID == billOfLadingID).ToList<Core.BillOfLadingRequestedCarTypeAttribute>();

            try
            {
                if(carTypeAttribute == null || carTypeAttribute.Count <= 0)
                {
                    return new BillOfLadingCarTypeAttributesListResponse(3, "No Results");
                }
                else
                {
                    return new BillOfLadingCarTypeAttributesListResponse(0, "Success", carTypeAttribute);
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new BillOfLadingCarTypeAttributesListResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public BillOfLadingCarTypeAttributesListResponse deleteBillOfLadingCartypeAttribute(int billOfLadingID)
        {
            List<Core.BillOfLadingRequestedCarTypeAttribute> carTypeAttribute = Core.BillOfLadingRequestedCarTypeAttribute.Find(x => x.billOfLadingID == billOfLadingID).ToList<Core.BillOfLadingRequestedCarTypeAttribute>();

            try
            {
                if (carTypeAttribute == null || carTypeAttribute.Count <= 0)
                {
                    return new BillOfLadingCarTypeAttributesListResponse(3, "No Results");
                }
                else
                {
                    for (int i = 0; i < carTypeAttribute.Count; i++ )
                    {
                        carTypeAttribute[i].Delete();
                    }
                    return new BillOfLadingCarTypeAttributesListResponse(0, "Success", carTypeAttribute);
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new BillOfLadingCarTypeAttributesListResponse(1, "An Exption was created please check the event log.");
            }
        }
    
        [WebMethod]
        public WaybillResponse addWaybill(int billOfLadingID, int carID, DateTime loadedAt, DateTime unloadedAt, DateTime preIcedAt, DateTime initialIcedAt, bool isWeighed, int weight, int currentLocationID)
        {
            Core.Waybill waybill = new Core.Waybill();

            try
            {
                waybill.billOfLadingID = billOfLadingID;
                //waybill.carID = carID;
                waybill.loadedAt = loadedAt;
                waybill.unloadedAt = unloadedAt;
                waybill.preIcedAt = preIcedAt;
                waybill.initialIcedAt = initialIcedAt;
                waybill.isWeighed = isWeighed;
                waybill.weight = weight;
                //waybill.currentLocationID = currentLocationID;
                waybill.Add();

                return new WaybillResponse(0, "Success", waybill);
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new WaybillResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public WaybillResponse updateWaybill(int ID, int billOfLadingID, int carID, DateTime loadedAt, DateTime unloadedAt, DateTime preIcedAt, DateTime initialIcedAt, bool isWeighed, int weight, int currentLocationID)
        {
            Core.Waybill waybill = Core.Waybill.SingleOrDefault(x => x.ID == ID);

            try
            {
                if (waybill != null)
                {
                    waybill.billOfLadingID = billOfLadingID;
                    //waybill.carID = carID;
                    waybill.loadedAt = loadedAt;
                    waybill.unloadedAt = unloadedAt;
                    waybill.preIcedAt = preIcedAt;
                    waybill.initialIcedAt = initialIcedAt;
                    waybill.isWeighed = isWeighed;
                    waybill.weight = weight;
                    //waybill.currentLocationID = currentLocationID;
                    waybill.Update();

                    return new WaybillResponse(0, "Success", waybill);
                }
                else
                {
                    return new WaybillResponse(3, "No Result");
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new WaybillResponse(1, "An Exption was created please check the event log.");
            }
        }

        [WebMethod]
        public WaybillResponse getWaybill(int ID)
        {
            Core.Waybill waybill = Core.Waybill.SingleOrDefault(x => x.ID == ID);

            try
            {
                if (waybill != null)
                {
                    return new WaybillResponse(0, "Success", waybill);
                }
                else
                {
                    return new WaybillResponse(3, "No Result");
                }
            }
            catch (Exception e)
            {
                writeEventLog(e);

                return new WaybillResponse(1, "An Exption was created please check the event log.");
            }
        }
    }
}