using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace rehber
{
    public partial class ImportExcelCheckList : BaseRadForm
    {

        System.Windows.Forms.ListBox _lstBox; 
        public ImportExcelCheckList(System.Windows.Forms.ListBox lstBox)
        {
            InitializeComponent();
            _lstBox = lstBox;
        }

        private List<RehberModel> _secim;

        private void btnExcelTamam_Click(object sender, EventArgs e)
        {
            ImportToExcell();
        }

        ////
        //--> ImportToExcell() -->verileri excel e aktaran metod
        ////
       
        private void ImportToExcell()
        {
            if (chkExcelAlan.CheckedItems.Count == 0)
            {
                RadMessageBox.SetThemeName("TelerikMetro");
                RadMessageBox.Show("Lütfen görüntülemek için en az 1 alan seçiniz.");
                
            }
            else
            {
                Excel.Application ExcelApp = new Excel.Application();
                Workbook book1 = ExcelApp.Workbooks.Add();
                Worksheet sheet1 = (Worksheet)book1.Sheets[1];

                ExcelApp.Visible = true;
                ExcelApp.Worksheets[1].Activate();

                Excel.Range rng = (Excel.Range)sheet1.Rows[1];
                rng.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                for (int i = 1; i < chkExcelAlan.CheckedItems.Count + 1; i++)
                {
                    ((Range)sheet1.Columns[i, Type.Missing]).ColumnWidth = 30;

                    sheet1.Cells[1, i].value = chkExcelAlan.CheckedItems[i - 1].ToString().ToUpper();
                    sheet1.Cells[1, i].Font.Bold = true;
                }

                
                for (int i = 0; i < _secim.Count; i++)
                {
                    var index = 1;
                    foreach (var item in chkExcelAlan.CheckedIndices)
                    {
                        switch (Convert.ToInt32(item))
                        {
                            case 0:
                                sheet1.Cells[i + 2, index].value = _secim[i].Isim;
                                break;
                            case 1:
                                sheet1.Cells[i + 2, index].value = _secim[i].Soyisim;
                                break;
                            case 2:
                                sheet1.Cells[i + 2, index].value = _secim[i].TelNo;
                                break;
                            case 3:
                                sheet1.Cells[i + 2, index].value = _secim[i].DogumTarihi;
                                sheet1.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                                break;
                            case 4:
                                sheet1.Cells[i + 2, index].value = _secim[i].Cinsiyet;
                                break;
                            case 5:
                                sheet1.Cells[i + 2, index].value = _secim[i].IsTanimi;
                                break;
                            default:
                            {
                                RadMessageBox.SetThemeName("TelerikMetro");
                                RadMessageBox.Show("Hay Aksi! İstenmeyen bir durum oluştu.", "Hata");
                                this.Close();
                                break;
                            }
                        }
                        index++;

                    }
                }
               
               
                
                this.Close();
            }

        }
        private void ImportExcelCheckList_Load(object sender, EventArgs e)
        {
            chkExcelAlan.Enabled = false;
        }

        private void btnListedenSec_Click(object sender, EventArgs e)
        {
            var _frmExcelKisi = new Frm_ExcelList();
            var result = _frmExcelKisi.ShowDialog();

            if (result == DialogResult.OK)
            {
                _secim = _frmExcelKisi.SelectedPerson;
                chkExcelAlan.Enabled = true;

            }
        }

        private void btnExcelIptal_Click(object sender, EventArgs e)
        {
            Close();
        }


        


    }
}
