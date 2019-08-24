using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data.Data;

namespace PCBVI.Controls.Production.MaterialsManage
{
    public partial class MaterialManageSearch : UserControl
    {
        public MaterialManageSearch()
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
            List<Data.Lot> lots = DB.Lot.GetAll();
            lots.Insert(0, new Data.Lot(""));
            bdsLot.DataSource = lots;

            List<Data.Process> processes = DB.Process.GetAll();
            processes.Insert(0, new Data.Process(""));
            bdsProcess.DataSource = processes;

            List<Data.MaterialState> materialStates = DB.MaterialState.GetAll();
            materialStates.Insert(0, new Data.MaterialState(""));
            bdsMaterialState.DataSource = materialStates;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int lotId = (int)cbbLotNo.SelectedValue;
            int proceesId = (int)cbbProcess.SelectedValue;
            int materialsId = (int)cbbMaterialState.SelectedValue;

            OnSearchButtonClicked(lotId, proceesId, materialsId);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int lotId, int processId, int workPlaceId)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(lotId, processId, workPlaceId);
            OnSearchButtonClicked(args);

            return args;
        }

        private SearchButtonClickedEventArgs OnSearchButtonClickedForOut()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }

        public class SearchButtonClickedEventArgs : EventArgs
        {
            public int LotId { get; set; }
            public int ProcessId { get; set; }
            public int WorkPlaceId { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int lotId, int processId, int workPlaceId)
            {
                LotId = lotId;
                ProcessId = processId;
                WorkPlaceId = workPlaceId;
            }
        }
        #endregion
    }
}
