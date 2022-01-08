using System;

namespace Расчет_массы_заготовки
{
    class Program
    {
        private const string V = "материала, плотность для которого была указана вами";

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать! Для начала работы введите форму заготовки: цилиндр, куб или прямоугольник, которой нужно расчитать и нажмите Enter");
            bool cube = false;
            bool pryamo = false;
            bool cil = false;

            string form = Console.ReadLine();
            if (form == "цилиндр" || form == "целиндр " || form == "цилиндрический")
            {
                cil = true;
                cube = false;
                pryamo = false;
            }
            else if (form == "куб" || form == "кубический" || form == "квадрат")
            {
                cube = true;
                cil = false;
                pryamo = false;

            }
            else if (form == "прямоугольник" || form == "призма" || form == "параллелограмм")
            {
                pryamo = true;
                cil = false;
                cube = false;
            }
            else
            {
                Console.WriteLine("вы ввели неверную форму. Перезапустите программу");
                return;
            }
            if ((cube is true) || (cil is true) || (pryamo is true))
            {
                Console.WriteLine("Вы выбрали форму, теперь укажите материал из предоставленного ниже списка \nАлюминий, Сталь, Чугун или введите команду *указать*, чтоб указать плотность материала объекта");
            }
            else
            {
                return;
            }
            {
                if ((cube is true))
                {
                    Console.WriteLine("вы выбрали кубическую форму");
                }
                else if ((cil is true))
                {
                    Console.WriteLine("вы выбрали цилиндрическую форму");
                }
                else if ((pryamo is true))
                {
                    Console.WriteLine("вы выбрали прямоугольную форму");
                }
            }
                string material = Console.ReadLine();
                bool alum = false;
            bool steel = false;
                bool cast = false;
                double ro;
                if (material == "алюминий" || material == "люмень" || material == "алюминиевый" || material == "Алюминий")
            {
                ro = 2.7d;
                alum = true;
            }
                else if (material == "сталь" || material == "стальной" || material == "сталюка" || material == "Сталь")
            {
                ro = 7.85d;
                steel = true;
            }
                else if (material == "чугун" || material == "чугуний" || material == "чугуновый" || material == "Чугун")
            {
                ro = 7.87d;
                cast = true;
            }
            else if (material == "указать" || material == "*указать*" || material == "указывать" || material == "Указать" || material == "*Указать*")
            {
                try
                {
                    Console.WriteLine("укажите плотность материала по системе СИ (г/см3) через запятую");
                    ro = Convert.ToDouble(Console.ReadLine());
                    material = V;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("вы ввели плотность в неверном формате, перезапустите программу и попробуйте снова в формате г/см3 используя только цифры и запятую");
                    return;
                }
                
            }
            else
            {
                Console.WriteLine("вы ввели неверный материал. Перезапустите программу");
                return;

            }
            Console.WriteLine("вы указали материал с плотностью " + ro + "г/см3");
            {
                if (cube is true)
                {
                    try
                    {
                        Console.WriteLine("укажите длину ребра куба в миллиметрах");
                        double s = Convert.ToDouble(Console.ReadLine());
                        int volume = Convert.ToInt32(Math.Pow(s, 3));
                        Console.WriteLine("объем вашего куба из " + material + " равна " + volume + "мм кубических");
                        double mass = ((volume * (ro / 10)) / 100);
                        Console.WriteLine("Расчетная масса куба, исходя из введенных вами данных равна " + mass + "грамм");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("вы неверно ввели значение размеров, перезапустите программу и попробуйте снова используя только цифры и запятые");
                        return;
                    }
                }
                else if (cil is true)
                {
                    try
                    {
                        Console.WriteLine("сначала укажите ДИАМЕТР цилиндра в миллиметрах");
                        double D = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("теперь укажите ВЫСОТУ (h) цилиндра в миллиметрах");
                        double height = Convert.ToDouble(Console.ReadLine());
                        double radius = D / 2;
                        double area = (Math.PI * (Math.Pow(radius, 2)));

                        double volume = area * height;
                        Console.WriteLine("объем вашего цилиндра из " + material + " равна " + volume + "мм кубических");
                        double mass = ((volume * (ro / 10))/100);
                        Console.WriteLine("Расчетная масса цилиндра, исходя из введенных вами данных равна " + mass + "грамм");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("вы неверно ввели значение размеров, перезапустите программу и попробуйте снова используя только цифры и запятые");
                        return;
                    }

                }
                else
                {
                    try
                    {
                        Console.WriteLine("укажите длину длинного ребра прямоугольника в миллиметрах");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("укажите длину короткого ребра прямоугольника в миллиметрах");
                        double b = Convert.ToDouble(Console.ReadLine());
                        double area = a * b;
                        Console.WriteLine("укажите ВЫСОТУ h прямоугольника в миллиметрах");
                        double h = Convert.ToDouble(Console.ReadLine());
                        double volume = area * h;
                        Console.WriteLine("объем вашего прямоугольника из " + material + " равна " + volume + "мм кубических");
                        double mass = ((volume * (ro / 10)) / 100);
                        Console.WriteLine("Расчетная масса прямоугольника, исходя из введенных вами данных равна " + mass + "грамм");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("вы неверно ввели значение размеров, перезапустите программу и попробуйте снова используя только цифры и запятые");
                        return;

                    }
                }

            }
            }
            
    }
} 
                   

            
            

