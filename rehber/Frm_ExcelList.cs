using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rehber
{
    public partial class Frm_ExcelList : BaseRadForm
    {
        public Frm_ExcelList()
        {
            InitializeComponent();
        }

      
        public new List<RehberModel> SelectedPerson { get; set; }

        private List<RehberModel> _excelKisiList;
        private void txtExcelKisiAra_TextChanged(object sender, EventArgs e)
        {
            if (txtExcelKisiAra.TextLength > 0)
            {
                ((ListBox)chkLstExcelKisiler).DataSource = _excelKisiList.Where(q => q.GenelBilgi.Contains(txtExcelKisiAra.Text)).ToList();
                ((ListBox)chkLstExcelKisiler).ValueMember = "KullaniciID";
                ((ListBox)chkLstExcelKisiler).DisplayMember = "GenelBilgi";

                return;
            }

            ((ListBox)chkLstExcelKisiler).DataSource = _excelKisiList;
            ((ListBox)chkLstExcelKisiler).ValueMember = "KullaniciID";
            ((ListBox)chkLstExcelKisiler).DisplayMember = "GenelBilgi";
        }

        public void KisiListele()
        {
            _excelKisiList = new RehberBL().RehberList();
            ((ListBox)chkLstExcelKisiler).DataSource = _excelKisiList;
            ((ListBox)chkLstExcelKisiler).ValueMember = "KullaniciID";
            ((ListBox)chkLstExcelKisiler).DisplayMember = "GenelBilgi"; 

        }

        private void Frm_ExcelList_Load(object sender, EventArgs e)
        {
            KisiListele();

            AutoCompleteStringCollection chkLstString = new AutoCompleteStringCollection();

            foreach (RehberModel model in _excelKisiList)
            {
                chkLstString.Add(model.GenelBilgi);
            }

            txtExcelKisiAra.AutoCompleteCustomSource = chkLstString;

        }

       
        public bool Selected()
        {
            SelectedPerson = new List<RehberModel>();

            if (chkLstExcelKisiler.CheckedItems.Count != 0)
            {
                foreach (var rm in chkLstExcelKisiler.CheckedItems)
                {
                    SelectedPerson.Add(((RehberModel) rm));
                }
                return true;
            }
            else
            {
                MessageBox.Show(" Kayıt seçilmedi! ");
                return false;
            }

            
        }

        private void btnExcelAliciSec_Click(object sender, EventArgs e)
        {
            if (Selected())
            {
                Close();
            }
        }

        private void chkTumunuSec_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (chkTumunuSec.Checked)
            {
                for (int i = 0; i < chkLstExcelKisiler.Items.Count; i++)
                {
                    chkLstExcelKisiler.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < chkLstExcelKisiler.Items.Count; i++)
                {
                    chkLstExcelKisiler.SetItemChecked(i, false);
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
