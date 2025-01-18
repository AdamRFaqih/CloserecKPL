using SingletonApp;

internal class Program
{
    private static void Main(string[] args)
    {
        DatabaseMahasiswa dataBase1 = DatabaseMahasiswa.getDatabaseMhs();
        DatabaseMahasiswa dataBase2 = DatabaseMahasiswa.getDatabaseMhs();

        dataBase1.PrintAllMhs();

        dataBase2.addMhs(new Mahasiswa("1302216969", "Rahma"));

        dataBase1.PrintAllMhs();
    }
}