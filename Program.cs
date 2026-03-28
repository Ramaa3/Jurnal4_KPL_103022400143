using MOD4_103022400143;
class Program
{
    static void Main(String[] args)
    {
        KodePaket kp = new KodePaket();

        Console.WriteLine("Masukan Nama Paket : ");
        string input = Console.ReadLine();

        string hasil = kp.getKodePaket(input);
        Console.WriteLine("Kode Paket : " + hasil );
    }
}