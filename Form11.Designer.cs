
namespace BeReSe
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.DataGridView_Alert = new System.Windows.Forms.DataGridView();
            this.Button_Deny = new System.Windows.Forms.Button();
            this.Button_Accept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Alert)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Alert
            // 
            this.DataGridView_Alert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Alert.Location = new System.Drawing.Point(51, 55);
            this.DataGridView_Alert.Name = "DataGridView_Alert";
            this.DataGridView_Alert.Size = new System.Drawing.Size(291, 209);
            this.DataGridView_Alert.TabIndex = 0;
            // 
            // Button_Deny
            // 
            this.Button_Deny.Location = new System.Drawing.Point(51, 271);
            this.Button_Deny.Name = "Button_Deny";
            this.Button_Deny.Size = new System.Drawing.Size(95, 23);
            this.Button_Deny.TabIndex = 1;
            this.Button_Deny.Text = "Deny";
            this.Button_Deny.UseVisualStyleBackColor = true;
            // 
            // Button_Accept
            // 
            this.Button_Accept.Location = new System.Drawing.Point(243, 270);
            this.Button_Accept.Name = "Button_Accept";
            this.Button_Accept.Size = new System.Drawing.Size(99, 23);
            this.Button_Accept.TabIndex = 2;
            this.Button_Accept.Text = "Accept";
            this.Button_Accept.UseVisualStyleBackColor = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 308);
            this.Controls.Add(this.Button_Accept);
            this.Controls.Add(this.Button_Deny);
            this.Controls.Add(this.DataGridView_Alert);
            this.DoubleBuffered = true;
            this.Name = "Form11";
            this.Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Alert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_Alert;
        private System.Windows.Forms.Button Button_Deny;
        private System.Windows.Forms.Button Button_Accept;
    }
}