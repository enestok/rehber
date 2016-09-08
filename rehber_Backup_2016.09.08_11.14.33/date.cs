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
    public partial class getDate : UserControl
    {
        public getDate()
        {
            InitializeComponent();
            YilDoldur();
        }

        private DateTime _tarih;
        public DateTime Tarih
        {
            get
            {
                var yil = comboBox1.SelectedItem ;
                var ay = numericUpDown2.Value;
                var gun = numericUpDown1.Value;

                _tarih = new DateTime(((KeyValuePair<int, int>)yil).Value, (int)ay, (int)gun);

                return _tarih;
            }
            set
            {
                _tarih = value;

                comboBox1.SelectedValue = value.Year;
                numericUpDown1.Value = value.Day;
                numericUpDown2.Value = value.Month;
            }
        }

        private void YilDoldur()
        {
            var yilList = new Dictionary<int, int>();

            for (int i = 0; i < (DateTime.Now.Year + 1) - 1900; i++)
            {
                yilList.Add(1900 + i, 1900 + i);
            }
            comboBox1.ValueMember = "Key";
            comboBox1.ValueMember = "Value";
            comboBox1.DataSource = yilList.ToList(); ;

            comboBox1.SelectedIndex = 1;
        }
    }
}
