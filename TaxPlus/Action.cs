using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPlus
{
    public class Action
    {
        public bool Ignore { get; set; }
        public decimal Before { get; set; }
        public decimal After { get; }
    }
}
