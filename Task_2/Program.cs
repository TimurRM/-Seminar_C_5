Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье  число: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a < (b + c) && b < (a + c) && c < (a + b)){
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}