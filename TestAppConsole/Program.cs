using System;
using System.Diagnostics;
using PdfSharpCore.Drawing;
using PdfSharpCore.Fonts;
using PdfSharpCore.Pdf;
using PdfSharpCore.Utils;

namespace TestAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                GlobalFontSettings.FontResolver = new FontResolver();

                var document = new PdfDocument();
                var page = document.AddPage();
                var gfx = XGraphics.FromPdfPage(page);

                var header = new XFont("OpenSans", 40, XFontStyle.Regular);
                var titleFont = new XFont("OpenSans", 20, XFontStyle.BoldItalic);
                var font = new XFont("OpenSans", 10, XFontStyle.Regular);

                var str = "	◙ Facin exeraessisit la consenim iureet dignibh eu facilluptat vercil dunt autpat " +
                 "Facin exeraessisit la consenim iureet.";


                XPen topheader = new XPen(XColors.DarkRed, 2);
                //gfx.DrawRectangle(topheader, new XRect(50, 20, 550, 50));
                gfx.DrawString("UNKNOW", header, XBrushes.DarkRed, new XRect(50, 20, 590, 100), XStringFormats.TopLeft);
                gfx.DrawLine(topheader, 50,70,590,70);


                //XPen educationPen = new XPen(XColors.Red, 2);
                //gfx.DrawRectangle(educationPen, new XRect(50, 110, 550, 120));
                gfx.DrawString("✓ Education", titleFont, XBrushes.DarkBlue, new XRect(50, 110, page.Width, page.Height), XStringFormats.TopLeft);

                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 140, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 160, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 180, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 200, 590, 100), XStringFormats.TopLeft);


                //XPen WorkExperiencePen = new XPen(XColors.Red, 2);
                //gfx.DrawRectangle(WorkExperiencePen, new XRect(50, 240, 550, 120));
                gfx.DrawString("✓ Work Experience", titleFont, XBrushes.DarkBlue, new XRect(50, 240, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 270, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 290, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 310, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 330, 590, 100), XStringFormats.TopLeft);


                //XPen ComputerSkillsPen = new XPen(XColors.Red, 2);
                //gfx.DrawRectangle(ComputerSkillsPen, new XRect(50, 370, 550, 120));
                gfx.DrawString("✓ Computer Skills", titleFont, XBrushes.DarkBlue, new XRect(50, 370, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 400, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 420, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 440, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 460, 590, 100), XStringFormats.TopLeft);


                //XPen HobbiesAndInterests = new XPen(XColors.Red, 2);
                //gfx.DrawRectangle(ComputerSkillsPen, new XRect(50, 500, 550, 120));
                gfx.DrawString("✓ Hobbies And Interests", titleFont, XBrushes.DarkBlue, new XRect(50, 500, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 530, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 550, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 570, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 590, 590, 100), XStringFormats.TopLeft);


                //XPen ReferenceDetails = new XPen(XColors.Red, 2);
                //gfx.DrawRectangle(ComputerSkillsPen, new XRect(50, 630, 550, 120));
                gfx.DrawString("✓ Reference Details", titleFont, XBrushes.DarkBlue, new XRect(50,630, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70,660, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 680, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 700, 590, 100), XStringFormats.TopLeft);
                gfx.DrawString(str, font, XBrushes.Black, new XRect(70, 720, 590, 100), XStringFormats.TopLeft);
                document.Save("test.pdf");
            }
            catch (Exception e)
            {

            }

        }
    }
}
