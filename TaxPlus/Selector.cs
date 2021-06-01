using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxPlus
{
    public partial class Selector : Form
    {
        private ModelForm mainForm = null;
        public Selector(Form callingForm)
        {
            mainForm = callingForm as ModelForm;
            InitializeComponent();
            var table = new TableLayoutPanel();
            table.RowStyles.Clear();
            for (int i = 0; i < 4; i++)
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            var plus = new Button() { Text = "+", Dock = DockStyle.Fill };
            plus.Click += button1_Click;
            var minus = new Button() { Text = "-", Dock = DockStyle.Fill };
            var multiply = new Button() { Text = "*", Dock = DockStyle.Fill };
            var divide = new Button() { Text = "/", Dock = DockStyle.Fill };
            var box = new TextBox();
            table.Controls.Add(plus, 0, 0);
            table.Controls.Add(minus, 0, 1);
            table.Controls.Add(multiply, 0, 2);
            table.Controls.Add(divide, 0, 3);
            table.Controls.Add(box, 1, 0);
            table.Dock = DockStyle.Fill;
            Controls.Add(table);
        }

        private void Selector_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var AL = mainForm.model.ActionList;
            if (AL.Count > 0)
            {
                AL.Add(new Plus(AL.Last().After, 10));
            }
            else
            {
                AL.Add(new Plus(mainForm.model.Input, 10));
            }
        }
        public Selector()
        {
            
        }
    }
}
