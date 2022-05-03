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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Mainmenu : System.Windows.Forms.Form
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btndep = new System.Windows.Forms.Button();
            this.btnwith = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblaccno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Orange;
            this.GroupBox1.Controls.Add(this.btndep);
            this.GroupBox1.Controls.Add(this.btnwith);
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.GroupBox1.Location = new System.Drawing.Point(36, 134);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupBox1.Size = new System.Drawing.Size(426, 205);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Savings and Current Account ";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btndep
            // 
            this.btndep.BackColor = System.Drawing.Color.Maroon;
            this.btndep.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndep.ForeColor = System.Drawing.Color.White;
            this.btndep.Location = new System.Drawing.Point(216, 117);
            this.btndep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btndep.Name = "btndep";
            this.btndep.Size = new System.Drawing.Size(155, 58);
            this.btndep.TabIndex = 2;
            this.btndep.Text = "Deposit";
            this.btndep.UseVisualStyleBackColor = false;
            this.btndep.Click += new System.EventHandler(this.btndep_Click);
            // 
            // btnwith
            // 
            this.btnwith.BackColor = System.Drawing.Color.Maroon;
            this.btnwith.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwith.ForeColor = System.Drawing.Color.White;
            this.btnwith.Location = new System.Drawing.Point(54, 117);
            this.btnwith.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnwith.Name = "btnwith";
            this.btnwith.Size = new System.Drawing.Size(155, 58);
            this.btnwith.TabIndex = 1;
            this.btnwith.Text = "Withdraw";
            this.btnwith.UseVisualStyleBackColor = false;
            this.btnwith.Click += new System.EventHandler(this.btnwith_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Maroon;
            this.Button1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(130, 38);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(155, 58);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Balance Receipt";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.White;
            this.btnlogout.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(307, 82);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(155, 27);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.Button4_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Black;
            this.lbldate.Location = new System.Drawing.Point(315, 9);
            this.lbldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(36, 14);
            this.lbldate.TabIndex = 7;
            this.lbldate.Text = "Date";
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(23, 47);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(90, 19);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Welcome :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(23, 86);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(113, 19);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Account No :";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(121, 47);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(48, 18);
            this.lblname.TabIndex = 10;
            this.lblname.Text = "name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblaccno
            // 
            this.lblaccno.AutoSize = true;
            this.lblaccno.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccno.ForeColor = System.Drawing.Color.Black;
            this.lblaccno.Location = new System.Drawing.Point(144, 87);
            this.lblaccno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblaccno.Name = "lblaccno";
            this.lblaccno.Size = new System.Drawing.Size(33, 18);
            this.lblaccno.TabIndex = 11;
            this.lblaccno.Text = "no.";
            this.lblaccno.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Project by group 37- batch 21.1";
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(510, 387);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.lblaccno);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Mainmenu_Load);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Button btnlogout;
		internal System.Windows.Forms.Button btndep;
		internal System.Windows.Forms.Button btnwith;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label lbldate;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label lblname;
		internal System.Windows.Forms.Label lblaccno;
        private Label label3;
    }
	
}
