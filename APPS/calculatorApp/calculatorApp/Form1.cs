using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(Value1Textbox.Text);
            int v2 = Convert.ToInt32(Value2Textbox.Text);
            int sum = Add(v1, v2);
            SolutionLabel.Text = sum.ToString();
        }

        private int Add(int value1, int value2) {
            int sum = value1 + value2;
            return sum;
        }
    }
}
