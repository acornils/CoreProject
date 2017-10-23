using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class RollingStockResponse
    {
        public int Status;
        public string Message;
        public Core.RollingStock Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public RollingStockResponse ()
        {

        }

        public RollingStockResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public RollingStockResponse(int status, string message, Core.RollingStock data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}