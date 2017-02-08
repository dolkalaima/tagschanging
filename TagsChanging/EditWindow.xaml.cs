using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;


namespace TagsChanging
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow()
        {
            InitializeComponent();
        }

        private void CommandList_OnLoaded(object sender, RoutedEventArgs e)
        {
          string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
          Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();                                                                                         
          Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(path+@"\docs\KRP_Aist2_command.xlsm", 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
          Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[1];

            for (int i = 3; i <= 131; i++)
            {
                CommandList.Items.Add((ObjWorkSheet.Cells[i, 3] as Excel.Range).Text);
            }

            ObjExcel.Quit(); 
        }
    }
}
