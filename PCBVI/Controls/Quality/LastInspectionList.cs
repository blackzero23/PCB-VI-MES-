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
using PCBVI.Data;

namespace PCBVI.Controls.Quality
{
    public partial class LastInspectionList : UserControl
    {
        public LastInspectionList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            InitSetDataSource();
        }

        private void InitSetDataSource()
        {
            bdsItem.DataSource = DB.Item.GetAll();
            bdsWorkPlace.DataSource = DB.WorkPlace.GetAll();
        }

        public void SetDataSource(List<Data.LastInspection> list)
        {
            dgvList.DataSource = list;
        }

        public List<Data.LastInspection> GetUpateList()
        {
            return (List<Data.LastInspection>)dgvList.DataSource;
        }

        public LastInspection GetCurrentLow()
        {
            return dgvList.CurrentRow.DataBoundItem as Data.LastInspection;
        }

        public DataGridView GetListView()
        {
            return dgvList;
        }
    }
}
