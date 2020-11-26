namespace BeReSe
{
    partial class Form_Admin
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
            System.Windows.Forms.Button Button_Login;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin));
            this.Label_Login_Visible = new System.Windows.Forms.Label();
            this.TextBox_Login = new System.Windows.Forms.TextBox();
            this.Groupbox_Login = new System.Windows.Forms.GroupBox();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            Button_Login = new System.Windows.Forms.Button();
            this.Groupbox_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Login_Visible
            // 
            this.Label_Login_Visible.AutoSize = true;
            this.Label_Login_Visible.BackColor = System.Drawing.Color.Transparent;
            this.Label_Login_Visible.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Login_Visible.Location = new System.Drawing.Point(195, 33);
            this.Label_Login_Visible.Name = "Label_Login_Visible";
            this.Label_Login_Visible.Size = new System.Drawing.Size(65, 25);
            this.Label_Login_Visible.TabIndex = 0;
            this.Label_Login_Visible.Text = "Login";
            // 
            // TextBox_Login
            // 
            this.TextBox_Login.Location = new System.Drawing.Point(150, 83);
            this.TextBox_Login.Name = "TextBox_Login";
            this.TextBox_Login.Size = new System.Drawing.Size(288, 20);
            this.TextBox_Login.TabIndex = 1;
            // 
            // Groupbox_Login
            // 
            this.Groupbox_Login.BackColor = System.Drawing.Color.Transparent;
            this.Groupbox_Login.Controls.Add(Button_Login);
            this.Groupbox_Login.Controls.Add(this.Label_Password);
            this.Groupbox_Login.Controls.Add(this.textBox1);
            this.Groupbox_Login.Controls.Add(this.Label_Username);
            this.Groupbox_Login.Controls.Add(this.TextBox_Login);
            this.Groupbox_Login.Controls.Add(this.Label_Login_Visible);
            this.Groupbox_Login.Location = new System.Drawing.Point(269, 125);
            this.Groupbox_Login.Name = "Groupbox_Login";
            this.Groupbox_Login.Size = new System.Drawing.Size(444, 314);
            this.Groupbox_Login.TabIndex = 2;
            this.Groupbox_Login.TabStop = false;
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Username.Location = new System.Drawing.Point(41, 81);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(92, 22);
            this.Label_Username.TabIndex = 2;
            this.Label_Username.Text = "Username";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password.Location = new System.Drawing.Point(41, 146);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(89, 22);
            this.Label_Password.TabIndex = 4;
            this.Label_Password.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Button_Login
            // 
            Button_Login.BackColor = System.Drawing.Color.MediumSlateBlue;
            Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_Login.ForeColor = System.Drawing.Color.White;
            Button_Login.Location = new System.Drawing.Point(150, 220);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new System.Drawing.Size(152, 48);
            Button_Login.TabIndex = 5;
            Button_Login.Text = "Login";
            Button_Login.UseVisualStyleBackColor = false;
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 567);
            this.Controls.Add(this.Groupbox_Login);
            this.DoubleBuffered = true;
            this.Name = "Form_Admin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            this.Groupbox_Login.ResumeLayout(false);
            this.Groupbox_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Login_Visible;
        private System.Windows.Forms.TextBox TextBox_Login;
        private System.Windows.Forms.GroupBox Groupbox_Login;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Label_Username;
    }
}

