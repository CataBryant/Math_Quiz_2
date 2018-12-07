namespace MathQuiz2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.proRightLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.proLeftLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.divRightLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.divLeftLabel = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.div = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.div)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "START EAZY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "START HARD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time left";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Time.Location = new System.Drawing.Point(364, 49);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(2, 19);
            this.Time.TabIndex = 3;
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.AutoSize = true;
            this.plusLeftLabel.Location = new System.Drawing.Point(232, 136);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(16, 17);
            this.plusLeftLabel.TabIndex = 4;
            this.plusLeftLabel.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "+";
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.AutoSize = true;
            this.plusRightLabel.Location = new System.Drawing.Point(309, 136);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(16, 17);
            this.plusRightLabel.TabIndex = 6;
            this.plusRightLabel.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "=";
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.AutoSize = true;
            this.minusRightLabel.Location = new System.Drawing.Point(309, 185);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(16, 17);
            this.minusRightLabel.TabIndex = 10;
            this.minusRightLabel.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "-";
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.AutoSize = true;
            this.minusLeftLabel.Location = new System.Drawing.Point(232, 185);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(16, 17);
            this.minusLeftLabel.TabIndex = 8;
            this.minusLeftLabel.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "=";
            // 
            // proRightLabel
            // 
            this.proRightLabel.AutoSize = true;
            this.proRightLabel.Location = new System.Drawing.Point(309, 221);
            this.proRightLabel.Name = "proRightLabel";
            this.proRightLabel.Size = new System.Drawing.Size(16, 17);
            this.proRightLabel.TabIndex = 14;
            this.proRightLabel.Text = "?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "*";
            // 
            // proLeftLabel
            // 
            this.proLeftLabel.AutoSize = true;
            this.proLeftLabel.Location = new System.Drawing.Point(232, 221);
            this.proLeftLabel.Name = "proLeftLabel";
            this.proLeftLabel.Size = new System.Drawing.Size(16, 17);
            this.proLeftLabel.TabIndex = 12;
            this.proLeftLabel.Text = "?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "=";
            // 
            // divRightLabel
            // 
            this.divRightLabel.AutoSize = true;
            this.divRightLabel.Location = new System.Drawing.Point(309, 252);
            this.divRightLabel.Name = "divRightLabel";
            this.divRightLabel.Size = new System.Drawing.Size(16, 17);
            this.divRightLabel.TabIndex = 18;
            this.divRightLabel.Text = "?";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(284, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "/";
            // 
            // divLeftLabel
            // 
            this.divLeftLabel.AutoSize = true;
            this.divLeftLabel.Location = new System.Drawing.Point(232, 252);
            this.divLeftLabel.Name = "divLeftLabel";
            this.divLeftLabel.Size = new System.Drawing.Size(16, 17);
            this.divLeftLabel.TabIndex = 16;
            this.divLeftLabel.Text = "?";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(416, 136);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(120, 22);
            this.sum.TabIndex = 3;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // difference
            // 
            this.difference.Location = new System.Drawing.Point(416, 185);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(120, 22);
            this.difference.TabIndex = 4;
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(416, 219);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(120, 22);
            this.product.TabIndex = 5;
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(416, 252);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(120, 22);
            this.div.TabIndex = 6;
            this.div.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(271, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "START MEDIUM";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 478);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.div);
            this.Controls.Add(this.product);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.divRightLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.divLeftLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.proRightLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.proLeftLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Math Quiz 2";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.div)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label proRightLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label proLeftLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label divRightLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label divLeftLabel;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.NumericUpDown div;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
    }
}

