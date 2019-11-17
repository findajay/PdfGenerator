using iText.Forms;
using iText.Forms.Fields;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanhackPdfGenerator.DataProcessor;

namespace VanhackPdfGenerator
{
    public partial class PdfUploader : Form
    {
        private static string SRCDocument = string.Empty;
        private static string OUTDocument = string.Empty;
        public PdfUploader()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form pdf generate action click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRender_Click(object sender, EventArgs e)
        {
            try
            {
                var isTrue = DataFieldProcessor.ProcessPdfFormFields(SRCDocument, OUTDocument);
                if (isTrue)
                {
                    MessageBox.Show("Pdf successfully rendered at output location. " + OUTDocument);
                }
                else
                {
                    MessageBox.Show("We are having some trouble in processing selected pdf.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// Get browsed location for source pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseSrc_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select file to be upload.";
            //which type file format you want to upload in database. just add them.
            openFileDialog1.Filter = "Select Valid Document(*.pdf;)|*.pdf;";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        srcPath.Text = path;
                        SRCDocument = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Get browsed location for destination pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseOut_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog2.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog2.Title = "Select file to be upload.";
            //which type file format you want to upload in database. just add them.
            openFileDialog2.Filter = "Select Valid Document(*.pdf;)|*.pdf;";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog2.FilterIndex = 1;
            try
            {
                if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog2.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog2.FileName);
                        outputPath.Text = path;
                        OUTDocument = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
