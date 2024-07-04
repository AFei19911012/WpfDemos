using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace DataGridRowDemo
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2024 All rights reserved
    /// Author      : Big Wang
    /// Created Time: 2024/2/19 20:02:17
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2024/2/19 20:02:17                     Big Wang        Init         
    ///
    public class MainVM : ViewModelBase
    {
        private ObservableCollection<DataModel> _ListDataModel;
        public ObservableCollection<DataModel> ListDataModel
        {
            get => _ListDataModel;
            set => Set(ref _ListDataModel, value);
        }


        public MainVM()
        {
            ListDataModel =
                [
                    new DataModel { IsEnbled = false, Name = "总计", Number = 30 },
                    new DataModel { Name = "张三", Number = 10 },
                    new DataModel { Name = "李四", Number = 20 },
                ];
        }
    }
}