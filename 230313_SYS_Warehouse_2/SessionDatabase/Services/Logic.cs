using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionDatabase.Services
{
    internal class Logic
    {
        public Database Database { get; set; }

        public static void CreatDummyData()
        {
            Database.CreateDummyData();
        }


    }
}
