using App.Gwin.Application.Presentation;
using App.Gwin.Entities.Secrurity.Authentication;
using Entities.MissionManagement;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtts.Presentation.PrintOrderMission
{
    [App.Gwin.Attributes.Menu( EntityType = typeof(MissionConvocation),Order = 10, Title = "PrintMissionOrder")]
    public partial class FormPrintOrderMission : BaseForm
    {

        public string PathPDF = "";
        public FormPrintOrderMission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void FormPrintOrderMission_Load(object sender, EventArgs e)
        {
            vtts.BAL.MissionManagement.PrintOrderMission printOrderMission = new vtts.BAL.MissionManagement.PrintOrderMission();
            //
            printOrderMission.HeaderImgDirectory = @"C:\USers\DELL\Desktop\vtts-windows-app\Images\Header.png";
            printOrderMission.Ordre = "OFP/DRNOII/ISMONTIC/OM/N° 13/17";
            printOrderMission.Date = DateTime.Now;
            printOrderMission.Region = "Le Directeur Regional de la DRNOII";
            printOrderMission.City = "Tanger";
            printOrderMission.Mensieur = "Monsieur   :   Bouybanin Anass";
            printOrderMission.Matricule = " 13716";
            printOrderMission.Category = "Cadre Principale";
            printOrderMission.Affectation = "I.S.M.O.N.T.I.C Tanger";
            printOrderMission.Place = "CDC TIC Casa Blanca";
            printOrderMission.Theme = "Pour assister aux atelier NETACAD CISCO";
            printOrderMission.DepartureDate = "24/04/2017";
            printOrderMission.ReturnDate = "29/04/2017";
            printOrderMission.DepartureHour = "13h00";
            printOrderMission.ReturnHour = "13h00";
            //PublicTransport , MissionCar, PersonalCar
            printOrderMission.TransportType = "PublicTransport";
            // In Other Cases
            //if(printOrderMission.TransportType == "MissionCar")
            //{
            //    printOrderMission.MissionCarmark = "Mark";
            //    printOrderMission.MissionCarPlatNumber = "Numero de plaque";
            //}
            //if(printOrderMission.TransportType == "PersonalCar")
            //{
            //    printOrderMission.PersonalCarmark = "Mark";
            //    printOrderMission.PersonalCarPlatNumber = "Numero de plaque";
            //    printOrderMission.PersonalCarFiscalPower = "Puissance Fiscale";
            //}
            //

            printOrderMission.FirstPersonne = "Abdelhamid ELMECHRAFI";
            printOrderMission.SecondePersonne = "Abdelmoula SADIK";
            this.PathPDF = printOrderMission.CreatePDF();


            // Print Document with Spire Library
            Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
            doc.LoadFromFile(this.PathPDF);

            printPreviewControl1.Document = doc.PrintDocument;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            


            // Print Document with Spire Library
            Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
            doc.LoadFromFile(this.PathPDF);


            //var ppd = new PrintPreviewDialog();
            //ppd.Document = doc.PrintDocument;
            //ppd.ShowDialog(this); // renders Image1 attached


            //printPreviewDialog1.Document = doc.PrintDocument;

            ///////
            ////Use the default printer to print all the pages 
            //doc.PrintDocument.Print();

            //Set the printer and select the pages you want to print 

            PrintDialog dialogPrint = new PrintDialog();
            dialogPrint.AllowPrintToFile = true;
            dialogPrint.AllowSomePages = true;
            dialogPrint.PrinterSettings.MinimumPage = 1;
            dialogPrint.PrinterSettings.MaximumPage = doc.Pages.Count;
            dialogPrint.PrinterSettings.FromPage = 1;
            dialogPrint.PrinterSettings.ToPage = doc.Pages.Count;

            if (dialogPrint.ShowDialog() == DialogResult.OK)
            {
                //Set the pagenumber which you choose as the start page to print 
                doc.PrintFromPage = dialogPrint.PrinterSettings.FromPage;
                //Set the pagenumber which you choose as the final page to print 
                doc.PrintToPage = dialogPrint.PrinterSettings.ToPage;
                //Set the name of the printer which is to print the PDF 
                doc.PrinterName = dialogPrint.PrinterSettings.PrinterName;

                PrintDocument printDoc = doc.PrintDocument;
                dialogPrint.Document = printDoc;
                printDoc.Print();
            }
        }
    }
}
