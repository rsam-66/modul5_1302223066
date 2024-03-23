// See https://aka.ms/new-console-template for more information
class PenjumlahanGeneric
{
    public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic a = angka1;
        dynamic b = angka2;
        dynamic c = angka3;
        return (a+b+c) ;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Penjumlahan berdasarkan NIM : ");
        Console.WriteLine(PenjumlahanGeneric.JumlahTigaAngka<int>(13, 02, 22));
    }
}
