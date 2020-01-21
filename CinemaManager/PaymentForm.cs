using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManager.Managers;
using CinemaManager.Models;

namespace CinemaManager
{
    public partial class PaymentForm : Form
    {
        private PaymentsMethod paymentsMethod;
        public float price;

        public PaymentForm(float price)
        {
            InitializeComponent();
            textBox1.Visible = false;
            label3.Visible = false;
            paymentsMethod = PaymentsMethod.None;
            label2.Text = price.ToString();
            this.price = price;
        }

        private void CardRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            paymentsMethod = PaymentsMethod.Card;
            textBox1.Visible = false;
            label3.Visible = false;
        }

        private void CashRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            paymentsMethod = PaymentsMethod.Cash;
            textBox1.Visible = true;
            label3.Visible = true;
        }

        private void AcceptButton(object sender, EventArgs e)
        {
            float cash = 0;
            if (paymentsMethod != PaymentsMethod.None)
            {
                button1.BackColor = Color.White;

                PaymentFactory pf = new PaymentFactory();

                if (paymentsMethod == PaymentsMethod.Cash)
                {
                    textBox1.BackColor = Color.White;
                    try
                    {
                         cash = float.Parse(textBox1.Text);
                    }
                    catch (Exception exception)
                    {

                        textBox1.BackColor = Color.Brown;
                    }
                }

                var res = pf.CreatePaymentMethod(paymentsMethod).MakePayment(100,cash);

                if (res.Result)
                {
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
            }
            else
            {
                button1.BackColor = Color.Brown;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
