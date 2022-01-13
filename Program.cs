using System;
/*
    Задание 9 - вариант 1.
    Т.к. C# - полностью ООП ЯП, создан класс Program, метод Main (Является точной входа в программу), где 
    в цикле While объявлены переменные, к которым присвоены результаты выполения методов (функций), а именно: 
    1. Метод func является основным методом решения данного варианта работы (в нем прописаны через условные 
        операторы условия выполнения варианта работы);

    2. Метод Round класса Math, входящий в состав пространства имен System (в первой строчке объявлен 
       через ключевое слово using (По простому - библиотека))
       работает с математическими функциями (Возведение в степень, округление результата);

    3. Вывод информации осуществляется с использованием метода WriteLine класса Console.
 */

namespace Lessons{
    //namespace Lesson - автоматически VS создал такое пространство имен. В данной программке его можно убрать. Но для объема его оставил
    class Program{
        //Код ниже - создание статических переменных типа double
        static bool exit_program = true;
        static int count;
        static double x;
        static double y;
        static double dx;
        static double function_result;
        static double F;
        static int N;
        static int Cycle_Count;
        
        
        // Код ниже - объявление метода func, аргументами которого являются переменнные arg1 и arg2 типов double, возвращаемый тип double
        // При соблюдении условия (см. параметры условных операторов) переменная function_result принимает значение, прописанные в варианте работы
        public static double func(double arg1, double arg2){
            if (arg1 < -0.9)
            {
                function_result = 3 * arg1 + arg1 - 6;
            }
            else if (arg1 >= - 0.9 && arg1 <= 0.9)
            {
                function_result = 74 * arg2;
            }
            else if (arg1 > 0.9)
            {
                function_result = (Math.Pow((arg2), (arg1 + 1))  - 5 * arg1);
            }
            return function_result;
        }

        public static double Lab_Task6_Var1(double arg1, double arg2){
            function_result = Math.Pow(arg2, 2) + Math.Pow(arg1, 2) + 5 * arg1 * arg2 + 78;
            return function_result;
        }

        public static double Lab_Task7_Var30(double arg1, double arg2) {
            if (arg1 > arg2)
            {
                function_result = Math.Atan(arg1 + arg2);
            }
            else if (arg1 < arg2)
            {
                function_result = Math.Max(arg1 * arg2, arg2+5);
                
            }
            else {
                function_result = (arg1 * arg2) / (Math.Pow(arg1 + arg2, arg1*arg2));
            }
            return function_result;
        }

        public static double Lab_Task8_1A_Var2(double arg1, double arg2) {
            function_result = Math.Pow(arg2, 2) + Math.Pow(arg1, 2) + 5 * arg1 * arg2 + 78;
            return function_result;
        }

        public static double Lav_Task8_1B_Var2(double arg1, double arg2) {
            function_result = Math.Pow(arg2, 2) + Math.Pow(arg1, 2) + 5 * arg1 * arg2 + 78;
            return function_result;
        }

        // Код ниже - точка входа в программу
        static void Main(string[] args){
            while (exit_program) {
                Console.WriteLine("Выберите, что вы хотите вывести на экран: ");
                Console.WriteLine("1. КДЗ, задание 9, вариант 1");
                Console.WriteLine("2. ЛР, задание 6, вариант 1");
                Console.WriteLine("3. ЛР, задание 7, вариант 30");
                Console.WriteLine("4. ЛР, задание 8.1а, вариант 2");
                Console.WriteLine("5. ЛР, задание 8.1б, вариант 2");
                Console.WriteLine("Для выходя из программы введите 0");
                count = int.Parse(Console.ReadLine());
                switch (count) {
                    case 1:
                        Console.WriteLine("Вы выбрали КДЗ, задание 9, вариант 1, смотрите: ");
                        x = -3;
                        y = 8.1;
                        dx = 0.3;
                        while (x <= 2) {
                            //Про цикл while написать нечего. Выбрал его для простоты. for слишком громоздкий, лень писать

                            // В переменную F прсваивается результат работы метода func (принимает значение переменной function_result из метода func)
                            F = func(x, y);
                            Console.WriteLine("X= " + x + " F= " + Math.Round(F, 5));
                            x = Math.Round(x, 5) + dx;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Вы выбрали ЛР, задание 6, вариант 1, смотрите: ");
                        Console.WriteLine("Введите число Х: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите число Y: ");
                        y = int.Parse(Console.ReadLine());
                        F = Math.Round(Lab_Task6_Var1(x, y), 2);
                        Console.WriteLine("Результат выполнения функции (округленное до двух знаков после запятой) F = " + F);
                        break;
                    case 3:
                        Console.WriteLine("Вы выбрали ЛР, задание 7, вариант 30, смотрите: ");
                        Console.WriteLine("Введите число Х: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите число Y: ");
                        y = int.Parse(Console.ReadLine());
                        F = Math.Round(Lab_Task7_Var30(x, y), 2);
                        Console.WriteLine("Результат выполнения функции (округленное до двух знаков после запятой) F = " + F);
                        break;
                    case 4:
                        Console.WriteLine("Вы выбрали ЛР, задание 8.1А, вариант 2, смотрите: ");
                        x = -2;
                        y = 3.2;
                        dx = 0.5;
                        while (x <= 4)
                        {
                            F = Lab_Task8_1A_Var2(x, y);
                            Console.WriteLine("X= " + x + " F= " + Math.Round(F, 5));
                            x = x + dx;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Вы выбрали ЛР, задание 8.1Б, вариант 2, смотрите: ");
                        Console.WriteLine("Введите число N: ");
                        N = int.Parse(Console.ReadLine());
                        int[] mas = new int[N];
                        y = 3.2;
                        Random rnd = new Random();
                        for (Cycle_Count = 0; Cycle_Count < N; Cycle_Count++) {
                            mas[Cycle_Count] = rnd.Next(0, 50);
                            F = Lav_Task8_1B_Var2(mas[Cycle_Count], y);
                            Console.WriteLine("Значение массива в X" + Cycle_Count + "= " + mas[Cycle_Count] + " F= " + F);
                       }
                        break;
                }
                if (count == 0){
                    exit_program = false;
                    Console.WriteLine("Хе-хе... Bye");                 
                }
                
            }
        }
    }
}