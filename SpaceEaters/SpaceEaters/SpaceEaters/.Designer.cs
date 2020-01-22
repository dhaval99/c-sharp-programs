namespace SpaceEaters
{
    partial class SpaceEatersForm
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
            this.Exit = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.lblLengthPrompt = new System.Windows.Forms.Label();
            this.lblWidthPrompt = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAreaDisplay = new System.Windows.Forms.Label();
            this.lblPerimeterDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(304, 289);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(39, 289);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(86, 23);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(179, 289);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // lblLengthPrompt
            // 
            this.lblLengthPrompt.AutoSize = true;
            this.lblLengthPrompt.Location = new System.Drawing.Point(12, 33);
            this.lblLengthPrompt.Name = "lblLengthPrompt";
            this.lblLengthPrompt.Size = new System.Drawing.Size(56, 17);
            this.lblLengthPrompt.TabIndex = 3;
            this.lblLengthPrompt.Text = "&Length:";
            this.lblLengthPrompt.Click += new System.EventHandler(this.lblLengthPrompt_Click);
            // 
            // lblWidthPrompt
            // 
            this.lblWidthPrompt.AutoSize = true;
            this.lblWidthPrompt.Location = new System.Drawing.Point(12, 76);
            this.lblWidthPrompt.Name = "lblWidthPrompt";
            this.lblWidthPrompt.Size = new System.Drawing.Size(48, 17);
            this.lblWidthPrompt.TabIndex = 4;
            this.lblWidthPrompt.Text = "&Width:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(12, 111);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 17);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "&Area:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(12, 147);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(73, 17);
            this.lblPerimeter.TabIndex = 6;
            this.lblPerimeter.Text = "&Perimeter:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblAreaDisplay
            // 
            this.lblAreaDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAreaDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAreaDisplay.Location = new System.Drawing.Point(0, 0);
            this.lblAreaDisplay.Name = "lblAreaDisplay";
            this.lblAreaDisplay.Size = new System.Drawing.Size(430, 23);
            this.lblAreaDisplay.TabIndex = 9;
            this.lblAreaDisplay.Text = "                    ";
            // 
            // lblPerimeterDisplay
            // 
            this.lblPerimeterDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPerimeterDisplay.Location = new System.Drawing.Point(267, 147);
            this.lblPerimeterDisplay.Name = "lblPerimeterDisplay";
            this.lblPerimeterDisplay.Size = new System.Drawing.Size(100, 23);
            this.lblPerimeterDisplay.TabIndex = 10;
            this.lblPerimeterDisplay.Click += new System.EventHandler(this.lblPerimeterDisplay_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(267, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SpaceEatersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPerimeterDisplay);
            this.Controls.Add(this.lblAreaDisplay);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblWidthPrompt);
            this.Controls.Add(this.lblLengthPrompt);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Exit);
            this.Name = "SpaceEatersForm";
            this.Text = "Space Eaters";
            this.Load += new System.EventHandler(this.txtLengthEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label lblLengthPrompt;
        private System.Windows.Forms.Label lblWidthPrompt;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAreaDisplay;
        private System.Windows.Forms.Label lblPerimeterDisplay;
        private System.Windows.Forms.Label label1;
    }
}

