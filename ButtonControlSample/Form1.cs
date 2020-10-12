using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonControlSample
{
    public partial class Form1 : Form
    {
        int i=1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (i <= 10)
            {
                Button b = new Button();
                Controls.Add(b);
                b.Location = new Point(e.X, e.Y);
                b.Text = i.ToString();
                b.BackColor = Color.Aqua;
            }
            i++;
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                
                
            }
            
        }
    }
}
