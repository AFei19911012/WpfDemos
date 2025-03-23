using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TreeDemo
{
    public class MainModel : EntityBase
    {
        public MainModel() { }

        #region 属性 Items
        private CollectionBase<TreeDataItem> _Items = null;
        public CollectionBase<TreeDataItem> Items
        {
            get
            {
                if (_Items == null)
                {
                    _Items = new CollectionBase<TreeDataItem>
                    {
                        new TreeDataItem("Name1","p1","p2","p3","p4",
                            new TreeDataItem("Name1_1","p1_1","p2_1","p3_1","p4_1"),
                            new TreeDataItem("Name1_2","p1_2","p2_2","p3_2","p4_2"),
                            new TreeDataItem("Name1_3","p1_3","p2_3","p3_3","p4_3"),
                            new TreeDataItem("Name1_4","p1_4","p2_4","p3_4","p4_4")),
                        new TreeDataItem("Name2","p1","p2","p3","p4",
                            new TreeDataItem("Name2_1","p1_1","p2_1","p3_1","p4_1"),
                            new TreeDataItem("Name2_2","p1_2","p2_2","p3_2","p4_2",
                                new TreeDataItem("Name2_2_1","p1_1","p2_1","p3_1","p4_1"),
                                new TreeDataItem("Name2_2_2","p1_2","p2_2","p3_2","p4_2"),
                                new TreeDataItem("Name2_2_3","p1_3","p2_3","p3_3","p4_3"),
                                new TreeDataItem("Name2_2_4","p1_4","p2_4","p3_4","p4_4")),
                            new TreeDataItem("Name2_3","p1_3","p2_3","p3_3","p4_3"),
                            new TreeDataItem("Name2_4","p1_4","p2_4","p3_4","p4_4")),
                        new TreeDataItem("Name3","p1","p2","p3","p4",
                            new TreeDataItem("Name3_1","p1_1","p2_1","p3_1","p4_1"),
                            new TreeDataItem("Name3_2","p1_2","p2_2","p3_2","p4_2"),
                            new TreeDataItem("Name3_3","p1_3","p2_3","p3_3","p4_3"),
                            new TreeDataItem("Name3_4","p1_4","p2_4","p3_4","p4_4"))
                    };
                }
                return _Items;
            }
            set
            {
                _Items = value;
                RaisePropertyChanged("Items");
            }
        }
        #endregion
    }

    public class TreeDataItem : EntityBase
    {
        public TreeDataItem()
        {

        }

        public TreeDataItem(string name, string p1, string p2, string p3, string p4, params TreeDataItem[] items)
        {
            Name = name;
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;

            if (items != null)
            {
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
        }

        #region 属性 Name
        private string _Name = string.Empty;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                RaisePropertyChanged("Name");
            }
        }
        #endregion

        #region 属性 P1
        private string _P1 = string.Empty;
        public string P1
        {
            get
            {
                return _P1;
            }
            set
            {
                _P1 = value;
                RaisePropertyChanged("P1");
            }
        }
        #endregion

        #region 属性 P2
        private string _P2 = string.Empty;
        public string P2
        {
            get
            {
                return _P2;
            }
            set
            {
                _P2 = value;
                RaisePropertyChanged("P2");
            }
        }
        #endregion

        #region 属性 P3
        private string _P3 = string.Empty;
        public string P3
        {
            get
            {
                return _P3;
            }
            set
            {
                _P3 = value;
                RaisePropertyChanged("P3");
            }
        }
        #endregion

        #region 属性 P4
        private string _P4 = string.Empty;
        public string P4
        {
            get
            {
                return _P4;
            }
            set
            {
                _P4 = value;
                RaisePropertyChanged("P4");
            }
        }
        #endregion

        #region 属性 Items
        private CollectionBase<TreeDataItem> _Items = null;
        public CollectionBase<TreeDataItem> Items
        {
            get
            {
                if (_Items == null)
                {
                    _Items = new CollectionBase<TreeDataItem>();
                }
                return _Items;
            }
            set
            {
                _Items = value;
                RaisePropertyChanged("Items");
            }
        }
        #endregion
    }

    public class CollectionBase<T> : ObservableCollection<T>
    {
    }

    public class EntityBase : INotifyPropertyChanged
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
