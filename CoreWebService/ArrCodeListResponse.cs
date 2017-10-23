using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class ArrCodeListResponse
    {
        public int Status;
        public string Message;
        public List<Core.ARRCode> Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public ArrCodeListResponse ()
        {

        }

        public ArrCodeListResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public ArrCodeListResponse(int status, string message, List<Core.ARRCode> data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}