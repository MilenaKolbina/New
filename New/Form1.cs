﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New
{
    public partial class Form1 : Form
    {
        TextBox[,] matrix_vis_1;
        TextBox[,] matrix_vis_2;
        TextBox[,] matrix_vis_3;

        int default_size = 5;
        public Form1()
        {
            InitializeComponent();

            matrix_vis_1 = new TextBox[,]
            {
                {m1_00, m1_01,m1_02, m1_03, m1_04},
                {m1_10, m1_11, m1_12, m1_13 ,m1_14 },
                {m1_20, m1_21, m1_22 , m1_23 , m1_24 },
                {m1_30, m1_31, m1_32 , m1_33 , m1_34},
                {m1_40 ,m1_41 ,m1_42 , m1_43 , m1_44}
            };
            matrix_vis_2 = new TextBox[,]
            {
                {m2_00 , m2_01 ,m2_02 ,m2_03 ,m2_04  },
                { m2_10,m2_11,m2_12 ,m2_13 ,m2_14 },
                { m2_20 ,m2_21 ,m2_22 ,m2_23 ,m2_24 },
                { m2_30 ,m2_31 ,m2_32 ,m2_33 ,m2_34 },
                { m2_40 ,m2_41 ,m2_42 ,m2_43 ,m2_44 }
            };
            matrix_vis_3 = new TextBox[,]
            {
                {m3_00,m3_01 ,m3_02 ,m3_03,m3_04},
                {m3_10 ,m3_11 ,m3_12 ,m3_13 ,m3_14},
                {m3_20,m3_21 ,m3_22 ,m3_23 ,m3_24},
                { m3_30 ,m3_31 ,m3_32 ,m3_33 ,m3_34 },
                { m3_40 ,m3_41 ,m3_42 ,m3_43 ,m3_44 }
            };
        }

        private void TextBox51_TextChanged(object sender, EventArgs e)
        {

        }

        private void M1_01_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
