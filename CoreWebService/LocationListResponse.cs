using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class LocationListResponse
    {
        public int Status;
        public string Message;
        public List<Core.Location> Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public LocationListResponse ()
        {

        }

        public LocationListResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public LocationListResponse(int status, string message, List<Core.Location> data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}