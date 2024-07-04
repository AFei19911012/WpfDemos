using SuperDog;
using System.IO;

namespace SuperDogDemo
{
    public class SuperDog3160698
    {
        private const string scope = "<dogscope />";
        private const string vendorCode = "VDpSwu6bggoB68AILJUAxNX0jJs0YmvU2Ta0XT1pI9nI3mIcLpYZjeupgLCUA9dDAP1n08Ytw4rFAZScw2sDaCzS31TsaFrqhaoOAc" +
            "lG1v2O17ey1KdNNNEAmgtGjfvKx5KhRpEBO11Y39rHvZpB/KCC3QU8QP2+cSMm0k2awm6nwrhnEHuhS6R84XiX7o5PL8iRFCvDFNcwmsH4uQl+L2rmKqQWyLfd7CNoMI4XbDC" +
            "v/PRhFb1iGrPqduhUMp5w4KHRk2beC7q58aXXZDyBsTb0YH8xHxgwlnMBrSdgZpyCMUW6xwg9ayyPASEV3oCRSwyw0gRr2G8m0Nr9mJNkmpVpG+EW+4ULTIEgyVYXQr3Ot54U" +
            "/R/MGwOg0cey+HcS5q62WvaJJhVw96itDAJbhJWhqNfrbWYEXWSs4lczaG1Y1aRf/LK7uYSU+DjxxcI9G60c1Y2vykcp9NP/wP01/VK/acdvS/09RQcq2t4xhJHi5nKy3fWzm" +
            "ODeWchq4wXAv1Bv6y8RZ99hlg2Fe7kQHmrmuKhPRsEpd8Zvl7+825fNEHHBzDusuTiOm9o0kHEBNvVIKjKNsGDsCD6xsAcnXX43eHlUpsAv5Hek814cFqyO9J5s+mJpVP6DtW" +
            "gSKsri56T7bAal38eAWAm00DTZvri0dZdPX0WLvMUnQeMlOm6Wt0ikDGYgEYFI/NjtHuOdF3vQKVwAX21lG0GVD1sUq1guAhtbHxHFjQ1MQoeyxVAXCL3GvW4yMkVaiQS1qWP" +
            "csIzvji+aPX02bohgDxjcS77EUhkgwnJMI/0P65oMmAuqDBh0F6YP6XxrsdXr60986kJQz5jaP+HEqBx/voavr2/opGxqQk1tRYu9XvWLhy1+aMk6QF5w5H7xlwP2XaAz+1Xb" +
            "QM+LGWIbQ1YUmw3QdRnNMoBFBGnBnDHJr3WPnf4adpdutTjPc5wBn+dNfzZtpY5QBXPl+7OG6BUFNN3V0w==";

        // 检查 SuperDog 是否存在
        private static bool GetDogInfo()
        {
            string queryFormat = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" +
                                 "<dogformat root=\"dog_info\">" +
                                 " <feature>" +
                                 "  <attribute name=\"id\" />" +
                                 "  <element name=\"license\" />" +
                                 " </feature>" +
                                 "</dogformat>";
            string info = "";
            // 如果出现闪退，联系客服用最新的 dog_net_windows.dll
            DogStatus status = Dog.GetInfo(scope, queryFormat, vendorCode, ref info);
            return DogStatus.StatusOk == status;
        }

        // 检查特征ID是否匹配
        private static Dog LoginDemo(DogFeature feature)
        {
            Dog dog = new Dog(feature);
            DogStatus status = dog.Login(vendorCode, scope);
            return dog.IsLoggedIn() ? dog : null;
        }

        public static string CheckSuperDog()
        {
            string info = "SuperDog Checked";
            // 检查 dll 是否齐全
            if (!File.Exists("api_dsp_windows.dll"))
            {
                info = "DllNotFoundException: api_dsp_windows.dll";
            }
            else if (!File.Exists("dog_net_windows.dll"))
            {
                info = "DllNotFoundException: dog_net_windows.dll";
            }
            else if (!File.Exists("dog_windows_3160698.dll"))
            {
                info = "DllNotFoundException: dog_windows_3160698.dll";
            }
            // 检查 SuperDog 是否存在
            else
            {
                bool hasDog = GetDogInfo();
                if (!hasDog)
                {
                    info = "SuperDog Not Found";
                }
                // 检查特征ID是否匹配（可以添加多个ID）
                else
                {
                    Dog dog = LoginDemo(new DogFeature(DogFeature.FromFeature(506).Feature));
                    if (dog == null)
                    {
                        info = "FeatureID Not Match";
                    }
                }
            }
            return info;
        }
    }
}
