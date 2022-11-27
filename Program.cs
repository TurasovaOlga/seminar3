
void zadacha19
{

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine ("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 10000;
int b = number % 10000 / 1000;
int c = number % 1000 / 100;
int d = number % 100 / 10;
int e = number % 10;
if (a==e && b==d)
    {
    Console.WriteLine("Это палиндром");
    }  
    else 
    {
       
        Console.WriteLine("Это не палиндром");
    }
}      




void zadacha21
{
    //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Впешите координаты х1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Впешите координаты х2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Впешите координаты y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Впешите координаты y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Впешите координаты z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Впешите координаты z2");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{Math.Sqrt((x2-x1)^2+(y2-y1)^2+(z2-z1)^2)}");
}

void zadacha23
{
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int index=0;
int stepen=3;
if (index>N)
{
    Console.WriteLine ("все кубы числе от 1 до N найдены");
}
while (index<N)
{
    index++;
    Console.WriteLine ("index^3="+Math.Pow(index,stepen));
}
}
