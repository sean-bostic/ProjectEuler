﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Project_Euler_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //copy answer to clipboard
            Clipboard.SetText(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //copy code to clipboard
            Clipboard.SetText(richTextBox2.Text);
        }
    }
}
