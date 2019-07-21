namespace PPT_Generate
{
    partial class Form
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_text = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(53, 106);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(130, 17);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Title of PowerPoint:";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(53, 172);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(130, 17);
            this.label_text.TabIndex = 1;
            this.label_text.Text = "Text of PowerPoint:";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(189, 103);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(268, 22);
            this.textBox_title.TabIndex = 2;
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(189, 169);
            this.textBox_text.Multiline = true;
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(441, 271);
            this.textBox_text.TabIndex = 3;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 501);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.label_title);
            this.Name = "Form";
            this.Text = "PowerPoint Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_text;
    }
}

