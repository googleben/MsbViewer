using SoulsFormats;
using System.ComponentModel;

namespace MsbViewer
{
    
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            LoadMSBs(@"\\WyattServer\Ben\EldenRing\Data2\map\mapstudio");
            //LoadMSBs(@"D:\EldenRing\data2y\map\mapstudio");
            InitializeComponent();
            //msbListControl.Columns.Clear();
            msbListControl.AutoGenerateColumns = false;
            msbItemsDgv.AutoGenerateColumns = false;
            msbItemListInnerDgv.AutoGenerateColumns = false;
            this.msbListControl.DataSource = this.msbs;
            //msbListControl.DataMember = "NameWrapper";
            msbListControl.Columns[0].DataPropertyName = "Name";
        }

        BindingList<MsbWrapper> msbs = new();

        void LoadMSBs(string folderPath)
        {
            List<MsbWrapper> ans = new();
            foreach (var file in Directory.GetFiles(folderPath)) {
                if (!file.EndsWith(".msb")) continue;
                ans.Add(new MsbWrapper(file, Path.GetFileNameWithoutExtension(file)));
            }
            ans.Sort();
            msbs = new BindingList<MsbWrapper>(ans);
        }

        private void msbListControl_SelectionChanged(object sender, EventArgs e)
        {
            msbItemsDgv.DataSource = null;
            msbItemListInnerDgv.DataSource = null;
            msbItemListItemDgv.DataSource = null;
            if (msbListControl.SelectedCells.Count > 0) {
                MsbWrapper msb = (MsbWrapper)msbListControl.SelectedCells[0].OwningRow.DataBoundItem;
                msbItemsDgv.DataSource = msb;
                msbItemsDgv.DataMember = "Items";
                msbItemsDgv.Columns[0].DataPropertyName="Name";
            }
        }

        private void msbItemsDgv_SelectionChanged(object sender, EventArgs e)
        {
            msbItemListInnerDgv.DataSource = null;
            msbItemListItemDgv.DataSource = null;
            if (msbItemsDgv.SelectedCells.Count > 0) {
                MsbItemList list = (MsbItemList)msbItemsDgv.SelectedCells[0].OwningRow.DataBoundItem;
                msbItemListInnerDgv.DataSource = list;
                msbItemListInnerDgv.DataMember = "Items";
                msbItemListInnerDgv.Columns[0].DataPropertyName = "Name";
            }
        }
        private class ItemListItem
        {
            public string Name { get; set; }
            public object? Value { get; set; }
            public ItemListItem(string name, object? value)
            {
                this.Name = name;
                this.Value = value;
            }
        }

        private static BindingList<object> makeObjBinding(object o)
        {
            BindingList<object> ans = new BindingList<object>();
            var t = o.GetType();
            foreach (var f in t.GetProperties()) {
                var val = f.GetValue(o);
                ans.Add(new ItemListItem(f.Name, val));
            }
            return ans;
        }

        private void msbItemListInnerDgv_SelectionChanged(object sender, EventArgs e)
        {
            msbItemListItemDgv.DataSource = null;
            if (msbItemListInnerDgv.SelectedCells.Count > 0) {
                object item = (object)msbItemListInnerDgv.SelectedCells[0].OwningRow.DataBoundItem;
                msbItemListItemDgv.AutoGenerateColumns = true;
                msbItemListItemDgv.DataSource = makeObjBinding(item);
                //msbItemListItemDgv.DataMember = "Value";
                msbItemListItemDgv.Columns[0].DataPropertyName = "Name";
            }
        }
    }
}