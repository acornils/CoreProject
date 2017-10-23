using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public partial class BillOfLadingResponse
    {
        public int Status;
        public string Message;
        public Core.BillOfLading Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public BillOfLadingResponse()
        {

        }
        
        public BillOfLadingResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public BillOfLadingResponse(int status, string message, Core.BillOfLading data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}