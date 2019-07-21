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
            this.textBox_text = new System.Windows.Forms.RichTextBox();
            this.groupBox_text = new System.Windows.Forms.GroupBox();
            this.label_text_instruction = new System.Windows.Forms.Label();
            this.button_next2 = new System.Windows.Forms.Button();
            this.button_bold = new System.Windows.Forms.Button();
            this.button_previous3 = new System.Windows.Forms.Button();
            this.button_next3 = new System.Windows.Forms.Button();
            this.groupBox_images = new System.Windows.Forms.GroupBox();
            this.groupBox_output = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_create = new System.Windows.Forms.Button();
            this.button_previous4 = new System.Windows.Forms.Button();
            this.textBox_output_folder = new System.Windows.Forms.TextBox();
            this.textBox_output_name = new System.Windows.Forms.TextBox();
            this.label_output_name = new System.Windows.Forms.Label();
            this.label_output_folder = new System.Windows.Forms.Label();
            this.button_browse_output_folder = new System.Windows.Forms.Button();
            this.groupBox_welcome = new System.Windows.Forms.GroupBox();
            this.label_welcome_msg = new System.Windows.Forms.Label();
            this.button_next1 = new System.Windows.Forms.Button();
            this.groupBox_text.SuspendLayout();
            this.groupBox_images.SuspendLayout();
            this.groupBox_output.SuspendLayout();
            this.groupBox_welcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(23, 60);
            this.label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(99, 13);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Title of PowerPoint:";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(22, 108);
            this.label_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(100, 13);
            this.label_text.TabIndex = 1;
            this.label_text.Text = "Text of PowerPoint:";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(126, 57);
            this.textBox_title.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(390, 20);
            this.textBox_title.TabIndex = 2;
            // 
            // textBox_text
            // 
            this.textBox_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox_text.Location = new System.Drawing.Point(126, 103);
            this.textBox_text.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(390, 234);
            this.textBox_text.TabIndex = 3;
            this.textBox_text.Text = "";
            // 
            // groupBox_text
            // 
            this.groupBox_text.Controls.Add(this.textBox_title);
            this.groupBox_text.Controls.Add(this.label_title);
            this.groupBox_text.Controls.Add(this.textBox_text);
            this.groupBox_text.Controls.Add(this.label_text_instruction);
            this.groupBox_text.Controls.Add(this.label_text);
            this.groupBox_text.Controls.Add(this.button_next2);
            this.groupBox_text.Controls.Add(this.button_bold);
            this.groupBox_text.Location = new System.Drawing.Point(12, 12);
            this.groupBox_text.Name = "groupBox_text";
            this.groupBox_text.Size = new System.Drawing.Size(555, 383);
            this.groupBox_text.TabIndex = 4;
            this.groupBox_text.TabStop = false;
            this.groupBox_text.Text = "Texts of PowerPoint";
            // 
            // label_text_instruction
            // 
            this.label_text_instruction.AutoSize = true;
            this.label_text_instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_text_instruction.Location = new System.Drawing.Point(23, 27);
            this.label_text_instruction.Name = "label_text_instruction";
            this.label_text_instruction.Size = new System.Drawing.Size(490, 25);
            this.label_text_instruction.TabIndex = 7;
            this.label_text_instruction.Text = "Enter the Title and the main Text field of the PowerPoint";
            // 
            // button_next2
            // 
            this.button_next2.Location = new System.Drawing.Point(462, 342);
            this.button_next2.Name = "button_next2";
            this.button_next2.Size = new System.Drawing.Size(75, 23);
            this.button_next2.TabIndex = 9;
            this.button_next2.Text = "Next";
            this.button_next2.UseVisualStyleBackColor = true;
            this.button_next2.Click += new System.EventHandler(this.Button_next2_Click);
            // 
            // button_bold
            // 
            this.button_bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bold.Location = new System.Drawing.Point(91, 194);
            this.button_bold.Name = "button_bold";
            this.button_bold.Size = new System.Drawing.Size(30, 34);
            this.button_bold.TabIndex = 8;
            this.button_bold.Text = "B";
            this.button_bold.UseVisualStyleBackColor = true;
            this.button_bold.Click += new System.EventHandler(this.Button_bold_Click);
            // 
            // button_previous3
            // 
            this.button_previous3.Location = new System.Drawing.Point(16, 342);
            this.button_previous3.Name = "button_previous3";
            this.button_previous3.Size = new System.Drawing.Size(75, 23);
            this.button_previous3.TabIndex = 11;
            this.button_previous3.Text = "Previous";
            this.button_previous3.UseVisualStyleBackColor = true;
            this.button_previous3.Click += new System.EventHandler(this.Button_previous3_Click);
            // 
            // button_next3
            // 
            this.button_next3.Location = new System.Drawing.Point(462, 342);
            this.button_next3.Name = "button_next3";
            this.button_next3.Size = new System.Drawing.Size(75, 23);
            this.button_next3.TabIndex = 10;
            this.button_next3.Text = "Next";
            this.button_next3.UseVisualStyleBackColor = true;
            this.button_next3.Click += new System.EventHandler(this.Button_next3_Click);
            // 
            // groupBox_images
            // 
            this.groupBox_images.Controls.Add(this.button_next3);
            this.groupBox_images.Controls.Add(this.button_previous3);
            this.groupBox_images.Location = new System.Drawing.Point(12, 12);
            this.groupBox_images.Name = "groupBox_images";
            this.groupBox_images.Size = new System.Drawing.Size(555, 383);
            this.groupBox_images.TabIndex = 4;
            this.groupBox_images.TabStop = false;
            this.groupBox_images.Text = "Image Selection";
            // 
            // groupBox_output
            // 
            this.groupBox_output.Controls.Add(this.label1);
            this.groupBox_output.Controls.Add(this.button_create);
            this.groupBox_output.Controls.Add(this.button_previous4);
            this.groupBox_output.Controls.Add(this.textBox_output_folder);
            this.groupBox_output.Controls.Add(this.textBox_output_name);
            this.groupBox_output.Controls.Add(this.label_output_name);
            this.groupBox_output.Controls.Add(this.label_output_folder);
            this.groupBox_output.Controls.Add(this.button_browse_output_folder);
            this.groupBox_output.Location = new System.Drawing.Point(12, 12);
            this.groupBox_output.Name = "groupBox_output";
            this.groupBox_output.Size = new System.Drawing.Size(555, 383);
            this.groupBox_output.TabIndex = 4;
            this.groupBox_output.TabStop = false;
            this.groupBox_output.Text = "Output File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 72);
            this.label1.TabIndex = 7;
            this.label1.Text = "Here you will decide on your powerpoint slide\'s name\r\nand where to export it. Hit" +
    " Create to create and export\r\nyour PowerPoint.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(462, 342);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 6;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.Button_create_Click);
            // 
            // button_previous4
            // 
            this.button_previous4.Location = new System.Drawing.Point(16, 342);
            this.button_previous4.Name = "button_previous4";
            this.button_previous4.Size = new System.Drawing.Size(75, 23);
            this.button_previous4.TabIndex = 5;
            this.button_previous4.Text = "Previous";
            this.button_previous4.UseVisualStyleBackColor = true;
            this.button_previous4.Click += new System.EventHandler(this.Button_previous4_Click);
            // 
            // textBox_output_folder
            // 
            this.textBox_output_folder.Location = new System.Drawing.Point(102, 216);
            this.textBox_output_folder.Name = "textBox_output_folder";
            this.textBox_output_folder.Size = new System.Drawing.Size(354, 20);
            this.textBox_output_folder.TabIndex = 4;
            // 
            // textBox_output_name
            // 
            this.textBox_output_name.Location = new System.Drawing.Point(102, 129);
            this.textBox_output_name.Name = "textBox_output_name";
            this.textBox_output_name.Size = new System.Drawing.Size(354, 20);
            this.textBox_output_name.TabIndex = 3;
            // 
            // label_output_name
            // 
            this.label_output_name.AutoSize = true;
            this.label_output_name.Location = new System.Drawing.Point(61, 132);
            this.label_output_name.Name = "label_output_name";
            this.label_output_name.Size = new System.Drawing.Size(41, 13);
            this.label_output_name.TabIndex = 2;
            this.label_output_name.Text = "Name: ";
            // 
            // label_output_folder
            // 
            this.label_output_folder.AutoSize = true;
            this.label_output_folder.Location = new System.Drawing.Point(22, 219);
            this.label_output_folder.Name = "label_output_folder";
            this.label_output_folder.Size = new System.Drawing.Size(74, 13);
            this.label_output_folder.TabIndex = 1;
            this.label_output_folder.Text = "Output Folder:";
            // 
            // button_browse_output_folder
            // 
            this.button_browse_output_folder.Location = new System.Drawing.Point(462, 214);
            this.button_browse_output_folder.Name = "button_browse_output_folder";
            this.button_browse_output_folder.Size = new System.Drawing.Size(75, 23);
            this.button_browse_output_folder.TabIndex = 0;
            this.button_browse_output_folder.Text = "Browse...";
            this.button_browse_output_folder.UseVisualStyleBackColor = true;
            this.button_browse_output_folder.Click += new System.EventHandler(this.Button_browse_output_folder_Click);
            // 
            // groupBox_welcome
            // 
            this.groupBox_welcome.Controls.Add(this.label_welcome_msg);
            this.groupBox_welcome.Controls.Add(this.button_next1);
            this.groupBox_welcome.Location = new System.Drawing.Point(12, 12);
            this.groupBox_welcome.Name = "groupBox_welcome";
            this.groupBox_welcome.Size = new System.Drawing.Size(555, 383);
            this.groupBox_welcome.TabIndex = 4;
            this.groupBox_welcome.TabStop = false;
            this.groupBox_welcome.Text = "Welcome";
            // 
            // label_welcome_msg
            // 
            this.label_welcome_msg.AutoSize = true;
            this.label_welcome_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_welcome_msg.Location = new System.Drawing.Point(70, 119);
            this.label_welcome_msg.Name = "label_welcome_msg";
            this.label_welcome_msg.Size = new System.Drawing.Size(446, 93);
            this.label_welcome_msg.TabIndex = 6;
            this.label_welcome_msg.Text = "Welcome to PowerPoint Generator. \r\nUsing this tool, you will generate\r\n a PowerPo" +
    "int Slide";
            this.label_welcome_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_next1
            // 
            this.button_next1.Location = new System.Drawing.Point(462, 342);
            this.button_next1.Name = "button_next1";
            this.button_next1.Size = new System.Drawing.Size(75, 23);
            this.button_next1.TabIndex = 5;
            this.button_next1.Text = "Next";
            this.button_next1.UseVisualStyleBackColor = true;
            this.button_next1.Click += new System.EventHandler(this.Button_next1_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 407);
            this.Controls.Add(this.groupBox_images);
            this.Controls.Add(this.groupBox_welcome);
            this.Controls.Add(this.groupBox_text);
            this.Controls.Add(this.groupBox_output);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form";
            this.Text = "PowerPoint Generator";
            this.groupBox_text.ResumeLayout(false);
            this.groupBox_text.PerformLayout();
            this.groupBox_images.ResumeLayout(false);
            this.groupBox_output.ResumeLayout(false);
            this.groupBox_output.PerformLayout();
            this.groupBox_welcome.ResumeLayout(false);
            this.groupBox_welcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_text;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.RichTextBox textBox_text;
        private System.Windows.Forms.GroupBox groupBox_welcome;
        private System.Windows.Forms.Button button_next1;
        private System.Windows.Forms.Label label_welcome_msg;
        private System.Windows.Forms.Label label_text_instruction;
        private System.Windows.Forms.Button button_bold;
        private System.Windows.Forms.Button button_next2;
        private System.Windows.Forms.GroupBox groupBox_images;
        private System.Windows.Forms.Button button_previous3;
        private System.Windows.Forms.Button button_next3;
        private System.Windows.Forms.GroupBox groupBox_output;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_previous4;
        private System.Windows.Forms.TextBox textBox_output_folder;
        private System.Windows.Forms.TextBox textBox_output_name;
        private System.Windows.Forms.Label label_output_name;
        private System.Windows.Forms.Label label_output_folder;
        private System.Windows.Forms.Button button_browse_output_folder;
        private System.Windows.Forms.Label label1;
        //private PPTtext
        private string PPTtitle;
        //private PPTimages
        private string outputFolder;
        private string outputName;
    }
}

