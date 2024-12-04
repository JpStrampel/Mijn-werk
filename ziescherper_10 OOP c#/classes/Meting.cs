using System;

public class Meting
{
    public int Temperatuur { get; set; }
    public string OpgemetenDoor { get; set; }

    public void ToonMetingInKleur()
    {
        if (Temperatuur < 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (Temperatuur > 30)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        Console.WriteLine($"Temperatuur: {Temperatuur}, Opgemeten door: {OpgemetenDoor}");
        Console.ResetColor();
    }

    public void VoegMetingToeEnVerwijder(ref Meting inMeting)
    {
        Temperatuur += inMeting.Temperatuur;
        inMeting.Temperatuur = 0;
        inMeting.OpgemetenDoor = "";
    }

    public Meting GenereerRandomMeting()
    {
        Meting result = new Meting();
        result.Temperatuur = Temperatuur * 2;
        result.OpgemetenDoor = OpgemetenDoor + " Junior";
        return result;
    }
}
