using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Win
{
    public partial class HowMuchMoneyForm : Form
    {
        public int Amount { 
            get {
                //return Convert.ToInt32(AmountTextbox.Text);    
                int v = 0;
                int.TryParse(AmountTextbox.Text, out v);
                return v;
            } 
        }

        public HowMuchMoneyForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
