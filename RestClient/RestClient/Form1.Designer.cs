namespace RestClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtRestURI = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cmdGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPswd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioOwn = new System.Windows.Forms.RadioButton();
            this.radioNetCred = new System.Windows.Forms.RadioButton();
            this.radioNTLM = new System.Windows.Forms.RadioButton();
            this.radioBasicAuth = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request URI:";
            // 
            // txtRestURI
            // 
            this.txtRestURI.Location = new System.Drawing.Point(100, 12);
            this.txtRestURI.Name = "txtRestURI";
            this.txtRestURI.Size = new System.Drawing.Size(334, 20);
            this.txtRestURI.TabIndex = 1;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(100, 190);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(422, 174);
            this.txtResponse.TabIndex = 2;
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(446, 12);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(77, 55);
            this.cmdGo.TabIndex = 3;
            this.cmdGo.Text = "GO!";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.CmdGo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Response:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // txtPswd
            // 
            this.txtPswd.Location = new System.Drawing.Point(302, 47);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.PasswordChar = '*';
            this.txtPswd.Size = new System.Drawing.Size(132, 20);
            this.txtPswd.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNetCred);
            this.groupBox1.Controls.Add(this.radioOwn);
            this.groupBox1.Location = new System.Drawing.Point(317, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 90);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Technique";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioNTLM);
            this.groupBox2.Controls.Add(this.radioBasicAuth);
            this.groupBox2.Location = new System.Drawing.Point(101, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 90);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Auth Type";
            // 
            // radioOwn
            // 
            this.radioOwn.AutoSize = true;
            this.radioOwn.Checked = true;
            this.radioOwn.Location = new System.Drawing.Point(13, 23);
            this.radioOwn.Name = "radioOwn";
            this.radioOwn.Size = new System.Drawing.Size(93, 17);
            this.radioOwn.TabIndex = 0;
            this.radioOwn.TabStop = true;
            this.radioOwn.Text = "Roll Your Own";
            this.radioOwn.UseVisualStyleBackColor = true;
            // 
            // radioNetCred
            // 
            this.radioNetCred.AutoSize = true;
            this.radioNetCred.Location = new System.Drawing.Point(13, 46);
            this.radioNetCred.Name = "radioNetCred";
            this.radioNetCred.Size = new System.Drawing.Size(143, 17);
            this.radioNetCred.TabIndex = 1;
            this.radioNetCred.Text = "Network Credential Class";
            this.radioNetCred.UseVisualStyleBackColor = true;
            // 
            // radioNTLM
            // 
            this.radioNTLM.AutoSize = true;
            this.radioNTLM.Location = new System.Drawing.Point(13, 46);
            this.radioNTLM.Name = "radioNTLM";
            this.radioNTLM.Size = new System.Drawing.Size(108, 17);
            this.radioNTLM.TabIndex = 3;
            this.radioNTLM.Text = "NTLM (Windows)";
            this.radioNTLM.UseVisualStyleBackColor = true;
            // 
            // radioBasicAuth
            // 
            this.radioBasicAuth.AutoSize = true;
            this.radioBasicAuth.Checked = true;
            this.radioBasicAuth.Location = new System.Drawing.Point(13, 23);
            this.radioBasicAuth.Name = "radioBasicAuth";
            this.radioBasicAuth.Size = new System.Drawing.Size(122, 17);
            this.radioBasicAuth.TabIndex = 2;
            this.radioBasicAuth.TabStop = true;
            this.radioBasicAuth.Text = "Basic Authentication";
            this.radioBasicAuth.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPswd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRestURI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "C# REST Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRestURI;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPswd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioNetCred;
        private System.Windows.Forms.RadioButton radioOwn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioNTLM;
        private System.Windows.Forms.RadioButton radioBasicAuth;
    }
}

