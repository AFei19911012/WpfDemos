using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using HelixToolkit.Wpf;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Media3D;

namespace TestHelixToolkit.ViewModel
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @Taosy.W 2022 All rights reserved
    /// Author      : Taosy.W
    /// Created Time: 2022/3/29 16:36:57
    /// Description :
    /// ------------------------------------------------------
    /// Version      Modified Time            Modified By    Modified Content
    /// V1.0.0.0     2022/3/29 16:36:57    Taosy.W                 
    ///
    public class MvvmVM : ViewModelBase
    {
        private ObservableCollection<Visual3D> hViewObjects = new ObservableCollection<Visual3D>();
        public ObservableCollection<Visual3D> HViewObjects
        {
            get => hViewObjects;
            set => Set(ref hViewObjects, value);
        }

        public MvvmVM()
        {
            Add();
        }

        public RelayCommand CmdAdd => new Lazy<RelayCommand>(() => new RelayCommand(Add)).Value;
        private void Add()
        {
            if (HViewObjects.Count == 0)
            {
                HViewObjects.Add(new DefaultLights());
            }
            HViewObjects.Add(new HelixVisual3D { Origin = GetRandomPoint(), Length = 30, Radius = 2, Diameter = 0.5, Turns = 6, Fill = GradientBrushes.Hue });
        }

        public RelayCommand CmdRemove => new Lazy<RelayCommand>(() => new RelayCommand(Remove)).Value;
        private void Remove()
        {
            int count = HViewObjects.Count;
            if (count < 1)
            {
                return;
            }
            HViewObjects.RemoveAt(count - 1);
        }

        private readonly Random r = new Random();
        private Point3D GetRandomPoint()
        {
            int d = 10;
            return new Point3D(r.Next(d) - (d / 2), r.Next(d) - (d / 2), r.Next(d) - (d / 2));
        }
    }
}