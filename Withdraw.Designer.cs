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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Withdraw : System.Windows.Forms.Form
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
            this.lblaccno = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblaccno
            // 
            this.lblaccno.AutoSize = true;
            this.lblaccno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccno.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblaccno.Location = new System.Drawing.Point(13, 31);
            this.lblaccno.Name = "lblaccno";
            this.lblaccno.Size = new System.Drawing.Size(35, 18);
            this.lblaccno.TabIndex = 17;
            this.lblaccno.Text = "No.";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbldate.Location = new System.Drawing.Point(242, 35);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(48, 18);
            this.lbldate.TabIndex = 16;
            this.lbldate.Text = "Date:";
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.Maroon;
            this.btnok.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnok.Location = new System.Drawing.Point(180, 132);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(88, 47);
            this.btnok.TabIndex = 13;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(95, 64);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(274, 26);
            this.txtamount.TabIndex = 18;
            this.txtamount.TextChanged += new System.EventHandler(this.txtamount_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(11, 67);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(76, 20);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Amount:";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label4.Location = new System.Drawing.Point(98, 102);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(262, 14);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "Maximum Withdraw amount in LKR 25,000";
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel1.LinkColor = System.Drawing.Color.AntiqueWhite;
            this.LinkLabel1.Location = new System.Drawing.Point(260, 8);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(167, 19);
            this.LinkLabel1.TabIndex = 30;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Back to Main Menu";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Project by group 37- batch 21.1";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(433, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.lblaccno);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.btnok);
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdrawal";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label lblaccno;
		internal System.Windows.Forms.Label lbldate;
		internal System.Windows.Forms.Button btnok;
		internal System.Windows.Forms.TextBox txtamount;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.LinkLabel LinkLabel1;
        private Label label1;
    }
	
}
