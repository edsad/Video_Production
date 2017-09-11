using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Video_Production.Models
{
    public class Production
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string client { get; set; }
        public string ProductionName { get; set; }
        public string ProductionType { get; set; }
        public string Description { get; set; }
    }
}
