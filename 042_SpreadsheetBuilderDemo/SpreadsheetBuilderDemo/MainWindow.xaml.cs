using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using SoftCircuits.Spreadsheet;
using System.Windows;

namespace SpreadsheetBuilderDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            string filename = "TestExcel.xlsx";

            SpreadsheetBuilder.ValidationExceptions = SaveValidation.DebugOnly;

            using SpreadsheetBuilder builder = SpreadsheetBuilder.Create(filename);
            SpreadsheetStyles styles = new(builder);

            // Table columns
            string[] bodyHeaders = new string[]
            {
                "Railcar",
                "Equipment Type",
                "Model",
                "Start Date",
                "End Date",
                "Monthly Rate",
                "Total"
            };

            // Create 10 sheets
            for (int i = 1; i <= 10; i++)
            {
                if (i > 1)
                    builder.Worksheet = builder.CreateWorksheet($"Sheet{i}");

                builder.SetColumnWidth(1, (uint)bodyHeaders.Length, 18);

                CellReference reference = new(1, 1);

                builder.SetCell("A1", "Company Name", styles.Header);
                builder.SetCell("G1", "Invoice 1117", styles.HeaderRight);
                builder.SetCell("A2", "Customer Name", styles.Subheader);
                builder.SetCell("G2", "6/1/2021 - 6/30/2021", styles.SubheaderRight);

                // Header table
                TableBuilder table = new(builder, "A4", 2);
                table.AddRow(new CellValue<string>("Total Cars:", styles.Bold), 16);
                table.AddRow(new CellValue<string>("Total:", styles.Bold), 4000m);
                table.BuildTable($"HeaderTable{i}", styles.HeaderTableStyle);

                // Items table
                table = new(builder, "A7", bodyHeaders);
                for (int j = 0; j <= 10; j++)
                {
                    table.AddRow("TILX332106",
                        "Covered Hopper",
                        "3281 Cubi Foot Hopper",
                        new CellValue<DateTime>(new DateTime(2020, 10, 1), styles.Date),
                        null,
                        (decimal)250.00,
                        new CellValue<CellFormula>(new CellFormula($"F{table.RowIndex}"), styles.Currency));
                }

                CellRange railcarRange = table.GetColumnRange(1);
                CellRange totalRange = table.GetColumnRange((uint)(bodyHeaders.Length - 1));
                table.AddRow(new CellFormula($"ROWS({railcarRange})"),
                    null,
                    null,
                    null,
                    null,
                    null,
                    new CellValue<CellFormula>(new($"SUM({totalRange})"), styles.Currency));
                table.BuildTable($"ItemsTable{i}", styles.ItemsTableStyle);
            }
            builder.Save();



            filename = "test2.xlsx";
            using SpreadsheetBuilder builder2 = SpreadsheetBuilder.Create(filename);
            builder2.SetCell("A1", "Hello, World!");
            builder2.SetCell("B5", 123.45);
            builder2.SetCell(new CellReference(2, 5), 123.45);
            builder2.SetCell("C17", new CellFormula("SUM(A1:C16)"));
            builder2.SetCell("A7", 123.45, builder.CellStyles[StandardCellStyle.Currency]);
            uint bold = builder2.CellStyles.Register(new CellFormat()
            {
                FontId = builder2.FontStyles[StandardFontStyle.Bold],
                ApplyFont = BooleanValue.FromBoolean(true),
            });

            uint header = builder2.CellStyles.Register(new CellFormat()
            {
                FontId = builder2.FontStyles[StandardFontStyle.Header],
                ApplyFont = BooleanValue.FromBoolean(true)
            });

            uint subheader = builder2.CellStyles.Register(new CellFormat()
            {
                FontId = builder2.FontStyles[StandardFontStyle.Subheader],
                ApplyFont = BooleanValue.FromBoolean(true)
            });

            uint headerRight = builder2.CellStyles.Register(new CellFormat()
            {
                FontId = builder2.FontStyles[StandardFontStyle.Header],
                ApplyFont = BooleanValue.FromBoolean(true),
                Alignment = new() { Horizontal = HorizontalAlignmentValues.Right },
                ApplyAlignment = BooleanValue.FromBoolean(true)
            });

            uint subheaderRight = builder2.CellStyles.Register(new CellFormat()
            {
                FontId = builder2.FontStyles[StandardFontStyle.Subheader],
                ApplyFont = BooleanValue.FromBoolean(true),
                Alignment = new() { Horizontal = HorizontalAlignmentValues.Right },
                ApplyAlignment = BooleanValue.FromBoolean(true)
            });

            builder2.SetCell("D22", "Header", header);

            string[] headers = new string[]
            {
              "Column1",
              "Column2",
              "Column3"
            };

            TableBuilder table2 = new(builder2, "A4", headers);
            table2.AddRow("Abc", 123, 123.45m);
            table2.AddRow("Def", 456, 4000m);
            table2.BuildTable("MyTableName", ExcelTableStyle.MediumBlue6);
        }
    }
}