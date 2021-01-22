using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class Form1 : Form
    {
        int calories;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBanana_Click(object sender, EventArgs e)
        {
            const int bananaCalories = 115;

            calories += bananaCalories;

            lblTotalCalories.Text = calories.ToString();
        }

        private void picApple_Click(object sender, EventArgs e)
        {
            const int appleCalories = 80;

            calories += appleCalories;

            lblTotalCalories.Text = calories.ToString();
        }

        private void picOrange_Click(object sender, EventArgs e)
        {
            const int orangeCalories = 90;

            calories += orangeCalories;

            lblTotalCalories.Text = calories.ToString();
        }

        private void picPear_Click(object sender, EventArgs e)
        {
            const int pearCalories = 120;

            calories += pearCalories;
            lblTotalCalories.Text = calories.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            calories = 0;
            lblTotalCalories.Text = calories.ToString();
        }
    }
}
