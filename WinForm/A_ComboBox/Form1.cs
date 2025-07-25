﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            lblRestaurant.Text = "이번주 모임장소는 : " + cb.SelectedIndex.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ( comboBox1.Text != "" )
            {
                comboBox1.Items.Add(comboBox1.Text);
                lblRestaurant.Text = comboBox1.Text + "Added!";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                lblRestaurant.Text = comboBox1.SelectedIndex.ToString() + "Deleted!";
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
        }
    }
}
