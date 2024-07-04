using System.Windows;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XmlDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            XDocument srcTree = new XDocument(
                                    new XComment("This is a comment"),
                                    new XElement("Root",
                                        new XElement("Child1", "data1"),
                                        new XElement("Child2", "data2"),
                                        new XElement("Child3", "data3"),
                                        new XElement("Child2", "data4"),
                                        new XElement("Info5", "info5"),
                                        new XElement("Info6", "info6"),
                                        new XElement("Info7", "info7"),
                                        new XElement("Info8", "info8")
                                    ));
            srcTree.Save("src.xml");

            XDocument doc = new XDocument(
                new XComment("This is a comment"),
                new XElement("Root", from el in srcTree.Element("Root").Elements() where ((string)el).StartsWith("data") select el));
            doc.Save("dst.xml");

            // 创建 xml 对象
            XDocument xDoc = new XDocument();
            // 创建一个根节点
            XElement root = new XElement("Root");
            // 将根节点加入到 xml 对象中
            xDoc.Add(root);
            // 创建一个子节点
            XElement child = new XElement("User");
            root.Add(child);
            // 添加属性
            XAttribute attr = new XAttribute("ID", 1);
            child.Add(attr);
            child.SetElementValue("Name", "张三");
            child.SetElementValue("Age", "18");
            child = new XElement("User");
            root.Add(child);

            attr = new XAttribute("ID", 2);
            child.Add(attr);
            child.SetElementValue("Name", "李四");
            child.SetElementValue("Age", "20");

            // 保存 xml 文件
            xDoc.Save("User.xml");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            XElement srcTree = new XElement("Root",
                                    new XElement("Element1", 1),
                                    new XElement("Element2", 2),
                                    new XElement("Element3", 3),
                                    new XElement("Element4", 4),
                                    new XElement("Element5", 5
                                    ));

            XDocument doc = XDocument.Load("src.xml");
            var root = doc.Root;
            root.Add(new XElement("NewChild", "new content"));
            root.Add(from el in srcTree.Elements() where (int)el > 3 select el);
            doc.Save("add.xml");
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            XDocument doc = XDocument.Load("add.xml");
            var root = doc.Root;
            var att = root.Descendants("NewChild").FirstOrDefault();
            att.Value = "Modify content";
            doc.Save("modify.xml");
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            XDocument doc = XDocument.Load("modify.xml");
            var root = doc.Root;
            var att = root.Descendants("NewChild").FirstOrDefault();
            att.Remove();
            doc.Save("remove.xml");
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            List<DataModel> datas =
            [
                new DataModel { Name = "张三", Age = 18, Id = "0001" },
                new DataModel { Name = "李四", Age = 18, Id = "0002" },
            ];
            ObjectToXml(datas, "Serialize.xml");
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            var datas = XmlToObject<List<DataModel>>("Serialize.xml");
            datas.Add(new DataModel { Name = "王五", Age = 20, Id = "0003" });
            ObjectToXml(datas, "NewSerialize.xml");
        }

        private void ObjectToXml<T>(T obj, string filename)
        {
            using XmlWriter xmlWriter = XmlWriter.Create(filename);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            xmlSerializer.Serialize(xmlWriter, obj);
        }

        private T XmlToObject<T>(string filename) where T : class
        {
            using XmlReader xmlReader = XmlReader.Create(filename);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            return (T)xmlSerializer.Deserialize(xmlReader);
        }
    }
}