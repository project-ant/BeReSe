
namespace BeReSe
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.Button_Vehicle = new System.Windows.Forms.Button();
            this.Button_Address = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Vehicle
            // 
            this.Button_Vehicle.Location = new System.Drawing.Point(37, 205);
            this.Button_Vehicle.Name = "Button_Vehicle";
            this.Button_Vehicle.Size = new System.Drawing.Size(239, 36);
            this.Button_Vehicle.TabIndex = 0;
            this.Button_Vehicle.Text = "Vehicle";
            this.Button_Vehicle.UseVisualStyleBackColor = true;
            // 
            // Button_Address
            // 
            this.Button_Address.Location = new System.Drawing.Point(37, 257);
            this.Button_Address.Name = "Button_Address";
            this.Button_Address.Size = new System.Drawing.Size(239, 36);
            this.Button_Address.TabIndex = 1;
            this.Button_Address.Text = "Address";
            this.Button_Address.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 349);
            this.Controls.Add(this.Button_Address);
            this.Controls.Add(this.Button_Vehicle);
            this.DoubleBuffered = true;
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Vehicle;
        private System.Windows.Forms.Button Button_Address;
    }
}