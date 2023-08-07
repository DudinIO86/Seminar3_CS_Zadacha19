// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
int num=int.Parse(Console.ReadLine());

int num1=0;
int num2=0;
int num3=0;
int num4=0;

//int[] Array=new int [5];
if(num>99999||num<10000)
{
    System.Console.WriteLine("Введено не пятизначное число");
}
else
{
    num1=num/10000;
    num2=num/1000%10;
    
    num3=num/10%10;
    num4=num%10;
    if(num1==num4&&num2==num3)
    //альтернативное решение через массив (закомменчен)
    //for (int i=0;i<5;i++)
    //{
        //num1=num%10;
        //num=num/10;
        //Array[i]=num1;
    //}
    //if(Array[0]==Array[4]&&Array[1]==Array[3])
    {
        System.Console.WriteLine("Число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Число не является палиндромом");
    }
}
