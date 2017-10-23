using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreWebService
{
    public class joinPath
    {
        Core.Path path = new Core.Path();

        public joinPath(int pathID)
        {
            path = Core.Path.SingleOrDefault(x => x.ID == pathID);
        }

        public int ID
        {
            get { return path.ID; }
        }

        public int RouteID
        {
            get { return Convert.ToInt32(path.RouteID); }
        }

        public int locationID
        {
            get { return Convert.ToInt32(path.locationID); }
        }

        public string locationName
        {
            get { return Core.Location.SingleOrDefault(x => x.ID == path.locationID).name; }
        }

        public string symbol
        {
            get { return path.symbol; }
        }

        public string defaultStatus
        {
            get { return path.defaultStatus; }
        }

        public bool isStart
        {
            get { return Convert.ToBoolean(path.isStart); }
        }

        public bool isEnd
        {
            get { return Convert.ToBoolean(path.isEnd); }
        }
    }
}