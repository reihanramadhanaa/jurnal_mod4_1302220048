internal class Program
{
    private static void Main(string[] args)
    {
        modul4_1302220048.KodeBuah kodeBuahObj = new modul4_1302220048.KodeBuah();
        string kodeBuahKelapa = kodeBuahObj.GetKodeBuah("Kelapa");
        Console.WriteLine( "Kode Buah Kelapa :"  + kodeBuahKelapa);

    }
}