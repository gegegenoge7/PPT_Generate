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
            this.label_img9 = new System.Windows.Forms.Label();
            this.label_img8 = new System.Windows.Forms.Label();
            this.label_img7 = new System.Windows.Forms.Label();
            this.label_img6 = new System.Windows.Forms.Label();
            this.label_img5 = new System.Windows.Forms.Label();
            this.label_img4 = new System.Windows.Forms.Label();
            this.label_img3 = new System.Windows.Forms.Label();
            this.label_img2 = new System.Windows.Forms.Label();
            this.label_img1 = new System.Windows.Forms.Label();
            this.label_sel_pic_num = new System.Windows.Forms.Label();
            this.label_sel_pic = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_instruction_images = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_output.SuspendLayout();
            this.groupBox_welcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(31, 74);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(130, 17);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Title of PowerPoint:";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(29, 133);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(130, 17);
            this.label_text.TabIndex = 1;
            this.label_text.Text = "Text of PowerPoint:";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(168, 70);
            this.textBox_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(519, 22);
            this.textBox_title.TabIndex = 2;
            // 
            // textBox_text
            // 
            this.textBox_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox_text.Location = new System.Drawing.Point(168, 127);
            this.textBox_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(519, 287);
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
            this.groupBox_text.Location = new System.Drawing.Point(16, 15);
            this.groupBox_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_text.Name = "groupBox_text";
            this.groupBox_text.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_text.Size = new System.Drawing.Size(740, 471);
            this.groupBox_text.TabIndex = 4;
            this.groupBox_text.TabStop = false;
            this.groupBox_text.Text = "Texts of PowerPoint";
            // 
            // label_text_instruction
            // 
            this.label_text_instruction.AutoSize = true;
            this.label_text_instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_text_instruction.Location = new System.Drawing.Point(31, 33);
            this.label_text_instruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_text_instruction.Name = "label_text_instruction";
            this.label_text_instruction.Size = new System.Drawing.Size(639, 29);
            this.label_text_instruction.TabIndex = 7;
            this.label_text_instruction.Text = "Enter the Title and the main Text field of the PowerPoint";
            // 
            // button_next2
            // 
            this.button_next2.Location = new System.Drawing.Point(616, 421);
            this.button_next2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_next2.Name = "button_next2";
            this.button_next2.Size = new System.Drawing.Size(100, 28);
            this.button_next2.TabIndex = 9;
            this.button_next2.Text = "Next";
            this.button_next2.UseVisualStyleBackColor = true;
            this.button_next2.Click += new System.EventHandler(this.Button_next2_Click);
            // 
            // button_bold
            // 
            this.button_bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bold.Location = new System.Drawing.Point(121, 239);
            this.button_bold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_bold.Name = "button_bold";
            this.button_bold.Size = new System.Drawing.Size(40, 42);
            this.button_bold.TabIndex = 8;
            this.button_bold.Text = "B";
            this.button_bold.UseVisualStyleBackColor = true;
            this.button_bold.Click += new System.EventHandler(this.Button_bold_Click);
            // 
            // button_previous3
            // 
            this.button_previous3.Location = new System.Drawing.Point(21, 421);
            this.button_previous3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_previous3.Name = "button_previous3";
            this.button_previous3.Size = new System.Drawing.Size(100, 28);
            this.button_previous3.TabIndex = 11;
            this.button_previous3.Text = "Previous";
            this.button_previous3.UseVisualStyleBackColor = true;
            this.button_previous3.Click += new System.EventHandler(this.Button_previous3_Click);
            // 
            // button_next3
            // 
            this.button_next3.Location = new System.Drawing.Point(616, 421);
            this.button_next3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_next3.Name = "button_next3";
            this.button_next3.Size = new System.Drawing.Size(100, 28);
            this.button_next3.TabIndex = 10;
            this.button_next3.Text = "Next";
            this.button_next3.UseVisualStyleBackColor = true;
            this.button_next3.Click += new System.EventHandler(this.Button_next3_Click);
            // 
            // groupBox_images
            // 
            this.groupBox_images.Controls.Add(this.label_img9);
            this.groupBox_images.Controls.Add(this.label_img8);
            this.groupBox_images.Controls.Add(this.label_img7);
            this.groupBox_images.Controls.Add(this.label_img6);
            this.groupBox_images.Controls.Add(this.label_img5);
            this.groupBox_images.Controls.Add(this.label_img4);
            this.groupBox_images.Controls.Add(this.label_img3);
            this.groupBox_images.Controls.Add(this.label_img2);
            this.groupBox_images.Controls.Add(this.label_img1);
            this.groupBox_images.Controls.Add(this.label_sel_pic_num);
            this.groupBox_images.Controls.Add(this.label_sel_pic);
            this.groupBox_images.Controls.Add(this.pictureBox9);
            this.groupBox_images.Controls.Add(this.pictureBox8);
            this.groupBox_images.Controls.Add(this.pictureBox7);
            this.groupBox_images.Controls.Add(this.pictureBox6);
            this.groupBox_images.Controls.Add(this.pictureBox5);
            this.groupBox_images.Controls.Add(this.pictureBox4);
            this.groupBox_images.Controls.Add(this.pictureBox3);
            this.groupBox_images.Controls.Add(this.pictureBox2);
            this.groupBox_images.Controls.Add(this.pictureBox1);
            this.groupBox_images.Controls.Add(this.label_instruction_images);
            this.groupBox_images.Controls.Add(this.button_next3);
            this.groupBox_images.Controls.Add(this.button_previous3);
            this.groupBox_images.Location = new System.Drawing.Point(16, 15);
            this.groupBox_images.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_images.Name = "groupBox_images";
            this.groupBox_images.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_images.Size = new System.Drawing.Size(740, 471);
            this.groupBox_images.TabIndex = 4;
            this.groupBox_images.TabStop = false;
            this.groupBox_images.Text = " v";
            // 
            // label_img9
            // 
            this.label_img9.AutoSize = true;
            this.label_img9.Location = new System.Drawing.Point(337, 259);
            this.label_img9.Name = "label_img9";
            this.label_img9.Size = new System.Drawing.Size(13, 13);
            this.label_img9.TabIndex = 30;
            this.label_img9.Text = "9";
            // 
            // label_img8
            // 
            this.label_img8.AutoSize = true;
            this.label_img8.Location = new System.Drawing.Point(207, 259);
            this.label_img8.Name = "label_img8";
            this.label_img8.Size = new System.Drawing.Size(13, 13);
            this.label_img8.TabIndex = 29;
            this.label_img8.Text = "8";
            // 
            // label_img7
            // 
            this.label_img7.AutoSize = true;
            this.label_img7.Location = new System.Drawing.Point(72, 259);
            this.label_img7.Name = "label_img7";
            this.label_img7.Size = new System.Drawing.Size(13, 13);
            this.label_img7.TabIndex = 28;
            this.label_img7.Text = "7";
            // 
            // label_img6
            // 
            this.label_img6.AutoSize = true;
            this.label_img6.Location = new System.Drawing.Point(337, 160);
            this.label_img6.Name = "label_img6";
            this.label_img6.Size = new System.Drawing.Size(13, 13);
            this.label_img6.TabIndex = 27;
            this.label_img6.Text = "6";
            // 
            // label_img5
            // 
            this.label_img5.AutoSize = true;
            this.label_img5.Location = new System.Drawing.Point(207, 160);
            this.label_img5.Name = "label_img5";
            this.label_img5.Size = new System.Drawing.Size(13, 13);
            this.label_img5.TabIndex = 26;
            this.label_img5.Text = "5";
            // 
            // label_img4
            // 
            this.label_img4.AutoSize = true;
            this.label_img4.Location = new System.Drawing.Point(72, 160);
            this.label_img4.Name = "label_img4";
            this.label_img4.Size = new System.Drawing.Size(13, 13);
            this.label_img4.TabIndex = 25;
            this.label_img4.Text = "4";
            // 
            // label_img3
            // 
            this.label_img3.AutoSize = true;
            this.label_img3.Location = new System.Drawing.Point(337, 67);
            this.label_img3.Name = "label_img3";
            this.label_img3.Size = new System.Drawing.Size(13, 13);
            this.label_img3.TabIndex = 24;
            this.label_img3.Text = "3";
            // 
            // label_img2
            // 
            this.label_img2.AutoSize = true;
            this.label_img2.Location = new System.Drawing.Point(207, 67);
            this.label_img2.Name = "label_img2";
            this.label_img2.Size = new System.Drawing.Size(13, 13);
            this.label_img2.TabIndex = 23;
            this.label_img2.Text = "2";
            // 
            // label_img1
            // 
            this.label_img1.AutoSize = true;
            this.label_img1.Location = new System.Drawing.Point(72, 67);
            this.label_img1.Name = "label_img1";
            this.label_img1.Size = new System.Drawing.Size(13, 13);
            this.label_img1.TabIndex = 5;
            this.label_img1.Text = "1";
            // 
            // label_sel_pic_num
            // 
            this.label_sel_pic_num.AutoSize = true;
            this.label_sel_pic_num.Location = new System.Drawing.Point(466, 160);
            this.label_sel_pic_num.Name = "label_sel_pic_num";
            this.label_sel_pic_num.Size = new System.Drawing.Size(0, 13);
            this.label_sel_pic_num.TabIndex = 22;
            // 
            // label_sel_pic
            // 
            this.label_sel_pic.AutoSize = true;
            this.label_sel_pic.Location = new System.Drawing.Point(462, 132);
            this.label_sel_pic.Name = "label_sel_pic";
            this.label_sel_pic.Size = new System.Drawing.Size(93, 13);
            this.label_sel_pic.TabIndex = 21;
            this.label_sel_pic.Text = "Selected Pictures:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(356, 259);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 78);
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.PictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(226, 259);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 78);
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.PictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(91, 259);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 78);
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.PictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(356, 160);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 78);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.PictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(226, 160);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 78);
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(91, 160);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 78);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(356, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 78);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(226, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 78);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(91, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label_instruction_images
            // 
            this.label_instruction_images.AutoSize = true;
            this.label_instruction_images.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_instruction_images.Location = new System.Drawing.Point(60, 27);
            this.label_instruction_images.Name = "label_instruction_images";
            this.label_instruction_images.Size = new System.Drawing.Size(428, 24);
            this.label_instruction_images.TabIndex = 5;
            this.label_instruction_images.Text = "Here you will select the images for the PowerPoint";
            this.label_instruction_images.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.groupBox_output.Location = new System.Drawing.Point(16, 15);
            this.groupBox_output.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_output.Name = "groupBox_output";
            this.groupBox_output.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_output.Size = new System.Drawing.Size(740, 471);
            this.groupBox_output.TabIndex = 4;
            this.groupBox_output.TabStop = false;
            this.groupBox_output.Text = "Output File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 87);
            this.label1.TabIndex = 7;
            this.label1.Text = "Here you will decide on your powerpoint slide\'s name\r\nand where to export it. Hit" +
    " Create to create and export\r\nyour PowerPoint.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(616, 421);
            this.button_create.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(100, 28);
            this.button_create.TabIndex = 6;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.Button_create_Click);
            // 
            // button_previous4
            // 
            this.button_previous4.Location = new System.Drawing.Point(21, 421);
            this.button_previous4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_previous4.Name = "button_previous4";
            this.button_previous4.Size = new System.Drawing.Size(100, 28);
            this.button_previous4.TabIndex = 5;
            this.button_previous4.Text = "Previous";
            this.button_previous4.UseVisualStyleBackColor = true;
            this.button_previous4.Click += new System.EventHandler(this.Button_previous4_Click);
            // 
            // textBox_output_folder
            // 
            this.textBox_output_folder.Location = new System.Drawing.Point(136, 266);
            this.textBox_output_folder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_output_folder.Name = "textBox_output_folder";
            this.textBox_output_folder.Size = new System.Drawing.Size(471, 22);
            this.textBox_output_folder.TabIndex = 4;
            // 
            // textBox_output_name
            // 
            this.textBox_output_name.Location = new System.Drawing.Point(136, 159);
            this.textBox_output_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_output_name.Name = "textBox_output_name";
            this.textBox_output_name.Size = new System.Drawing.Size(471, 22);
            this.textBox_output_name.TabIndex = 3;
            // 
            // label_output_name
            // 
            this.label_output_name.AutoSize = true;
            this.label_output_name.Location = new System.Drawing.Point(81, 162);
            this.label_output_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_output_name.Name = "label_output_name";
            this.label_output_name.Size = new System.Drawing.Size(53, 17);
            this.label_output_name.TabIndex = 2;
            this.label_output_name.Text = "Name: ";
            // 
            // label_output_folder
            // 
            this.label_output_folder.AutoSize = true;
            this.label_output_folder.Location = new System.Drawing.Point(29, 270);
            this.label_output_folder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_output_folder.Name = "label_output_folder";
            this.label_output_folder.Size = new System.Drawing.Size(99, 17);
            this.label_output_folder.TabIndex = 1;
            this.label_output_folder.Text = "Output Folder:";
            // 
            // button_browse_output_folder
            // 
            this.button_browse_output_folder.Location = new System.Drawing.Point(616, 263);
            this.button_browse_output_folder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_browse_output_folder.Name = "button_browse_output_folder";
            this.button_browse_output_folder.Size = new System.Drawing.Size(100, 28);
            this.button_browse_output_folder.TabIndex = 0;
            this.button_browse_output_folder.Text = "Browse...";
            this.button_browse_output_folder.UseVisualStyleBackColor = true;
            this.button_browse_output_folder.Click += new System.EventHandler(this.Button_browse_output_folder_Click);
            // 
            // groupBox_welcome
            // 
            this.groupBox_welcome.Controls.Add(this.label_welcome_msg);
            this.groupBox_welcome.Controls.Add(this.button_next1);
            this.groupBox_welcome.Location = new System.Drawing.Point(16, 15);
            this.groupBox_welcome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_welcome.Name = "groupBox_welcome";
            this.groupBox_welcome.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_welcome.Size = new System.Drawing.Size(740, 471);
            this.groupBox_welcome.TabIndex = 4;
            this.groupBox_welcome.TabStop = false;
            this.groupBox_welcome.Text = "Welcome";
            // 
            // label_welcome_msg
            // 
            this.label_welcome_msg.AutoSize = true;
            this.label_welcome_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_welcome_msg.Location = new System.Drawing.Point(93, 146);
            this.label_welcome_msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_welcome_msg.Name = "label_welcome_msg";
            this.label_welcome_msg.Size = new System.Drawing.Size(559, 117);
            this.label_welcome_msg.TabIndex = 6;
            this.label_welcome_msg.Text = "Welcome to PowerPoint Generator. \r\nUsing this tool, you will generate\r\n a PowerPo" +
    "int Slide";
            this.label_welcome_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_next1
            // 
            this.button_next1.Location = new System.Drawing.Point(616, 421);
            this.button_next1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_next1.Name = "button_next1";
            this.button_next1.Size = new System.Drawing.Size(100, 28);
            this.button_next1.TabIndex = 5;
            this.button_next1.Text = "Next";
            this.button_next1.UseVisualStyleBackColor = true;
            this.button_next1.Click += new System.EventHandler(this.Button_next1_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 501);
            this.Controls.Add(this.groupBox_images);
            this.Controls.Add(this.groupBox_welcome);
            this.Controls.Add(this.groupBox_text);
            this.Controls.Add(this.groupBox_output);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form";
            this.Text = "PowerPoint Generator";
            this.groupBox_text.ResumeLayout(false);
            this.groupBox_text.PerformLayout();
            this.groupBox_images.ResumeLayout(false);
            this.groupBox_images.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private string PPTtext;
        private string PPTtitle;
        private string[] PPTimages;
        private string outputFolder;
        private string outputName;
        private System.Windows.Forms.Label label_instruction_images;
        private System.Windows.Forms.Label label_sel_pic;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_sel_pic_num;
        private System.Windows.Forms.Label label_img9;
        private System.Windows.Forms.Label label_img8;
        private System.Windows.Forms.Label label_img7;
        private System.Windows.Forms.Label label_img6;
        private System.Windows.Forms.Label label_img5;
        private System.Windows.Forms.Label label_img4;
        private System.Windows.Forms.Label label_img3;
        private System.Windows.Forms.Label label_img2;
        private System.Windows.Forms.Label label_img1;
    }
}

