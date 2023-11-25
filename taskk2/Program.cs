class Taskk2
{
    static void Main()

    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
    }

    static void Task1()
    {
        string name = "Aqil";
        string lastName = "Abbasov";

        string FullName = name + " " + lastName;

        Console.WriteLine(FullName);
    }

    static void Task2()
    {
        int a = 5;
        int b = 3;
        int cavab = a + b;
        Console.WriteLine(cavab);
    }

    static void Task3()
    {
        int a = 3;
        int b = 5;
        int cavab = a - b;
        Console.WriteLine(cavab);
    }

    static void Task4()
    {
        int a = 2;
        int b = 3;
        int c = a * b;
        int cavab = c * c;
        Console.WriteLine(cavab);
    }

    static void Task5()
    {
        int a = 18;
        int b = 5;
        int c = a / b;
        int cavab = c * c;
        Console.WriteLine(cavab);
    }
}