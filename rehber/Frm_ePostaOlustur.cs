using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Net.Mail;

namespace rehber
{
    public partial class Frm_ePostaOlustur : Form
    {
        public Frm_ePostaOlustur()
        {
            InitializeComponent();
            
        }


        public bool MailGonder(string konu, string icerik)
        {
            string GonderenMail = txtGonderenMail.Text;
            string GonderenSifre = txtGonderenSifre.Text; 
            string AliciMail = txtAliciMail.Text;
            string MailKonu = txtKonu.Text;
            string MailIcerik = txtRichMesaj.Text;

            MailMessage ePosta = new MailMessage();

            ePosta.From = new MailAddress("" + GonderenMail + "");  // gönderici 

            
            var splitMails = AliciMail.Split(';').ToList();   
            foreach (string hasSplitted in splitMails)
            {
                if ( hasSplitted.Trim() != "")
                {
                    try
                    {
                        ePosta.To.Add(hasSplitted.Trim().ToString());  // alıcı
                    }
                    catch (FormatException e)
                    {
                        MessageBox.Show("bilgilerinizi kontrol ediniz..." + "\n " + "farklı adresler arasında ';' kullanmayı unutmayın. "+"\n \n" + e);
                        return false;
                    }
                        
                }
                
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

            object userState = ePosta;
            bool kontrol = true;

            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
                //smtp.Send(ePosta);

                MessageBox.Show("mail gönderildi."); 
            }
            catch (Exception e)
            {
                kontrol = false;
                MessageBox.Show(" mail gönderme işlemi başarısız! " + "\n \n" + e );
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

            openFileDialog1.ShowDialog();

            List<string> pathList = openFileDialog1.FileNames.ToList(); //path listesi

            selectedFilePanel1.AddTool(pathList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RefreshLocation();
            //MessageBox.Show(txtRichMesaj.Rtf);
        }

        private void txtAliciMail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Frm_ePostaOlustur_Load(object sender, EventArgs e)
        {
            txtGonderenMail.Text = 
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

      

    }
}
