// Задача семинара 2

Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 == number1 * number1){
    Console.WriteLine("Да");
}
else if (number1 == number2 * number2){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}