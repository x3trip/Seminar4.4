//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreatArray(int size)
{
    int[] array = new int[size];  
    for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите элемент массива ({i+1}/{size}) >: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    return array;
}    

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

}

Console.Write("input a number ");
int num2 = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreatArray(num2);
WriteArray(myArray);
*/
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
double Degree(double num1, double num2)
{
    return Math.Pow(num1, num2);
}
Console.Write("Input A: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Input B: ");
double b = Convert.ToDouble(Console.ReadLine());
double deg = Degree(a,b);
Console.WriteLine(deg);
*/
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int num)
{
    int res = 0;
    while(num > 0)
    {
        res += num % 10;
        // int num1 = num % 10;
        // res +=num1;
        num /=10;  

    }
    return res;
}
Console.Write("input a number ");
int num2 = Convert.ToInt32(Console.ReadLine());
int rest = Sum(num2);
Console.WriteLine(rest);
*/