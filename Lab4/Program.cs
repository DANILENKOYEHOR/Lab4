using Lab4;

internal class Program
{
    public static void Main(string[] args)
    {
        double a1 = 1;
        double b1 = 3;
        double a2 = -2;
        double b2 = -1;

        Straight AB = new Straight(a1, b1);
        Straight CD = new Straight(a2, b2);

        Console.WriteLine(AB.GetIntersections());
        Console.WriteLine(CD.GetIntersections());
        Console.WriteLine(AB != CD);//Перпендикулярны ли прямые?
        Console.WriteLine(AB % CD); //Угол между прямыми в градусах
         
    }
    
}
