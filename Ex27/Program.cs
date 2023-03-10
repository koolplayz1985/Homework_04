// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//Console.Clear() - метод Clear класса Console, который удаляет из буфера консоли и ее окна отображаемую информацию
//Console.Write() - метод Write класса Console, который записывает текстовое представление заданного значения или значений в стандартный выходной поток
//Console.ReadLine() - метод ReadLine класса Console, который считывает введённое пользователем значение и возвращает его в формате строки (string)
//для того чтобы преобразовать считанную строку (string) в число (int) используем:
//Convert.ToInt32() - метод ToInt32 класса Convert, который преобразует заданное значение в 32-битовое целое число со знаком
//оператор '||' - условный логический оператор означает 'или'
//оператор '%' - вычисляет остаток от деления
//оператор '+=' - присваивание сложения (пример: x += y эквивалентно x = x + y)

Console.Clear();
Console.Write("Введите число, сумму цифр которого хотите узнать: "); //пользователь вводит число
int num = Convert.ToInt32(Console.ReadLine()); //переменной num присваиваем введённое пользователем число

//int - возвр. тип данных, SumOfDigits - имя метода, (int number) - тип данных и имя аргумента
int SumOfDigits(int number)
{
    int digit = 0; //переменная число
    int sum = 0;  //сумма цифр в числе
    for (int i = 0; number > 0 || number < 0; i++) //пока number больше или меньше ноля
    {
        digit = number % 10;  //% - знак вычисляет остаток от деления number на 10, 
                              //452 % 10 = 2, digit = 2, (1 цикл)
                              //45 % 10 = 5, digit = 5,  (2 цикл)
                              //4 % 10 = 4, digit = 4.   (3 цикл)
                              
        sum += digit;         //+= - присваивание сложения,
                              //sum = sum + digit, sum = 0 + 2, sum = 2, (1 цикл)
                              //sum = sum + digit, sum = 2 + 5, sum = 7, (2 цикл)
                              //sum = sum + digit, sum = 7 + 4, sum = 11.(3 цикл)

        number = number / 10; //переменной number присваиваем результат деления number на 10, (1 цикл)
                              //452 / 10 = 45,2 (число после запятой отсекаем), number = 45,  (2 цикл)
                              //45 / 10 = 4,5 (число после запятой отсекаем), number = 4,     (3 цикл)
                              //4 / 10 = 0,4 (число после запятой отсекаем), number = 0. (данное условие не удовлетворяет заданному условию цикла for (number > 0 || number < 0) выходим из цикла:                 
    }
    return sum; //возвращаем резуьтат работы метода SumOfDigits, sum == 11
}

//void - вид метода - принимает/не возвращает, имя PrintResult, int тип аргумента (целое число), result - его имя
void PrintResult(int result)
{
    Console.WriteLine($"Сумма цифр в числе: {result}");
}

int res = 0; //переменная в которую помещается результат работы метода, тип данных переменной тот, который указывается при описании метода
if (num > 0) res = SumOfDigits(num);
else if (num < 0) res = SumOfDigits(num);
PrintResult(res);