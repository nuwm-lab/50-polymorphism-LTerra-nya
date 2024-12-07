using System;
using System.Security.Cryptography;
using System.Text;
public class Line
{
    double[] vals = new double[3];
    // тут я задав так трохи по "рагульски" змінні для того щоб я не заплутався, бо функція йде як a1x + a2y + a0
    public virtual void init()
    {
        System.Console.WriteLine("Введiть координати точок лінії  a1, a2, a3:");
        int a1 = Convert.ToInt32(Console.ReadLine());
        int a2 = Convert.ToInt32(Console.ReadLine());
        int a3 = Convert.ToInt32(Console.ReadLine());
        this.vals[1] = a1;
        this.vals[2] = a2;
        this.vals[0] = a3;
    }
    public virtual void setinit()
    {
        System.Console.WriteLine("Введiть координати точок лінії  a1, a2, a3:");
        int a1 = Convert.ToInt32(Console.ReadLine());
        int a2 = Convert.ToInt32(Console.ReadLine());
        int a3 = Convert.ToInt32(Console.ReadLine());
        vals[1] = a1;
        vals[2] = a2;
        vals[0] = a3;
    }
    public virtual void PrintVals()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(3);
            Console.WriteLine(" a" + i + ": " + this.vals[i]);
        }

    }

    public virtual bool IsBel()
    {
        //xa1 + ya2 + a0 = 0
        System.Console.WriteLine("Введiть координати точки  a1, a2:");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        if (x * vals[1] + y * vals[2] + vals[0] == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
public class Hyper : Line
{
    double[] vals = new double[5];

    public override void init()
    {
        System.Console.WriteLine("Введiть координати точок лінії  a1, a2, a3, a4, a5:");
        int a1 = Convert.ToInt32(Console.ReadLine());
        int a2 = Convert.ToInt32(Console.ReadLine());
        int a3 = Convert.ToInt32(Console.ReadLine());
        int a4 = Convert.ToInt32(Console.ReadLine());
        int a5 = Convert.ToInt32(Console.ReadLine());
        this.vals[1] = a1;
        this.vals[2] = a2;
        this.vals[3] = a3;
        this.vals[4] = a4;
        this.vals[0] = a5;
    }
    public override void setinit()
    {
        System.Console.WriteLine("Введiть координати точок гіперплощини  a1, a2, a3, a4, a5:");
        int a1 = Convert.ToInt32(Console.ReadLine());
        int a2 = Convert.ToInt32(Console.ReadLine());
        int a3 = Convert.ToInt32(Console.ReadLine());
        int a4 = Convert.ToInt32(Console.ReadLine());
        int a5 = Convert.ToInt32(Console.ReadLine());
        vals[1] = a1;
        vals[2] = a2;
        vals[3] = a3;
        vals[4] = a4;
        vals[0] = a5;
    }
    public override bool IsBel()
    {
        //xa1 + ya2 + a0 = 0
        System.Console.WriteLine("Введiть координати площини a1, a2, a3, a4");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());
        int f = Convert.ToInt32(Console.ReadLine());
        if (x * vals[1] + y * vals[2] + z * vals[3] + f * vals[4] + vals[0] == 0)
        {

            return true;
        }
        else
        {
            return false;
        }
    }
    public override void PrintVals()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(" a" + i + ": " + this.vals[i]);
        }

    }
}
class Program
{
    static void Main(string[] args)
    {

        Line Bonny = new Line();
        System.Console.WriteLine("1 для гіперплощини");
        int x = Convert.ToInt32(Console.ReadLine());

        try
        {
            if (x == 1)
            {
                Bonny = new Hyper();
                Bonny.init();
            }
            else
            {
                Bonny.init();
            }
        }

        catch {
            Bonny.init();
        }
        Bonny.PrintVals();
        Console.WriteLine(Bonny.IsBel());

    }
}