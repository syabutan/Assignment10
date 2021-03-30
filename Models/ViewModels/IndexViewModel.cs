using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment10.Models.ViewModels
{
    public class IndexViewModel 
    {
        public IEnumerable<Bowlers> Bowlers { get; set; }
        public IEnumerable<Teams> Teams { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }
        public string CurrentTeam { get; set; }

    }
}
