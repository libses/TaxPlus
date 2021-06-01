using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPlus
{
    public class Model
    {
        public decimal Input;
        public List<Action> ActionList = new List<Action>();
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
