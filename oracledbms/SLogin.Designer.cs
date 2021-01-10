
namespace oracledbms
{
    partial class SLogin
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
            this.sname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labele = new System.Windows.Forms.Label();
            this.textboox = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(301, 175);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(100, 20);
            this.sname.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labele
            // 
            this.labele.AutoSize = true;
            this.labele.Location = new System.Drawing.Point(228, 182);
            this.labele.Name = "labele";
            this.labele.Size = new System.Drawing.Size(63, 13);
            this.labele.TabIndex = 2;
            this.labele.Text = "Shop Name";
            // 
            // textboox
            // 
            this.textboox.AutoSize = true;
            this.textboox.Location = new System.Drawing.Point(228, 225);
            this.textboox.Name = "textboox";
            this.textboox.Size = new System.Drawing.Size(53, 13);
            this.textboox.TabIndex = 3;
            this.textboox.Text = "Password";
            this.textboox.Click += new System.EventHandler(this.label2_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(301, 222);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(288, 258);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "New seller? Register now.";
            // 
            // SLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textboox);
            this.Controls.Add(this.labele);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sname);
            this.Name = "SLogin";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labele;
        private System.Windows.Forms.Label textboox;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}