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
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.shutDownAfterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTextBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.hoursTextBox.Location = new System.Drawing.Point(122, 136);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(115, 46);
            this.hoursTextBox.TabIndex = 0;
            this.hoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hoursTextBox_KeyPress);
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Roboto", 24F);
            this.hoursLabel.Location = new System.Drawing.Point(243, 143);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(103, 39);
            this.hoursLabel.TabIndex = 1;
            this.hoursLabel.Text = "Hours";
            // 
            // shutDownAfterLabel
            // 
            this.shutDownAfterLabel.AutoSize = true;
            this.shutDownAfterLabel.Font = new System.Drawing.Font("Roboto", 24F);
            this.shutDownAfterLabel.Location = new System.Drawing.Point(115, 81);
            this.shutDownAfterLabel.Name = "shutDownAfterLabel";
            this.shutDownAfterLabel.Size = new System.Drawing.Size(246, 39);
            this.shutDownAfterLabel.TabIndex = 2;
            this.shutDownAfterLabel.Text = "Shut down after";
            // 
            // ShutX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.shutDownAfterLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.hoursTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShutX";
            this.Text = "ShutX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label shutDownAfterLabel;
    }
}

