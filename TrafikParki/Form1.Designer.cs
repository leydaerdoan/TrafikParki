namespace TrafikParki
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_seriPort = new System.Windows.Forms.TextBox();
            this.btn_Baglan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Durdur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Veriler = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Location = new System.Drawing.Point(804, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_seriPort);
            this.groupBox1.Controls.Add(this.btn_Baglan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Durdur);
            this.groupBox1.Location = new System.Drawing.Point(17, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arduino İletişimi";
            // 
            // txt_seriPort
            // 
            this.txt_seriPort.Location = new System.Drawing.Point(152, 44);
            this.txt_seriPort.Name = "txt_seriPort";
            this.txt_seriPort.Size = new System.Drawing.Size(109, 22);
            this.txt_seriPort.TabIndex = 5;
            this.txt_seriPort.Tag = "";
            this.txt_seriPort.Text = "COM3";
            // 
            // btn_Baglan
            // 
            this.btn_Baglan.BackColor = System.Drawing.Color.Lime;
            this.btn_Baglan.Location = new System.Drawing.Point(551, 30);
            this.btn_Baglan.Name = "btn_Baglan";
            this.btn_Baglan.Size = new System.Drawing.Size(98, 48);
            this.btn_Baglan.TabIndex = 0;
            this.btn_Baglan.Text = "Bağlan";
            this.btn_Baglan.UseVisualStyleBackColor = false;
            this.btn_Baglan.Click += new System.EventHandler(this.btn_Baglan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seri Port :";
            // 
            // btn_Durdur
            // 
            this.btn_Durdur.BackColor = System.Drawing.Color.Red;
            this.btn_Durdur.Location = new System.Drawing.Point(655, 30);
            this.btn_Durdur.Name = "btn_Durdur";
            this.btn_Durdur.Size = new System.Drawing.Size(94, 48);
            this.btn_Durdur.TabIndex = 1;
            this.btn_Durdur.Text = "Durdur";
            this.btn_Durdur.UseVisualStyleBackColor = false;
            this.btn_Durdur.Click += new System.EventHandler(this.btn_Durdur_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Veriler);
            this.groupBox2.Location = new System.Drawing.Point(17, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 318);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veriler";
            // 
            // txt_Veriler
            // 
            this.txt_Veriler.Location = new System.Drawing.Point(32, 34);
            this.txt_Veriler.Multiline = true;
            this.txt_Veriler.Name = "txt_Veriler";
            this.txt_Veriler.Size = new System.Drawing.Size(717, 263);
            this.txt_Veriler.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(804, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 318);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Puan Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 69);
            this.label2.TabIndex = 0;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(54, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toplam Puan";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 91);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1069, 483);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Trafik Parkı Masaüstü Uygulaması";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_seriPort;
        private System.Windows.Forms.Button btn_Baglan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Durdur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Veriler;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

