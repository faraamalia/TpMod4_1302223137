
class program
{
    static void Main()
    {

        KodePos kodePos = new KodePos();
        Console.Write("Input nama kelurahan: ");
        string kelurahan = Console.ReadLine();
        Console.WriteLine(kodePos.GetKodePos(kelurahan));
        Console.WriteLine(" ");

        DoorMachine doorMachine = new DoorMachine();
        Console.Write("Input perintah (Terkunci/Terbuka):");
        string perintah = Console.ReadLine();
        doorMachine.perubahanState(perintah);
    }
}
