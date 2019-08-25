﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data.Data;

namespace PCBVI.Forms.Production
{
    public partial class WorkOrderForm : Form
    {
        public WorkOrderForm()
        {
            InitializeComponent();
        }

        private int _itemId;
        private int _rotationId;
        private DateTime _fromDate;
        private DateTime _toDate;

        private void WorkOrderSearchControl1_SearchButtonClicked(object sender, Controls.Production.WorkOrder.WorkOrderSearchControl.SearchButtonClickedEventArgs e)
        {
            uscList.SetDataSource(DB.WorkOrder.Search(e.ItemId,e.RotationId,e.FromDate,e.ToDate));
            _itemId = e.ItemId;
            _rotationId = e.RotationId;
            _fromDate = e.FromDate;
            _toDate = e.ToDate;
        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new WorkOrderInsertForm());
            uscList.InitSetDataSource();
        }

        private void UscTopMenu_UpdateButtonClicked(object sender, Controls.CommonControl.TopMenubar.UpdateButtonClickedEventArgs e)
        {
            List<Data.WorkOrder> workOrders = uscList.GetUpateList();

            if (workOrders == null)
                return;

            uscTopMenu.UpdateAll(workOrders);
            MessageBox.Show("저장이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UscTopMenu_ExcelButtonClicked(object sender, Controls.CommonControl.TopMenubar.ExcelButtonClickedEventArgs e)
        {
            DataGridView data = uscList.GetListView();

            string fileName = null;
            string filePath = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "저장경로 지정하세요.";
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.Filter = " Excel97 - 2003 통합문서(*.xls) | *.xls | Excle 통합 문서(*.xlsx)| *.xlsx ";
            //saveFileDialog.Filter = "Excle 통합 문서(*.xlsx)| *.xlsx | Excel97 - 2003 통합문서(*.xls) | *.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                filePath = Path.GetFullPath(saveFileDialog.FileName);
                uscTopMenu.SaveExcelFile(data, filePath, fileName);

            }
        }

        private void UscTopMenu_DeleteButtonClicked(object sender, Controls.CommonControl.TopMenubar.DeleteButtonClickedEventArgs e)
        {
            Data.WorkOrder workOrder = uscList.GetCurrentLow();
            if (workOrder == null)
                return;
            uscTopMenu.DeleteAt(workOrder);

            uscList.SetDataSource(DB.WorkOrder.Search(_itemId, _rotationId, _fromDate, _toDate));

            MessageBox.Show("삭제가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
