using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class ConsigneeShipperListResponse
    {
        public int Status;
        public string Message;
        public List<Core.ConsigneeShipper> Data;

        //0 = Success 1 = Fail 2 = Duplicate
        public ConsigneeShipperListResponse ()
        {

        }

        public ConsigneeShipperListResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public ConsigneeShipperListResponse(int status, string message, List<Core.ConsigneeShipper> data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}