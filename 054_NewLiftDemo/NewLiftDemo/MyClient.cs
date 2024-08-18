using NewLife.Data;
using NewLife.Remoting;

namespace NewLiftDemo
{
    ///
	/// ----------------------------------------------------------------
	/// Copyright @BigWang 2024 All rights reserved
	/// Author      : BigWang
	/// Created Time: 2024/8/18 21:32:38
	/// Description :
	/// ----------------------------------------------------------------
	/// Version      Modified Time              Modified By     Modified Content
	/// V1.0.0.0     2024/8/18 21:32:38                     BigWang         首次编写         
	///
    /// 自定义业务客户端
    public class MyClient : ApiClient
    {
        public MyClient(string uri) : base(uri) { }

        /// <summary>添加，标准业务服务，走Json序列化</summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public async Task<int> AddAsync(int x, int y)
        {
            return await InvokeAsync<int>("My/Add", new { x, y });
        }

        /// <summary>RC4加解密，高速业务服务，二进制收发不经序列化</summary>
        /// <param name="pk"></param>
        /// <returns></returns>
        public async Task<Packet> RC4Async(Packet pk)
        {
            return await InvokeAsync<Packet>("My/RC4", pk);
        }

        public async Task<User> FindUserAsync(int uid, bool enable)
        {
            return await InvokeAsync<User>("User/FindByID", new { uid, enable });
        }
    }
}