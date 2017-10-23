using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public partial class WaybillResponse
    {
        public int Status;
        public string Message;
        public Core.Waybill Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public WaybillResponse()
        {

        }
        
        public WaybillResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public WaybillResponse(int status, string message, Core.Waybill data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}