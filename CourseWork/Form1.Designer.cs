
namespace CourseWork
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
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.lblSpreading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSizePoint = new System.Windows.Forms.TrackBar();
            this.tbEmitterX = new System.Windows.Forms.TrackBar();
            this.tbEmitterY = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmitterX = new System.Windows.Forms.Label();
            this.lblEmitterY = new System.Windows.Forms.Label();
            this.lblSizePoint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSizePoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmitterX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmitterY)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(776, 426);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.Click += new System.EventHandler(this.picDisplay_Click);
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            this.picDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseDoubleClick);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(31, 474);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(104, 45);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(141, 478);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(13, 15);
            this.lblDirection.TabIndex = 2;
            this.lblDirection.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Направление частиц";
            // 
            // tbSpreading
            // 
            this.tbSpreading.Location = new System.Drawing.Point(178, 472);
            this.tbSpreading.Maximum = 359;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(104, 45);
            this.tbSpreading.TabIndex = 4;
            this.tbSpreading.Scroll += new System.EventHandler(this.tbSpreading_Scroll);
            // 
            // lblSpreading
            // 
            this.lblSpreading.AutoSize = true;
            this.lblSpreading.Location = new System.Drawing.Point(288, 478);
            this.lblSpreading.Name = "lblSpreading";
            this.lblSpreading.Size = new System.Drawing.Size(13, 15);
            this.lblSpreading.TabIndex = 5;
            this.lblSpreading.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Разброс частиц";
            // 
            // tbSizePoint
            // 
            this.tbSizePoint.Location = new System.Drawing.Point(625, 472);
            this.tbSizePoint.Maximum = 130;
            this.tbSizePoint.Minimum = 40;
            this.tbSizePoint.Name = "tbSizePoint";
            this.tbSizePoint.Size = new System.Drawing.Size(104, 45);
            this.tbSizePoint.TabIndex = 7;
            this.tbSizePoint.Value = 40;
            this.tbSizePoint.Scroll += new System.EventHandler(this.tbSizePoint_Scroll);
            // 
            // tbEmitterX
            // 
            this.tbEmitterX.Location = new System.Drawing.Point(317, 472);
            this.tbEmitterX.Maximum = 776;
            this.tbEmitterX.Name = "tbEmitterX";
            this.tbEmitterX.Size = new System.Drawing.Size(104, 45);
            this.tbEmitterX.TabIndex = 8;
            this.tbEmitterX.Scroll += new System.EventHandler(this.tbEmitterX_Scroll);
            // 
            // tbEmitterY
            // 
            this.tbEmitterY.Location = new System.Drawing.Point(466, 472);
            this.tbEmitterY.Maximum = 426;
            this.tbEmitterY.Name = "tbEmitterY";
            this.tbEmitterY.Size = new System.Drawing.Size(104, 45);
            this.tbEmitterY.TabIndex = 9;
            this.tbEmitterY.Scroll += new System.EventHandler(this.tbEmitterY_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Координата частиц X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Координата частиц Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Размер точек";
            // 
            // lblEmitterX
            // 
            this.lblEmitterX.AutoSize = true;
            this.lblEmitterX.Location = new System.Drawing.Point(426, 477);
            this.lblEmitterX.Name = "lblEmitterX";
            this.lblEmitterX.Size = new System.Drawing.Size(13, 15);
            this.lblEmitterX.TabIndex = 13;
            this.lblEmitterX.Text = "0";
            this.lblEmitterX.Click += new System.EventHandler(this.lblEmitterX_Click);
            // 
            // lblEmitterY
            // 
            this.lblEmitterY.AutoSize = true;
            this.lblEmitterY.Location = new System.Drawing.Point(576, 477);
            this.lblEmitterY.Name = "lblEmitterY";
            this.lblEmitterY.Size = new System.Drawing.Size(13, 15);
            this.lblEmitterY.TabIndex = 14;
            this.lblEmitterY.Text = "0";
            // 
            // lblSizePoint
            // 
            this.lblSizePoint.AutoSize = true;
            this.lblSizePoint.Location = new System.Drawing.Point(735, 478);
            this.lblSizePoint.Name = "lblSizePoint";
            this.lblSizePoint.Size = new System.Drawing.Size(13, 15);
            this.lblSizePoint.TabIndex = 15;
            this.lblSizePoint.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.lblSizePoint);
            this.Controls.Add(this.lblEmitterY);
            this.Controls.Add(this.lblEmitterX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmitterY);
            this.Controls.Add(this.tbEmitterX);
            this.Controls.Add(this.tbSizePoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSpreading);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Частицы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSizePoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmitterX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmitterY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.Label lblSpreading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbSizePoint;
        private System.Windows.Forms.TrackBar tbEmitterX;
        private System.Windows.Forms.TrackBar tbEmitterY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmitterX;
        private System.Windows.Forms.Label lblEmitterY;
        private System.Windows.Forms.Label lblSizePoint;
    }
}

