using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_00
{
    class Pyramid
    {
    private double sosn;        // площадь основания
    private double sbok;        // площадь боковая
    private double h;           // высота

    public Pyramid(double sosn, double sbok, double h)			// Конструктор
    {
        this.sosn = sosn;
        this.sbok = sbok;
        this.h = h;
    }

    public double Area_Pyramid()		//Вычисление площади
    {
        return sosn + sbok;
    }

    public double Volume_Pyramid()		//Вычисление объёма
    {
        return 0.33 * sosn * h;

    }
    public void InfoPyramid()		//Информация об объекте
    {
        Console.WriteLine("площадь основания=" + sosn);
        Console.WriteLine("боковая площадь=" + sbok);
        Console.WriteLine("высота=" + h);
        Console.WriteLine("Площадь пирамиды =" + Area_Pyramid() + "  Объём пирамиды=" + Volume_Pyramid());
        
    }


}
   
}
