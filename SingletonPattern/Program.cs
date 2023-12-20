// See https://aka.ms/new-console-template for more information

using SinglePattern;

Main();

void Main()
{
    Singleton firstInstance = Singleton.GetInstance();
    Singleton secondInstance = Singleton.GetInstance();

    if(firstInstance == secondInstance)
    {
        Console.WriteLine("Both the instances are same hence its a correct implementation of SingletonPattern");
    }
    else
    {
        Console.WriteLine("Both the instances are not same hence its an Incorrect implementation of SingletonPattern");
    }

}

