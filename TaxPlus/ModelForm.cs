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
        public Model model;
        public string test;
        public void ClickOnAdd(object sender, EventArgs e)
        {
            var f = new Selector(this);
            f.Show();
        }
        public ModelForm(string name)
        {
            InitializeComponent();
            model = new Model();
            var table = new TableLayoutPanel();
            table.ColumnStyles.Clear();
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            this.Text = name;
            var button = new Button() { Dock = DockStyle.Fill, Text = "Добавить действие"};
            button.Click += ClickOnAdd;
            table.Controls.Add(button, 0, 0);
            var listview = new ListView() { Dock = DockStyle.Fill };
            listview.CheckBoxes = true;
            listview.View = View.List;
            listview.Items.Add(new ListViewItem("aboba"));
            listview.Items.Add(new ListViewItem("aboba2"));
            table.Controls.Add(listview, 1, 0);
            table.Dock = DockStyle.Fill;
            Controls.Add(table);
        }
    }
}
