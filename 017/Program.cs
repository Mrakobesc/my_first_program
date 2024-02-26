//void OpenMatryoshka(int size)
//{
// System.Console.WriteLine($"Opening matryoshka of size {size}..."); // если эту команду написать после 9 строки,то будет открываться в обратном порядке
// if(size == 1)
//{
//System.Console.WriteLine("Reached the smallest matryoshka!");
// return;
//}
//OpenMatryoshka(size-1);

//}

//OpenMatryoshka(5);


int Fact(int n)
{
    if (n == 1 || n == 0)
   {
        System.Console.WriteLine($"Stop:{n}");
        return 1;
   }
    System.Console.WriteLine(n);
    return n * Fact(n - 1);
}
System.Console.WriteLine(Fact(5));    











