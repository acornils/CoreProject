using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class LocationResponse
    {
        public int Status;
        public string Message;
        public Core.Location Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public LocationResponse ()
        {

        }

        public LocationResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public LocationResponse(int status, string message, Core.Location data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}