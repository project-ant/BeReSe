
namespace BeReSe
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.Button_Not_Available = new System.Windows.Forms.Button();
            this.Button_Available = new System.Windows.Forms.Button();
            this.Button_List = new System.Windows.Forms.Button();
            this.Button_My_Account = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Not_Available
            // 
            this.Button_Not_Available.Location = new System.Drawing.Point(27, 114);
            this.Button_Not_Available.Name = "Button_Not_Available";
            this.Button_Not_Available.Size = new System.Drawing.Size(134, 78);
            this.Button_Not_Available.TabIndex = 0;
            this.Button_Not_Available.Text = "Not Available";
            this.Button_Not_Available.UseVisualStyleBackColor = true;
            // 
            // Button_Available
            // 
            this.Button_Available.Location = new System.Drawing.Point(203, 114);
            this.Button_Available.Name = "Button_Available";
            this.Button_Available.Size = new System.Drawing.Size(134, 78);
            this.Button_Available.TabIndex = 1;
            this.Button_Available.Text = "Available";
            this.Button_Available.UseVisualStyleBackColor = true;
            // 
            // Button_List
            // 
            this.Button_List.Location = new System.Drawing.Point(52, 257);
            this.Button_List.Name = "Button_List";
            this.Button_List.Size = new System.Drawing.Size(66, 36);
            this.Button_List.TabIndex = 2;
            this.Button_List.Text = "List";
            this.Button_List.UseVisualStyleBackColor = true;
            // 
            // Button_My_Account
            // 
            this.Button_My_Account.Location = new System.Drawing.Point(212, 257);
            this.Button_My_Account.Name = "Button_My_Account";
            this.Button_My_Account.Size = new System.Drawing.Size(101, 36);
            this.Button_My_Account.TabIndex = 3;
            this.Button_My_Account.Text = "My Account";
            this.Button_My_Account.UseVisualStyleBackColor = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(363, 305);
            this.Controls.Add(this.Button_My_Account);
            this.Controls.Add(this.Button_List);
            this.Controls.Add(this.Button_Available);
            this.Controls.Add(this.Button_Not_Available);
            this.DoubleBuffered = true;
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Not_Available;
        private System.Windows.Forms.Button Button_Available;
        private System.Windows.Forms.Button Button_List;
        private System.Windows.Forms.Button Button_My_Account;
    }
}