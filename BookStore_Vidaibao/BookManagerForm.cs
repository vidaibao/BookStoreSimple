﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_Vidaibao
{
    public partial class BookManagerForm : Form
    {
        public BookManagerForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
