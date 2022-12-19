// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Console.ReadLine() - метод ReadLine класса Console, который считывает введённое пользователем значение и возвращает его в формате строки (string)
//для того чтобы преобразовать считанную строку (string) в число (int) используем:
//Convert.ToInt32() - метод ToInt32 класса Convert, который преобразует заданное значение в 32-битовое целое число со знаком

Console.Write ("Введите число А - возводимое в степень: ");//пользователь вводит число
int nA = Convert.ToInt32(Console.ReadLine());              //переменной nA присваиваем введённое пользователем число
Console.Write ("Введите число В - степень в которую необходимо возвести: ");//пользователь вводит число
int nB = Convert.ToInt32(Console.ReadLine());              //переменной nB присваиваем введённое пользователем число

//int - возвр. тип данных, Exponentiation - имя метода, int number, degree - тип данных и имена аргументов
int Exponentiation(int number, int degree) //number - возводимое число A (3), degree - степень в которое возводится B (5))
{
    int exponentiationNumber = number;     //переменной exponentiationNumber присвоить значение number (3)
    for (int i = 1; i < degree; i++)       //i это текущая степень (1), пока i меньше degree (заданная пользоваталем степень - 5)
    {                                      //пока текущая степень (i) меньше заданной (degree) умножаем заданное число nA (3) на себя
        exponentiationNumber = exponentiationNumber * nA; //exponentiationNumber - сумма возведения в степень числа 3,
    }
    return exponentiationNumber;           //возращаем результат работы метода - число 243
}
//void - вид метода - принимает/не возвращает, имя PrintResult, int тип аргумента (целое число), result - его имя
void PrintResult(int result)// (res)
{                     //      (3)                        (5)              (res)
    Console.WriteLine($"Число {nA} в натуральной степени {nB} дает число {result}");
}

//т.е. сначала мы прописываем алгоритм работы двух методов:
//1. Exponentiation - возводит заданное число в заданную степень
//2. PrintResult - выводит в консоль текст в который помещены результаты работы метода Exponentiation

int res = Exponentiation(nA, nB); //переменной res присвоить результат работы метода Exponentiation с числами 3 и 5 = 243
PrintResult(res); //вызываем метод PrintResult 