using NewLife;
using NewLife.Data;
using System.Text;

namespace NewLiftDemo
{
    ///
	/// ----------------------------------------------------------------
	/// Copyright @BigWang 2024 All rights reserved
	/// Author      : BigWang
	/// Created Time: 2024/8/18 21:33:20
	/// Description :
	/// ----------------------------------------------------------------
	/// Version      Modified Time              Modified By     Modified Content
	/// V1.0.0.0     2024/8/18 21:33:20                     BigWang         首次编写         
	///
    /// 自定义控制器，包含多个服务
    public class MyController
    {
        /// <summary>添加，标准业务服务，走Json序列化</summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Add(int x, int y) => x + y;

        /// <summary>RC4加解密，高速业务服务，二进制收发不经序列化</summary>
        /// <param name="pk"></param>
        /// <returns></returns>
        public Packet RC4(Packet pk)
        {
            var data = pk.ToArray();
            var pass = "NewLife".GetBytes();

            return data.RC4(pass);
        }
    }
}