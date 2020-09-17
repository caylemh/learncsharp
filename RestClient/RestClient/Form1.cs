using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        #region UI Event Handlers

        private void CmdGo_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();

            rClient.endPoint = txtRestURI.Text;
            //rClient.authTech = authenticationTechnique.RollYourOwn;
            //rClient.authType = authenticationType.Basic;

            switch(cboVerb.Text)
            {
                case "POST":
                    rClient.httpMethod = httpverb.POST;
                    rClient.postJSON = txtJSONOut.Text;
                    break;
                case "PUT":
                    rClient.httpMethod = httpverb.PUT;
                    rClient.putJSON = txtJSONOut.Text;
                    break;
                default:
                    rClient.httpMethod = httpverb.GET;
                    break;
            }

            //rClient.postJSON = txtJSONOut.Text;
            rClient.userEmail = txtEmail.Text;
            rClient.userPswd = txtPswd.Text;

            debugOutput("REST Client Created");

            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();

            debugOutput(strResponse);
        }

        #endregion

        #region Debug Output
        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
        #endregion

        private void CmdClear_Click(object sender, EventArgs e)
        {
            txtResponse.Clear();
        }

        private void CmdCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(txtResponse.Text);
        }

        private void CboVerb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboVerb.Text == "POST" || cboVerb.Text == "PUT")
            {
                txtJSONOut.Enabled = true;
            }
            else
            {
                txtJSONOut.Enabled = false;
            }
        }
    }
}
