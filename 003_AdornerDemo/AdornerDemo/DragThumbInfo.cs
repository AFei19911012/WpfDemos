namespace AdornerDemo
{
    public class DragThumbInfo
    {
        public string IdSource { get; set; }
        public EnumDragThumbType OrientationSource { get; set; }
        public string IdTarget { get; set; }
        public EnumDragThumbType OrientationTarget{ get; set; }

        public DragThumbInfo()
        {
            
        }

        public DragThumbInfo(string id1, EnumDragThumbType type1, string id2, EnumDragThumbType type2)
        {
            IdSource = id1;
            OrientationSource = type1;
            IdTarget = id2;
            OrientationTarget = type2;
        }
    }
}