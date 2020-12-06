
namespace BeReSe
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.Button_Email = new System.Windows.Forms.Button();
            this.Button_Phone = new System.Windows.Forms.Button();
            this.Button_Contact = new System.Windows.Forms.Button();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Email
            // 
            this.Button_Email.Location = new System.Drawing.Point(138, 177);
            this.Button_Email.Name = "Button_Email";
            this.Button_Email.Size = new System.Drawing.Size(34, 23);
            this.Button_Email.TabIndex = 0;
            this.Button_Email.Text = "Email";
            this.Button_Email.UseVisualStyleBackColor = true;
            // 
            // Button_Phone
            // 
            this.Button_Phone.Location = new System.Drawing.Point(178, 177);
            this.Button_Phone.Name = "Button_Phone";
            this.Button_Phone.Size = new System.Drawing.Size(44, 23);
            this.Button_Phone.TabIndex = 1;
            this.Button_Phone.Text = "Number";
            this.Button_Phone.UseVisualStyleBackColor = true;
            // 
            // Button_Contact
            // 
            this.Button_Contact.Location = new System.Drawing.Point(228, 177);
            this.Button_Contact.Name = "Button_Contact";
            this.Button_Contact.Size = new System.Drawing.Size(34, 23);
            this.Button_Contact.TabIndex = 2;
            this.Button_Contact.Text = "WA";
            this.Button_Contact.UseVisualStyleBackColor = true;
            // 
            // Button_Edit
            // 
            this.Button_Edit.Location = new System.Drawing.Point(323, 12);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(75, 23);
            this.Button_Edit.TabIndex = 3;
            this.Button_Edit.Text = "Edit";
            this.Button_Edit.UseVisualStyleBackColor = true;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 319);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.Button_Contact);
            this.Controls.Add(this.Button_Phone);
            this.Controls.Add(this.Button_Email);
            this.DoubleBuffered = true;
            this.Name = "Form13";
            this.Text = "Form13";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Email;
        private System.Windows.Forms.Button Button_Phone;
        private System.Windows.Forms.Button Button_Contact;
        private System.Windows.Forms.Button Button_Edit;
    }
}