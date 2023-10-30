using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ContextDb
    {
        private static ContextDb _instance = null;

        private ContextDb()
        {

        }

        public static ContextDb Instance 
        { 
            get 
            {
                if (_instance == null) 
                {
                    _instance = new ContextDb();
                    Console.WriteLine("Instance created successfully");
                }
                return _instance;
            }
        }

        public void ExecuteQuery(string query)
            => Console.WriteLine(query);
    }
}
