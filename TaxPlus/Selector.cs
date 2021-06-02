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
        TextBox box;
        private ModelForm mainForm = null;
        public Selector(Form callingForm)
        {
            mainForm = callingForm as ModelForm;
            InitializeComponent();
            var table = new TableLayoutPanel();
            table.RowStyles.Clear();
            for (int i = 0; i < 4; i++)
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            var plus = new Button() { Text = "+", Dock = DockStyle.Fill};
            plus.Click += button1_Click;
            var minus = new Button() { Text = "-", Dock = DockStyle.Fill };
            minus.Click += button1_Click;
            var multiply = new Button() { Text = "*", Dock = DockStyle.Fill };
            multiply.Click += button1_Click;
            var divide = new Button() { Text = "/", Dock = DockStyle.Fill };
            divide.Click += button1_Click;
            box = new TextBox() { Dock = DockStyle.Fill };
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
            var model = mainForm.model;
            var button = (Button)sender;
            var dec = decimal.Zero;
            try
            {
                dec = decimal.Parse(box.Text);
            }
            catch { }
            switch (button.Text) {
                case "+":
                    AddToMainForm(model, new Plus(dec));
                    break;
                case "-":
                    AddToMainForm(model, new Minus(dec));
                    break;
                case "/":
                    AddToMainForm(model, new Divide(dec));
                    break;
                case "*":
                    AddToMainForm(model, new Multiply(dec));
                    break;
            }
        }
        public void AddToMainForm<T>(Model model, T value) where T : IAction
        {
            var AL = model.ActionList;
            if (AL.Count > 0)
            {
                value.Before = AL.Last();
                AL.Add(value);
            }
            else
            {
                value.Before = null;
                value.Input = model;
                AL.Add(value);
            }
        }
        public Selector()
        {

        }
    }
}
