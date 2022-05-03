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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Receipt : System.Windows.Forms.Form
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbldep = new System.Windows.Forms.Label();
            this.lblwith = new System.Windows.Forms.Label();
            this.lblbal = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblnewbal = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Maroon;
            this.Button1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button1.Location = new System.Drawing.Point(195, 216);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(103, 47);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "OK";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(31, 76);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(77, 18);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Balance:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(31, 108);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(156, 18);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Amount Withdraw:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(33, 145);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(139, 18);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Amount Deposit:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(31, 16);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(40, 14);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Date:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(84, 16);
            this.lbldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(36, 14);
            this.lbldate.TabIndex = 6;
            this.lbldate.Text = "date";
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // lbldep
            // 
            this.lbldep.AutoSize = true;
            this.lbldep.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldep.Location = new System.Drawing.Point(298, 145);
            this.lbldep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldep.Name = "lbldep";
            this.lbldep.Size = new System.Drawing.Size(78, 13);
            this.lbldep.TabIndex = 10;
            this.lbldep.Text = "Amount Dep:";
            // 
            // lblwith
            // 
            this.lblwith.AutoSize = true;
            this.lblwith.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwith.Location = new System.Drawing.Point(298, 108);
            this.lblwith.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwith.Name = "lblwith";
            this.lblwith.Size = new System.Drawing.Size(86, 13);
            this.lblwith.TabIndex = 9;
            this.lblwith.Text = "Amount With:";
            // 
            // lblbal
            // 
            this.lblbal.AutoSize = true;
            this.lblbal.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbal.Location = new System.Drawing.Point(298, 76);
            this.lblbal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbal.Name = "lblbal";
            this.lblbal.Size = new System.Drawing.Size(57, 13);
            this.lblbal.TabIndex = 8;
            this.lblbal.Text = "Balance:";
            this.lblbal.Click += new System.EventHandler(this.lblbal_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(31, 177);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(182, 18);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "New account balance:";
            this.Label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // lblnewbal
            // 
            this.lblnewbal.AutoSize = true;
            this.lblnewbal.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblnewbal.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewbal.Location = new System.Drawing.Point(298, 177);
            this.lblnewbal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnewbal.Name = "lblnewbal";
            this.lblnewbal.Size = new System.Drawing.Size(0, 18);
            this.lblnewbal.TabIndex = 12;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(31, 46);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(53, 18);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Name:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(99, 46);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(48, 18);
            this.lblname.TabIndex = 14;
            this.lblname.Text = "name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Project by group 37- batch 21.1";
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel1.LinkColor = System.Drawing.Color.AntiqueWhite;
            this.LinkLabel1.Location = new System.Drawing.Point(282, 15);
            this.LinkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(167, 19);
            this.LinkLabel1.TabIndex = 31;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Back to Main Menu";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(506, 313);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.lblnewbal);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.lbldep);
            this.Controls.Add(this.lblwith);
            this.Controls.Add(this.lblbal);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button1);
            this.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label lbldate;
		internal System.Windows.Forms.Label lbldep;
		internal System.Windows.Forms.Label lblwith;
		internal System.Windows.Forms.Label lblbal;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label lblnewbal;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label lblname;
        private Label label1;
        internal LinkLabel LinkLabel1;
    }
	
}
