using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class BillOfLadingListResponse
    {
        public int Status;
        public string Message;
        public List<Core.BillOfLading> Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public BillOfLadingListResponse ()
        {

        }

        public BillOfLadingListResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public BillOfLadingListResponse(int status, string message, List<Core.BillOfLading> data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}