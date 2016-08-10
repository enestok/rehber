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
    public partial class Frm_AliciEkle : Form
    {
        public Frm_AliciEkle()
        {
            InitializeComponent();
        }

        private List<RehberModel> _mailList;

        public new List<string> Choose { get; set; } //Frm_ePostaOlustur un nesnelerine ( txtAliciMail ) erişebilmek için referans olması için "get set" kullandık.
        

        private void txtAliciAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAliciAra.TextLength > 0)
            {
                ((ListBox)chkLstKisiler).DataSource = _mailList.Where(q => q.MailListe.Contains(txtAliciAra.Text)).ToList();
                ((ListBox)chkLstKisiler).ValueMember = "KullaniciID";
                ((ListBox)chkLstKisiler).DisplayMember = "MailListe";

                return;
            }

            ((ListBox)chkLstKisiler).DataSource = _mailList;
            ((ListBox)chkLstKisiler).ValueMember = "KullaniciID";
            ((ListBox)chkLstKisiler).DisplayMember = "MailListe";
        }

        private void Frm_AliciEkle_Load(object sender, EventArgs e)
        {
            AliciListele();

            AutoCompleteStringCollection chkLstString = new AutoCompleteStringCollection();

            foreach (RehberModel model in _mailList)
            {
                chkLstString.Add(model.MailListe);
            }

            txtAliciAra.AutoCompleteCustomSource = chkLstString;

            

        }

        public void AliciListele()
        {
            _mailList = new RehberBL().RehberList();
            ((ListBox)chkLstKisiler).DataSource = _mailList;
            ((ListBox)chkLstKisiler).ValueMember = "KullaniciID";
            ((ListBox)chkLstKisiler).DisplayMember = "MailListe"; // MailListe, RehberModel'in içinde "İsim + Soyisim + Email" bilgilerini birlikte tutan liste elemanı.

        }

        public bool Selected()
        {
            var chosen = new List<string>();

            if (chkLstKisiler.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen görüntülemek için en az 1 alan seçiniz.");
                return false;
            }
            else
            {
                foreach (var rm in chkLstKisiler.CheckedItems)
                {
                    chosen.Add(((RehberModel)rm).EMail);
                }
               
            }

            Choose = chosen;

            return true;
        }

        private void btnAliciSec_Click(object sender, EventArgs e)
        {
            if (Selected())
            {
                Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
