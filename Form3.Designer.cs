namespace BeReSe
{
    partial class Form_Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Service));
            this.DataGridView_ = new System.Windows.Forms.DataGridView();
            this.Button_MainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_
            // 
            this.DataGridView_.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_.Location = new System.Drawing.Point(27, 81);
            this.DataGridView_.Name = "DataGridView_";
            this.DataGridView_.Size = new System.Drawing.Size(418, 328);
            this.DataGridView_.TabIndex = 1;
            // 
            // Button_MainMenu
            // 
            this.Button_MainMenu.Location = new System.Drawing.Point(720, 12);
            this.Button_MainMenu.Name = "Button_MainMenu";
            this.Button_MainMenu.Size = new System.Drawing.Size(68, 46);
            this.Button_MainMenu.TabIndex = 2;
            this.Button_MainMenu.Text = "Main Menu";
            this.Button_MainMenu.UseVisualStyleBackColor = true;
            this.Button_MainMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_MainMenu);
            this.Controls.Add(this.DataGridView_);
            this.DoubleBuffered = true;
            this.Name = "Form_Service";
            this.Text = "Service";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_;
        private System.Windows.Forms.Button Button_MainMenu;
    }
}