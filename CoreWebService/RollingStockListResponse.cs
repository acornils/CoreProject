using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class RollingStockListResponse
    {
        public int Status;
        public string Message;
        public List<Core.RollingStock> Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public RollingStockListResponse ()
        {

        }

        public RollingStockListResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public RollingStockListResponse(int status, string message, List<Core.RollingStock> data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}