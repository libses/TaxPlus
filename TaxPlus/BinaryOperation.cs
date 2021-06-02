using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPlus
{
    public abstract class MustInitialize
    {
        public MustInitialize(IAction before, decimal amount) { }
        public MustInitialize(decimal amount) { }
    }
    public interface IBinaryOperation : IAction
    {
        decimal Amount { get; set; }
    }
}
