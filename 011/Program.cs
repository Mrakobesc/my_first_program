// вид 1

void Method1()
{
    Console.WriteLine("Автор...");
}
// Method1();


// вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4); - пояснение
//Method21( "Текст",  4);


// вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// вид 4

//string Method4(int count,string text)
//{
    //int i = 0;
    //string result = string.Empty;
    //while (i < count)
   // {
        //result = result + text;
       // i++;
   // }
    //return result;
//}
//string result = Method4(10,"asd");
//System.Console.WriteLine(result);

// вид 4 более коротким способом
//string Method5(int count,string text)
//{
    
    //string result = string.Empty;
    //for(int i = 0;i < count;i++)
   
    //{
        //result = result + text;
   // }
    //return result;
//}
//string result = Method5(10,"asd");
//System.Console.WriteLine(result);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i}*{j}={i*j}");
    }
    //System.Console.WriteLine(); - для красоты можно добавить
}


