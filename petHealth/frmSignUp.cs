﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petHealth
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        public frmSignUp(string test)
        {
            string s = test;
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
