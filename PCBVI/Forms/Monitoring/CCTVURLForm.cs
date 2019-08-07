using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace PCBVI.Forms.Monitoring
{
    public partial class CCTVURLForm : KryptonForm
    {
        public CCTVURLForm()
        {
            InitializeComponent();
        }

        private string url;

        public string URL
        {
            get { return url; }
        }

        public string[] URLs
        {
            set
            {
                cbbURL.Items.AddRange(value);
            }
        }

        public string Description
        {
            get { return lbDescription.Text; }
            set { lbDescription.Text = value; }
        }

        //버튼 옵션에 DirlogRejult 설정해야됨 필수.
        private void KryptonButton1_Click(object sender, EventArgs e)
        {
            url = cbbURL.Text;
        }
    }
}
