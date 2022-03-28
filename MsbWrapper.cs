using SoulsFormats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsbViewer
{
    internal class MsbWrapper : IComparable<MsbWrapper>
    {

        public string Name { get; }
        public string Path { get; }

        private MSBE? _msb;
        public MSBE Msb { 
            get {
                if (_msb == null) {
                    _msb = MSBE.Read(Path);
                    SetupLists();
                }
                return _msb;
            } 
        }
        private BindingList<MsbItemList> _items = new BindingList<MsbItemList>();
        public BindingList<MsbItemList> Items { get {
                if (_msb == null) { _ = this.Msb; }
                return _items;
            }
        }

        private void SetupLists()
        {
            Type t = Msb.GetType();
            foreach (var f in t.GetProperties()) {
                var curr = f.PropertyType;
                while (curr != null && curr.Name != "object") {
                    if (curr.Name.StartsWith("IMsbParam") || curr.Name.StartsWith("Param")) {
                        var fVal = f.GetValue(Msb);
                        foreach (var f2 in f.PropertyType.GetProperties()) {
                            if (!f2.PropertyType.Name.StartsWith("List")) continue;
                            var f2Val = f2.GetValue(fVal);
                            if (f2Val == null) continue;
                            var f2T = f2Val.GetType();
                            var toArray = f2T.GetMethod("ToArray");
                            if (toArray == null) throw new NullReferenceException("ToArray was null on List");
                            var arr = toArray.Invoke(f2Val, null);
                            if (arr == null) throw new NullReferenceException("ToArray result was null on List");
                            Items.Add(new MsbItemList($"{f.Name}.{f2.Name}", (object[])arr));
                        }
                        break;
                    } else curr = curr.BaseType;
                }
            }
            return;
        }

        public MsbWrapper(string path, string name)
        {
            Name = name;
            Path = path;
            this._msb = null;
        }

        public int CompareTo(MsbWrapper? other) => Name.CompareTo(other?.Name);
    }

    class MsbItemList
    {
        public string Name { get; }
        public BindingList<object> Items { get; }
        public MsbItemList(string name)
        {
            this.Name = name;
            this.Items = new BindingList<object>();
        }
        public MsbItemList(string name, IEnumerable<object> items)
        {
            this.Name = name;
            this.Items = new BindingList<object>();
            foreach (var i in items) Items.Add(i);
        }
    }
}
