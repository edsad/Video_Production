using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Video_Production.Models
{
    public class Crew
    {
        public int Id { get; set; }

        public string CrewName { get; set; }
        public string Producer { get; set; }
        public string Director { get; set; }
        public string ScriptWriter { get; set; }
        public string DP { get; set; }
        public string CameraOp { get; set; }

    }
}
