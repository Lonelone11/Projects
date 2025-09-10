namespace Graphical_Hangman
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
            this.display = new System.Windows.Forms.Label();
            this.livesText = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.hintButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.livesLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.BackColor = System.Drawing.Color.Transparent;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.display.Location = new System.Drawing.Point(395, 22);
            this.display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.display.MinimumSize = new System.Drawing.Size(533, 65);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(533, 108);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // livesText
            // 
            this.livesText.AutoSize = true;
            this.livesText.BackColor = System.Drawing.Color.Transparent;
            this.livesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesText.ForeColor = System.Drawing.Color.Maroon;
            this.livesText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.livesText.Location = new System.Drawing.Point(5, 9);
            this.livesText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.livesText.MinimumSize = new System.Drawing.Size(267, 65);
            this.livesText.Name = "livesText";
            this.livesText.Size = new System.Drawing.Size(267, 73);
            this.livesText.TabIndex = 1;
            this.livesText.Text = "LIVES:";
            this.livesText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.livesText.Click += new System.EventHandler(this.livesText_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(795, 416);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.MinimumSize = new System.Drawing.Size(50, 45);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(133, 50);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // hintButton
            // 
            this.hintButton.BackColor = System.Drawing.Color.PowderBlue;
            this.hintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintButton.Location = new System.Drawing.Point(831, 366);
            this.hintButton.Margin = new System.Windows.Forms.Padding(2);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(98, 46);
            this.hintButton.TabIndex = 4;
            this.hintButton.Text = "HINT";
            this.hintButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hintButton.UseVisualStyleBackColor = false;
            this.hintButton.Click += new System.EventHandler(this.hintButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(11, 403);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MinimumSize = new System.Drawing.Size(333, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 65);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // livesLabel
            // 
            this.livesLabel.AutoSize = true;
            this.livesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.livesLabel.Location = new System.Drawing.Point(26, 82);
            this.livesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.livesLabel.MinimumSize = new System.Drawing.Size(33, 65);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(69, 73);
            this.livesLabel.TabIndex = 3;
            this.livesLabel.Text = "7";
            this.livesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.livesLabel.Click += new System.EventHandler(this.livesLabel_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(662, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(940, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hintButton);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.livesText);
            this.Controls.Add(this.display);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Label livesText;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button hintButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Button button1;
        }
}

