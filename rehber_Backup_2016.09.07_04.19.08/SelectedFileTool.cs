using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rehber
{

    public partial class SelectedFileTool : UserControl
    {
        private string _fileName;

        //public RichTextBox Parent { get; set; }
        public new SelectedFilePanel Parent { get; set; }

        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                lblFileName.Text = value;   // tool un içindeki linkLabel. Path yazan yer. Sadece dosya ismini yazdır..
            }
        }

        public SelectedFileTool()
        {
            InitializeComponent();
        }

        private void btnCancelAttach_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            Parent.RefreshLocation(); 
        }
    }
}
