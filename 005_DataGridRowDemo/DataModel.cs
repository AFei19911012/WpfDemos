using GalaSoft.MvvmLight;

namespace DataGridRowDemo
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2024 All rights reserved
    /// Author      : Big Wang
    /// Created Time: 2024/2/22 23:53:27
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2024/2/22 23:53:27                     Big Wang        Init         
    ///
    public class DataModel : ViewModelBase
    {
        private bool _IsEnabled = true;

        public bool IsEnbled
        {
            get => _IsEnabled;
            set => Set(ref _IsEnabled, value);
        }

        public string  Name { get; set; }



        private int _Number;

        public int Number
        {
            get => _Number;
            set => Set(ref _Number, value);
        }

    }
}