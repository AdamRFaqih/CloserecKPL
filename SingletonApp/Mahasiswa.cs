using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    class Mahasiswa
    {
        public string id {  get; set; }
        public string name { get; set; }

        public Mahasiswa() { }

        public Mahasiswa(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
