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
    public partial class frmPetProfiles : Form
    {
        public frmPetProfiles()
        {
            InitializeComponent();
        }

        private void frmPetProfiles_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
