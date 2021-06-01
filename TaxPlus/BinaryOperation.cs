using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPlus
{
    public class BinaryOperation : Action
    {
        public decimal Amount { get; set; }
        public BinaryOperation(decimal before, decimal amount)
        {
            Before = before;
            Amount = amount;
            Ignore = false;
        }
    }
}
