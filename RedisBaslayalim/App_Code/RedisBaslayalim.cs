﻿using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedisBaslayalim
{
    public class RedisBaslayalim
    {


        public static int BaslayalimKaydet(string host, string key, string value)
        {
            try
            {
                using (RedisClient _RedisClient = new RedisClient(host))
                {
                    if (_RedisClient.Get<string>(key) == null)
                    {
                        _RedisClient.Set(key, value);
                    }
                }
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static string BaslayalimRead(string host, string key)
        {
            try
            {
                using (RedisClient _RedisClient = new RedisClient(host))
                {
                    return _RedisClient.Get<string>(key);
                } 
            }
            catch
            {
                return null;
            }
        }
    }
}