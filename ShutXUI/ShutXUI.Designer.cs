namespace ShutXUI {
    partial class ShutXUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.hourIncrementButton = new System.Windows.Forms.Button();
            this.hourDecrementButton = new System.Windows.Forms.Button();
            this.minuteIncrementButton = new System.Windows.Forms.Button();
            this.secondIncrementButton = new System.Windows.Forms.Button();
            this.minuteDecrementButton = new System.Windows.Forms.Button();
            this.secondDecrementButton = new System.Windows.Forms.Button();
            this.hourLabel = new System.Windows.Forms.TextBox();
            this.minuteLabel = new System.Windows.Forms.TextBox();
            this.secondLabel = new System.Windows.Forms.TextBox();
            this.launchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hourIncrementButton
            // 
            this.hourIncrementButton.BackColor = System.Drawing.Color.Black;
            this.hourIncrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hourIncrementButton.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourIncrementButton.ForeColor = System.Drawing.Color.White;
            this.hourIncrementButton.Location = new System.Drawing.Point(43, 34);
            this.hourIncrementButton.Name = "hourIncrementButton";
            this.hourIncrementButton.Size = new System.Drawing.Size(45, 41);
            this.hourIncrementButton.TabIndex = 0;
            this.hourIncrementButton.Text = "^";
            this.hourIncrementButton.UseVisualStyleBackColor = false;
            this.hourIncrementButton.Click += new System.EventHandler(this.hourIncrementButton_Click);
            // 
            // hourDecrementButton
            // 
            this.hourDecrementButton.BackColor = System.Drawing.Color.Black;
            this.hourDecrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hourDecrementButton.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourDecrementButton.ForeColor = System.Drawing.Color.White;
            this.hourDecrementButton.Location = new System.Drawing.Point(43, 113);
            this.hourDecrementButton.Name = "hourDecrementButton";
            this.hourDecrementButton.Size = new System.Drawing.Size(45, 41);
            this.hourDecrementButton.TabIndex = 1;
            this.hourDecrementButton.Text = "⌄";
            this.hourDecrementButton.UseVisualStyleBackColor = false;
            this.hourDecrementButton.Click += new System.EventHandler(this.hourDecrementButton_Click);
            // 
            // minuteIncrementButton
            // 
            this.minuteIncrementButton.BackColor = System.Drawing.Color.Black;
            this.minuteIncrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minuteIncrementButton.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteIncrementButton.ForeColor = System.Drawing.Color.White;
            this.minuteIncrementButton.Location = new System.Drawing.Point(94, 34);
            this.minuteIncrementButton.Name = "minuteIncrementButton";
            this.minuteIncrementButton.Size = new System.Drawing.Size(45, 41);
            this.minuteIncrementButton.TabIndex = 3;
            this.minuteIncrementButton.Text = "^";
            this.minuteIncrementButton.UseVisualStyleBackColor = false;
            this.minuteIncrementButton.Click += new System.EventHandler(this.minuteIncrementButton_Click);
            // 
            // secondIncrementButton
            // 
            this.secondIncrementButton.BackColor = System.Drawing.Color.Black;
            this.secondIncrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secondIncrementButton.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondIncrementButton.ForeColor = System.Drawing.Color.White;
            this.secondIncrementButton.Location = new System.Drawing.Point(145, 34);
            this.secondIncrementButton.Name = "secondIncrementButton";
            this.secondIncrementButton.Size = new System.Drawing.Size(45, 41);
            this.secondIncrementButton.TabIndex = 6;
            this.secondIncrementButton.Text = "^";
            this.secondIncrementButton.UseVisualStyleBackColor = false;
            this.secondIncrementButton.Click += new System.EventHandler(this.secondIncrementButton_Click);
            // 
            // minuteDecrementButton
            // 
            this.minuteDecrementButton.BackColor = System.Drawing.Color.Black;
            this.minuteDecrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minuteDecrementButton.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteDecrementButton.ForeColor = System.Drawing.Color.White;
            this.minuteDecrementButton.Location = new System.Drawing.Point(94, 113);
            this.minuteDecrementButton.Name = "minuteDecrementButton";
            this.minuteDecrementButton.Size = new System.Drawing.Size(45, 41);
            this.minuteDecrementButton.TabIndex = 4;
            this.minuteDecrementButton.Text = "⌄";
            this.minuteDecrementButton.UseVisualStyleBackColor = false;
            this.minuteDecrementButton.Click += new System.EventHandler(this.minuteDecrementButton_Click);
            // 
            // secondDecrementButton
            // 
            this.secondDecrementButton.BackColor = System.Drawing.Color.Black;
            this.secondDecrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secondDecrementButton.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondDecrementButton.ForeColor = System.Drawing.Color.White;
            this.secondDecrementButton.Location = new System.Drawing.Point(145, 113);
            this.secondDecrementButton.Name = "secondDecrementButton";
            this.secondDecrementButton.Size = new System.Drawing.Size(45, 41);
            this.secondDecrementButton.TabIndex = 7;
            this.secondDecrementButton.Text = "⌄";
            this.secondDecrementButton.UseVisualStyleBackColor = false;
            this.secondDecrementButton.Click += new System.EventHandler(this.secondDecrementButton_Click);
            // 
            // hourLabel
            // 
            this.hourLabel.BackColor = System.Drawing.Color.Black;
            this.hourLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourLabel.ForeColor = System.Drawing.Color.White;
            this.hourLabel.Location = new System.Drawing.Point(43, 81);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(45, 24);
            this.hourLabel.TabIndex = 8;
            this.hourLabel.Text = "00";
            this.hourLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hourLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hourLabel_KeyPress);
            // 
            // minuteLabel
            // 
            this.minuteLabel.BackColor = System.Drawing.Color.Black;
            this.minuteLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteLabel.ForeColor = System.Drawing.Color.White;
            this.minuteLabel.Location = new System.Drawing.Point(94, 81);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(45, 24);
            this.minuteLabel.TabIndex = 9;
            this.minuteLabel.Text = "00";
            this.minuteLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minuteLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minuteLabel_KeyPress);
            // 
            // secondLabel
            // 
            this.secondLabel.BackColor = System.Drawing.Color.Black;
            this.secondLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.ForeColor = System.Drawing.Color.White;
            this.secondLabel.Location = new System.Drawing.Point(145, 81);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(45, 24);
            this.secondLabel.TabIndex = 10;
            this.secondLabel.Text = "00";
            this.secondLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.secondLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondLabel_KeyPress);
            // 
            // launchButton
            // 
            this.launchButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.launchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.launchButton.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchButton.ForeColor = System.Drawing.Color.White;
            this.launchButton.Location = new System.Drawing.Point(43, 176);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(147, 41);
            this.launchButton.TabIndex = 11;
            this.launchButton.Text = "LAUNCH";
            this.launchButton.UseVisualStyleBackColor = false;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // ShutXUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(241, 264);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.secondDecrementButton);
            this.Controls.Add(this.secondIncrementButton);
            this.Controls.Add(this.minuteDecrementButton);
            this.Controls.Add(this.minuteIncrementButton);
            this.Controls.Add(this.hourDecrementButton);
            this.Controls.Add(this.hourIncrementButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShutXUI";
            this.Text = "ShutX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hourIncrementButton;
        private System.Windows.Forms.Button hourDecrementButton;
        private System.Windows.Forms.Button minuteIncrementButton;
        private System.Windows.Forms.Button secondIncrementButton;
        private System.Windows.Forms.Button minuteDecrementButton;
        private System.Windows.Forms.Button secondDecrementButton;
        private System.Windows.Forms.TextBox hourLabel;
        private System.Windows.Forms.TextBox minuteLabel;
        private System.Windows.Forms.TextBox secondLabel;
        private System.Windows.Forms.Button launchButton;
    }
}

