using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class RollingStockAttributeResponse
    {
        public int Status;
        public string Message;
        public Core.rollingStockAtrribute Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public RollingStockAttributeResponse ()
        {

        }

        public RollingStockAttributeResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public RollingStockAttributeResponse(int status, string message, Core.rollingStockAtrribute data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}