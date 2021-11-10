using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRecall.Models
{
    public class Dashboard
    {
        public List<AnnouncementListItem> AnnouncementListItem { get; set; }
        public List<RecallListItem> RecallListItem { get; set; }
    }
}
