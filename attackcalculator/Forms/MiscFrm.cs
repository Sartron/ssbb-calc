﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attackcalculator
{
    public partial class MiscFrm : Form
    {
        private Collision curCollision;

        public MiscFrm(Collision collision)
        {
            InitializeComponent();
            curCollision = collision;
        }
    }
}