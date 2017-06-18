using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Utilities
{
    public class Utility
    {
        private static volatile Utility _instance;

        public static Utility Instance
        {
            get
            {
                if (_instance == null)
                {
                    object lockObj = new object();
                    lock (lockObj)
                    {
                        if (_instance == null)
                        {
                            _instance = new Utility();
                        }

                    }
                }
                return _instance;
            }
        }

        public string JsonSerializer<T>(T t)
        {
            return JsonConvert.SerializeObject(t);
        }

        public T JsonDeserialize<T>(string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
    }
}
