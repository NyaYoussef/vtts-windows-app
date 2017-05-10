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
    [App.Gwin.Attributes.Menu( EntityType = typeof(MissionConvocation))]
    public partial class FormPrintOrderMission : Form
    {
        public FormPrintOrderMission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;

            // Print Document wi Spire Library
            Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
            doc.LoadFromFile(appRootDir + "/PDFs/" + "OrdreMission.pdf");


            var ppd = new PrintPreviewDialog();
            ppd.Document = doc.PrintDocument;
            ppd.ShowDialog(this); // renders Image1 attached


            printPreviewDialog1.Document = doc.PrintDocument;

            //Use the default printer to print all the pages 
            //doc.PrintDocument.Print(); 

            //Set the printer and select the pages you want to print 

            //PrintDialog dialogPrint = new PrintDialog();
            //dialogPrint.AllowPrintToFile = true;
            //dialogPrint.AllowSomePages = true;
            //dialogPrint.PrinterSettings.MinimumPage = 1;
            //dialogPrint.PrinterSettings.MaximumPage = doc.Pages.Count;
            //dialogPrint.PrinterSettings.FromPage = 1;
            //dialogPrint.PrinterSettings.ToPage = doc.Pages.Count;

            //if (dialogPrint.ShowDialog() == DialogResult.OK)
            //{
            //    //Set the pagenumber which you choose as the start page to print 
            //    doc.PrintFromPage = dialogPrint.PrinterSettings.FromPage;
            //    //Set the pagenumber which you choose as the final page to print 
            //    doc.PrintToPage = dialogPrint.PrinterSettings.ToPage;
            //    //Set the name of the printer which is to print the PDF 
            //    doc.PrinterName = dialogPrint.PrinterSettings.PrinterName;

            //    PrintDocument printDoc = doc.PrintDocument;
            //    dialogPrint.Document = printDoc;
            //    printDoc.Print();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create PDF Document with ItextSharp
            string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
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
                    doc.Add(new Paragraph("Hello World"));

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
        }
    }
}
