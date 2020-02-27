using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class FormHelloWorld : Form
    {
        public FormHelloWorld()
        {
            InitializeComponent();
        }

        private void butHello_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "Hello World";
        }

        private void butGoodbye_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "Goodbye World";
        }
    }
}
