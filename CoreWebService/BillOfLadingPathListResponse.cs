using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class BillOfLadingPathListResponse
    {
        public int Status;
        public string Message;
        public List<Core.BillOfLadingPath> Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public BillOfLadingPathListResponse ()
        {

        }

        public BillOfLadingPathListResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public BillOfLadingPathListResponse(int status, string message, List<Core.BillOfLadingPath> data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}