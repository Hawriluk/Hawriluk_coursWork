namespace courseWork
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
            this.BtnRender = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtXMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtXMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtYMin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtYMax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtImgW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtImgH = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RatioChecker = new System.Windows.Forms.CheckBox();
            this.TxtIters = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PBOutput = new System.Windows.Forms.PictureBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRender
            // 
            this.BtnRender.Location = new System.Drawing.Point(398, 24);
            this.BtnRender.Name = "BtnRender";
            this.BtnRender.Size = new System.Drawing.Size(75, 23);
            this.BtnRender.TabIndex = 4;
            this.BtnRender.Text = "Render";
            this.BtnRender.UseVisualStyleBackColor = true;
            this.BtnRender.Click += new System.EventHandler(this.BtnRender_Click_1);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(398, 53);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtXMin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtXMax);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtYMin);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtYMax);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "{ X , Y }";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "}";
            // 
            // TxtXMin
            // 
            this.TxtXMin.Location = new System.Drawing.Point(40, 19);
            this.TxtXMin.Name = "TxtXMin";
            this.TxtXMin.Size = new System.Drawing.Size(30, 20);
            this.TxtXMin.TabIndex = 17;
            this.TxtXMin.Text = "-2,5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "}";
            // 
            // TxtXMax
            // 
            this.TxtXMax.Location = new System.Drawing.Point(72, 19);
            this.TxtXMax.Name = "TxtXMax";
            this.TxtXMax.Size = new System.Drawing.Size(30, 20);
            this.TxtXMax.TabIndex = 8;
            this.TxtXMax.Text = "1,5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "{";
            // 
            // TxtYMin
            // 
            this.TxtYMin.Location = new System.Drawing.Point(40, 45);
            this.TxtYMin.Name = "TxtYMin";
            this.TxtYMin.Size = new System.Drawing.Size(30, 20);
            this.TxtYMin.TabIndex = 10;
            this.TxtYMin.Text = "-1,5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Y:";
            // 
            // TxtYMax
            // 
            this.TxtYMax.Location = new System.Drawing.Point(72, 45);
            this.TxtYMax.Name = "TxtYMax";
            this.TxtYMax.Size = new System.Drawing.Size(30, 20);
            this.TxtYMax.TabIndex = 9;
            this.TxtYMax.Text = "1,5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "X:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "{";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtImgW);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtImgH);
            this.groupBox2.Location = new System.Drawing.Point(150, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 72);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Resolution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height";
            // 
            // TxtImgW
            // 
            this.TxtImgW.Location = new System.Drawing.Point(50, 19);
            this.TxtImgW.Name = "TxtImgW";
            this.TxtImgW.Size = new System.Drawing.Size(51, 20);
            this.TxtImgW.TabIndex = 17;
            this.TxtImgW.Text = "450";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // TxtImgH
            // 
            this.TxtImgH.Location = new System.Drawing.Point(50, 45);
            this.TxtImgH.Name = "TxtImgH";
            this.TxtImgH.Size = new System.Drawing.Size(51, 20);
            this.TxtImgH.TabIndex = 10;
            this.TxtImgH.Text = "350";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RatioChecker);
            this.groupBox3.Controls.Add(this.TxtIters);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(270, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 72);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // RatioChecker
            // 
            this.RatioChecker.AutoSize = true;
            this.RatioChecker.Checked = true;
            this.RatioChecker.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RatioChecker.Location = new System.Drawing.Point(6, 47);
            this.RatioChecker.Name = "RatioChecker";
            this.RatioChecker.Size = new System.Drawing.Size(115, 17);
            this.RatioChecker.TabIndex = 18;
            this.RatioChecker.Text = "Keep Aspect Ratio";
            this.RatioChecker.UseVisualStyleBackColor = true;
            // 
            // TxtIters
            // 
            this.TxtIters.Location = new System.Drawing.Point(50, 19);
            this.TxtIters.Name = "TxtIters";
            this.TxtIters.Size = new System.Drawing.Size(66, 20);
            this.TxtIters.TabIndex = 17;
            this.TxtIters.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Iterations";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PBOutput);
            this.groupBox4.Location = new System.Drawing.Point(12, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 374);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OutputImage";
            // 
            // PBOutput
            // 
            this.PBOutput.Location = new System.Drawing.Point(6, 19);
            this.PBOutput.Name = "PBOutput";
            this.PBOutput.Size = new System.Drawing.Size(450, 350);
            this.PBOutput.TabIndex = 0;
            this.PBOutput.TabStop = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 470);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(461, 10);
            this.ProgressBar.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 490);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnRender);
            this.Name = "Form1";
            this.Text = "Course Work. FRACTAL.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button BtnRender;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.CheckBox RatioChecker;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.GroupBox groupBox4;
        protected System.Windows.Forms.TextBox TxtXMin;
        protected System.Windows.Forms.TextBox TxtXMax;
        protected System.Windows.Forms.TextBox TxtYMin;
        protected System.Windows.Forms.TextBox TxtYMax;
        protected System.Windows.Forms.TextBox TxtImgW;
        protected System.Windows.Forms.TextBox TxtImgH;
        protected System.Windows.Forms.TextBox TxtIters;
        protected System.Windows.Forms.Button BtnSave;
        protected System.Windows.Forms.ProgressBar ProgressBar;
        protected System.Windows.Forms.PictureBox PBOutput;
    }
}

