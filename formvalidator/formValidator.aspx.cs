using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetPractice
{
    public partial class formValidator : System.Web.UI.Page
    {
        //=============
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        //=============
        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            /*int result = 0;
            bool bCNIC = int.TryParse(txtCNIC.Text, out result);

            char[] aName = txtName.Text.ToCharArray();
            bool bName = true;
            foreach (char name in aName)
            {
                if (!char.IsLetter(name))
                {
                    bName = false;
                }
            }

            if (bCNIC && bName)
            {
                Log(txtName.Text, txtCNIC.Text);
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "FormSubmit", "alert('Your data is added');", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "FormSubmit", "alert('" + (!bName ? "name failed" : "") + (!bCNIC ? "cnic failed" : "") + "');", true);
            }*/

            double result;
            bool bCNIC = double.TryParse(txtCNIC.Text, out result);
            char[] aName = txtName.Text.ToCharArray();
            bool bName = true;


            Label1.Text = "";
            Label2.Text = "";

            if (string.IsNullOrEmpty(txtName.Text))
            {
                bName = false;
                Label1.Text = "Please Enter Your Name";
            }

            if (string.IsNullOrEmpty(txtCNIC.Text))
            {
                bName = false;
                Label2.Text = "Please Enter Your CNIC";
            }

            if (!bCNIC)
            {
                Label2.Text = "Incorrect CNIC";
            }


            foreach (char name in aName)
            {
                if (!char.IsLetter(name))
                {
                    bName = false;
                    Label1.Text = "Incorrect Name";
                }
            }

            if (bCNIC && bName)
            {
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "FormSubmit", "alert('Your data is added');", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "FormSubmit", "alert('FAILED');", true);
            }

        }

        //=============
     /*   public void Log(string name, string cnic)
        {
            string path = @"C:\Users\user\source\repos\ApiHitPractice\DotNetPractice\logdata\" + cnic + ".txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.WriteLine("Name = " + name + Environment.NewLine);
                    writer.WriteLine("CNIC = " + cnic + Environment.NewLine);
                    writer.Flush();
                    writer.Close();
                }
            }
        } */

        
    }
}