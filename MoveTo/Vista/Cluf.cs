using MoveTo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveTo.Vista
{
    public partial class Cluf : Form
    {
        public Cluf()
        {
            InitializeComponent();
            richTextBox1.Text = Resources.eula.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
