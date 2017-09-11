using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Video_Production.Models
{
    public class Production
    {

        public int Id { get; set; }

        public string client { get; set; }
        public string ProductionName { get; set; }
        public string ProductionType { get; set; }
        public string Description { get; set; }
    }
}
