internal class Program
{
    private static void Main(string[] args)
    {
        KodeBuah obj_kodebuah = new KodeBuah();
        String kodebuah = obj_kodebuah.getKodeBuah(KodeBuah.Buah.Kelapa);
        Console.WriteLine("Kode buah " + KodeBuah.Buah.Kelapa + " " + kodebuah);

    }
}
