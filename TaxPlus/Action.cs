using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPlus
{
    public interface IAction
    {
        Model Input { get; set; }
        string Name { get; set; }
        bool Ignore { get; set; }
        IAction Before { get; set; }
        decimal After{ get; set; }
    }
}
