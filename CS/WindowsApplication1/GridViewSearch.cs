using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace WindowsApplication1
{
    public partial class GridViewSearch : UserControl
    {
        public GridViewSearch()
        {
            InitializeComponent();
        }


        private GridColumn _SearchColumn;
        public GridColumn SearchColumn
        {
            get { return _SearchColumn; }
            set { _SearchColumn = value; }
        }

        private string _SearchText;
        public string SearchText
        {
            get { return _SearchText; }
            set { _SearchText = value; OnSearchTextChanged(); }
        }

        private void OnSearchTextChanged()
        {
            btSearch.Text = _SearchText;
        }

        GridView GetSearchGridView()
        {
            return SearchColumn.View as GridView;
        }

        int FindRow(int startRowHandle, bool isForward)
        {
            if (SearchColumn == null) return GridControl.InvalidRowHandle;
            startRowHandle = Math.Max(0, startRowHandle);
            GridView view = GetSearchGridView();
            try
            {
                int delta = isForward ? 1 : -1;
                int n = startRowHandle;
                while (view.IsValidRowHandle(n))
                {
                    n += delta;

                    string cellText = GetSearchGridView().GetRowCellDisplayText(n, SearchColumn);
                    if (cellText.Contains(SearchText)) return n;

                }
            }
            catch { }
            return GridControl.InvalidRowHandle;
        }

        private void FocusNextRow(bool isForward)
        {
            GridView searchGridView = GetSearchGridView();
            int focusedRowHandle = FindRow(searchGridView.FocusedRowHandle, isForward);
            searchGridView.FocusedRowHandle = focusedRowHandle;
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FocusNextRow(!e.Button.IsLeft);
        }

        private void btSearchChanged(object sender, EventArgs e)
        {
            SearchText = btSearch.Text;
        }
    }
}
