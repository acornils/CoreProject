using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public partial class BillOfLadingPathResponse
    {
        public int Status;
        public string Message;
        public Core.BillOfLadingPath Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public BillOfLadingPathResponse()
        {

        }
        
        public BillOfLadingPathResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public BillOfLadingPathResponse(int status, string message, Core.BillOfLadingPath data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}