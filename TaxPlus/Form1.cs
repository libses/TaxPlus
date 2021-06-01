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
    public partial class Form1 : Form
    {
		string name;
		public void ButtonClick(object sender, EventArgs e)
        {
			var f = new ModelForm(name);
			f.Show();
        }
		public void NameChange(object sender, EventArgs e)
        {
			var box = (TextBox)sender;
			name = box.Text;
        }
        
        public Form1()
        {
			var label = new Label
			{
				Text = "Название модели",
				Dock = DockStyle.Fill
			};
			var box = new TextBox
			{
				Dock = DockStyle.Fill,
			};
			var button = new Button
			{
				Text = "Создать модель",
				Dock = DockStyle.Fill
			};

			var table = new TableLayoutPanel();
			table.RowStyles.Clear();
			table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
			table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
			table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
			table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
			table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
			table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

			table.Controls.Add(new Panel(), 0, 0);
			table.Controls.Add(label, 0, 1);
			table.Controls.Add(box, 0, 2);
			table.Controls.Add(button, 0, 3);
			table.Controls.Add(new Panel(), 0, 4);

			table.Dock = DockStyle.Fill;
			Controls.Add(table);

			box.TextChanged += NameChange;
			button.Click += ButtonClick;
			InitializeComponent();
        }
    }
}
