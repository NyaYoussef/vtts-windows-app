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
            //string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).FullName;
            //string path = appRootDir + "/PDFs/" + "OrdreMission.pdf";
            try
            {
                // Step 1: Creating System.IO.FileStream object
                using (FileStream fs = new FileStream("OrdreMission.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
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
                    file.AddImage(doc,650f, 100f, 30f, doc.PageSize.Width - 400f, doc.PageSize.Height - 65f);
                    // Ordre , Date 
                    file.CreateText(doc, writer, Ordre, doc.PageSize.Width - 250f, doc.PageSize.Height - 100f, false, true);
                    file.CreateText(doc, writer, "Date : " + Date.ToShortDateString(), doc.PageSize.Width - 250f, doc.PageSize.Height - 120f, false, true);
                    //
                    file.CreateText(doc, writer, "Ordre de Mission", doc.PageSize.Width / 2 - 45f, doc.PageSize.Height - 160f, true, false);
                    //
                    file.CreateText(doc, writer, Region, doc.PageSize.Width / 2 - 80f, doc.PageSize.Height - 180f, false, false);
                    //
                    file.CreateText(doc, writer, "-" + City + "-", doc.PageSize.Width / 2 - 20f, doc.PageSize.Height - 200f, false, false);
                    //
                    file.CreateText(doc, writer, "DESIGNE", doc.PageSize.Width / 2 - 24f, doc.PageSize.Height - 218f, false, true);

                    //


                    // First :
                    ///////
                    //int YPos = 620;
                    //int k = 15;
                    //List<Object> Cell1 = new List<object>();
                    //Cell1.Add(Mensieur);
                    //Cell1.Add("Matricule : " + Matricule);
                    //file.AddTableCells(writer, Cell1, 50, YPos);



                    //List<Object> Cell2 = new List<object>();
                    //Cell2.Add("Categorie : " + Category);
                    //file.AddTableCells(writer, Cell2, 50, YPos - (k ));


                    //List<Object> Cell3 = new List<object>();
                    //Cell3.Add("Affectation : " + Affectation);
                    //file.AddTableCells(writer, Cell3, 50, YPos - (k * 2));//2

                    //List<Object> Cell4 = new List<object>();
                    //Cell4.Add("De se rendre à : " + Place);
                    //file.AddTableCells(writer, Cell4, 50, YPos - (k * 3));

                    //List<Object> Cell5 = new List<object>();
                    //Cell5.Add(Theme);
                    //file.AddTableCells(writer, Cell5, 50, YPos - (k * 4));


                    //List<Object> Cell6 = new List<object>();
                    //Cell6.Add("Date de Depart : " + DepartureDate);
                    //Cell6.Add("Heure : " + DepartureHour);
                    //file.AddTableCells(writer, Cell6, 50, YPos - (k * 5));

                    //List<Object> Cell7 = new List<object>();
                    //Cell7.Add("Date de Retour : " + ReturnDate);
                    //Cell7.Add("Heure  " + ReturnHour);
                    //file.AddTableCells(writer, Cell7, 50, YPos - (k * 6));

                    //List<Object> Cell8 = new List<object>();
                    //Cell8.Add("L'intéressé (e) utilisera : ");
                    //file.AddTableCells(writer, Cell8, 50, YPos - (k * 7));


                    ////////List<Object> Cell9 = new List<object>();
                    ////////Cell9.Add("\t\t\tTransport Public");
                    ////////Cell9.Add("\t\t\tVoiture de Mission\n\nMarque : \nN° de plaque : ");
                    ////////Cell9.Add("\t\t\tVoiture Personnelle\n\nMarque : \nPuissance Fiscale : \nN° de plaque : ");
                    ////////file.AddTableCells(writer, Cell9, 50, YPos - (k * 8));
                    ////////////////////
                    //List<Object> Cell9 = new List<object>();
                    //if (TransportType == "PublicTransport")
                    //{
                    //    Cell9.Add("X)\n\nTransport Public");
                    //    Cell9.Add("..)\n\nVoiture de Mission\n\nMarque : \nN° de plaque : ");
                    //    Cell9.Add("..)\n\nVoiture Personnelle\n\nMarque : \nPuissance Fiscale : \nN° de plaque : ");
                    //    file.AddTableCells(writer, Cell9, 50, YPos - (k * 8));
                    //}
                    //if (TransportType == "MissionCar")
                    //{
                    //    Cell9.Add("..)\n\nTransport Public");
                    //    Cell9.Add("X)\n\nVoiture de Mission\n\nMarque : " + MissionCarmark + "\nN° de plaque : " + MissionCarPlatNumber);
                    //    Cell9.Add("..)\n\nVoiture Personnelle\n\nMarque : \nPuissance Fiscale : \nN° de plaque : ");
                    //    file.AddTableCells(writer, Cell9, 50, YPos - (k * 8));
                    //}
                    //if (TransportType == "PersonalCar")
                    //{
                    //    Cell9.Add("..)\n\nTransport Public");
                    //    Cell9.Add("..)\n\nVoiture Personnelle\n\nMarque : \nPuissance Fiscale : \nN° de plaque : ");
                    //    Cell9.Add("X)\n\nVoiture Personnelle\n\nMarque : " + PersonalCarmark + "\nPuissance Fiscale : " + PersonalCarPlatNumber + "\nN° de plaque : ");
                    //    file.AddTableCells(writer, Cell9, 50, YPos - (k * 8));
                    //}

                    ////Table Footer
                    //List<Object> Cell10 = new List<object>();
                    //Cell10.Add("Le Directeur d'Ismontic Tanger : \n\n" + FirstPersonne);
                    //Cell10.Add(Region + "\n\n" + SecondePersonne);
                    //file.AddTableCells(writer, Cell10, 50, YPos - (k * 16));

                    // 
                    PdfPTable table = new PdfPTable(3);
                    // Row 1 ( Mensieur , Matricule )
                    PdfPCell cell = new PdfPCell(new Phrase(Mensieur)) { Colspan = 2 };
                    cell.MinimumHeight = 30f;
                    
                    
                    PdfPCell cell2 = new PdfPCell(new Phrase("Matricule : " + Matricule));
                    cell2.MinimumHeight = 30f;
                    table.AddCell(cell);
                    table.AddCell(cell2);

                    // Row 2 (Categorie)
                    PdfPCell cell3 = new PdfPCell(new Phrase("Categorie : " + Category)) { Colspan = 3 } ;
                    cell3.MinimumHeight = 30f;
                    table.AddCell(cell3);

                    //Row 3 (Affectation)
                    PdfPCell cell4 = new PdfPCell(new Phrase("Affectation : " + Affectation, new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.BOLD , BaseColor.BLACK))) { Colspan = 3 };
                    cell3.MinimumHeight = 30f;
                    table.AddCell(cell4);

                    //Row 4 (Theme)
                    PdfPCell cell5 = new PdfPCell(new Phrase("Theme  : " + Theme)) { Colspan = 3 };
                    cell5.MinimumHeight = 30f;
                    table.AddCell(cell5);

                    //Row 5 (Departure Date , Departure Hour)
                    PdfPCell cell6 = new PdfPCell(new Phrase("Date de Depart : " + DepartureDate)) { Colspan = 2 };
                    cell6.MinimumHeight = 30f;
                    table.AddCell(cell6);

                    PdfPCell cell7 = new PdfPCell(new Phrase("Heure : " + DepartureHour)) ;
                    cell7.MinimumHeight = 30f;
                    table.AddCell(cell7);

                    // Row 6 (Return Date , return hour)
                    PdfPCell cell8 = new PdfPCell(new Phrase("Date de retour : " + ReturnDate)) { Colspan = 2 };
                    cell8.MinimumHeight = 30f;
                    table.AddCell(cell8);

                    PdfPCell cell9 = new PdfPCell(new Phrase("Heure : " + ReturnHour));
                    cell9.MinimumHeight = 30f;
                    table.AddCell(cell9);

                    // Row 7 (Message !)
                    PdfPCell cell10 = new PdfPCell(new Phrase("L'intéressé (e) Utilisera : ")) { Colspan = 3 };
                    cell10.MinimumHeight = 30f;
                    cell10.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell10.VerticalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell10);

                    //Row 8 (Transport Type)
                    if (TransportType == "PublicTransport")
                    {
                        PdfPCell cell11 = new PdfPCell(new Phrase("X)\n\nTransport Public", new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.BOLD, BaseColor.BLACK)));
                        cell11.MinimumHeight = 32f;
                        table.AddCell(cell11);

                        PdfPCell cell12 = new PdfPCell(new Phrase("..)\n\nVoiture de Mission\n\nMarque : \nN° de plaque : "));
                        cell12.MinimumHeight = 32f;
                        table.AddCell(cell12);

                        PdfPCell cell13 = new PdfPCell(new Phrase("..)\n\nVoiture Personnelle\n\nMarque : \nPuissance Fiscale : \nN° de plaque : "));
                        cell13.MinimumHeight = 32f;
                        table.AddCell(cell13);
                    }
                    if (TransportType == "MissionCar")
                    {
                        PdfPCell cell11 = new PdfPCell(new Phrase("..)\n\nTransport Public"));
                        cell11.MinimumHeight = 32f;
                        table.AddCell(cell11);

                        PdfPCell cell12 = new PdfPCell(new Phrase("X)\n\nVoiture de Mission\n\nMarque : " + MissionCarmark + " \nN° de plaque : " + MissionCarPlatNumber, new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.BOLD, BaseColor.BLACK)));
                        cell12.MinimumHeight = 32f;
                        table.AddCell(cell12);

                        PdfPCell cell13 = new PdfPCell(new Phrase("..)\n\nVoiture Personnelle\n\nMarque : \nPuissance Fiscale : \nN° de plaque : "));
                        cell13.MinimumHeight = 32f;
                        table.AddCell(cell13);
                    }
                    if (TransportType == "PersonalCar")
                    {
                        PdfPCell cell11 = new PdfPCell(new Phrase("..)\n\nTransport Public"));
                        cell11.MinimumHeight = 32f;
                        table.AddCell(cell11);

                        PdfPCell cell12 = new PdfPCell(new Phrase("..)\n\nVoiture de Mission\n\nMarque : \nN° de plaque : "));
                        cell12.MinimumHeight = 32f;
                        table.AddCell(cell12);

                        PdfPCell cell13 = new PdfPCell(new Phrase("X)\n\nVoiture Personnelle\n\nMarque : " + PersonalCarmark + "\nPuissance Fiscale : " + PersonalCarFiscalPower + "\nN° de plaque : " + PersonalCarPlatNumber, new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.BOLD, BaseColor.BLACK)));
                        cell13.MinimumHeight = 32f;
                        table.AddCell(cell13);
                    }

                    //PdfPCell cell14 = new PdfPCell(new Phrase("Le Directeur d'Ismontic Tanger : " + FirstPersonne)) { Colspan = 3 };
                    //cell14.MinimumHeight = 50f;
                    //table.AddCell(cell14);
                    PdfContentByte cb = writer.DirectContent;
                    table.TotalWidth = 500f;
                    table.WriteSelectedRows(0, -1, 50, 600, cb);
                    //Table Footer
                    //List<Object> Cell10 = new List<object>();
                    //Cell10.Add("Le Directeur d'Ismontic Tanger : \n\n" + FirstPersonne);
                    //Cell10.Add(Region + "\n\n" + SecondePersonne);
                    //file.AddTableCells(writer, Cell10, 50, 620 - (15 * 25));
                    PdfPTable table2 = new PdfPTable(2);
                    PdfPCell c1 = new PdfPCell(new Phrase("Le Directeur d'Ismontic Tanger : \n\n" + FirstPersonne, new Font( Font.FontFamily.TIMES_ROMAN, 12, Font.BOLD | Font.UNDERLINE, BaseColor.BLACK)));
                    
                    c1.MinimumHeight = 50f;
                    c1.HorizontalAlignment = Element.ALIGN_CENTER;
                    c1.VerticalAlignment = Element.ALIGN_CENTER;
                    table2.AddCell(c1);
                    PdfPCell c2 = new PdfPCell(new Phrase(Region + " :\n\n" + SecondePersonne, new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.BOLD | Font.UNDERLINE, BaseColor.BLACK)));
                    c2.MinimumHeight = 50f;
                    c2.HorizontalAlignment = Element.ALIGN_CENTER;
                    c2.VerticalAlignment = Element.ALIGN_CENTER;
                    table2.AddCell(c2);


                    PdfContentByte cb2 = writer.DirectContent;
                    table2.TotalWidth = 500f;
                    table2.WriteSelectedRows(0, -1, 50, 620 -(15*25), cb2);


                    // Create Footer
                    //1
                    file.CreateText(doc, writer, "Direction Régionale", doc.PageSize.Width / 2 -210, 620 - (15*35),true,false);
                    file.CreateText(doc, writer, "Nord-Ouest II", doc.PageSize.Width / 2 - 210, 620 - (15 * 36), true, false);
                    file.CreateText(doc, writer, "ISMONTIC", doc.PageSize.Width / 2 - 210, 620 - (15 * 37), true, false);
                    //2
                    file.CreateText(doc, writer, "Institut Spécialisé dans les Métieres d'offshoring  ", doc.PageSize.Width / 2, 620 - (15 * 35), true, false);
                    file.CreateText(doc, writer, "et les Nouvelles Technologies", doc.PageSize.Width / 2, 620 - (15 * 36), true, false);
                    file.CreateText(doc, writer, " de l'Information", doc.PageSize.Width / 2, 620 - (15 * 37),true,false);
                    //3
                    file.CreateText(doc, writer, "Km 06,Route Principale de Rabat 90000 -Tanger-", doc.PageSize.Width / 2, 620 - (15 * 38), false, true);
                    file.CreateText(doc, writer, "Tél : 0539 38 08 71   Email : istantic_tanger@menara.ma", doc.PageSize.Width / 2, 620 - (15 * 39), false, true);
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

            return "OrdreMission.pdf";

        }
    }
}
