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
    public partial class SelectedFilePanel : UserControl
    {
        public SelectedFilePanel()
        {
            InitializeComponent();
        }

        private int _ly = 10;

        public List<string> GetPathList
        {
            get
            {
                return this.Controls.OfType<SelectedFileTool>().Select(tool => tool.Path).ToList();
            }
        }

        public void AddTool(List<string> pathList) 
            // attach edilen belgeler etrafındaki çerçeveyle beraber gösteriliyor.
        {

            foreach (var item in pathList)
            {
                var fn = item.Split('\\');

                var fname = fn[fn.Length - 1];

                var tool = new SelectedFileTool
                {
                    FileName = fname,
                    Parent = this,
                    Location = new Point(5, _ly),
                    Path = item
                };

                this.Controls.Add(tool);

                _ly += 35;
            }
        }

        private void SelectedFilePanel_Load(object sender, EventArgs e)
        {

        }

        public void RefreshLocation() // eklenen belge iptal edilmek istendiğinde çerçevedeki (x) e basınca çerçeve görünmeyecek. 
        {                             // diğer eklenen belgelerin konumlarının yenilenmesini sağlıyor..
            _ly = 10;

            foreach (Control cntr in this.Controls)
            {
                if (cntr is SelectedFileTool)
                {
                    cntr.Location = new Point(5, _ly);

                    _ly += 35;
                }

            }
        }


    }
}
