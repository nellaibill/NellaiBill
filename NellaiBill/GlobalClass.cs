using System;
using System.Windows.Forms;

namespace NellaiBill
{
    public class GlobalClass
    {

        public GlobalClass()
        {

        }
        public  string DoFormat(double myNumber)
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
        public  void ClearFormControls(GroupBox form)
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
    }
}
