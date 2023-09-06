using RecipeWinForms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmLogin : Form
    {
        bool loginsuccess = false;
        public frmLogin()
        {
            InitializeComponent();
            btnOk.Click += BtnOk_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        public bool ShowLogin()
        {
#if DEBUG
            this.Text = this.Text + " - Dev";
#endif
            txtUserName.Text = Settings.Default.userid;
            this.ShowDialog();
            return loginsuccess;
        }

        private void BtnOk_Click(object? sender, EventArgs e)
        {
            try
            {
                string connstringkey = "";
#if DEBUG
                connstringkey = "devconn";

#else
                connstringkey = "liveconn";
#endif
                string constring = ConfigurationManager.ConnectionStrings[connstringkey].ConnectionString;
                DBManager.SetConnectionString(constring, true, txtUserName.Text, txtPassword.Text);
                loginsuccess = true;
                Settings.Default.userid = txtUserName.Text;
                Settings.Default.Save();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid login, try again.", Application.ProductName);
            }
        }
        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }


    }
}
