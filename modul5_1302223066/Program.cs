// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Penjumlahan berdasarkan NIM : ");
        Console.WriteLine(PenjumlahanGeneric.JumlahTigaAngka<int>(13, 02, 22));
        SimpleDataBase<int>Db = new SimpleDataBase<int>();
        Db.AddNewData(13);
        Db.AddNewData(02);
        Db.AddNewData(22);
        Db.PrintAllData();
    }
}
class PenjumlahanGeneric
{
    public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic a = angka1;
        dynamic b = angka2;
        dynamic c = angka3;
        return (a+b+c) ;
    }
}

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        this.storedData.Add(data);
        this.inputDates.Add(DateTime.Now);  
    }

    public void PrintAllData()
    {
       for (int i = 0; i < this.storedData.Count; i++)
        {
            Console.WriteLine("Data " + i + " berisi: " + this.storedData[i] + ", yang disimpan pada waktu UTC: " + this.inputDates[i]);
        }
    }
}

