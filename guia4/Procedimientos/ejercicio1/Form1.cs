﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PresentacInic()
        {
            grbResult.Visible = false;
            nupBase.Focus();
        }

        private void HacerCalculos(Decimal N)
        {
            int c;
            decimal res;

            lstTabla1.Items.Clear();
            c = 1;
            do
            {
                res = N * c;
                lstTabla1.Items.Add(N.ToString() + "X" + c.ToString() + " ="
                    + res.ToString());
                c += 1;
            } while (!(c > 10));

            lstTabla2.Items.Clear();
            c = 1;

            do
            {
                res = Elevar(N, c);
                lstTabla2.Items.Add(N.ToString() + " a la "+ c.ToString()
                    +" = "+res.ToString());
            } while (c<=10);
        }
            
        private decimal Elevar(decimal B, int expo)
        {
            int i = 1;
            decimal r = 1;
            do
            {
                r *= 0;
                i += 1;
            } while (!(i>expo));
            return r;
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            decimal n = nupBase.Value;
            HacerCalculos(n);
            grbResult.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PresentacInic();
        }
    }
}
