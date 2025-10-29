using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_1
{
    public partial class Form1 : Form
    {
        private string total;
        const string BIGA = "A";
        const string  SMALLA= "a";
        const string AN = "An";
        const string SMALLAN = "an";
        const string THE= "The";
        const string SMALLTHE = "the";
        const string MAN = "man";
        const string WOMAN= "woman";
        const string DOG = "dog";
        const string CAT = "cat";
        const string CAR = "car";
        const string BICYLE = "bicyle";
        const string BEAUTIFUL = "beautiful";
        const string BIG = "big";
        const string SMALL = "small";
        const string STRANGE = "strange";
        const string LOOKEDAT = "looked at";
        const string RODE = "rode";
        const string SPOKETO = "spoke to";
        const string LAUGHEDAT = "laughed at";
        const string DROVE = "drove";
        const string SPACE = " ";
        const string PERIOD= ".";
        const string MARVEL = "!";
        public Form1()
        {
            InitializeComponent();
        }

        private void A_Click(object sender, EventArgs e)
        {
            total += BIGA;
            label1.Text = total.ToString();
        }

        private void smalla_Click(object sender, EventArgs e)
        {
            total += SMALLA;
            label1.Text = total.ToString();
        }

        private void An_Click(object sender, EventArgs e)
        {
            total += AN;
            label1.Text = total.ToString();
        }

        private void smallAN_Click(object sender, EventArgs e)
        {
            total += SMALLAN;
            label1.Text = total.ToString();
        }

        private void bigthe_Click(object sender, EventArgs e)
        {
            total += THE;
            label1.Text = total.ToString();
        }

        private void the_Click(object sender, EventArgs e)
        {
            total += SMALLTHE;
            label1.Text = total.ToString();
        }

        private void man_Click(object sender, EventArgs e)
        {
            total += MAN;
            label1.Text = total.ToString();
        }

        private void woman_Click(object sender, EventArgs e)
        {
            total += WOMAN;
            label1.Text = total.ToString();
        }

        private void dog_Click(object sender, EventArgs e)
        {
            total += DOG;
            label1.Text = total.ToString();
        }

        private void cat_Click(object sender, EventArgs e)
        {
            total += CAT;
            label1.Text = total.ToString();
        }

        private void car_Click(object sender, EventArgs e)
        {
            total += CAR;
            label1.Text = total.ToString();
        }

        private void bicyle_Click(object sender, EventArgs e)
        {
            total += BICYLE;
            label1.Text = total.ToString();
        }

        private void beautiful_Click(object sender, EventArgs e)
        {
            total += BEAUTIFUL;
            label1.Text = total.ToString();
        }

        private void big_Click(object sender, EventArgs e)
        {
            total += BIG;
            label1.Text = total.ToString();
        }

        private void small_Click(object sender, EventArgs e)
        {
            total += SMALL;
            label1.Text = total.ToString();
        }

        private void strange_Click(object sender, EventArgs e)
        {
            total += STRANGE;
            label1.Text = total.ToString();
        }

        private void lookedat_Click(object sender, EventArgs e)
        {
            total += LOOKEDAT;
            label1.Text = total.ToString();
        }

        private void rode_Click(object sender, EventArgs e)
        {
            total += RODE;
            label1.Text = total.ToString();
        }

        private void spoketo_Click(object sender, EventArgs e)
        {
            total += SPOKETO;
            label1.Text = total.ToString();
        }

        private void laughedat_Click(object sender, EventArgs e)
        {
            total += LAUGHEDAT;
            label1.Text = total.ToString();
        }

        private void drove_Click(object sender, EventArgs e)
        {
            total += DROVE;
            label1.Text = total.ToString();
        }

        private void space_Click(object sender, EventArgs e)
        {
            total += SPACE;
            label1.Text = total.ToString();
        }

        private void period_Click(object sender, EventArgs e)
        {
            total += PERIOD;
            label1.Text = total.ToString();
        }

        private void marvel_Click(object sender, EventArgs e)
        {
            total += MARVEL;
            label1.Text = total.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            total = " ";
            label1.Text = total.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
