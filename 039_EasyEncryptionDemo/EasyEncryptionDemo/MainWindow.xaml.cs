using SoftCircuits.EasyEncryption;
using System.IO;
using System.Windows;

namespace EasyEncryptionDemo
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
            // 简单加密、解密
            Encryption encrypt = new Encryption("admin", EncryptionAlgorithm.TripleDes);
            string original = "This is my message";
            string cipher = encrypt.Encrypt(original);
            string result = encrypt.DecryptString(cipher);

            // 数据类型
            int originalInt = 55;
            double originalDouble = 123.45;
            string cipherInt = encrypt.Encrypt(originalInt);
            string cipherDouble = encrypt.Encrypt(originalDouble);
            int resultInt = encrypt.DecryptInt32(cipherInt);
            double resultDouble = encrypt.DecryptDouble(cipherDouble);

            // 保存文件
            string filename = "test.data";
            int[] intValues = [123, 88, 902, 27, 16, 4, 478, 54];
            using (EncryptionWriter writer = encrypt.CreateStreamWriter(filename))
            {
                for (int i = 0; i < intValues.Length; i++)
                {
                    writer.Write(intValues[i]);
                }
            }

            // 加载文件
            intValues = new int[8];
            using (EncryptionReader reader = encrypt.CreateStreamReader(filename))
            {
                for (int i = 0; i < intValues.Length; i++)
                {
                    intValues[i] = reader.ReadInt32();
                }
            }

            // 流
            using (MemoryStream stream = new MemoryStream())
            using (EncryptionWriter writer = encrypt.CreateStreamWriter(stream))
            {
                writer.Write("ABC");
                writer.Write(123);
                writer.Write(123.45);
                string s = Encryption.EncodeBytesToString(stream.ToArray());
            }
        }
    }
}