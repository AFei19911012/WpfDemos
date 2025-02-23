using HashidsNet;
using System.Text;
using System;
using System.Windows;

namespace HashidsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Test();
        }

        private void Test()
        {
            // 加密数字
            var hashids = new Hashids("this is my salt");
            var hash = hashids.Encode(12345);  // NkK9
            hash = hashids.EncodeLong(666555444333222L);   // KVO9yy1oO5j

            // 解密
            var numbers = hashids.Decode("NkK9");      // [ 12345 ]
            var numbersL = hashids.DecodeLong("KVO9yy1oO5j");   // [ 666555444333222L ]

            // Decoding a single id
            int number = hashids.DecodeSingle("NkK9");      // 12345
            var flag = hashids.TryDecodeSingle("NkK9", out number);   // 12345


            var numberL = hashids.DecodeSingleLong("KVO9yy1oO5j");   // 666555444333222L
            flag = hashids.TryDecodeSingleLong("NkK9", out numberL);  // 666555444333222L


            hashids = new Hashids("this is my pepper");
            numbers = hashids.Decode("NkK9");    // []


            hashids = new Hashids("this is my salt");
            var hashes = hashids.Encode(683, 94108, 123, 5);  // aBMswoO2UB3Sj
            var numbersInt = hashids.Decode("aBMswoO2UB3Sj");  // [ 683, 94108, 123, 5 ]


            hashids = new Hashids("this is my salt", 8);
            hashes = hashids.Encode(1);                      // gB0NV05e
            numbers = hashids.Decode("gB0NV05e");           // [ 1 ]


            hashids = new Hashids("this is my salt", 0, "abcdefghijkABCDEFGHIJK12345");
            hash = hashids.Encode(1, 2, 3, 4, 5);    // Ec4iEHeF3


            hashids = new Hashids("this is my salt");
            hash = hashids.Encode(5, 5, 5, 5);    // 1Wc8cwcE

            hash = hashids.Encode(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);   // kRHnurhptKcjIDTWC3sx

            hashids.Encode(1); // => NV
            hashids.Encode(2); // => 6m
            hashids.Encode(3); // => yD
            hashids.Encode(4); // => 2l
            hashids.Encode(5); // => rD

            hash = hashids.EncodeHex("DEADBEEF");   // kRNrpKlJ

            var hex = hashids.DecodeHex("kRNrpKlJ");   // DEADBEEF
        }
    }
}