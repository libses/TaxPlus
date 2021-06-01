using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPlus
{
    public class Plus : BinaryOperation
    {
        public Plus(decimal before, decimal amount) : base(before, amount)
        {
        }
        public new decimal After
        {
            get
            {
                if (Ignore)
                    return Before;
                return Before + Amount;
            }
        }
    }
}
