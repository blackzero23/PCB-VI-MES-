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

namespace PCBVI.Controls.Basic.ErrorCode
{
    public partial class ErrorCodeSearch : UserControl
    {
       

        public ErrorCodeSearch()
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

        public void InitSetDataSource()
        {
            List<Data.ErrorCode> errorCodes = DB.ErrorCode.GetAll();
            errorCodes.Insert(0, new Data.ErrorCode(""));
            cbbErrorCode.DataSource = errorCodes;

            List<Data.ErrorType> errorTypes = DB.ErrorType.GetAll();
            errorTypes.Insert(0, new Data.ErrorType(""));
            cbbErrorType.DataSource = errorTypes;

            var errorKinds = DB.ErrorKind.GetAll();
            errorKinds.Insert(0, new Data.ErrorKind(""));
            cbbErrorKind.DataSource = errorKinds;
        }


        //usc형태의 콤보박스바인딩
        //콤보박스바인딩
        //
        //매개변수 List< >using이 적용이 안되는 이유는 겹치는 부분이 존재하는것으로 추정.ㅣ

        #region SearchClicked event things for C# 3.0
        public event EventHandler<SearchClickedEventArgs> SearchClicked;

        protected virtual void OnSearchClicked(SearchClickedEventArgs e)
        {
            if (SearchClicked != null)
                SearchClicked(this, e);
        }

        private SearchClickedEventArgs OnSearchClicked(int errorCodeId, int errorTypeId, int errorKindId)
        {
            SearchClickedEventArgs args = new SearchClickedEventArgs(errorCodeId, errorTypeId, errorKindId);
            OnSearchClicked(args);

            return args;
        }

        private SearchClickedEventArgs OnSearchClickedForOut()
        {
            SearchClickedEventArgs args = new SearchClickedEventArgs();
            OnSearchClicked(args);

            return args;
        }

        public class SearchClickedEventArgs : EventArgs
        {
            public int ErrorCodeId { get; set; }
            public int ErrorTypeId { get; set; }
            public int ErrorKindId { get; set; }

            public SearchClickedEventArgs()
            {
            }

            public SearchClickedEventArgs(int errorCodeId, int errorTypeId, int errorKindId)
            {
                ErrorCodeId = errorCodeId;
                ErrorTypeId = errorTypeId;
                ErrorKindId = errorKindId;
            }
        }
        #endregion

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int code = (int)cbbErrorCode.SelectedValue;
            int type = (int)cbbErrorType.SelectedValue;
            int kind = (int)cbbErrorKind.SelectedValue;
            

            OnSearchClicked(code, type, kind);            
        }
    }
}
