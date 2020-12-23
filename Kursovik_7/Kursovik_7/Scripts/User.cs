using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik_7
{
    interface User
    {
        string FullName { get; }
        string Password { get; }
        string GUID { get; }

    }

    class Admin : User
    {
        public string FullName { get; }
        public string Password { get; }
        public string GUID { get; }
        public Admin()
        {
            FullName = "admin";
            Password = "adminpass";
            GUID = Guid.NewGuid().ToString("N");
        }

    }

    [Serializable]
    class Teacher : User
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string GUID { get; }
        public Teacher(string fname,string pass)
        {
            FullName = fname;
            Password = pass;
            GUID = Guid.NewGuid().ToString("N");
        }
    }
}
