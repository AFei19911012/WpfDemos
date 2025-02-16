using GalaSoft.MvvmLight;

namespace VtkWpfDemo
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2025 All rights reserved
    /// Author      : BigWang
    /// Created Time: 2025/2/16 14:46:10
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2025/2/16 14:46:10                     BigWang         首次编写         
    ///
    public class MainVM : ViewModelBase
    {
		private double _PosX;
		public double PosX
		{
			get => _PosX;
			set => Set(ref _PosX, value);
		}

		private double _PosY;
		public double PosY
		{
			get => _PosY;
			set => Set(ref _PosY, value);
		}

		private double _PosZ;
		public double PosZ
		{
			get => _PosZ;
			set => Set(ref _PosZ, value);
		}

		private string _StrPosition;
		public string StrPosition
		{
			get => _StrPosition;
			set => Set(ref _StrPosition, value);
		}

	}
}