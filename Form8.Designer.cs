
namespace BeReSe
{
    partial class Form8_Vehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8_Vehicle));
            this.DataGridView_Vehicle = new System.Windows.Forms.DataGridView();
            this.Button_MainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Vehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Vehicle
            // 
            this.DataGridView_Vehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Vehicle.Location = new System.Drawing.Point(49, 65);
            this.DataGridView_Vehicle.Name = "DataGridView_Vehicle";
            this.DataGridView_Vehicle.Size = new System.Drawing.Size(248, 242);
            this.DataGridView_Vehicle.TabIndex = 0;
            // 
            // Button_MainMenu
            // 
            this.Button_MainMenu.Location = new System.Drawing.Point(260, 12);
            this.Button_MainMenu.Name = "Button_MainMenu";
            this.Button_MainMenu.Size = new System.Drawing.Size(75, 47);
            this.Button_MainMenu.TabIndex = 1;
            this.Button_MainMenu.Text = "Main Menu";
            this.Button_MainMenu.UseVisualStyleBackColor = true;
            this.Button_MainMenu.Click += new System.EventHandler(this.Button_MainMenu_Click);
            // 
            // Form8_Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 359);
            this.Controls.Add(this.Button_MainMenu);
            this.Controls.Add(this.DataGridView_Vehicle);
            this.DoubleBuffered = true;
            this.Name = "Form8_Vehicle";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Vehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_Vehicle;
        private System.Windows.Forms.Button Button_MainMenu;
    }
}