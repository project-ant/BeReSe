namespace BeReSe
{
    partial class Form_User_MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_User_MainMenu));
            this.Button_Request = new System.Windows.Forms.Button();
            this.Button_Account = new System.Windows.Forms.Button();
            this.Button_History = new System.Windows.Forms.Button();
            this.Button_Search = new System.Windows.Forms.Button();
            this.Button_Profile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Request
            // 
            this.Button_Request.BackColor = System.Drawing.Color.Transparent;
            this.Button_Request.Location = new System.Drawing.Point(224, 116);
            this.Button_Request.Name = "Button_Request";
            this.Button_Request.Size = new System.Drawing.Size(96, 58);
            this.Button_Request.TabIndex = 0;
            this.Button_Request.Text = "Request";
            this.Button_Request.UseVisualStyleBackColor = false;
            // 
            // Button_Account
            // 
            this.Button_Account.Location = new System.Drawing.Point(44, 116);
            this.Button_Account.Name = "Button_Account";
            this.Button_Account.Size = new System.Drawing.Size(114, 58);
            this.Button_Account.TabIndex = 1;
            this.Button_Account.Text = "My Account";
            this.Button_Account.UseVisualStyleBackColor = true;
            // 
            // Button_History
            // 
            this.Button_History.Location = new System.Drawing.Point(44, 203);
            this.Button_History.Name = "Button_History";
            this.Button_History.Size = new System.Drawing.Size(114, 59);
            this.Button_History.TabIndex = 2;
            this.Button_History.Text = "History";
            this.Button_History.UseVisualStyleBackColor = true;
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(200, 203);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(152, 59);
            this.Button_Search.TabIndex = 3;
            this.Button_Search.Text = "Find Workshop";
            this.Button_Search.UseVisualStyleBackColor = true;
            // 
            // Button_Profile
            // 
            this.Button_Profile.Location = new System.Drawing.Point(282, 3);
            this.Button_Profile.Name = "Button_Profile";
            this.Button_Profile.Size = new System.Drawing.Size(58, 43);
            this.Button_Profile.TabIndex = 4;
            this.Button_Profile.Text = "Profile";
            this.Button_Profile.UseVisualStyleBackColor = true;
            // 
            // Form_User_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(364, 360);
            this.Controls.Add(this.Button_Profile);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.Button_History);
            this.Controls.Add(this.Button_Account);
            this.Controls.Add(this.Button_Request);
            this.DoubleBuffered = true;
            this.Name = "Form_User_MainMenu";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Request;
        private System.Windows.Forms.Button Button_Account;
        private System.Windows.Forms.Button Button_History;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.Button Button_Profile;
    }
}