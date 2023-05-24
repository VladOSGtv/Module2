using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module_2.Models
{
    public class Allowance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int PositionId { get; set; }
    }
}