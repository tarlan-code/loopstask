#region  Task-1
using System;

int count = 0;
float num = Convert.ToInt32(Console.ReadLine());
float numForTest = num;
while (num >= 2)
{
    num /= 2;
    count++;
}

#region expon funksiyasi loop ilə
// 2^count ve 2^(count+1) tapmaq ucun kod bloku.Sonrakı kod blokunda istifade edirem

int expon = 1;
for (int i = 0; i < count; i++)
{
    expon *= 2;
}
int bigExpon = expon * 2;


#endregion


if (num > 1)  //Altdakı kod bloku əgər 2-nin qüvvəti olmasa hansı qüvvətə daha yaxın olacağını tapmaq üçündür
{

    if (numForTest - expon <= bigExpon - numForTest)
    {
        Console.WriteLine("Say: " + count);
    }
    else
    {
        Console.WriteLine("Say: " + (count + 1));
    }
}
else
{
    Console.WriteLine("Say: " + count);
}
#endregion










//#region Task-2
//using System;

//int sum = 0;
//int num = Convert.ToInt32(Console.ReadLine());

//while (num != 0)
//{
//    sum += num % 10;
//    num /= 10;
//}

//Console.WriteLine(sum);
//#endregion










//#region Task-3


//int count = 0;
//Console.WriteLine("Eded: ");
//int num = Convert.ToInt32(Console.ReadLine());

//for (int i = 2; i < num; i++)
//{
//    if (num % i == 0)
//    {
//        count++;
//    }
//}

//if (count == 0)
//{
//    Console.WriteLine("Eded sadedir");
//}

//else
//{
//    Console.WriteLine("Eded mürekkebdir");
//}

//#endregion