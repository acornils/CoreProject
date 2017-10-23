using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public partial class CarTypeAttributeResponse
    {
        public int Status;
        public string Message;
        public Core.CarTypeAttribute Data = new Core.CarTypeAttribute();

        //0 = Success 1 = Fail 2 = Duplicate 3 = No Result
        public CarTypeAttributeResponse()
        {

        }
        
        public CarTypeAttributeResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public CarTypeAttributeResponse(int status, string message, Core.CarTypeAttribute data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}