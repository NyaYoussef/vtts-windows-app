using App.Gwin.Application.Presentation;
using App.Gwin.Entities.Secrurity.Authentication;
using vtts.Entities.MissionManagement;
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
using App.Gwin.Components.Manager.DataGrid;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using vtts.Entities.MissionManagement.Enumeration;



namespace vtts.Presentation.PrintOrderMission
{
    public partial class FormPrintOrderMission : BaseForm, IFormSelectedEntityAction
    {
        MissionOrder MissionOrder = null;
        public string PathPDF = "";
        public FormPrintOrderMission()
        {
            InitializeComponent();
        }

        public void SetEntity(BaseEntity obj)
        {
            MissionOrder = obj as MissionOrder;
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
            printOrderMission.HeaderImgDirectory = @"C:\USers\DELL\Desktop\vtts-windows-app\Images\Header.png";
            printOrderMission.Ordre = MissionOrder.OrderNumber;
            printOrderMission.Date = MissionOrder.DateOrder;
            printOrderMission.Region = "Le Directeur Regional de la ";//+MissionOrder.MissionConvocation.Institution.Region;
            printOrderMission.City = "Tanger";

            if(MissionOrder.Staff.Sex)
            printOrderMission.Mensieur = "Monsieur   :  "+MissionOrder.Staff.LastName+"  "+MissionOrder.Staff.FirstName;
            if(!MissionOrder.Staff.Sex)
            printOrderMission.Mensieur = "Madame   :  " + MissionOrder.Staff.LastName + "  " + MissionOrder.Staff.FirstName;
            printOrderMission.Matricule = MissionOrder.Staff.RegistrationNumber;

            if (MissionOrder.Staff.Grade != null)
                printOrderMission.Category = MissionOrder.Staff.Grade.Name + "";
            else
              MessageBox.Show(new Exception("grade is null").ToString());


            printOrderMission.Affectation =  "I.S.M.N.T.I.C Tanger  "; //MissionOrder.MissionConvocation.Institution.Region.Name.Current;
            printOrderMission.Place = MissionOrder.MissionConvocation.Institution.Name.Current+"  ";//MissionOrder.MissionConvocation.Institution.Region.Name.Current
            printOrderMission.Theme = MissionOrder.MissionConvocation.Theme.Current;
            printOrderMission.DepartureDate = MissionOrder.DepartureDate.ToShortDateString();
            printOrderMission.ReturnDate = MissionOrder.ArrivalDate.ToShortDateString();
            printOrderMission.DepartureHour =MissionOrder.DepartureTime+ "h00";
            printOrderMission.ReturnHour = MissionOrder.ArrivingTime+"h00";
            printOrderMission.Category = MissionOrder.MissionConvocation.MissionCategory.Name.Current;
            //PublicTransport , MissionCar, PersonalCar
            printOrderMission.TransportType = MissionOrder.MeansTransportCategory.ToString();
            // In Other Cases

            if(printOrderMission.TransportType ==MeansTransportCategories.Public.ToString())

            {
                printOrderMission.MissionCarmark = MissionOrder.Car.Mark;
                printOrderMission.MissionCarPlatNumber = MissionOrder.Car.PlateNumber;
            }

            if(printOrderMission.TransportType == MeansTransportCategories.Voiture_Personnel.ToString()|| printOrderMission.TransportType == MeansTransportCategories.Voiture_de_Service.ToString())

            {
                printOrderMission.PersonalCarmark = MissionOrder.Car.Mark;
                printOrderMission.PersonalCarPlatNumber = MissionOrder.Car.PlateNumber;
                printOrderMission.PersonalCarFiscalPower = MissionOrder.Car.TaxPower+"";
            }


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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
