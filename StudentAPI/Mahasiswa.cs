namespace StudentAPI
{
    public class Mahasiswa
    {
        public string id {  get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string major { get; set; }

        public Mahasiswa()
        {

        }

        public Mahasiswa(string id, string name, int age, string major)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.major = major;
        }
    }
}
