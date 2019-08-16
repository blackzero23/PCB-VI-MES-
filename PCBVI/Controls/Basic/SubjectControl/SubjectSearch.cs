﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data.Data;

namespace PCBVI.Controls.Basic.SubjectControl
{
    public partial class SubjectSearch : UserControl
    {
        public SubjectSearch()
        {
            InitializeComponent();
        }

        //USC가 로드될때 이용하는곳.
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
            //데이터 바인딩 곳에 데이터를 불러와서 넣는다.
            bdsFirstDivision.DataSource = DB.FirstItemDivision.GetAll();

            bdsSecondDivision.DataSource =
                DB.SecondItemDivision.GetAll();
        }

       
        

    }
}
