
namespace woocommerce
{
    partial class tagform
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
            this.tagdesc = new System.Windows.Forms.TextBox();
            this.tagname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addtagbutton = new System.Windows.Forms.Button();
            this.homebutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagdesc
            // 
            this.tagdesc.Location = new System.Drawing.Point(127, 56);
            this.tagdesc.Multiline = true;
            this.tagdesc.Name = "tagdesc";
            this.tagdesc.Size = new System.Drawing.Size(319, 137);
            this.tagdesc.TabIndex = 9;
            // 
            // tagname
            // 
            this.tagname.Location = new System.Drawing.Point(127, 20);
            this.tagname.Name = "tagname";
            this.tagname.Size = new System.Drawing.Size(319, 20);
            this.tagname.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tag Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addtagbutton);
            this.panel1.Controls.Add(this.homebutton);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tagdesc);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tagname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 341);
            this.panel1.TabIndex = 10;
            // 
            // addtagbutton
            // 
            this.addtagbutton.Location = new System.Drawing.Point(316, 267);
            this.addtagbutton.Name = "addtagbutton";
            this.addtagbutton.Size = new System.Drawing.Size(130, 62);
            this.addtagbutton.TabIndex = 11;
            this.addtagbutton.Text = "Add Tag";
            this.addtagbutton.UseVisualStyleBackColor = true;
            this.addtagbutton.Click += new System.EventHandler(this.addtagbutton_Click);
            // 
            // homebutton
            // 
            this.homebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homebutton.Location = new System.Drawing.Point(12, 267);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(131, 62);
            this.homebutton.TabIndex = 10;
            this.homebutton.Text = "Home Form";
            this.homebutton.UseVisualStyleBackColor = true;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // tagform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.panel1);
            this.Name = "tagform";
            this.Text = "tagform";
            this.Load += new System.EventHandler(this.tagform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tagdesc;
        private System.Windows.Forms.TextBox tagname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addtagbutton;
        private System.Windows.Forms.Button homebutton;
    }
}