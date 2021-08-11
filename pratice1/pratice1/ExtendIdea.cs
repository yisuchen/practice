using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice1
{
    public class HashMaker
    {
        public string GetHash(string password)
        {
            return string.Format("zqaz2wsx{0}zxasqwzq", password);
        }
    }

    /// <summary>
    /// 嘗試 驗證程序 "相依" HashMaker 時, 驗證輸入 "密碼" 是否等於 "存放密碼 + 亂數"
    /// 比對 注入 差異
    /// </summary>
    public class ExtendIdea
    {
        private string _fixedPassword = "fgh";  // 存放的密碼
        public ExtendIdea() { }
        public ExtendIdea(string fixPassword)
        {
            this._fixedPassword = fixPassword;
        }

        public bool CheckAuthentication(string inputPassword)
        {
            HashMaker hash = new HashMaker();
            return inputPassword == (hash.GetHash(_fixedPassword));
        }
    }
}
