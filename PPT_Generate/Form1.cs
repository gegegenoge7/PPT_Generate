using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;

namespace PPT_Generate
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
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
            this.groupBox_welcome.Hide();
            this.groupBox_text.Hide();
            this.groupBox_images.Show();
            this.groupBox_output.Hide();
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
            //PPTimages
            outputName = this.textBox_output_name.Text;
            outputFolder = this.textBox_output_folder.Text;

            if (!outputName.EndsWith(".pptx"))
            {
                outputName += ".pptx";
            }
            string output_path = outputFolder + @"/" + outputName;
            Generate_PPT generate = new Generate_PPT(PPTtitle, PPTtext, output_path);


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
    }
}
