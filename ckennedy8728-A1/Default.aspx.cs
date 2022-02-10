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
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
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

        //buttons to change text
        protected void btnGreen_Click(object sender, EventArgs e)
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
                lblEntry.Font.Size = FontUnit.Large;
                lblEntry.BackColor = Color.SpringGreen;
                lblEntry.ForeColor = Color.DarkRed;
                lblEntry.Text = entry;
            }
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
                string reverseEntry = string.Join(" ", entry.Split(' ').Select(s => new String(s.Reverse().ToArray())));
                lblEntry.Text = reverseEntry;
            }
        }

        protected void btnBold_Click(object sender, EventArgs e)
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
                lblEntry.Font.Bold = true;
                lblEntry.Text = entry;
            }
        }

        protected void btnItalic_Click(object sender, EventArgs e)
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
                lblEntry.Text = entry;
            }
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
    }
}