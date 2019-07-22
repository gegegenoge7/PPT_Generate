using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;

namespace PPT_Generate
{
    class Generate_PPT
    {
        public Generate_PPT(string Title, string text, string FullOutputPath, string[] imageLinks)
        {

            Microsoft.Office.Interop.PowerPoint.Application pptApplication = new Microsoft.Office.Interop.PowerPoint.Application();

            Microsoft.Office.Interop.PowerPoint.Slides slides;
            Microsoft.Office.Interop.PowerPoint._Slide slide;
            Microsoft.Office.Interop.PowerPoint.TextRange objText;

            // Create the Presentation File
            Presentation pptPresentation = pptApplication.Presentations.Add(MsoTriState.msoFalse);

            Microsoft.Office.Interop.PowerPoint.CustomLayout customLayout = pptPresentation.SlideMaster.CustomLayouts[Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutText];

            // Create new Slide
            slides = pptPresentation.Slides;
            slide = slides.AddSlide(1, customLayout);

            // Add title
            objText = slide.Shapes[1].TextFrame.TextRange;
            objText.Text = Title;
            objText.Font.Name = "Arial";
            objText.Font.Size = 32;

            Clipboard.SetData(DataFormats.Rtf, text);
            Microsoft.Office.Interop.PowerPoint.TextFrame tf = slide.Shapes[2].TextFrame;
            Microsoft.Office.Interop.PowerPoint.TextRange tr = tf.TextRange;
            tr.PasteSpecial(PpPasteDataType.ppPasteRTF);


            //fix
            
            int i = 1;
            foreach (string image in imageLinks)
            {
                Microsoft.Office.Interop.PowerPoint.Shape shape = slide.Shapes[3];
                if (i == 1)
                {
                    slide.Shapes.AddPicture(image, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue, shape.Left + (shape.Width / 2), shape.Top, shape.Width / 2, shape.Height / 2);
                }
                else if (i == 2)
                {
                    slide.Shapes.AddPicture(image, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue, shape.Left, shape.Top + (shape.Height/2), shape.Width / 2, shape.Height / 2);
                }
                else if (i == 3)
                {
                    slide.Shapes.AddPicture(image, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue, shape.Left + (shape.Width / 2), shape.Top + (shape.Height / 2), shape.Width / 2, shape.Height / 2);

                }
                i++;
            }
            pptPresentation.SaveAs(FullOutputPath, Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoTrue);
            pptPresentation.Close();
            pptApplication.Quit();
        }
    }
}
