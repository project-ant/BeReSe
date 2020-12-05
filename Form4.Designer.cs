namespace BeReSe
{
    partial class Form_Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Status));
            this.dataGridView_Status = new System.Windows.Forms.DataGridView();
            this.Button_MainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Status)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Status
            // 
            this.dataGridView_Status.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Status.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_Status.Location = new System.Drawing.Point(415, 60);
            this.dataGridView_Status.Name = "dataGridView_Status";
            this.dataGridView_Status.Size = new System.Drawing.Size(349, 347);
            this.dataGridView_Status.TabIndex = 0;
            // 
            // Button_MainMenu
            // 
            this.Button_MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_MainMenu.Location = new System.Drawing.Point(736, 13);
            this.Button_MainMenu.Name = "Button_MainMenu";
            this.Button_MainMenu.Size = new System.Drawing.Size(52, 29);
            this.Button_MainMenu.TabIndex = 1;
            this.Button_MainMenu.Text = "Main Menu";
            this.Button_MainMenu.UseVisualStyleBackColor = true;
            this.Button_MainMenu.Click += new System.EventHandler(this.Button_MainMenu_Click);
            // 
            // Form_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_MainMenu);
            this.Controls.Add(this.dataGridView_Status);
            this.DoubleBuffered = true;
            this.Name = "Form_Status";
            this.Text = "Status";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Status;
        private System.Windows.Forms.Button Button_MainMenu;
    }
}