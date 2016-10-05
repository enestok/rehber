using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Net.Mail;
using Telerik.WinControls;

namespace rehber
{
    public partial class Frm_ePostaOlustur : BaseRadForm
    {
        public Frm_ePostaOlustur()
        {
            InitializeComponent();
            
        }

        FrmRehber _frmRehber = new FrmRehber();
        FrmNewPerson _frmNewPerson = new FrmNewPerson();

        private List<RehberModel> _rehberList; 
        public bool MailGonder(string konu, string icerik)
        {
            string GonderenMail = txtGonderenMail.Text;
            string GonderenSifre = txtGonderenSifre.Text; 
            string AliciMail = txtAliciMail.Text;
            string MailKonu = txtKonu.Text;
            string MailIcerik = txtRichMesaj.Text;

            MailMessage ePosta = new MailMessage();

            if (_frmNewPerson.IsMailAddress(GonderenMail) && GonderenSifre != "")
            {
                try
                {
                    ePosta.From = new MailAddress("" + GonderenMail + "");  // gönderici 
                }
                catch (FormatException e)
                {
                    RadMessageBox.SetThemeName("TelerikMetro");
                    RadMessageBox.Show("Gönderici bilgilerini kontrol ediniz. \n \n" + e);
                }
                
            }
            else
            {
                RadMessageBox.SetThemeName("TelerikMetro");
                RadMessageBox.Show("Gönderen bilgilerini kontrol ediniz.");
            }
            
            if (_frmNewPerson.IsMailAddress(AliciMail))
            {
                var splitMails = AliciMail.Split(';').ToList();
                foreach (string hasSplitted in splitMails)
                {
                    if (hasSplitted.Trim() != "")
                    {
                        try
                        {
                            ePosta.To.Add(hasSplitted.Trim());  // alıcı
                        }
                        catch (FormatException e)
                        {
                            RadMessageBox.SetThemeName("TelerikMetro");
                            RadMessageBox.Show("Alıcı bilgilerini kontrol ediniz..." + "\n " + "farklı adresler arasında ';' kullanmayı unutmayın. " + "\n \n" + e);
                            return false;
                        }

                    }

                }
            }
            else
            {
                RadMessageBox.SetThemeName("TelerikMetro");
                RadMessageBox.Show("Alıcı Mail adresini kontrol ediniz.");
            }
            

            ePosta.Subject = MailKonu; // mail konusu\başlığı
            ePosta.Body = MailIcerik; // mail içeriği

            var files = selectedFilePanel1.GetPathList;

            if (files.Count > 0) 
            {
                foreach (var f in files)
                {
                    ePosta.Attachments.Add(new Attachment(f));
                }
               
            }
            //else if (result == DialogResult.Cancel)
            //{
                
            //}
            
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials= new NetworkCredential("" + GonderenMail + "", "" + GonderenSifre + "");


            smtp.Port = 587; // gmail port numarası
            smtp.Host = "smtp.gmail.com";

            smtp.EnableSsl = true;

            //if (txtGonderenMail.Text.Contains("@gmail.com"))
            //{
            //    smtp.Port = 587; // gmail port numarası
            //    smtp.Host = "smtp.gmail.com";
            //}
            //else if (txtGonderenMail.Text.Contains("@outlook.com"))
            //{
            //    smtp.Port = 587; // hotmail port numarası
            //    smtp.Host = "smtp.live.com";
            //}
 

           

            object userState = ePosta;
            bool kontrol = true;

            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
                //smtp.Send(ePosta);
                RadMessageBox.SetThemeName("TelerikMetro");
                RadMessageBox.Show("mail gönderildi."); 
            }
            catch (Exception e)
            {
                kontrol = false;
                RadMessageBox.SetThemeName("TelerikMetro");
                RadMessageBox.Show(" mail gönderme işlemi başarısız! " + "\n \n" + e);
                
                
            }

            return kontrol;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailGonder(txtKonu.Text, txtRichMesaj.Text);
        }

       

        private void btnGonder_MouseLeave(object sender, EventArgs e)
        {
            btnGonder.Image = Properties.Resources.sendOff;
        }

        private void btnGonder_MouseMove(object sender, MouseEventArgs e)
        {
            btnGonder.Image = Properties.Resources.sendOn;
        }

        private void btnAliciEkle_Click(object sender, EventArgs e)
        {
            Frm_AliciEkle _frmAlici = new Frm_AliciEkle();
            var result =   _frmAlici.ShowDialog();

            if (result == DialogResult.OK)
            {
                var secim = _frmAlici.Choose;
                
                for (int i = 0; i < secim.Count; i++)
                {
                    this.txtAliciMail.Text += secim[i] + ";";
                }
                
            }
        }

        private void btnAliciEkle_MouseMove(object sender, MouseEventArgs e)
        {
            btnAliciEkle.Image = Properties.Resources.iconAddOn_50x50;
        }

        private void btnAliciEkle_MouseLeave(object sender, EventArgs e)
        {
            btnAliciEkle.Image = Properties.Resources.iconAddd;
        }

        private void btnAddAttach_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Dosya Seç..";

            openFileDialog1.FileName = null;

            openFileDialog1.Multiselect = true;

            DialogResult result = new DialogResult();

            result = openFileDialog1.ShowDialog();
            

            if (result == DialogResult.OK)
            {
                lnkAttachTumunuTemizle.Show();
            }

            List<string> pathList = openFileDialog1.FileNames.ToList(); //path listesi

            //string[] fileNameSplit = new string[pathList.Count * 5];
            //string[] aa = new string[pathList.Count];
            //for (int i = 0; i < pathList.Count(); i++)
            //{
            //    fileNameSplit = pathList[i].Split('\\');
            //     aa[i] = fileNameSplit.Last();
                
            //}
          
            //selectedFilePanel1.AddTool(aa.ToList());
            selectedFilePanel1.AddTool(pathList);


            
        }

        private void Frm_ePostaOlustur_Load(object sender, EventArgs e)
        {
            var info = KullaniciBilgi.KullaniciBilgileri;
            txtGonderenMail.Text = info.kullaniciEMail; //giriş yapan kullanıcının mail adresini otomatik olarak gönderici mail adresi kısmına yazdırıyor.
            lnkAttachTumunuTemizle.Hide();
        }

        private void lnkTumunuTemizle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            selectedFilePanel1.Controls.Clear();
            selectedFilePanel1.RefreshLocation();
        }

        private void lnkAliciTemizle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtAliciMail.Clear();
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void radLabel3_Click(object sender, EventArgs e)
        {

        }

        private void radLabel4_Click(object sender, EventArgs e)
        {

        }

     
      

    }
}
