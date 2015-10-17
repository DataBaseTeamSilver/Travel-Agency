namespace TravelAgency.Logic
{
    using iTextSharp.text;
    using iTextSharp.text.pdf;
    using System.IO;
    using System.Linq;

    using TravelAgency.Data;
    using TravelAgency.Model;
    using System.Data.Entity;
    using System;

    public class PdfGenerator
    {
        //public static void Main()
        //{
        //    TarvelAgencyDbContext dbContext = new TarvelAgencyDbContext();

        //    GeneratePdfReports(dbContext);
        //}

        public void GeneratePdfReports(TravelAgencyDbContext dbContext)
        {
            FileStream fs = new FileStream("../../Reports.pdf", FileMode.Create, FileAccess.Write, FileShare.None);

            Document document = new Document(this.CreatePdfRectangle());

            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            this.FillDocument(document, dbContext);


        }

        private Rectangle CreatePdfRectangle()
        {
            Rectangle rect = new Rectangle(PageSize.A4);
            rect.BackgroundColor = new BaseColor(System.Drawing.Color.LightGray);

            return rect;
        }

        private void FillDocument(Document document, TravelAgencyDbContext dbContext)
        {
            document.Open();

            this.GenerateData(document, dbContext);

            document.Close();
        }

        private void GenerateData(Document document, TravelAgencyDbContext dbContext)
        {
            var excursionsCount = dbContext.Excursions.Count();

            var excursions = dbContext.Excursions.ToList();

            PdfPTable table = new PdfPTable(4);
            //table.AddCell(this.CreateCell(new Phrase("Name", new Font(Font.BOLD, 8f, Font.NORMAL, BaseColor.YELLOW))));
            table.AddCell(this.CreateCell(new Phrase("Name")));
            table.AddCell(this.CreateCell(new Phrase("Destination")));
            table.AddCell(this.CreateCell(new Phrase("Clients count")));
            table.AddCell(this.CreateCell(new Phrase("Duration in days")));

            for (int i = 0; i < 4; i++)
            {
                 table.AddCell(this.CreateCell(new Phrase(excursions[i].Name)));
                 table.AddCell(this.CreateCell(new Phrase(excursions[i].Destination.Country +
                     "(" + excursions[i].Destination.Distance + "km)")));
                 table.AddCell(this.CreateCell(new Phrase(excursions[i].Clients)));

                if (excursions[i].EndDate != null && excursions[i].StartDate != null)
                {
                    var endDate = excursions[i].EndDate ?? DateTime.Now;
                    var startDate = excursions[i].StartDate ?? DateTime.Now;
                    var duration = endDate.Subtract(startDate);
                     table.AddCell(this.CreateCell(new Phrase(duration.ToString())));
                }
                else
                {
                    table.AddCell(this.CreateCell(new Phrase("Undifined(is not a function)")));
                }

                //table.AddCell(this.CreateCell(new Phrase("Ex nam" + i)));
                //table.AddCell(this.CreateCell(new Phrase("Country" + i)));
                //table.AddCell(this.CreateCell(new Phrase("Clinets" + i + 50)));
                //table.AddCell(this.CreateCell(new Phrase("Duration" + i + "days")));
            }

            document.Add(table);
        }

        private PdfPCell CreateCell(Phrase phrase)
        {
            return new PdfPCell(phrase);
        }
    }
}
