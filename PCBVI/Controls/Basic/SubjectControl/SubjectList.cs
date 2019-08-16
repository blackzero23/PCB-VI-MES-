using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBVI.Controls.Basic.SubjectControl
{
    public partial class SubjectList : UserControl
    {
        public SubjectList()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
            //데이터 바인딩 곳에 데이터를 불러와서 넣는다.

           // dbsItem.DataSource = 
        }

        /*
        public void SetBarcodeDataSource(List<Item> list)
        {
            dgvList.DataSource = list;
        }
        */
    }
}
