using System.Windows;
using System.Windows.Controls;

namespace TreeDemo.Controls
{
    public class TreeDataGrid : DataGrid
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new TreeDataGridRow();
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is TreeDataGridRow;
        }
    }

    public class TreeDataGridRow : DataGridRow
    {

    }
}
