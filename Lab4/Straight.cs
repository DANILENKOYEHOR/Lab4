namespace Lab4;

public class Straight
{
    private double a;
    private double b;

    // Конструктор
    public Straight(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    // Метод вывода уравнения прямой
    public override string ToString()
    {
        return $"Straight line y = {a}x + ({b})";
    }
    
    // Определение точек пересечения с осями
    public string GetIntersections()
    {
        double xIntersection = -b / a;
        double yIntersection = b;
        return $"Intersection for line y={a}x+({b}) with abscissa is ({xIntersection}, 0), with ordinate is (0, {yIntersection})";
    }
    
    // Определение перпендикулярности
    public static bool operator !=(Straight l1, Straight l2)
    {
        return l1.a * l2.a == -1;
    }

    public static bool operator ==(Straight l1, Straight l2)
    {
        return l1.a.Equals(l2.a) && l1.b.Equals(l2.b);
    }
    
    // Определение угла между прямыми
    public static double operator %(Straight l1, Straight l2)
    {
        double angleRadians = Math.Atan(Math.Abs((l1.a - l2.a) / (1 + l1.a * l2.a))); // Формула для вычисления арктангенса угла между прямыми
        return Math.Round(angleRadians * (180 / Math.PI), 2); // Конвертация в градусы
    }
    
}