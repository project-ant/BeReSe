
namespace BeReSe
{
    partial class Form9_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9_Report));
            this.DataGridView_Address = new System.Windows.Forms.DataGridView();
            this.Button_MainMenu = new System.Windows.Forms.Button();
            this.Button_Profile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Address)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Address
            // 
            this.DataGridView_Address.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Address.Location = new System.Drawing.Point(50, 51);
            this.DataGridView_Address.Name = "DataGridView_Address";
            this.DataGridView_Address.Size = new System.Drawing.Size(257, 233);
            this.DataGridView_Address.TabIndex = 0;
            this.DataGridView_Address.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Address_CellContentClick);
            // 
            // Button_MainMenu
            // 
            this.Button_MainMenu.Location = new System.Drawing.Point(313, 4);
            this.Button_MainMenu.Name = "Button_MainMenu";
            this.Button_MainMenu.Size = new System.Drawing.Size(38, 40);
            this.Button_MainMenu.TabIndex = 1;
            this.Button_MainMenu.Text = "Main Menu";
            this.Button_MainMenu.UseVisualStyleBackColor = true;
            this.Button_MainMenu.Click += new System.EventHandler(this.Button_MainMenu_Click);
            // 
            // Button_Profile
            // 
            this.Button_Profile.Location = new System.Drawing.Point(252, 5);
            this.Button_Profile.Name = "Button_Profile";
            this.Button_Profile.Size = new System.Drawing.Size(55, 40);
            this.Button_Profile.TabIndex = 2;
            this.Button_Profile.Text = "Profile";
            this.Button_Profile.UseVisualStyleBackColor = true;
            this.Button_Profile.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 310);
            this.Controls.Add(this.Button_Profile);
            this.Controls.Add(this.Button_MainMenu);
            this.Controls.Add(this.DataGridView_Address);
            this.DoubleBuffered = true;
            this.Name = "Form9";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Address)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_Address;
        private System.Windows.Forms.Button Button_MainMenu;
        private System.Windows.Forms.Button Button_Profile;
    }
}