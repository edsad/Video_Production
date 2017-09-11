using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Video_Production.Models
{
    public class ProductionType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductionName { get; set; }
        public string Budget { get; set; }
}
