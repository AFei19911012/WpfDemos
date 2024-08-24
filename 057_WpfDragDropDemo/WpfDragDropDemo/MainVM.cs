using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace WpfDragDropDemo
{
    ///
	/// ----------------------------------------------------------------
	/// Copyright @BigWang 2024 All rights reserved
	/// Author      : BigWang
	/// Created Time: 2024/8/21 21:07:52
	/// Description :
	/// ----------------------------------------------------------------
	/// Version      Modified Time              Modified By     Modified Content
	/// V1.0.0.0     2024/8/21 21:07:52                     BigWang         首次编写         
	///
    public class MainVM : ViewModelBase
    {
        private ObservableCollection<DataModel> _ListDataModel = [];
        public ObservableCollection<DataModel> ListDataModel
        {
            get => _ListDataModel;
            set => Set(ref _ListDataModel, value);
        }

        private ObservableCollection<DataModel> _Collection1;

        public ObservableCollection<DataModel>  Collection1
        {
            get => _Collection1;
            set => Set(ref _Collection1, value);
        }

        private ObservableCollection<DataModel> _Collection2;

        public ObservableCollection<DataModel> Collection2
        {
            get => _Collection2;
            set => Set(ref _Collection2, value);
        }


        public MainVM()
        {
            for (int i = 0; i < 10; i++)
            {
                var model = new DataModel($"{i}-item") { Children = [new DataModel("item-1"), new DataModel("item-2"), new DataModel("item-13")] };
                ListDataModel.Add(model);
            }
        }
    }
}