// Напишите программу, которая на вход принимает число и выдает, является ли оно четным
Console.WriteLine("Введите число");
string num = Console.ReadLine();
if(Int32.Parse(num)%2==0){
    Console.WriteLine("Число четное");
}
else{
    Console.WriteLine("Число нечетное");
}