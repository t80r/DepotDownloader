using System;
using System.Collections.Generic;

namespace DepotDownloader;

public static class DictionaryExtension
{
    public static bool TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
    {
        try
        {
            dictionary.Add(key, value);
            return true;
        }
        catch (Exception e) when (e is not ArgumentNullException)
        {
            return false;
        }
    }
}
