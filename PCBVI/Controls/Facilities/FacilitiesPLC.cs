﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBVI.Controls.Facilities
{
    public partial class FacilitiesPLC : UserControl
    {
        public FacilitiesPLC()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Data.FacilitiesPower> list)
        {
            dgvList.DataSource = list;
        }
    }
}
