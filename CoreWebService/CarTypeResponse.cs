using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public partial class CarTypeResponse
    {
        public int Status;
        public string Message;
        public Core.CarType Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public CarTypeResponse()
        {

        }
        
        public CarTypeResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public CarTypeResponse(int status, string message, Core.CarType data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}