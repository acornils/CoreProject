using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class RollingStockAttributeListResponse
    {
        public int Status;
        public string Message;
        public List<Core.rollingStockAtrribute> Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public RollingStockAttributeListResponse ()
        {

        }

        public RollingStockAttributeListResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public RollingStockAttributeListResponse(int status, string message, List<Core.rollingStockAtrribute> data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}