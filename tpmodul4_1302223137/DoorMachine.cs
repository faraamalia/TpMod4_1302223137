using System;

public class DoorMachine
{
    private string stateIn = "Terkunci";

    public void perubahanState(string state )
    {
        if (state == "Terkunci")
        {
            Console.WriteLine("Pintu terkunci");
        }
        else if (state == "Terbuka")
        {
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Perintah tidak valid");
            return;
        }
        stateIn = state;
    }
}
