using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetIASalotti
{
    public partial class Form1 : Form
    {
        static public string initialPosition;
        static public string finalPosition;
        public Form1()
        {
            InitializeComponent();
        }

        private void resolvebtn_Click(object sender, EventArgs e)
        {
            initialPosition = initialpositiontxtbx.Text;
            finalPosition = finalpositiontxtbx.Text;

        }
    }
}
