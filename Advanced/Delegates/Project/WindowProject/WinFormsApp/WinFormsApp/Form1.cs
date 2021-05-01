using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "Click Me";
            button.Size = new Size(100, 50);
            button.Location = new Point(150, 150);
            this.Controls.Add(button);
            //button.Click += new EventHandler(button_Click);

            button.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("You called an Anonymous Method..."); 
            };
        }
        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked On ClickMe button...");
        }
    }
}
