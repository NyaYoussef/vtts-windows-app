using vtts.Entities.MissionManagement;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vtts.Presentation.PrintOrderMission;

namespace vtts.BAL.MissionManagement
{
    /// <summary>
    /// Create Order Mission PDF
    /// </summary>
    public class PrintOrderMission
    {


        //OFP/DRNOII/ISMONTIC/OM/N° 13/17
        public string Ordre { get; set; }
        //
        public DateTime Date { get; set; }
        //Ex : Le Directeur Regional de la DRNOII
        public string Region { get; set; }
        //Ville
        public string City { get; set; }
        //
        public string Mensieur { get; set; }
        //
        public string Matricule { get; set; }
        //
        public string Category { get; set; }
        //
        public string Affectation { get; set; }
        // Ex : se rendre à  : atelier ..
        public string Place { get; set; }
        //
        public string Theme { get; set; }
        //
        public DateTime DepartureDate { get; set; }
        //
        public DateTime ReturnDate { get; set; }
        //
        public string DepartureHour { get; set; }
        //
        public string ReturnHour { get; set; }
        //
        public bool PublicTransport { get; set; }
        //
        public bool MissionCar { get; set; }
        //
        public bool PersonalCar { get; set; }
        //
        public string RegionDirectorName { get; set; }
        //
        public string DirectorName { get; set; }

        public PrintOrderMission()
        {
            Date = DateTime.Now;
            DepartureDate = DateTime.Now;
            ReturnDate = DateTime.Now;
        }

        public string CreatePDF()
        {

            // Create PDF Document with ItextSharp
            string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
            string path = appRootDir + "/PDFs/" + "OrdreMission.pdf";
            try
            {
                // Step 1: Creating System.IO.FileStream object
                using (FileStream fs = new FileStream(appRootDir + "/PDFs/" + "OrdreMission.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
                // Step 2: Creating iTextSharp.text.Document object
                using (Document doc = new Document())
                // Step 3: Creating iTextSharp.text.pdf.PdfWriter object
                // It helps to write the Document to the Specified FileStream
                using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                {
                    // Step 4: Openning the Document
                    doc.Open();

                    // Step 5: Adding a paragraph
                    // NOTE: When we want to insert text, then we've to do it through creating paragraph
                     //doc.Add(new Paragraph("Hello World :"));
                    PdfFile file = new PdfFile();
                    file.CreateText(doc, writer, Ordre, doc.PageSize.Width / 2, doc.PageSize.Height - 150f);
                    file.CreateText(doc, writer, Date.ToShortDateString(), doc.PageSize.Width / 2, doc.PageSize.Height - 170f);
                    //file.CreateParagraph(doc, "Ordre de Mission", true, true, true);
                    file.CreateText(doc, writer, "ordre de Mission", doc.PageSize.Width -320f, doc.PageSize.Height - 320f);
                    // Step 6: Closing the Document
                    doc.Close();
                }
            }
            // Catching iTextSharp.text.DocumentException if any
            catch (DocumentException de)
            {
                throw de;
            }
            // Catching System.IO.IOException if any
            catch (IOException ioe)
            {
                throw ioe;
            }

            return path;

        }
    }
}
