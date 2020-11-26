namespace BeReSe
{
    partial class Form_Admin_MainMenu
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
            System.Windows.Forms.Button Button_Service;
            System.Windows.Forms.Button Button_Status;
            System.Windows.Forms.Button button_Member;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin_MainMenu));
            this.DataGridView_Service = new System.Windows.Forms.DataGridView();
            this.DataGridView_Member = new System.Windows.Forms.DataGridView();
            Button_Service = new System.Windows.Forms.Button();
            Button_Status = new System.Windows.Forms.Button();
            button_Member = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Member)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Service
            // 
            this.DataGridView_Service.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView_Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Service.Location = new System.Drawing.Point(26, 92);
            this.DataGridView_Service.Name = "DataGridView_Service";
            this.DataGridView_Service.Size = new System.Drawing.Size(262, 254);
            this.DataGridView_Service.TabIndex = 0;
            // 
            // Button_Service
            // 
            Button_Service.BackColor = System.Drawing.Color.White;
            Button_Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_Service.ForeColor = System.Drawing.Color.Black;
            Button_Service.Location = new System.Drawing.Point(26, 352);
            Button_Service.Name = "Button_Service";
            Button_Service.Size = new System.Drawing.Size(92, 37);
            Button_Service.TabIndex = 6;
            Button_Service.Text = "Service";
            Button_Service.UseVisualStyleBackColor = false;
            // 
            // Button_Status
            // 
            Button_Status.BackColor = System.Drawing.Color.White;
            Button_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_Status.ForeColor = System.Drawing.Color.Black;
            Button_Status.Location = new System.Drawing.Point(321, 205);
            Button_Status.Name = "Button_Status";
            Button_Status.Size = new System.Drawing.Size(92, 37);
            Button_Status.TabIndex = 7;
            Button_Status.Text = "Status";
            Button_Status.UseVisualStyleBackColor = false;
            // 
            // DataGridView_Member
            // 
            this.DataGridView_Member.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Member.Location = new System.Drawing.Point(444, 92);
            this.DataGridView_Member.Name = "DataGridView_Member";
            this.DataGridView_Member.Size = new System.Drawing.Size(335, 254);
            this.DataGridView_Member.TabIndex = 8;
            // 
            // button_Member
            // 
            button_Member.BackColor = System.Drawing.Color.White;
            button_Member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Member.ForeColor = System.Drawing.Color.Black;
            button_Member.Location = new System.Drawing.Point(444, 352);
            button_Member.Name = "button_Member";
            button_Member.Size = new System.Drawing.Size(92, 37);
            button_Member.TabIndex = 9;
            button_Member.Text = "Member";
            button_Member.UseVisualStyleBackColor = false;
            // 
            // Form_Admin_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(button_Member);
            this.Controls.Add(this.DataGridView_Member);
            this.Controls.Add(Button_Status);
            this.Controls.Add(Button_Service);
            this.Controls.Add(this.DataGridView_Service);
            this.DoubleBuffered = true;
            this.Name = "Form_Admin_MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Service)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Member)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_Service;
        private System.Windows.Forms.DataGridView DataGridView_Member;
    }
}