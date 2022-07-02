using Microsoft.Office.Interop.Word;
using NellaiBill.Donor;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CheckBox = System.Windows.Forms.CheckBox;

namespace NellaiBill
{
    public class GlobalClass
    {
        public GlobalClass()
        {

        }
        public string DoFormat(double myNumber)
        {
            return string.Format("{0:0.00}", myNumber);
        }
        public string GetReportPath()
        {
            //return "E:\\Dotnet\\NellaiBill\\NellaiBill\\CrystalReports\\";
            // return "D:\\Saleem\\reports\\";
            return System.Windows.Forms.Application.StartupPath + "\\CrystalReports\\";
        }
        public void DisplayMessage(string xMessage)
        {
            MessageBox.Show(xMessage);
        }
        public void AcceptOnlyNumeric(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        public void ClearFormControls(GroupBox form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    txtbox.Text = string.Empty;
                }
                else if (control is CheckBox)
                {
                    CheckBox chkbox = (CheckBox)control;
                    chkbox.Checked = false;
                }
                else if (control is RadioButton)
                {
                    RadioButton rdbtn = (RadioButton)control;
                    rdbtn.Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }
            }
        }
        public int getInteger(bool xBooleanValue)
        {
            return xBooleanValue == true ? 1 : 0;
        }
        public bool getBoolean(int xIntegerValue)
        {
            return xIntegerValue == 1 ? true : false;
        }
        //Create document method  
        public void CreateDocument(List<string> donorNames, List<string> donorAddress)
        {
            try
            {
                //Create an instance for word app  
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application  
                winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.  
                winword.Visible = false;

                //Create a missing variable for missing value  
                object missing = System.Reflection.Missing.Value;

                //Create a new document  
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                /*

               //Add header into the document  
               foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
               {
                   //Get the header range and add the header details.  
                   Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                   headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                   headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                   headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                   headerRange.Font.Size = 10;
                   headerRange.Text = "Header text goes here";
               }

               //Add the footers into the document  
               foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
               {
                   //Get the footer range and add the footer details.  
                   Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                   footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                   footerRange.Font.Size = 10;
                   footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                   footerRange.Text = "Footer text goes here";
               }
               /*
               //adding text to document  
               document.Content.SetRange(0, 0);
               document.Content.Text = "This is test document " + Environment.NewLine;

               //Add paragraph with Heading 1 style  
               Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
               object styleHeading1 = "Heading 1";
               para1.Range.set_Style(ref styleHeading1);
               para1.Range.Text = "Para 1 text";
               para1.Range.InsertParagraphAfter();

               //Add paragraph with Heading 2 style  
               Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
               object styleHeading2 = "Heading 2";
               para2.Range.set_Style(ref styleHeading2);
               para2.Range.Text = "Para 2 text";
               para2.Range.InsertParagraphAfter();
               */
                //Create a 5X5 table and insert some dummy record  
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);



                Table firstTable = document.Tables.Add(para1.Range, donorNames.Count - 1, 2, ref missing, ref missing);

                int i = 0;
                firstTable.Borders.Enable = 1;
                foreach (Row row in firstTable.Rows)
                {
                    foreach (Cell rowcell in row.Cells)
                    {
                        var myString = donorNames[row.Index] + "\r\n" + donorAddress[row.Index] + "\r\n";

                        rowcell.Range.Text = myString;
                        i += 1;
                        if (i % 2 == 0)
                        {
                            // document.Words.Last.InsertBreak(WdBreakType.wdPageBreak);
                            rowcell.Range.Text="\f";
                        }


                        //    //Header row  
                        //    if (rowcell.RowIndex == 1)
                        //    {
                        //        rowcell.Range.Text = "Column " + rowcell.ColumnIndex.ToString();
                        //        rowcell.Range.Font.Bold = 1;
                        //        //other format properties goes here  
                        //        rowcell.Range.Font.Name = "verdana";
                        //        rowcell.Range.Font.Name = "verdana";
                        //        rowcell.Range.Font.Size = 10;
                        //        //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
                        //        rowcell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                        //        //Center alignment for the Header cells  
                        //        rowcell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        //        rowcell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                        //    }
                        //    //Data row  
                        //    else
                        //    {

                        // }
                    }
                }

                //Save the document  
                object filename = @"d:\temp1.docx";
                document.SaveAs2(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                MessageBox.Show("Document created successfully !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
