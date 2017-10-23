using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class CarTypeAttributeListResponse
    {
        public int Status;
        public string Message;
        public List<Core.CarTypeAttribute> Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public CarTypeAttributeListResponse ()
        {

        }

        public CarTypeAttributeListResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public CarTypeAttributeListResponse(int status, string message, List<Core.CarTypeAttribute> data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}