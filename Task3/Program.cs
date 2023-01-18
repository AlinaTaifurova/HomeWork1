//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

int InputInt(string massage)
{
    Console.WriteLine(massage);
    int х = Convert.ToInt32(Console.ReadLine());
    return х;
}
int a = InputInt("Привет! Введи число и я скажу четное оно или нет  ");
int b = 2;
if (a % b == 0)
    Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");
