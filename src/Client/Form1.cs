using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace EHLLAPI
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmEhllapi : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtSessione;
		private System.Windows.Forms.Button sendStr;
		private System.Windows.Forms.TextBox txtString;
		private System.Windows.Forms.Button Connect;
		private System.Windows.Forms.Button Disconnect;
		private System.Windows.Forms.Button ReadStr;
		private System.Windows.Forms.Button SetCursorPos;
		private System.Windows.Forms.TextBox txtCursorPos;
		private System.Windows.Forms.TextBox txtReadPos;
		private System.Windows.Forms.TextBox txtReadLen;
		private System.Windows.Forms.Label lblReadOut;
		private System.Windows.Forms.Button Wait;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button getCursorPos;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmEhllapi()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Connect = new System.Windows.Forms.Button();
			this.Disconnect = new System.Windows.Forms.Button();
			this.txtSessione = new System.Windows.Forms.TextBox();
			this.sendStr = new System.Windows.Forms.Button();
			this.txtString = new System.Windows.Forms.TextBox();
			this.txtReadPos = new System.Windows.Forms.TextBox();
			this.ReadStr = new System.Windows.Forms.Button();
			this.SetCursorPos = new System.Windows.Forms.Button();
			this.txtCursorPos = new System.Windows.Forms.TextBox();
			this.txtReadLen = new System.Windows.Forms.TextBox();
			this.lblReadOut = new System.Windows.Forms.Label();
			this.Wait = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.getCursorPos = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Connect
			// 
			this.Connect.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.Connect.Location = new System.Drawing.Point(16, 16);
			this.Connect.Name = "Connect";
			this.Connect.Size = new System.Drawing.Size(72, 24);
			this.Connect.TabIndex = 0;
			this.Connect.Text = "Connect";
			this.Connect.Click += new System.EventHandler(this.button1_Click);
			// 
			// Disconnect
			// 
			this.Disconnect.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.Disconnect.Location = new System.Drawing.Point(16, 46);
			this.Disconnect.Name = "Disconnect";
			this.Disconnect.Size = new System.Drawing.Size(72, 24);
			this.Disconnect.TabIndex = 1;
			this.Disconnect.Text = "Disconnect";
			this.Disconnect.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtSessione
			// 
			this.txtSessione.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.txtSessione.Location = new System.Drawing.Point(202, 36);
			this.txtSessione.Name = "txtSessione";
			this.txtSessione.Size = new System.Drawing.Size(40, 20);
			this.txtSessione.TabIndex = 2;
			this.txtSessione.Text = "A";
			// 
			// sendStr
			// 
			this.sendStr.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.sendStr.Location = new System.Drawing.Point(16, 136);
			this.sendStr.Name = "sendStr";
			this.sendStr.Size = new System.Drawing.Size(72, 24);
			this.sendStr.TabIndex = 3;
			this.sendStr.Text = "Send String";
			this.sendStr.Click += new System.EventHandler(this.sendStr_Click);
			// 
			// txtString
			// 
			this.txtString.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.txtString.Location = new System.Drawing.Point(200, 138);
			this.txtString.Name = "txtString";
			this.txtString.Size = new System.Drawing.Size(136, 20);
			this.txtString.TabIndex = 4;
			this.txtString.Text = "";
			// 
			// txtReadPos
			// 
			this.txtReadPos.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.txtReadPos.Location = new System.Drawing.Point(200, 172);
			this.txtReadPos.Name = "txtReadPos";
			this.txtReadPos.Size = new System.Drawing.Size(40, 20);
			this.txtReadPos.TabIndex = 6;
			this.txtReadPos.Text = "";
			// 
			// ReadStr
			// 
			this.ReadStr.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.ReadStr.Location = new System.Drawing.Point(16, 184);
			this.ReadStr.Name = "ReadStr";
			this.ReadStr.Size = new System.Drawing.Size(72, 24);
			this.ReadStr.TabIndex = 5;
			this.ReadStr.Text = "Read String";
			this.ReadStr.Click += new System.EventHandler(this.ReadStr_Click);
			// 
			// SetCursorPos
			// 
			this.SetCursorPos.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.SetCursorPos.Location = new System.Drawing.Point(16, 76);
			this.SetCursorPos.Name = "SetCursorPos";
			this.SetCursorPos.Size = new System.Drawing.Size(72, 24);
			this.SetCursorPos.TabIndex = 7;
			this.SetCursorPos.Text = "Set Cursor";
			this.SetCursorPos.Click += new System.EventHandler(this.SetCursorPos_Click);
			// 
			// txtCursorPos
			// 
			this.txtCursorPos.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.txtCursorPos.Location = new System.Drawing.Point(202, 91);
			this.txtCursorPos.Name = "txtCursorPos";
			this.txtCursorPos.Size = new System.Drawing.Size(40, 20);
			this.txtCursorPos.TabIndex = 8;
			this.txtCursorPos.Text = "";
			// 
			// txtReadLen
			// 
			this.txtReadLen.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.txtReadLen.Location = new System.Drawing.Point(336, 172);
			this.txtReadLen.Name = "txtReadLen";
			this.txtReadLen.Size = new System.Drawing.Size(40, 20);
			this.txtReadLen.TabIndex = 9;
			this.txtReadLen.Text = "";
			// 
			// lblReadOut
			// 
			this.lblReadOut.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.lblReadOut.Location = new System.Drawing.Point(200, 200);
			this.lblReadOut.Name = "lblReadOut";
			this.lblReadOut.Size = new System.Drawing.Size(176, 16);
			this.lblReadOut.TabIndex = 10;
			// 
			// Wait
			// 
			this.Wait.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.Wait.Location = new System.Drawing.Point(16, 224);
			this.Wait.Name = "Wait";
			this.Wait.Size = new System.Drawing.Size(72, 24);
			this.Wait.TabIndex = 11;
			this.Wait.Text = "Wait";
			this.Wait.Click += new System.EventHandler(this.Wait_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Location = new System.Drawing.Point(104, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "Session ID";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label2.Location = new System.Drawing.Point(104, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Cursor Position";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.label3.Location = new System.Drawing.Point(104, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 14;
			this.label3.Text = "String";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.label4.Location = new System.Drawing.Point(104, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 15;
			this.label4.Text = "Cursor Position";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.label5.Location = new System.Drawing.Point(264, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 16;
			this.label5.Text = "Length";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.label6.Location = new System.Drawing.Point(104, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 16);
			this.label6.TabIndex = 17;
			this.label6.Text = "String result";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(96, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(288, 24);
			this.label7.TabIndex = 18;
			this.label7.Text = "PARAMETERS";
			// 
			// getCursorPos
			// 
			this.getCursorPos.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.getCursorPos.Location = new System.Drawing.Point(16, 106);
			this.getCursorPos.Name = "getCursorPos";
			this.getCursorPos.Size = new System.Drawing.Size(72, 24);
			this.getCursorPos.TabIndex = 19;
			this.getCursorPos.Text = "Get Cursor";
			this.getCursorPos.Click += new System.EventHandler(this.getCursorPos_Click);
			// 
			// frmEhllapi
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(432, 261);
			this.Controls.Add(this.getCursorPos);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Wait);
			this.Controls.Add(this.lblReadOut);
			this.Controls.Add(this.txtReadLen);
			this.Controls.Add(this.txtCursorPos);
			this.Controls.Add(this.SetCursorPos);
			this.Controls.Add(this.txtReadPos);
			this.Controls.Add(this.ReadStr);
			this.Controls.Add(this.txtString);
			this.Controls.Add(this.sendStr);
			this.Controls.Add(this.txtSessione);
			this.Controls.Add(this.Disconnect);
			this.Controls.Add(this.Connect);
			this.Name = "frmEhllapi";
			this.Text = "EHLLAPI DEMO";
			this.TopMost = true;
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(EhllapiWrapper.Connect(txtSessione.Text).ToString());
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
		   MessageBox.Show(EhllapiWrapper.Disconnect(txtSessione.Text).ToString());
		}

		private void sendStr_Click(object sender, System.EventArgs e)
		{
			EhllapiWrapper.SendStr(this.txtString.Text);
		}

		private void SetCursorPos_Click(object sender, System.EventArgs e)
		{
			EhllapiWrapper.SetCursorPos(Convert.ToInt32(this.txtCursorPos.Text));
		}

		private void ReadStr_Click(object sender, System.EventArgs e)
		{   string s;
			EhllapiWrapper.ReadScreen(Convert.ToInt32(this.txtReadPos.Text),Convert.ToInt32(this.txtReadLen.Text),out s);
			this.lblReadOut.Text=s;
		}

		private void Wait_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(EhllapiWrapper.Wait().ToString());
		}

		private void getCursorPos_Click(object sender, System.EventArgs e)
		{
		  int p;	
		  EhllapiWrapper.GetCursorPos(out p);
		  this.txtCursorPos.Text=p.ToString();	
		}
		
	}
}
