using Entities.MissionManagement;
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
        public string DepartureDate { get; set; }
        //
        public string ReturnDate { get; set; }
        //
        public string DepartureHour { get; set; }
        //
        public string ReturnHour { get; set; }
        
        //PublicTransport , MissionCar, PersonalCar
        public string TransportType { get; set; }
        // MissionCar Informations
        public string MissionCarmark { get; set; }
        // Puissance Fiscale
        public string MissionCarPlatNumber { get; set; }
        // PersonalCar Informations
        public string PersonalCarmark { get; set; }
        public string PersonalCarFiscalPower { get; set; }
        // N° de plaque
        public string PersonalCarPlatNumber { get; set; }
        
        // Personns
        public string FirstPersonne { get; set; }
        public string SecondePersonne { get; set; }

        //Header Image Directory
        public string HeaderImgDirectory { get; set; } 


        public PrintOrderMission()
        {
            Date = DateTime.Now;
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
                    // Add Image Header 
                    file.AddImage(doc,HeaderImgDirectory, 650f, 100f, 30f, doc.PageSize.Width - 400f, doc.PageSize.Height - 65f);
                    // Ordre , Date 
                    file.CreateText(doc, writer, Ordre , doc.PageSize.Width -250f, doc.PageSize.Height - 100f, false,true);
                    file.CreateText(doc, writer, "Date : " + Date.ToShortDateString(), doc.PageSize.Width - 250f, doc.PageSize.Height - 120f, false, true);
                    //
                    file.CreateText(doc, writer, "Ordre de Mission", doc.PageSize.Width / 2 - 45f, doc.PageSize.Height - 160f, true, false);
                    //
                    file.CreateText(doc, writer, Region, doc.PageSize.Width / 2 - 80f, doc.PageSize.Height - 180f, false, false);
                    //
                    file.CreateText(doc, writer,"-"+City+"-", doc.PageSize.Width / 2 - 20f , doc.PageSize.Height - 200f, false, false);
                    //
                    file.CreateText(doc, writer, "DESIGNE", doc.PageSize.Width / 2 - 24f, doc.PageSize.Height - 218f, false, true);

                    //
                    int YPos = 620;
                    int k = 15;
                    List<Object> Cell1 = new List<object>();
                    Cell1.Add(Mensieur);
                    Cell1.Add("Matricule : " + Matricule);
                    file.AddTableCells(writer, Cell1, 50, YPos);

                    List<Object> Cell2 = new List<object>();
                    Cell2.Add("Categorie : " + Category);
                    file.AddTableCells(writer, Cell2, 50, YPos - k);

                    List<Object> Cell3 = new List<object>();
                    Cell3.Add("Affectation : " + Affectation);
                    file.AddTableCells(writer, Cell3, 50, YPos - (k*2));

                    List<Object> Cell4 = new List<object>();
                    Cell4.Add("De se rendre à : "+Place);
                    file.AddTableCells(writer, Cell4, 50, YPos - (k * 3));

                    List<Object> Cell5 = new List<object>();
                    Cell5.Add(Theme);
                    file.AddTableCells(writer, Cell5, 50, YPos - (k * 4));


                    List<Object> Cell6 = new List<object>();
                    Cell6.Add("Date de Depart : "+DepartureDate);
                    Cell6.Add("Heure : " +DepartureHour);
                    file.AddTableCells(writer, Cell6, 50, YPos - (k * 5));

                    List<Object> Cell7 = new List<object>();
                    Cell7.Add("Date de Retour : " +ReturnDate);
                    Cell7.Add("Heure  " +ReturnHour);
                    file.AddTableCells(writer, Cell7, 50, YPos - (k * 6));

                    List<Object> Cell8 = new List<object>();
                    Cell8.Add("L'intéressé (e) utilisera : ");
                    file.AddTableCells(writer, Cell8, 50, YPos - (k * 7));


                    //List<Object> Cell9 = new List<object>();
                    //Cell9.Add("\t\t\tTransport Public");
                    //Cell9.Add("\t\t\tVoiture de Mission\n\nMarque : \nN° de plaque : ");
                    //Cell9.Add("\t\t\tVoiture Personnelle\n\nMarque : \nPuissance Fiscale : \nN° de plaque : ");
                    //file.AddTableCells(writer, Cell9, 50, YPos - (k * 8));
                    //////////////
                    List<Object> Cell9 = new List<object>();
                    if (TransportType == "PublicTransport")
                    {
                        Cell9.Add("X)\n\nTransport Public");
                        Cell9.Add("..)\n\nVoiture de Mission\n\nMarque : \nN° de plaque : ");
                        Cell9.Add("..)\n\nVoiture Personnelle\n\nMarque : \nPuissance Fiscale : \nN° de plaque : ");
                        file.AddTableCells(writer, Cell9, 50, YPos - (k * 8));
                    }
                    if (TransportType == "MissionCar")
                    {
                        Cell9.Add("..)\n\nTransport Public");
                        Cell9.Add("X)\n\nVoiture de Mission\n\nMarque : " + MissionCarmark + "\nN° de plaque : " + MissionCarPlatNumber);
                        Cell9.Add("..)\n\nVoiture Personnelle\n\nMarque : \nPuissance Fiscale : \nN° de plaque : ");
                        file.AddTableCells(writer, Cell9, 50, YPos - (k * 8));
                    }
                    if (TransportType == "PersonalCar")
                    {
                        Cell9.Add("..)\n\nTransport Public");
                        Cell9.Add("..)\n\nVoiture Personnelle\n\nMarque : \nPuissance Fiscale : \nN° de plaque : ");
                        Cell9.Add("X)\n\nVoiture Personnelle\n\nMarque : " + PersonalCarmark + "\nPuissance Fiscale : " + PersonalCarPlatNumber + "\nN° de plaque : ");
                        file.AddTableCells(writer, Cell9, 50, YPos - (k * 8));
                    }

                    //Table Footer
                    List<Object> Cell10 = new List<object>();
                    Cell10.Add("Le Directeur d'Ismontic Tanger : \n\n"+ FirstPersonne);
                    Cell10.Add(Region + "\n\n" + SecondePersonne);
                    file.AddTableCells(writer, Cell10, 50, YPos - (k * 16));



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
