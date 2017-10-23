using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public partial class ArrCodeResponse
    {
        public int Status;
        public string Message;
        public Core.ARRCode Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public ArrCodeResponse()
        {

        }
        
        public ArrCodeResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public ArrCodeResponse(int status, string message, Core.ARRCode data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}