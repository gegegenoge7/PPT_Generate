using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.CognitiveServices.Search.ImageSearch;
using Microsoft.Azure.CognitiveServices.Search.ImageSearch.Models;
using System.IO;

namespace PPT_Generate
{
    public partial class Form : System.Windows.Forms.Form
    {
        private List<int> pic_num_selected;
        string[] ImageResult_url;
        public Form()
        {
            InitializeComponent();
            pic_num_selected = new List<int>();
            this.groupBox_welcome.Hide();
            this.groupBox_welcome.Show();
            this.groupBox_text.Hide();
            this.groupBox_images.Hide();
            this.groupBox_output.Hide();
        }

        private void Button_next1_Click(object sender, EventArgs e)
        {
            this.groupBox_welcome.Hide();
            this.groupBox_text.Show();
            this.groupBox_images.Hide();
            this.groupBox_output.Hide();
        }

        private void Button_next2_Click(object sender, EventArgs e)
        {
            string key = "35e097947bfd47c690722ee36f91b353";
            Images imageResults = null;
            string bold_words = bolded_words();
            string searchTerm = this.textBox_title.Text + " " + bold_words;
            Console.WriteLine(searchTerm);
            var client = new ImageSearchClient(new ApiKeyServiceClientCredentials(key));
            imageResults = client.Images.SearchAsync(query: searchTerm).Result;
            if (imageResults == null)
            {
                MessageBox.Show("Failed to search for images with given title and bold text");
            }
            else
            {
                ImageResult_url = new string[9];
                for (int i = 0; i<9; i++)
                {
                    ImageResult_url[i] = imageResults.Value[i].ThumbnailUrl;
                }
                pictureBox1.Load(ImageResult_url[0]);
                pictureBox2.Load(ImageResult_url[1]);
                pictureBox3.Load(ImageResult_url[2]);
                pictureBox4.Load(ImageResult_url[3]);
                pictureBox5.Load(ImageResult_url[4]);
                pictureBox6.Load(ImageResult_url[5]);
                pictureBox7.Load(ImageResult_url[6]);
                pictureBox8.Load(ImageResult_url[7]);
                pictureBox9.Load(ImageResult_url[8]);

                this.groupBox_welcome.Hide();
                this.groupBox_text.Hide();
                this.groupBox_images.Show();
                this.groupBox_output.Hide();
            }
        }
        private void Button_next3_Click(object sender, EventArgs e)
        {
            this.groupBox_welcome.Hide();
            this.groupBox_text.Hide();
            this.groupBox_images.Hide();
            this.groupBox_output.Show();
        }

        private void Button_create_Click(object sender, EventArgs e)
        {
            PPTtext = this.textBox_text.Rtf;
            PPTtitle = this.textBox_title.Text;
            PPTimages = new string[pic_num_selected.Count()];
            int count = 0;
            foreach(int i in pic_num_selected)
            {
                PPTimages[count] = ImageResult_url[i-1];
                count++;
            }
            outputName = this.textBox_output_name.Text;
            outputFolder = this.textBox_output_folder.Text;

            if (!outputName.EndsWith(".pptx"))
            {
                outputName += ".pptx";
            }
            string output_path = outputFolder + @"/" + outputName;
            Generate_PPT generate = new Generate_PPT(PPTtitle, PPTtext, output_path, PPTimages);


            MessageBox.Show("Created PowerPoint. Closing...");
            this.Close();
        }
        private void Button_previous3_Click(object sender, EventArgs e)
        {
            this.groupBox_welcome.Hide();
            this.groupBox_text.Show();
            this.groupBox_images.Hide();
            this.groupBox_output.Hide();
        }

        private void Button_previous4_Click(object sender, EventArgs e)
        {
            this.groupBox_welcome.Hide();
            this.groupBox_text.Hide();
            this.groupBox_images.Show();
            this.groupBox_output.Hide();
        }

        private void Button_bold_Click(object sender, EventArgs e)
        {
            this.textBox_text.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 9, FontStyle.Bold);
        }

