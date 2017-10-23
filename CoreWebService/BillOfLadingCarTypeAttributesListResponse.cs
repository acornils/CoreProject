using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class BillOfLadingCarTypeAttributesListResponse
    {
        public int Status;
        public string Message;
        public List<Core.BillOfLadingRequestedCarTypeAttribute> Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public BillOfLadingCarTypeAttributesListResponse ()
        {

        }

        public BillOfLadingCarTypeAttributesListResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public BillOfLadingCarTypeAttributesListResponse(int status, string message, List<Core.BillOfLadingRequestedCarTypeAttribute> data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}