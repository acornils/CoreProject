using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class WaybillListResponse
    {
        public int Status;
        public string Message;
        public List<Core.Waybill> Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public WaybillListResponse ()
        {

        }

        public WaybillListResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public WaybillListResponse(int status, string message, List<Core.Waybill> data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}