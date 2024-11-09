using System;

class Point3D
{
    public int x, y, z;

    public Point3D()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    public Point3D(int xKey, int yKey, int zKey)
    {
        x = xKey;
        y = yKey;
        z = zKey;
    }

    // Операторная функция, в которой реализуется алгоритм преобразования
    // значения типа Point2D в значение типа Point3D. 
    //Это преобразование осуществляется НЕЯВНО.
    public static implicit operator Point3D(Point2D p2d)
    {
        Point3D p3d = new Point3D();
        p3d.x = p2d.x;
        p3d.y = p2d.y;
        p3d.z = 0;
        return p3d;
    }
}

class Point2D
{
    public int x, y;

    public Point2D()
    {
        x = 0;
        y = 0;
    }

    public Point2D(int xKey, int yKey)
    {
        x = xKey;
        y = yKey;
    }

    // Операторная функция, в которой реализуется алгоритм преобразования
    // значения типа Point3D в значение типа Point2D. 
    // Это преобразование     осуществляется с ЯВНЫМ указанием необходимости преобразования.

    // Принятие решения относительно присутствия в объявлении ключевого
    // слова explicit вместо implicit оправдывается тем, что это
    // преобразование сопровождается потерей информации. 
    public static explicit operator Point2D(Point3D p3d)
    {
        Point2D p2d = new Point2D();
        p2d.x = p3d.x;
        p2d.y = p3d.y;
        return p2d;
    }

}

class TestClass
{
    static void Main(string[] args)
    {
        Point2D p2d = new Point2D(125, 125);
        Point3D p3d; 
        // Этой ссылке присваивается значение в результате
        // НЕЯВНОГО преобразования значения типа Point2D к типу Point3D
        p3d = p2d;

        // Изменили значения полей объекта.  
        p3d.x = p3d.x * 2;
        p3d.y = p3d.y * 2;
        p3d.z = 125; // Главное – появилась новая информация,
        // которая будет потеряна в случае присвоения значения типа Point3D
        // значению типа Point2D.
        // Ключевое слово explicit в объявлении соответствующего
        // метода преобразования вынуждает программиста подтверждать,
        // что он в курсе возможных последствий этого преобразования.
        p2d = (Point2D)p3d;
    }
}

