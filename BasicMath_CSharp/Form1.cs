using System;
using System.Windows.Forms;

namespace BasicMath_CSharp
{
    public partial class frmMath : Form
    {
        public frmMath()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double Numb1 = Convert.ToDouble(txtNum1.Text);
            double Numb2 = Convert.ToDouble(txtNum2.Text);

            double Output = Numb1 + Numb2;

            txtOutput.Text = Output.ToString();

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double Numb1 = Convert.ToDouble(txtNum1.Text);
            double Numb2 = Convert.ToDouble(txtNum2.Text);

            double Output = Numb1 - Numb2;

            txtOutput.Text = Output.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double Numb1 = Convert.ToDouble(txtNum1.Text);
            double Numb2 = Convert.ToDouble(txtNum2.Text);

            double Output = Numb1 * Numb2;

            txtOutput.Text = Output.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double Numb1 = Convert.ToDouble(txtNum1.Text);
            double Numb2 = Convert.ToDouble(txtNum2.Text);

            double Output = Numb1 / Numb2;

            txtOutput.Text = Output.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtOutput.Clear();
        }
    }
}
