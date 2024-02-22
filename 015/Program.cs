//int Factorial(int n)
//{
   // if(n == 1) return 1;
   // else return n * Factorial(n-1);
//}
//System.Console.WriteLine(Factorial(3));

double Factorial(int n) // тут double,а не int , потому что слишком большие числа и int не выводит просто все
{
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    System.Console.WriteLine($"{i}! = {Factorial(i)}");
}
