try
{
    Console.WriteLine("Введите температуру");
    int temp = int.Parse(Console.ReadLine());
    { 
       if(temp>20) Console.WriteLine("Можно выпустить на прогулку слонов, жирафов и львов");
       else if (temp < 20) Console.WriteLine("Можно выпустить на прогулку только кенгуру");
            else Console.WriteLine("Температура не входит ни в один из диапазонов");
    }

}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}