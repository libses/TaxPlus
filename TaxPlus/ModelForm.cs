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
    public partial class ModelForm : Form
    {
        TextBox input;
        TextBox output;
        public ListView listview;
        public Model model;
        public string test;
        public void ClickOnAdd(object sender, EventArgs e)
        {
            var f = new Selector(this);
            f.Show();
        }
        public void Refresh(object sender, EventArgs e)
        {
            try
            {
                model.Input = decimal.Parse(input.Text);
            }
            catch
            {
                
            }
            listview.Items.Clear();
            foreach (var item in model.ActionList)
            {
                var sb = item.Name;
                if (item is IBinaryOperation)
                {
                    sb = sb + " " + ((IBinaryOperation)item).Amount;
                }
                var ListItem = new ListViewItem(sb);
                listview.Items.Add(ListItem);
            }
            if (model.ActionList.Count > 0)
            {
                output.Text = model.ActionList.Last().After.ToString();
            } else
            {
                output.Text = input.Text;
            }
            
        }
        public ModelForm(string name)
        {
            InitializeComponent();
            model = new Model();
            var timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Refresh;
            timer.Start();
            var table = new TableLayoutPanel();
            table.ColumnStyles.Clear();
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            table.RowStyles.Clear();
            table.RowStyles.Add(new ColumnStyle(SizeType.Percent, 90));
            table.RowStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            input = new TextBox() { Dock = DockStyle.Fill };
            output = new TextBox() { Dock = DockStyle.Fill };
            this.Text = name;
            var button = new Button() { Dock = DockStyle.Fill, Text = "Добавить действие"};
            button.Click += ClickOnAdd;
            table.Controls.Add(button, 0, 0);
            listview = new ListView() { Dock = DockStyle.Fill };
            listview.CheckBoxes = true;
            listview.View = View.List;
            table.Controls.Add(listview, 1, 0);
            table.Controls.Add(input, 0, 1);
            table.Controls.Add(output, 1, 1);
            table.Dock = DockStyle.Fill;
            Controls.Add(table);
        }
    }
}
