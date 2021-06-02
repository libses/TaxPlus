using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPlus
{
    public class Model
    {
        public decimal Input { get; set; }
        public List<IAction> ActionList = new List<IAction>();
        public decimal Output { 
            get
            {
                if (ActionList.Count > 0)
                {
                    return ActionList.Last().After;
                } 
                else
                {
                    return Input;
                }
            }
        }
    }
}
