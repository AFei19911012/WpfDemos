using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace TreeDemo.Controls
{
    public class TreeItemData : EntityBase
    {
        #region 属性 IsExpanded
        private bool _IsExpanded = true;
        public bool IsExpanded
        {
            get
            {
                return _IsExpanded;
            }
            set
            {
                if (_IsExpanded == value)
                {
                    return;
                }
                _IsExpanded = value;
                RaisePropertyChanged("IsExpanded");
                SetItemsVisible(value);
            }
        }
        #endregion

        #region 属性 Level
        private int _Level = 0;
        public int Level
        {
            get
            {
                return _Level;
            }
            set
            {
                _Level = value;
                RaisePropertyChanged("Level");
            }
        }
        #endregion

        #region 属性 IsFirstItem
        private bool _IsFirstItem = true;
        public bool IsFirstItem
        {
            get
            {
                return _IsFirstItem;
            }
            set
            {
                _IsFirstItem = value;
                RaisePropertyChanged("IsFirstItem");
            }
        }
        #endregion

        #region 属性 IsLastItem
        private bool _IsLastItem = false;
        public bool IsLastItem
        {
            get
            {
                return _IsLastItem;
            }
            set
            {
                _IsLastItem = value;
                RaisePropertyChanged("IsLastItem");
            }
        }
        #endregion

        #region 属性 Data
        private object _Data = null;
        public object Data
        {
            get
            {
                return _Data;
            }
            set
            {
                _Data = value;
                RaisePropertyChanged("Data");
            }
        }
        #endregion

        #region 属性 ParentItem
        private TreeItemData _ParentItem = null;
        public TreeItemData ParentItem
        {
            get
            {
                return _ParentItem;
            }
            set
            {
                _ParentItem = value;
                RaisePropertyChanged("ParentItem");
            }
        }
        #endregion

        #region 属性 ParentItems
        private List<TreeItemData> _ParentItems = null;
        public List<TreeItemData> ParentItems
        {
            get
            {
                if (_ParentItems == null)
                {
                    _ParentItems = new List<TreeItemData>();
                }
                return _ParentItems;
            }
            set
            {
                _ParentItems = value;
                RaisePropertyChanged("ParentItems");
            }
        }
        #endregion

        #region 属性 Items
        private List<TreeItemData> _Items = null;
        public List<TreeItemData> Items
        {
            get
            {
                if (_Items == null)
                {
                    _Items = new List<TreeItemData>();
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

        #region 属性 HasItems
        public bool HasItems
        {
            get
            {
                return Items.Count > 0;
            }
        }
        #endregion

        #region 属性 IconType
        private int _IconType = 0;
        public int IconType
        {
            get
            {
                return _IconType;
            }
            set
            {
                if (_IconType == value)
                {
                    return;
                }

                _IconType = value;
                RaisePropertyChanged("IconType");
            }
        }
        #endregion 

        #region 属性 IsVisible
        private bool _IsVisible = true;
        public bool IsVisible
        {
            get
            {
                return _IsVisible;
            }
            private set
            {
                if (_IsVisible == value)
                {
                    return;
                }
                _IsVisible = value;
                RaisePropertyChanged("IsVisible");
                SetItemsVisible(value);
            }
        }
        #endregion

        private void SetItemsVisible(bool visible)
        {
            if (IsExpanded == false || visible == false)
            {
                Items.ForEach(p => p.IsVisible = false);
            }
            else
            {
                Items.ForEach(p => p.IsVisible = true);
            }
        }

        int GetIconType()
        {
            if (HasItems)
            {
                if (IsFirstItem && IsLastItem && Level == 0)
                {
                    return IsExpanded ? 5 : 1;
                }

                if (Level == 0 && IsFirstItem)
                {
                    return IsExpanded ? 5 : 2;
                }

                if (IsLastItem)
                {
                    return IsExpanded ? 7 : 0;
                }

                return IsExpanded ? 7 : 0;
            }
            if (IsLastItem)
            {
                return 9;
            }
            else
            {
                return 8;
            }
        }

        protected override void RaisePropertyChanged(string name)
        {
            base.RaisePropertyChanged(name);
            if (!name.Equals("IconType"))
            {
                IconType = GetIconType();
            }
        }
    }

    public class TreeItemDataCollection : ObservableCollection<TreeItemData>
    {
        IEnumerable _SourceItems = null;

        string _ItemsPath = "";

        List<TreeItemData> _RootItems = new List<TreeItemData>();

        #region 属性 UseTree
        private bool _UseTree = false;
        public bool UseTree
        {
            get
            {
                return _UseTree;
            }
            set
            {
                _UseTree = value;
            }
        }
        #endregion

        public TreeItemDataCollection()
        {

        }

        public TreeItemDataCollection(IEnumerable sourceItems, string itemsPath, bool useTree = false)
        {
            _SourceItems = sourceItems;
            _ItemsPath = itemsPath;
            if (_SourceItems is INotifyCollectionChanged list)
            {
                list.CollectionChanged += List_CollectionChanged;
            }
            UseTree = useTree;
            ResetItems();
        }

        private void List_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            ResetItems();
        }

        private void ResetItems()
        {
            if (_SourceItems is null)
            {
                ClearAllItems();
                return;
            }

            var items = new List<TreeItemData>();
            _RootItems.Clear();

            var list = this.Items.ToDictionary(l => l.Data);
            foreach (var item in _SourceItems)
            {
                if (list.TryGetValue(item, out var treeItem))
                {
                    list.Remove(item);
                }
                else
                {
                    treeItem = new TreeItemData { Data = item };
                }

                treeItem.ParentItems.Clear();
                treeItem.Level = 0;
                items.Add(treeItem);
                _RootItems.Add(treeItem);

                foreach (var sitem in GetSubItems(treeItem, _ItemsPath, list).ToList())
                {
                    items.Add(sitem);
                }
            }

            ResetSubItems(_RootItems);

            this.Items.Clear();
            if (UseTree)
            {
                _RootItems.ForEach(t => this.Items.Add(t));
            }
            else
            {
                items.ForEach(t => this.Items.Add(t));
            }
        }

        private void ResetSubItems(List<TreeItemData> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                var item = items[i];
                item.IsFirstItem = i == 0;
                item.IsLastItem = i == items.Count - 1;
            }
        }

        private IEnumerable<TreeItemData> GetSubItems(TreeItemData treeItem, string itemsPath, Dictionary<object, TreeItemData> list)
        {
            var data = treeItem.Data;
            var p = data.GetType().GetProperty(itemsPath);
            var pvalue = p.GetValue(data, null);
            treeItem.Items.Clear();
            if (pvalue is IEnumerable subItems)
            {
                foreach (var item in subItems)
                {
                    if (list.TryGetValue(item, out var subitem))
                    {
                        list.Remove(item);
                    }
                    else
                    {
                        subitem = new TreeItemData { Data = item };
                    }

                    subitem.ParentItem = treeItem;
                    subitem.Level = treeItem.Level + 1;

                    subitem.ParentItems.Clear();
                    foreach (var pitem in treeItem.ParentItems)
                    {
                        subitem.ParentItems.Add(pitem);
                    }
                    subitem.ParentItems.Add(treeItem);

                    treeItem.Items.Add(subitem);
                    yield return subitem;

                    foreach (var sitem in GetSubItems(subitem, itemsPath, list))
                    {
                        yield return sitem;
                    }
                }
                if (treeItem.Items.Count > 0)
                {
                    ResetSubItems(treeItem.Items);
                }
            }
        }

        private void ClearAllItems()
        {
            this.Items.Clear();
        }
    }

    public class TreeItemDataConverter : IValueConverter
    {
        #region 属性 UseTree
        private bool _UseTree = false;
        public bool UseTree
        {
            get
            {
                return _UseTree;
            }
            set
            {
                _UseTree = value;
            }
        }
        #endregion

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return value;
            }
            if (value is IEnumerable items)
            {
                return new TreeItemDataCollection(items, parameter.ToString(), UseTree);
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
