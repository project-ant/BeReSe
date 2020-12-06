
namespace BeReSe
{
    partial class Form_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_List));
            this.DataGridView_List = new System.Windows.Forms.DataGridView();
            this.Button_Bengkel_MainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_List)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_List
            // 
            this.DataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_List.Location = new System.Drawing.Point(22, 37);
            this.DataGridView_List.Name = "DataGridView_List";
            this.DataGridView_List.Size = new System.Drawing.Size(321, 185);
            this.DataGridView_List.TabIndex = 0;
            // 
            // Button_Bengkel_MainMenu
            // 
            this.Button_Bengkel_MainMenu.Location = new System.Drawing.Point(268, 228);
            this.Button_Bengkel_MainMenu.Name = "Button_Bengkel_MainMenu";
            this.Button_Bengkel_MainMenu.Size = new System.Drawing.Size(75, 23);
            this.Button_Bengkel_MainMenu.TabIndex = 1;
            this.Button_Bengkel_MainMenu.Text = "Main Menu";
            this.Button_Bengkel_MainMenu.UseVisualStyleBackColor = true;
            // 
            // Form_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(355, 303);
            this.Controls.Add(this.Button_Bengkel_MainMenu);
            this.Controls.Add(this.DataGridView_List);
            this.DoubleBuffered = true;
            this.Name = "Form_List";
            this.Text = "Form12";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_List;
        private System.Windows.Forms.Button Button_Bengkel_MainMenu;
    }
}