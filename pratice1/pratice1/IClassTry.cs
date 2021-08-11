﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice1
{
    public interface IAccountDao
    {
        string GetPassword(string id);
    }

    public interface IHash
    {
        string GetHashResult(string password);
    }

    public class AccountDao : IAccountDao
    {
        public string GetPassword(string id)
        {
            throw new NotImplementedException();
        }
    }

    public class Hash : IHash
    {
        public string GetHashResult(string password)
        {
            throw new NotImplementedException();
        }
    }

    public class Validation
    {
        private IAccountDao _accountDao;
        private IHash _hash;

        public Validation(IAccountDao dao, IHash hash)
        {
            this._accountDao = dao;
            this._hash = hash;
        }

        public bool CheckAuthentication(string id, string password)
        {
            // 取得資料中，id對應的密碼                       
            var passwordByDao = this._accountDao.GetPassword(id);

            // 針對傳入的password，進行hash運算
            var hashResult = this._hash.GetHashResult(password);

            // 比對hash後的密碼，與資料中的密碼是否吻合
            return passwordByDao == hashResult;
        }
    }

    public class StubAccountDao : IAccountDao
    {
        public string GetPassword(string id)
        {
            return "91";
        }
    }
    public class StubHash : IHash
    {
        public string GetHashResult(string password)
        {
            return "91";
        }
    }
}
