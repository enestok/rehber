using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace rehber
{
    public partial class ImportExcelCheckList : Form
    {

        System.Windows.Forms.ListBox _lstBox; 
        public ImportExcelCheckList(System.Windows.Forms.ListBox lstBox)
        {
            InitializeComponent();
            _lstBox = lstBox;
        }

        private void btnExcelIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcelTamam_Click(object sender, EventArgs e)
        {
            ImportToExcell();
        }

        ////
        //--> ImportToExcell() -->verileri excel e aktaran metod
        ////
        private void ImportToExcell()
        {
            if(checkedListBox1.CheckedItems.Count == 0)
                MessageBox.Show("Lütfen görüntülemek için en az 1 alan seçiniz.");
            else
            {
                Excel.Application ExcelApp = new Excel.Application();
                Workbook book1 = ExcelApp.Workbooks.Add();
                Worksheet sheet1 = (Worksheet)book1.Sheets[1];

                ExcelApp.Visible = true;
                ExcelApp.Worksheets[1].Activate();

                Excel.Range rng = (Excel.Range)sheet1.Rows[1];
                rng.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;


                for (int i = 1; i < checkedListBox1.CheckedItems.Count + 1; i++)
                {
                    ((Range)sheet1.Columns[i, Type.Missing]).ColumnWidth = 30;

                    sheet1.Cells[1, i].value = checkedListBox1.CheckedItems[i - 1].ToString().ToUpper();
                    sheet1.Cells[1, i].Font.Bold = true;
                }



                for (int i = 0; i < _lstBox.Items.Count; i++) //checkboxların indisine göre seçilen kolonlara gerekli girdileri yazdırıyor.
                {
                    var index = 1;
                    foreach (var item in checkedListBox1.CheckedIndices)
                    {
                        switch (Convert.ToInt32(item))
                        {
                            case 0: sheet1.Cells[i + 2, index].value = ((RehberModel)_lstBox.Items[i]).Isim; break;
                            case 1: sheet1.Cells[i + 2, index].value = ((RehberModel)_lstBox.Items[i]).Soyisim; break;
                            case 2: sheet1.Cells[i + 2, index].value = ((RehberModel)_lstBox.Items[i]).TelNo; break;
                            case 3: sheet1.Cells[i + 2, index].value = ((RehberModel)_lstBox.Items[i]).DogumTarihi;
                                sheet1.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft; break;
                            case 4: sheet1.Cells[i + 2, index].value = ((RehberModel)_lstBox.Items[i]).Cinsiyet; break;
                            case 5: sheet1.Cells[i + 2, index].value = ((RehberModel)_lstBox.Items[i]).IsTanimi; break;
                            default: { MessageBox.Show("Hay Aksi! İstenmeyen bir durum oluştu.", "Hata"); this.Close(); break; }
                        }
                        index++;
                        
                    }

                }

                this.Close();

            }
            

         }

        private void ImportExcelCheckList_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("asd");
        }

        
    }
}
