using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbering_system
{


    public  partial class Form1 : Form
    {
        private dynamic  selectedItem2;
        private dynamic  selectedItem1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void fromBox_SelectedIndexChanged(object sender, EventArgs e)
        {
              selectedItem1 = fromBox.Items[fromBox.SelectedIndex].ToString();
             
        }

        public void toBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             selectedItem2 = toBox.Items[fromBox.SelectedIndex].ToString();
        }



    }
}
