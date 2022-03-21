using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tut_task1
{
    public partial class Form1 : Form
    {
        float total = 0f;

        public Form1()
        {
            InitializeComponent();
        }

        private void resetInputs()
        {
            txtName.Text = "";
            comCat.ResetText();
            numAge.Value = 0;
            numPurchasedPrice.Value = 0;
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int age = (int)numAge.Value;
            float purchasedPrice = (float)numPurchasedPrice.Value;
            

            if(age == 0 | purchasedPrice == 0.0)
            {
                lblOuput.Text = "Please enter a valid price or year";
            }
            else
            {
                float currentValue = CalculateCurrentValue(purchasedPrice, age);
                total += currentValue;
                lblOuput.Text = $"The item is worth {currentValue}.\n The collection so far is worth {total}";
            }

            resetInputs();



        }

        private float CalculateCurrentValue(float purchasedValue, int age)
        {
            float depreciation = purchasedValue * 0.2f * age;
            if (depreciation > purchasedValue) return 0f;
            return purchasedValue - depreciation;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //resetInputs();
            lblOuput.Text = "";
        }
    }
}
