namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBYear = new System.Windows.Forms.TextBox();
            this.textBoxGPA = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.labelBYear = new System.Windows.Forms.Label();
            this.labelGPA = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelจำนวน = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGPAmax = new System.Windows.Forms.TextBox();
            this.textBoxGPAmin = new System.Windows.Forms.TextBox();
            this.textBoxGPAavg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNameGPAmax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNameGPAmin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(99, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxBYear
            // 
            this.textBoxBYear.Location = new System.Drawing.Point(99, 84);
            this.textBoxBYear.Name = "textBoxBYear";
            this.textBoxBYear.Size = new System.Drawing.Size(125, 27);
            this.textBoxBYear.TabIndex = 1;
            // 
            // textBoxGPA
            // 
            this.textBoxGPA.Location = new System.Drawing.Point(99, 145);
            this.textBoxGPA.Name = "textBoxGPA";
            this.textBoxGPA.Size = new System.Drawing.Size(125, 27);
            this.textBoxGPA.TabIndex = 2;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(12, 33);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(49, 20);
            this.labelname.TabIndex = 3;
            this.labelname.Text = "Name";
            // 
            // labelBYear
            // 
            this.labelBYear.AutoSize = true;
            this.labelBYear.Location = new System.Drawing.Point(12, 91);
            this.labelBYear.Name = "labelBYear";
            this.labelBYear.Size = new System.Drawing.Size(68, 20);
            this.labelBYear.TabIndex = 4;
            this.labelBYear.Text = "Birhtyear";
            // 
            // labelGPA
            // 
            this.labelGPA.AutoSize = true;
            this.labelGPA.Location = new System.Drawing.Point(12, 148);
            this.labelGPA.Name = "labelGPA";
            this.labelGPA.Size = new System.Drawing.Size(36, 20);
            this.labelGPA.TabIndex = 5;
            this.labelGPA.Text = "GPA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(77, 157);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(150, 27);
            this.textBoxTotal.TabIndex = 8;
            this.textBoxTotal.Text = "0";
            // 
            // labelจำนวน
            // 
            this.labelจำนวน.AutoSize = true;
            this.labelจำนวน.Location = new System.Drawing.Point(13, 157);
            this.labelจำนวน.Name = "labelจำนวน";
            this.labelจำนวน.Size = new System.Drawing.Size(53, 20);
            this.labelจำนวน.TabIndex = 9;
            this.labelจำนวน.Text = "อายุรวม";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "รายชื่อ";
            // 
            // textBoxGPAmax
            // 
            this.textBoxGPAmax.Location = new System.Drawing.Point(89, 38);
            this.textBoxGPAmax.Name = "textBoxGPAmax";
            this.textBoxGPAmax.Size = new System.Drawing.Size(125, 27);
            this.textBoxGPAmax.TabIndex = 12;
            // 
            // textBoxGPAmin
            // 
            this.textBoxGPAmin.Location = new System.Drawing.Point(89, 71);
            this.textBoxGPAmin.Name = "textBoxGPAmin";
            this.textBoxGPAmin.Size = new System.Drawing.Size(125, 27);
            this.textBoxGPAmin.TabIndex = 13;
            // 
            // textBoxGPAavg
            // 
            this.textBoxGPAavg.Location = new System.Drawing.Point(89, 104);
            this.textBoxGPAavg.Name = "textBoxGPAavg";
            this.textBoxGPAavg.Size = new System.Drawing.Size(125, 27);
            this.textBoxGPAavg.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "GPA Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "GPA Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "GPA Avg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Name GPA max";
            // 
            // textBoxNameGPAmax
            // 
            this.textBoxNameGPAmax.Location = new System.Drawing.Point(321, 38);
            this.textBoxNameGPAmax.Name = "textBoxNameGPAmax";
            this.textBoxNameGPAmax.Size = new System.Drawing.Size(125, 27);
            this.textBoxNameGPAmax.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Name GPA min";
            // 
            // textBoxNameGPAmin
            // 
            this.textBoxNameGPAmin.Location = new System.Drawing.Point(321, 104);
            this.textBoxNameGPAmin.Name = "textBoxNameGPAmin";
            this.textBoxNameGPAmin.Size = new System.Drawing.Size(125, 27);
            this.textBoxNameGPAmin.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBoxGPAmax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNameGPAmin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxGPAmin);
            this.groupBox1.Controls.Add(this.textBoxNameGPAmax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxGPAavg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelจำนวน);
            this.groupBox1.Controls.Add(this.textBoxTotal);
            this.groupBox1.Location = new System.Drawing.Point(267, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 371);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลรายวิชา";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 195);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 144);
            this.textBox1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelGPA);
            this.Controls.Add(this.labelBYear);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.textBoxGPA);
            this.Controls.Add(this.textBoxBYear);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxBYear;
        private TextBox textBoxGPA;
        private Label labelname;
        private Label labelBYear;
        private Label labelGPA;
        private Button button1;
        private TextBox textBoxTotal;
        private Label labelจำนวน;
        private Label label1;
        private TextBox textBoxGPAmax;
        private TextBox textBoxGPAmin;
        private TextBox textBoxGPAavg;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxNameGPAmax;
        private Label label6;
        private TextBox textBoxNameGPAmin;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}