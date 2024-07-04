using GalaSoft.MvvmLight;

namespace MvvmDemo.Model
{
    public class DataModel : ViewModelBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        private string _Description;
        public string Description
        {
            get => _Description;
            set => Set(ref _Description, value);
        }


        public DataModel(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public DataModel(DataModel data)
        {
            Id = data.Id;
            Name = data.Name;
            Description = data.Description;
        }
    }
}