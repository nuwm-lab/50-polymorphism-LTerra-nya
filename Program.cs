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
        int coeff1 = Convert.ToInt32(Console.ReadLine());
        int coeff2 = Convert.ToInt32(Console.ReadLine());
        int coeff3 = Convert.ToInt32(Console.ReadLine());
        //coeff 3 HAS to be first. don't give me any "this doesn't look right" becasue IT'S SUPPOSED TO BE LIKE THIS.
        this.vals[0] = coeff3;
        this.vals[1] = coeff1;
        this.vals[2] = coeff2;
        
    }
    public virtual void setinit()
    {
        System.Console.WriteLine("Введiть координати точок лінії  a1, a2, a3:");
        int coeff1 = Convert.ToInt32(Console.ReadLine());
        int coeff2 = Convert.ToInt32(Console.ReadLine());
        int coeff3 = Convert.ToInt32(Console.ReadLine());
        //coeff 3 HAS to be first. don't give me any "this doesn't look right" becasue IT'S SUPPOSED TO BE LIKE THIS.
        this.vals[0] = coeff3;
        this.vals[1] = coeff1;
        this.vals[2] = coeff2;
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
        int x;
        int y;
        try
        {
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Invalid Input");
            return false;
        }
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
public class HyperPlane : Line
{
    double[] vals = new double[5];

    public override void init()
    {
        System.Console.WriteLine("Введiть координати точок площини  a1, a2, a3, a4, a5:");
        int coeff1 = Convert.ToInt32(Console.ReadLine());
        int coeff2 = Convert.ToInt32(Console.ReadLine());
        int coeff3 = Convert.ToInt32(Console.ReadLine());
        int coeff4 = Convert.ToInt32(Console.ReadLine());
        int coeff5 = Convert.ToInt32(Console.ReadLine());
        //coeff 5 HAS to be first. don't give me any "this doesn't look right" becasue IT'S SUPPOSED TO BE LIKE THIS.
        this.vals[0] = coeff5;
        this.vals[1] = coeff1;
        this.vals[2] = coeff2;
        this.vals[3] = coeff3;
        this.vals[4] = coeff4;
        
    }
    public override void setinit()
    {
        System.Console.WriteLine("Введiть координати точок площини  a1, a2, a3, a4, a5:");
        int coeff1 = Convert.ToInt32(Console.ReadLine());
        int coeff2 = Convert.ToInt32(Console.ReadLine());
        int coeff3 = Convert.ToInt32(Console.ReadLine());
        int coeff4 = Convert.ToInt32(Console.ReadLine());
        int coeff5 = Convert.ToInt32(Console.ReadLine());
        //coeff 5 HAS to be first. don't give me any "this doesn't look right" becasue IT'S SUPPOSED TO BE LIKE THIS.
        this.vals[0] = coeff5;
        this.vals[1] = coeff1;
        this.vals[2] = coeff2;
        this.vals[3] = coeff3;
        this.vals[4] = coeff4;
    }
    public override bool IsBel()
    {
        //xa1 + ya2 + a0 = 0
        System.Console.WriteLine("Введiть координати площини a1, a2, a3, a4");
        int x;
        int y;
        int z;
        int f;
        try
        {
             x = Convert.ToInt32(Console.ReadLine());
             y = Convert.ToInt32(Console.ReadLine());
             z = Convert.ToInt32(Console.ReadLine());
             f = Convert.ToInt32(Console.ReadLine());
        }
        catch {
            Console.WriteLine("Invalid Input");
            return false;
        }
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
                Bonny = new HyperPlane();
                Bonny.init();
            }
            else
            {
                Bonny.init();
            }
        }
        catch
        {
            Bonny.init();
        }
        Bonny.PrintVals();
        Console.WriteLine(Bonny.IsBel());


    }
}