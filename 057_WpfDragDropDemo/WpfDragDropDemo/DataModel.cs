using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace WpfDragDropDemo
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2023 All rights reserved
    /// Author      : BigWang
    /// Created Time: 2023/6/3 0:01:51
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2023/6/3 0:01:51                     BigWang         首次编写         
    ///
    public class DataModel : ViewModelBase
    {
        public string Text { get; set; }

        public ObservableCollection<DataModel> Children { get; set; } = [];


        public DataModel()
        {
        }

        public DataModel(string text)
        {
            Text = text;
        }
    }
}