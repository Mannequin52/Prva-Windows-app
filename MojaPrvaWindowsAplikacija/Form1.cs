﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojaPrvaWindowsAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            int brojA, brojB, zbroj;
            brojA = Convert.ToInt32(txtUnosBrojaA.Text);
            brojB = Convert.ToInt32(txtUnosBrojaB.Text);
            zbroj = brojA + brojB;

            txtIspisBroja.Text = "" + zbroj;

        }
    }
}
