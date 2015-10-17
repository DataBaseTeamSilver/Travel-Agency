namespace TravelAgency.Logic
{
    using System;
    using System.IO;
    using System.Linq;
    using iTextSharp.text;
    using iTextSharp.text.pdf;

    using TravelAgency.Data;

    public class PdfGenerator
    {
        public void GeneratePdfReports(TravelAgencyDbContext dbContext)
        {
            FileStream fs = new FileStream("../../../Data files/ExcursionsReport.pdf", FileMode.Create, FileAccess.Write, FileShare.None);

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

            PdfPTable table = new PdfPTable(5);

            int[] widths = new int[] { 20, 20, 20, 15, 11 };

            table.SetWidths(widths);

            table.AddCell(this.CreateCell(new Phrase("Excursion name"), true));
            table.AddCell(this.CreateCell(new Phrase("Destination"), true));
            table.AddCell(this.CreateCell(new Phrase("Clients count"), true));
            table.AddCell(this.CreateCell(new Phrase("Clients satisfaction"), true));
            table.AddCell(this.CreateCell(new Phrase("Duration in days"), true));

            for (int i = 0; i < excursionsCount; i++)
            {
                table.AddCell(this.CreateCell(new Phrase(excursions[i].Name)));
                table.AddCell(this.CreateCell(new Phrase(excursions[i].Destination.Country +
                    " (" + excursions[i].Destination.Distance + "km)")));
                table.AddCell(this.CreateCell(new Phrase(excursions[i].Clients.ToString())));
                table.AddCell(this.CreateCell(new Phrase((excursions[i].Guide.Experience * 10).ToString() + "%")));

                if (excursions[i].EndDate != null && excursions[i].StartDate != null)
                {
                    var endDate = excursions[i].EndDate ?? DateTime.Now;
                    var startDate = excursions[i].StartDate ?? DateTime.Now;
                    var duration = endDate.Subtract(startDate);
                    table.AddCell(this.CreateCell(new Phrase(duration.Days.ToString())));
                }
                else
                {
                    table.AddCell(this.CreateCell(new Phrase("Undifined(is not a function)")));
                }
            }

            document.Add(table);
        }

        private PdfPCell CreateCell(Phrase phrase, bool isHeader = false)
        {
            PdfPCell cell = new PdfPCell(phrase);
            if (isHeader)
            {
                cell.BackgroundColor = new BaseColor(102, 153, 153);
            }
            else
            {
                cell.BackgroundColor = new BaseColor(204, 204, 255);
            }

            cell.MinimumHeight = 25;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.HorizontalAlignment = 1;

            return cell;
        }
    }
}
