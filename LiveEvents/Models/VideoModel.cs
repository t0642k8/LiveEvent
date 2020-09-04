using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveEvents.Models
{
    public class VideoModel
    {
        public int MyVideoID { get; set; }
        public string TitleVideo { get; set; }
        public string AssetID { get; set; }
        public string StreamuRL { get; set; }
        public string PicURL { get; set; }
        public string ccURL { get; set; }
        public string OrgURL { get; set; }
        public string Status { get; set; }

        public DateTime DateLive { get; set; }
        public string Desc { get; set; }
    }
}
