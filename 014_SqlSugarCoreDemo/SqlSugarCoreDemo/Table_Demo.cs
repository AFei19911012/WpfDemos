using SqlSugar;

namespace SqlSugarCoreDemo
{
    [SugarTable("Table_Demo")]
    public class Table_Demo
    {
        [SugarColumn(IsPrimaryKey = true, ColumnDataType = "varchar", Length = 50)]
        public string Uid { get; set; }
        

        [SugarColumn(ColumnName = "Name", ColumnDataType = "varchar", Length = 50)]
        public string Name { get; set; }


        [SugarColumn(ColumnName = "Remark", ColumnDataType = "varchar", Length = 100)]
        public string Remark { get; set; } = "";


        [SugarColumn(ColumnName = "IsChecked", ColumnDataType = "bool")]
        public bool IsChecked { get; set; }
    }
}