﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add_Store : Form
    {
        public Add_Store()
        {
            InitializeComponent();
        }
        public List<string> storeNames = new List<string>();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Store_Form str = new Store_Form();
            storeNames.Add(txtLocation.Text);
        }

      /*  public string storeLocation
        {
            set { }
            get { return txtLocation.Text; }
        }*/
    }
}
