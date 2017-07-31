namespace CoordinateConversion
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
            this.labelCx = new System.Windows.Forms.Label();
            this.labelCy = new System.Windows.Forms.Label();
            this.labelCz = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCrY = new System.Windows.Forms.Label();
            this.labelCrX = new System.Windows.Forms.Label();
            this.labelCrZ = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnReverseTransform = new System.Windows.Forms.Button();
            this.btnApplyTransform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCx
            // 
            this.labelCx.AutoSize = true;
            this.labelCx.Location = new System.Drawing.Point(55, 15);
            this.labelCx.Name = "labelCx";
            this.labelCx.Size = new System.Drawing.Size(25, 13);
            this.labelCx.TabIndex = 1;
            this.labelCx.Text = "400";
            // 
            // labelCy
            // 
            this.labelCy.AutoSize = true;
            this.labelCy.Location = new System.Drawing.Point(81, 15);
            this.labelCy.Name = "labelCy";
            this.labelCy.Size = new System.Drawing.Size(25, 13);
            this.labelCy.TabIndex = 2;
            this.labelCy.Text = "240";
            // 
            // labelCz
            // 
            this.labelCz.AutoSize = true;
            this.labelCz.Location = new System.Drawing.Point(107, 14);
            this.labelCz.Name = "labelCz";
            this.labelCz.Size = new System.Drawing.Size(13, 13);
            this.labelCz.TabIndex = 3;
            this.labelCz.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelCrY);
            this.groupBox1.Controls.Add(this.labelCrX);
            this.groupBox1.Controls.Add(this.labelCrZ);
            this.groupBox1.Controls.Add(this.labelCx);
            this.groupBox1.Controls.Add(this.labelCy);
            this.groupBox1.Controls.Add(this.labelCz);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 45);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cube Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rotated";
            // 
            // labelCrY
            // 
            this.labelCrY.AutoSize = true;
            this.labelCrY.Location = new System.Drawing.Point(83, 28);
            this.labelCrY.Name = "labelCrY";
            this.labelCrY.Size = new System.Drawing.Size(13, 13);
            this.labelCrY.TabIndex = 10;
            this.labelCrY.Text = "0";
            // 
            // labelCrX
            // 
            this.labelCrX.AutoSize = true;
            this.labelCrX.Location = new System.Drawing.Point(55, 28);
            this.labelCrX.Name = "labelCrX";
            this.labelCrX.Size = new System.Drawing.Size(13, 13);
            this.labelCrX.TabIndex = 9;
            this.labelCrX.Text = "0";
            // 
            // labelCrZ
            // 
            this.labelCrZ.AutoSize = true;
            this.labelCrZ.Location = new System.Drawing.Point(108, 28);
            this.labelCrZ.Name = "labelCrZ";
            this.labelCrZ.Size = new System.Drawing.Size(13, 13);
            this.labelCrZ.TabIndex = 11;
            this.labelCrZ.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Location = new System.Drawing.Point(399, 392);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(166, 85);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rotate Cube";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(111, 49);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "- Z";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.RotateNegativeZ);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(111, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Z";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.RotatePositiveZ);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(59, 49);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "- Y";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.RotateNegativeY);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(59, 20);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(46, 23);
            this.button10.TabIndex = 2;
            this.button10.Text = "Y";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.RotatePositiveY);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(7, 49);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(46, 23);
            this.button11.TabIndex = 1;
            this.button11.Text = "- X";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.RotateNegativeX);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(7, 20);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(46, 23);
            this.button12.TabIndex = 0;
            this.button12.Text = "X";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.RotatePositiveX);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(6, 81);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(99, 22);
            this.button14.TabIndex = 14;
            this.button14.Text = "Reset";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnReverseTransform);
            this.groupBox9.Controls.Add(this.button14);
            this.groupBox9.Controls.Add(this.btnApplyTransform);
            this.groupBox9.Location = new System.Drawing.Point(621, 392);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(114, 116);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Configuration";
            // 
            // btnReverseTransform
            // 
            this.btnReverseTransform.Location = new System.Drawing.Point(0, 45);
            this.btnReverseTransform.Name = "btnReverseTransform";
            this.btnReverseTransform.Size = new System.Drawing.Size(105, 29);
            this.btnReverseTransform.TabIndex = 20;
            this.btnReverseTransform.Text = "Reverse Transform";
            this.btnReverseTransform.UseVisualStyleBackColor = true;
            this.btnReverseTransform.Click += new System.EventHandler(this.btnReverseTransform_Click);
            // 
            // btnApplyTransform
            // 
            this.btnApplyTransform.Location = new System.Drawing.Point(0, 19);
            this.btnApplyTransform.Name = "btnApplyTransform";
            this.btnApplyTransform.Size = new System.Drawing.Size(105, 22);
            this.btnApplyTransform.TabIndex = 19;
            this.btnApplyTransform.Text = "Apply Transform";
            this.btnApplyTransform.UseVisualStyleBackColor = true;
            this.btnApplyTransform.Click += new System.EventHandler(this.btnApplyTransform_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "The 0,0 coordinate on the red cube face is the origin of the plane of interest.  " +
    "In GDI this is the upper left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(617, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "The transforms will keep the position of the 0,0 constant, so even through the cu" +
    "be appears to move the point to watch is the 0,0 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(519, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Rotate the cube. After it is rotated use \'Apply Transform\' \nto restore the red fa" +
    "ce to the front. Use \'Reverse Transform\' to \nrestore \\n the red face to the previ" +
    "ous rotation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 520);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Coordinate Conversion Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnApplyTransform;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCrY;
        private System.Windows.Forms.Label labelCrX;
        private System.Windows.Forms.Label labelCrZ;
        private System.Windows.Forms.Label labelCx;
        private System.Windows.Forms.Label labelCy;
        private System.Windows.Forms.Label labelCz;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnReverseTransform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

