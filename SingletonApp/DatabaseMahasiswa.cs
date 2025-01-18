using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    class DatabaseMahasiswa
    {
        private List<Mahasiswa> _mhs;
        private DatabaseMahasiswa()
        {
            _mhs = new List<Mahasiswa>();
        }
        private static DatabaseMahasiswa _instance;
        public static DatabaseMahasiswa getDatabaseMhs()
        {
            if (_instance == null)
            {
                _instance = new DatabaseMahasiswa();
            }
            return _instance;
        }

        public void addMhs(Mahasiswa mhs)
        {
            _mhs.Add(mhs);
        }

        public void PrintAllMhs()
        {
            if ( _mhs.Count > 0)
            {
                foreach (var item in _mhs)
                {
                    Console.WriteLine(item.id);
                    Console.WriteLine(item.name);
                    Console.WriteLine("------------------------------------");
                }
            }else
            {
                Console.WriteLine("Empty");
            }
                
        }
    }
}
