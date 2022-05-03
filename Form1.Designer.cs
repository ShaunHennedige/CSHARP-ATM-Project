// VBConversions Note: VB project level imports
using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;
// End of VB project level imports


namespace atmsystem
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Login_frm : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_frm));
            this.llblreg = new System.Windows.Forms.LinkLabel();
            this.txtpin = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // llblreg
            // 
            this.llblreg.AutoSize = true;
            this.llblreg.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblreg.LinkColor = System.Drawing.Color.AntiqueWhite;
            this.llblreg.Location = new System.Drawing.Point(224, 125);
            this.llblreg.Name = "llblreg";
            this.llblreg.Size = new System.Drawing.Size(148, 16);
            this.llblreg.TabIndex = 4;
            this.llblreg.TabStop = true;
            this.llblreg.Text = "Create New Account";
            this.llblreg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblreg_LinkClicked);
            // 
            // txtpin
            // 
            this.txtpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpin.Location = new System.Drawing.Point(164, 39);
            this.txtpin.Name = "txtpin";
            this.txtpin.PasswordChar = '*';
            this.txtpin.Size = new System.Drawing.Size(187, 29);
            this.txtpin.TabIndex = 6;
            this.txtpin.TextChanged += new System.EventHandler(this.txtpin_TextChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Orange;
            this.GroupBox1.Controls.Add(this.txtpin);
            this.GroupBox1.Controls.Add(this.llblreg);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.btnlogin);
            this.GroupBox1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 73);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(378, 154);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Login";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(6, 43);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(154, 22);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Enter the Pin:";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Maroon;
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlogin.Location = new System.Drawing.Point(207, 73);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(102, 33);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Project by group 37- batch 21.1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 55);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(419, 274);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Login_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Login_frm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.LinkLabel llblreg;
		internal System.Windows.Forms.TextBox txtpin;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button btnlogin;
        private Label label1;
        private PictureBox pictureBox1;
    }
	
}
