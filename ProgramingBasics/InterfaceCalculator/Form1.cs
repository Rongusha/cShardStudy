using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var num1 = decimal.Parse(this.Box1.Text);
            var num2 = decimal.Parse(this.Box2.Text);
            var sum = num1 * num2;
            this.Suma.Text = "" + sum;
        }
    }
}
