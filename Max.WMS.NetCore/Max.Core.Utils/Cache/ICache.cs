using System.Collections.Generic;

namespace Max.Core.Utils.Cache
{
    public interface ICache
    {
        T Get<T>(string key);

        List<T> GetList<T>(string key);

        string GetJson(string key);

        string Get(string key);
    }
}