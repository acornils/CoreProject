using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class CarTypeListResponse
    {
        public int Status;
        public string Message;
        public List<Core.CarType> Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public CarTypeListResponse ()
        {

        }

        public CarTypeListResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public CarTypeListResponse(int status, string message, List<Core.CarType> data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}