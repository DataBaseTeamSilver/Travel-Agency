namespace PdfGenerator
{
    using iTextSharp.text;
    using iTextSharp.text.pdf;
    using System;
    using System.IO;
    using Drawing = System.Drawing;

    public class PdfGenerator
    {
        public static void Main()
        {
            FileStream fs = new FileStream("../../Hello.pdf", FileMode.Create, FileAccess.Write, FileShare.None);

            Rectangle rect = new Rectangle(PageSize.A4);
            //rect.BackgroundColor = new BaseColor(System.Drawing.Color.Black);

            Document doc = new Document();

            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            doc.Add(new Paragraph("Hello, World!"));
            doc.Close();
        }
    }
}
