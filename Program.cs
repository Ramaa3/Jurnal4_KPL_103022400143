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

        Console.WriteLine(" ");
        Console.WriteLine("=========================");
        Console.WriteLine("=========================");
        Console.WriteLine(" ");

        MesinKopi mesin = new MesinKopi();

        mesin.PowerOn();

        Console.WriteLine(" ");
        Console.WriteLine("==============");
        Console.WriteLine(" ");

        mesin.StartBrewing();

        Console.WriteLine(" ");
        Console.WriteLine("==============");
        Console.WriteLine(" ");

        mesin.FinishBrewing();

        Console.WriteLine(" ");
        Console.WriteLine("==============");
        Console.WriteLine(" ");

        mesin.StartMaintenance();

        Console.WriteLine(" ");
        Console.WriteLine("==============");
        Console.WriteLine(" ");

        mesin.FinishMaintenance();

        Console.WriteLine(" ");
        Console.WriteLine("==============");
        Console.WriteLine(" ");

        mesin.PowerOff();

        Console.WriteLine(" ");
        Console.WriteLine("==============");
        Console.WriteLine(" ");

        mesin.gagal();

        Console.WriteLine(" ");
        Console.WriteLine("==============");
        Console.WriteLine(" ");
    }


    
}