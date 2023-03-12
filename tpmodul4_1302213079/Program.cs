using System;

public class KodePos
{
    private static readonly System.Collections.Generic.Dictionary<string, string> Table = new System.Collections.Generic.Dictionary<string, string>() {
        { "Batununggal", "40266" },
        { "Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijaura", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Sekejati", "40286" },
        { "Kebonwaru", "40272" },
        { "Maleer", "40274" },
        { "Samoja", "40273" }
    };

    public static string GetKodePos(string kelurahan)
    {
        if (Table.ContainsKey(kelurahan))
        {
            return Table[kelurahan];
        }
        return "Kode Pos tidak ditemukan.";
    }
}

public class DoorMachine
{
    private State state;

    public DoorMachine()
    {
        state = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        state = State.Terbuka;
        Console.WriteLine("Pintu tidak terkunci");
    }

    public void KunciPintu()
    {
        state = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    private enum State
    {
        Terkunci,
        Terbuka
    }
}


class Program
{
    static void Main(string[] args)
    {
        string kodePos = KodePos.GetKodePos("Batununggal");
        Console.WriteLine(kodePos);
        kodePos = KodePos.GetKodePos("Kujangsari");
        Console.WriteLine(kodePos);
        kodePos = KodePos.GetKodePos("Mengger");
        Console.WriteLine(kodePos);
        kodePos = KodePos.GetKodePos("Wates");
        Console.WriteLine(kodePos);
        kodePos = KodePos.GetKodePos("Cijaura");
        Console.WriteLine(kodePos);
        kodePos = KodePos.GetKodePos("Jatisari");
        Console.WriteLine(kodePos);
        kodePos = KodePos.GetKodePos("Margasari");
        Console.WriteLine(kodePos);
        kodePos = KodePos.GetKodePos("Sekejati");
        Console.WriteLine(kodePos);
        kodePos = KodePos.GetKodePos("Kebonwaru");
        Console.WriteLine(kodePos);
        kodePos = KodePos.GetKodePos("Maleer");
        Console.WriteLine(kodePos);
        kodePos = KodePos.GetKodePos("Samoja");
        Console.WriteLine(kodePos);
        kodePos = KodePos.GetKodePos("Ga tau");
        Console.WriteLine(kodePos);

        Console.WriteLine("==========================================");

        DoorMachine mesinPintu = new DoorMachine();
        mesinPintu.BukaPintu();
        mesinPintu.KunciPintu();
    }
}

