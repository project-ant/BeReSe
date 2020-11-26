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
            // Form_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Status);
            this.DoubleBuffered = true;
            this.Name = "Form_Status";
            this.Text = "Status";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Status;
    }
}