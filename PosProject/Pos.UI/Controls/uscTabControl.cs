using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Pos.Data;

namespace Pos.UI
{
    public partial class TabButton : DevExpress.XtraEditors.XtraUserControl
    {
        public TabButton()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            AddTab();
        }

        // 탭추가
        private void AddTab()
        {
            var names = DataRepository.IngredientsCategory.GetAllNames();
            foreach (var name in names)
            {
                var page = new DevExpress.XtraTab.XtraTabPage();
                page.Text = name;
                
                AddTable(page);
                uscTabControl.TabPages.Add(page);
                uscTabControl.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            }

        }
        // 테이블추가

        private void AddTable(DevExpress.XtraTab.XtraTabPage page)
        {
            var tableGrid = new TableLayoutPanel();

            tableGrid.ColumnCount = 4;
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableGrid.Location = new Point(3, 3);
            tableGrid.Name = "tlpButtonGrid";
            tableGrid.RowCount = 4;
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableGrid.Size = new Size(591, 481);
            tableGrid.TabIndex = 0;


            var categoryId = DataRepository.IngredientsCategory.GetIdByName(page.Text);
            FillTable(tableGrid, categoryId);
            page.Controls.Add(tableGrid);
        }

        // 버튼 추가
        private void FillTable(TableLayoutPanel tbl ,int categoryId)
        {
            var names = DataRepository.Ingredient.GetNamesOfCategory(categoryId);
            
            foreach(var name in names)
            {
                var button = new SimpleButton();
                button.Text = name;
                button.Size = new Size(150, 115);
                
                button.Click += new EventHandler(TabButton_Click);
                tbl.Controls.Add(button);
            }
        }

        private void TabButton_Click(object sender, EventArgs e)
        {
            OnTabButtonClicked(((SimpleButton)sender).Text);
        }

        #region TabButtonClicked event things for C# 3.0
        public event EventHandler<TabButtonClickedEventArgs> TabButtonClicked;

        protected virtual void OnTabButtonClicked(TabButtonClickedEventArgs e)
        {
            if (TabButtonClicked != null)
                TabButtonClicked(this, e);
        }

        private TabButtonClickedEventArgs OnTabButtonClicked(string buttonText)
        {
            TabButtonClickedEventArgs args = new TabButtonClickedEventArgs(buttonText);
            OnTabButtonClicked(args);

            return args;
        }

        private TabButtonClickedEventArgs OnTabButtonClickedForOut()
        {
            TabButtonClickedEventArgs args = new TabButtonClickedEventArgs();
            OnTabButtonClicked(args);

            return args;
        }

        public class TabButtonClickedEventArgs : EventArgs
        {
            public string ButtonText { get; set; }

            public TabButtonClickedEventArgs()
            {
            }

            public TabButtonClickedEventArgs(string buttonText)
            {
                ButtonText = buttonText;
            }
        }
        #endregion
    }
}
