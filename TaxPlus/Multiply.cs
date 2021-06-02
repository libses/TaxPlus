using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPlus
{
    public class Multiply : MustInitialize, IBinaryOperation
    {
        public Model Input { get; set; }
        public decimal Amount { get; set; }
        public string Name { get; set; }
        public bool Ignore { get; set; }
        public IAction Before { get; set; }
        public decimal After
        {
            get
            {
                if (Before == null)
                {
                    if (Ignore)
                    {
                        return Input.Input;
                    }
                    else
                    {
                        return Input.Input * Amount;
                    }
                }
                if (Ignore)
                {
                    return Before.After;
                }
                else
                {
                    return Before.After * Amount;
                }
            }
            set { After = value; }
        }

        public Multiply(IAction before, decimal amount) : base(before, amount)
        {
            Name = "multiply";
            Amount = amount;
            Ignore = false;
            Before = before;
        }
        public Multiply(decimal amount) : base(amount)
        {
            Name = "multiply";
            Amount = amount;
            Ignore = false;
        }

    }
}
