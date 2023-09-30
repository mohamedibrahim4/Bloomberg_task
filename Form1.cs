using System;
using System.Windows.Forms;
//using System.Text.UTF8Encoding;
using Microsoft.Office.Interop;
namespace testWindowsblp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (txtresult.Text=="")
            {
                lblfilename.Visible = false;
                txtfileName.Visible = false;
                btnSave.Visible = false;
                for (int i = 1; i <= 25; i++)
                {
                    string[] numbers = { i.ToString() };
                    rbtntextRows.Items.AddRange(numbers);
                    rbtntextColumns.Items.AddRange(numbers);
                    rbtnResultRows.Items.AddRange(numbers);
                    rbtnResultColumns.Items.AddRange(numbers);

                }
                lblTextRows.Visible = false;
                lblTextColumns.Visible = false;
                lblResultRows.Visible = false;
                lblResultColumn.Visible = false;

                rbtntextRows.Visible = false;
                rbtntextColumns.Visible = false;
                rbtnResultRows.Visible = false;
                rbtnResultColumns.Visible = false;

            }
        }
        //object request = new object();
        String response;
        HtmlDocument html;
        string website;
        float price;



        private void button1_Click(object sender, EventArgs e)
        {
            website = "https://www.bloomberg.com/quote/SPY:US";
            dynamic  request = Microsoft.VisualBasic.Interaction.CreateObject("MSXML2.ServerXMLHTTP");
            request.open("Get", website, false);
            request.SetRequestHeader("if-modified-Since", "Sat, 1 Jan 2000 00:00:00 GMT");
            request.Send();
            
            if (request.Status == 200)
            {

                response = request.responseText;
                int StartindexPattern = response.LastIndexOf("<span class=\"priceText__06f600fa3e\">");

                //string gg ="changeAbsolute__cd26c98843 negative__d4d87cba99 animatedBackground__e12b56f780";
                //int j = gg.Length;

                //int StartindexPattern2 = response.LastIndexOf("<span class=\"changeAbsolute__cd26c98843 negative__d4d87cba99 animatedBackground__e12b56f780\">");
                //string specificNumber2 = response.Substring(StartindexPattern2 + 93, 8);

                string specificNumber = response.Substring(StartindexPattern + 36, 8);
                txtresult.Text = specificNumber ;
            }
            else
            {
                return;
            }
            if (txtresult.Text !="")
            {
                lblfilename.Visible = true;
                txtfileName.Visible = true;
                btnSave.Visible = true;

                lblTextRows.Visible = true;
                lblTextColumns.Visible = true;
                lblResultRows.Visible = true;
                lblResultColumn.Visible = true;

                rbtntextRows.Visible = true;
                rbtntextColumns.Visible = true;
                rbtnResultRows.Visible = true;
                rbtnResultColumns.Visible = true;
            }
            //CreateExcelSheet();


        }
    //    private void CreateExcelSheet()
    //    {
    //        Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

    //        if (xlApp == null)
    //        {
    //            MessageBox.Show("Excel is not properly installed!!");
    //            return;
    //        }


    //        Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
    //        Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
    //        object misValue = System.Reflection.Missing.Value;

    //        xlWorkBook = xlApp.Workbooks.Add(misValue);
    //        xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

    //        xlWorkSheet.Cells[1, 1] = "ID";
    //        xlWorkSheet.Cells[1, 2] = "Name";
    //        xlWorkSheet.Cells[2, 1] = "1";
    //        xlWorkSheet.Cells[2, 2] = "One";
    //        xlWorkSheet.Cells[3, 1] = "2";
    //        xlWorkSheet.Cells[3, 2] = "Two";
             


    //        xlWorkBook.SaveAs("D:\\csharp-Excel.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
    //        xlWorkBook.Close(true, misValue, misValue);
    //        xlApp.Quit();

    //        //Marshal.ReleaseComObject(xlWorkSheet);
    //        //Marshal.ReleaseComObject(xlWorkBook);
    //        //Marshal.ReleaseComObject(xlApp);

    //        MessageBox.Show("Excel file created , you can find the file D:\\csharp-Excel.xls");
        
    //}

        private void Save(object sender, EventArgs e)
        {
            if (txtfileName.Text == "")
            {
                errorProvider1.SetError(txtfileName, "Please Enter Name");
                //MessageBox.Show("Please enter File name");
                return;
            }
            else
            {
                errorProvider1.SetError(txtfileName, "");

            }
            if (rbtntextRows.SelectedIndex == -1)
            {
                errorProvider1.SetError(rbtntextRows, "Please Select text Rows");
                //MessageBox.Show("Please enter File name");
                return;
            }
            else
            {
                errorProvider1.SetError(rbtntextRows, "");

            }
            if (rbtntextColumns.SelectedIndex == -1)
            {
                errorProvider1.SetError(rbtntextColumns, "Please Select text Columns");
                //MessageBox.Show("Please enter File name");
                return;
            }
            else
            {
                errorProvider1.SetError(rbtntextColumns, "");

            }
            if (rbtnResultRows.SelectedIndex == -1)
            {
                errorProvider1.SetError(rbtnResultRows, "Please Select Result Rows");
                //MessageBox.Show("Please enter File name");
                return;
            }
            else
            {
                errorProvider1.SetError(rbtnResultRows, "");

            }
            if (rbtnResultColumns.SelectedIndex == -1)
            {
                errorProvider1.SetError(rbtnResultColumns, "Please Select Result Columns");
                //MessageBox.Show("Please enter File name");
                return;
            }
            else
            {
                errorProvider1.SetError(rbtnResultColumns, "");

            }

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            ////xlWorkSheet.Cells[1, 1] = "ID";
            ////xlWorkSheet.Cells[1, 2] = "Name";
            ////xlWorkSheet.Cells[2, 1] = "1";
            ////xlWorkSheet.Cells[2, 2] = "One";
            ////xlWorkSheet.Cells[3, 1] = "2";
            ////xlWorkSheet.Cells[3, 2] = "Two";
            //xlWorkSheet.Cells[1, 1] = "SPY:US";

            xlWorkSheet.Cells[int.Parse(rbtntextRows.SelectedItem.ToString()), int.Parse(rbtntextColumns.SelectedItem.ToString())] = "SPY:US";


            //xlWorkSheet.Cells[1, 2] = "Name";
            //xlWorkSheet.Cells[2, 1] = txtresult.Text;
            xlWorkSheet.Cells[int.Parse(rbtnResultRows.SelectedItem.ToString()), int.Parse(rbtnResultColumns.SelectedItem.ToString())] = txtresult.Text;





            xlWorkBook.SaveAs("E:\\"+txtfileName.Text+".xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            //Marshal.ReleaseComObject(xlWorkSheet);
            //Marshal.ReleaseComObject(xlWorkBook);
            //Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file D:\\" + txtfileName.Text + ".xls");
        }

        private void Clear(object sender, EventArgs e)
        {
            lblfilename.Visible = false;
            txtfileName.Visible = false;
            btnSave.Visible = false;
            txtresult.Text = "";
            lblTextRows.Visible = false;
            lblTextColumns.Visible = false;
            lblResultRows.Visible = false;
            lblResultColumn.Visible = false;

            rbtntextRows.Visible = false;
            rbtntextColumns.Visible = false;
            rbtnResultRows.Visible = false;
            rbtnResultColumns.Visible = false;
        }
    }
}
