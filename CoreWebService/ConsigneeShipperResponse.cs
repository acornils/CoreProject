using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class ConsigneeShipperResponse
    {
        public int Status;
        public string Message;
        public Core.ConsigneeShipper Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public ConsigneeShipperResponse ()
        {

        }

        public ConsigneeShipperResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public ConsigneeShipperResponse(int status, string message, Core.ConsigneeShipper data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}