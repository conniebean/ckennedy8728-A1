using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace ckennedy8728_A1
{
    public partial class _Default : Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            lblEntry.Visible = false;
            lblError.Visible = false;
            lblBinaryOutput.Visible = false;
            lblIntErrors.Visible = false;
            lblIntOutput.Visible = false;
            lblBinaryErrors.Visible = false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ButtonMethod();
            NoStyle();
            CommonFont();
        }

        //buttons to change text
        protected void btnGreen_Click(object sender, EventArgs e)
        {
            ButtonMethod();
            NoStyle();
            lblEntry.Font.Size = FontUnit.Large;
            lblEntry.BackColor = Color.SpringGreen;
            lblEntry.ForeColor = Color.DarkRed;
        }

        protected void btnReverse_Click(object sender, EventArgs e)
        {
            string entry = txtEntry.Text;

            if (txtEntry.Text == "")
            {
                lblError.Visible = true;
                lblError.Text = "Please enter some text to show";
            }
            else
            {
                lblError.Visible = false;
                lblEntry.Visible = true;
                NoStyle();
                CommonFont();
                string reverseEntry = string.Join(" ", entry.Split(' ').Select(s => new String(s.Reverse().ToArray())));
                lblEntry.Text = reverseEntry;
            }
        }

        protected void btnBold_Click(object sender, EventArgs e)
        {
            ButtonMethod();

            lblEntry.Font.Bold = true;
            lblEntry.Font.Italic = false;
            CommonFont();
        }

        protected void btnItalic_Click(object sender, EventArgs e)
        {
            ButtonMethod();

            lblEntry.Font.Italic = true;
            lblEntry.Font.Bold = false;
            CommonFont();
        }

        protected void btnApplyAll_Click(object sender, EventArgs e)
        {
            string entry = txtEntry.Text;

            if (txtEntry.Text == "")
            {
                lblError.Visible = true;
                lblError.Text = "Please enter some text to show";
            }
            else
            {
                lblError.Visible = false;
                lblEntry.Visible = true;
                lblEntry.Font.Italic = true;
                lblEntry.Font.Bold = true;
                lblEntry.Font.Size = FontUnit.Large;
                lblEntry.BackColor = Color.SpringGreen;
                lblEntry.ForeColor = Color.DarkRed;
                string reverseEntry = string.Join(" ", entry.Split(' ').Select(s => new String(s.Reverse().ToArray())));
                lblEntry.Text = reverseEntry;
            }
        }

        public void ButtonMethod()
        {
            string entry = txtEntry.Text;

            if (txtEntry.Text == "")
            {
                lblError.Visible = true;
                lblError.Text = "Please enter some text to show";
            }
            else
            {
                lblError.Visible = false;
                lblEntry.Visible = true;
                lblEntry.Text = entry;
            }
        }

        public void CommonFont()
        {
            lblEntry.Font.Size = FontUnit.Medium;
            lblEntry.BackColor = Color.Transparent;
            lblEntry.ForeColor = Color.Black;
        }

        public void NoStyle()
        {
            lblEntry.Font.Bold = false;
            lblEntry.Font.Italic = false;
        }

        protected void btnBinarySubmit_Click(object sender, EventArgs e)
        {
            if (txtIntToBinary.Text == "")
            {
                lblIntErrors.Visible = true;
                lblIntErrors.Text = "Please enter a number to convert";
            }
            else if (int.Parse(txtIntToBinary.Text) <= 0)
            {
                lblIntErrors.Visible = true;
                lblIntErrors.Text = "Please enter a whole number abover ZERO to convert";
            }
            else
            {
                int numEntry = int.Parse(txtIntToBinary.Text);

                int val;
                string a = "";

                while (numEntry >= 1)
                {
                    val = numEntry / 2;
                    a += (numEntry % 2).ToString();
                    numEntry = val;
                }

                string binaryConversion = "";
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    binaryConversion = binaryConversion + a[i];
                }

                lblBinaryOutput.Visible = true;
                lblBinaryOutput.Text = binaryConversion;
                
            }
        }

        protected void btnIntSubmit_Click(object sender, EventArgs e)
        {

            ConvertBinary();
        }

        public void ConvertBinary() 
        {
            if (txtBinaryToInt.Text == "")
            {
                lblBinaryErrors.Visible = true;
                lblBinaryErrors.Text = "Please enter a binary number to convert";
            }
            else if ((int)Convert.ToInt64(txtBinaryToInt.Text) <= 0)
            {
                lblBinaryErrors.Visible = true;
                lblBinaryErrors.Text = "Please enter a binary number greater than ZERO to convert";
            }
            else
            {
                int binaryEntry = (int)Convert.ToInt64(txtBinaryToInt.Text);
                int decimalOutput = 0;

                int baseValue = 1;

                while (binaryEntry > 0)
                {
                    int remainder = binaryEntry % 10;
                    binaryEntry = binaryEntry / 10;
                    decimalOutput += remainder * baseValue;
                    baseValue = baseValue * 2;
                }


                lblIntOutput.Visible = true;
                lblIntOutput.Text = decimalOutput.ToString();
            }
        }


    }
}