        private void Button_unbold_Click(object sender, EventArgs e)
        {
            this.textBox_text.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 9);
        }

        private void Button_browse_output_folder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.textBox_output_folder.Text = fbd.SelectedPath;
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (pic_num_selected.Contains(1))
            {
                pic_num_selected.Remove(1);
            }
            else if (pic_num_selected.Count() > 2)
            {
                MessageBox.Show("You can only select upto 3 images!");
            }
            else
            {
                pic_num_selected.Add(1);
            }
            Update_pic_num_label();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (pic_num_selected.Contains(2))
            {
                pic_num_selected.Remove(2);
            }
            else if (pic_num_selected.Count() > 2)
            {
                MessageBox.Show("You can only select upto 3 images!");
            }
            else
            {
                pic_num_selected.Add(2);
            }
            Update_pic_num_label();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (pic_num_selected.Contains(3))
            {
                pic_num_selected.Remove(3);
            }
            else if (pic_num_selected.Count() > 2)
            {
                MessageBox.Show("You can only select upto 3 images!");
            }
            else
            {
                pic_num_selected.Add(3);
            }
            Update_pic_num_label();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (pic_num_selected.Contains(4))
            {
                pic_num_selected.Remove(4);
            }
            else if (pic_num_selected.Count() > 2)
            {
                MessageBox.Show("You can only select upto 3 images!");
            }
            else
            {
                pic_num_selected.Add(4);
            }
            Update_pic_num_label();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            if (pic_num_selected.Contains(5))
            {
                pic_num_selected.Remove(5);
            }
            else if (pic_num_selected.Count() > 2)
            {
                MessageBox.Show("You can only select upto 3 images!");
            }
            else
            {
                pic_num_selected.Add(5);
            }
            Update_pic_num_label();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            if (pic_num_selected.Contains(6))
            {
                pic_num_selected.Remove(6);
            }
            else if (pic_num_selected.Count() > 2)
            {
                MessageBox.Show("You can only select upto 3 images!");
            }
            else
            {
                pic_num_selected.Add(6);
            }
            Update_pic_num_label();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            if (pic_num_selected.Contains(7))
            {
                pic_num_selected.Remove(7);
            }
            else if (pic_num_selected.Count() > 2)
            {
                MessageBox.Show("You can only select upto 3 images!");
            }
            else
            {
                pic_num_selected.Add(7);
            }
            Update_pic_num_label();
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            if (pic_num_selected.Contains(8))
            {
                pic_num_selected.Remove(8);
            }
            else if (pic_num_selected.Count() > 2)
            {
                MessageBox.Show("You can only select upto 3 images!");
            }
            else
            {
                pic_num_selected.Add(8);
            }
            Update_pic_num_label();
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            if (pic_num_selected.Contains(9))
            {
                pic_num_selected.Remove(9);
            }
            else if (pic_num_selected.Count() > 2)
            {
                MessageBox.Show("You can only select upto 3 images!");
            }
            else
            {
                pic_num_selected.Add(9);
            }
            Update_pic_num_label();
        }
        private void Update_pic_num_label()
        {
            this.label_sel_pic_num.Text = "";
            foreach (int index in pic_num_selected)
            {
                this.label_sel_pic_num.Text += index.ToString() + " ";
            }
        }
        private string bolded_words()
        {
            string bolded_words = "";
            Console.WriteLine(this.textBox_text.Rtf);
            string str = this.textBox_text.Rtf;
            int StartIndex = str.IndexOf(@"\b");
            Console.WriteLine(StartIndex);
            while (StartIndex != -1)
            {
                StartIndex = str.IndexOf(' ', StartIndex) + 1;
                Console.WriteLine("updated start" + StartIndex);
                int endIndex = str.IndexOf(@"\b0", StartIndex) - 1;
                if (endIndex == -1)
                {
                    endIndex = str.Length - 1;
                    break;
                }
                Console.WriteLine("end" + endIndex);
                bolded_words += (str.Substring(StartIndex, endIndex - StartIndex) + " ");
                StartIndex = str.IndexOf(@"\b", endIndex + 3);
                Console.WriteLine("next\n" + StartIndex);
            }

            /*
            string[] words = this.textBox_text.Rtf.Split(new char[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            bool bolded = false;
            for (int index = 0; index < words.Count(); index++)
            {
                Console.WriteLine(words[index]);
                if (bolded)
                {
                    int end = words[index].IndexOf(@"\b0");
                    bolded_words += (words[index].Substring(0, end) + " ");
                }
                if (words[index].Contains(@"\b"))
                {
                    bolded = true;
                    continue;
                }
            }*/
            return bolded_words;
        }
    }
}
