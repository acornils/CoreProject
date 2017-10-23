using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class BillOfLadingCarTypeAttributesResponse
    {
        public int Status;
        public string Message;
        public Core.BillOfLadingRequestedCarTypeAttribute Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public BillOfLadingCarTypeAttributesResponse ()
        {

        }

        public BillOfLadingCarTypeAttributesResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public BillOfLadingCarTypeAttributesResponse(int status, string message, Core.BillOfLadingRequestedCarTypeAttribute data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}