namespace TuLieuHocTap
{
	partial class AddStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.imageBox5 = new Emgu.CV.UI.ImageBox();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ho = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 554);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bước 1";
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.Color.Transparent;
            this.imageBox1.Location = new System.Drawing.Point(19, 128);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(501, 407);
            this.imageBox1.TabIndex = 4;
            this.imageBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 102);
            this.button1.TabIndex = 3;
            this.button1.Text = "Khởi động Camera và phát hiện";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.closeProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.backToolStripMenuItem.Text = "Quay lại";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // closeProgramToolStripMenuItem
            // 
            this.closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            this.closeProgramToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.closeProgramToolStripMenuItem.Text = "Đóng cửa sổ";
            this.closeProgramToolStripMenuItem.Click += new System.EventHandler(this.closeProgramToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.imageBox3);
            this.groupBox2.Controls.Add(this.imageBox5);
            this.groupBox2.Controls.Add(this.imageBox4);
            this.groupBox2.Controls.Add(this.imageBox2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(576, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 288);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bước 2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nose";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mouth";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Eyes";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Khuôn mặt";
            // 
            // imageBox3
            // 
            this.imageBox3.BackColor = System.Drawing.Color.Transparent;
            this.imageBox3.Location = new System.Drawing.Point(10, 182);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(100, 100);
            this.imageBox3.TabIndex = 17;
            this.imageBox3.TabStop = false;
            this.imageBox3.Visible = false;
            // 
            // imageBox5
            // 
            this.imageBox5.BackColor = System.Drawing.Color.Transparent;
            this.imageBox5.Location = new System.Drawing.Point(303, 41);
            this.imageBox5.Name = "imageBox5";
            this.imageBox5.Size = new System.Drawing.Size(100, 100);
            this.imageBox5.TabIndex = 19;
            this.imageBox5.TabStop = false;
            this.imageBox5.Visible = false;
            // 
            // imageBox4
            // 
            this.imageBox4.BackColor = System.Drawing.Color.Transparent;
            this.imageBox4.Location = new System.Drawing.Point(278, 182);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(100, 100);
            this.imageBox4.TabIndex = 18;
            this.imageBox4.TabStop = false;
            this.imageBox4.Visible = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.Color.Transparent;
            this.imageBox2.Location = new System.Drawing.Point(133, 182);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(100, 100);
            this.imageBox2.TabIndex = 16;
            this.imageBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 102);
            this.button2.TabIndex = 15;
            this.button2.Text = "Nhận diện";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.Ho);
            this.groupBox3.Location = new System.Drawing.Point(567, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 211);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bước 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tên lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên Khoa";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 29);
            this.textBox2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mã SV";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 29);
            this.textBox1.TabIndex = 18;
            // 
            // Ho
            // 
            this.Ho.AutoSize = true;
            this.Ho.Location = new System.Drawing.Point(8, 49);
            this.Ho.Name = "Ho";
            this.Ho.Size = new System.Drawing.Size(80, 24);
            this.Ho.TabIndex = 17;
            this.Ho.Text = "Họ Tên";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(698, 553);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 46);
            this.button3.TabIndex = 19;
            this.button3.Text = "Lưu nhận dạng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 32);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(105, 168);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(307, 32);
            this.comboBox2.TabIndex = 27;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 612);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddStudent";
            this.Text = " Facial Recognition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProgramToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox imageBox5;
        private Emgu.CV.UI.ImageBox imageBox4;
        private Emgu.CV.UI.ImageBox imageBox3;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Ho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

