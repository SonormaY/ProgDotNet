void Greet(string userName){
    System.Console.WriteLine($"Greetings, {userName}");
}

void PrintNameAndAge(string userName, int age){
    System.Console.WriteLine($"{userName}, {age}");
}

void PrintToTen(){
    for (int i = 1; i < 11; i++)
    {
        System.Console.WriteLine(i);
    }
}

void Sum(int num1, int num2){
    System.Console.WriteLine(num1 + num2);
}

void Main(){
    System.Console.WriteLine("Enter your name and age");
    var userName = Console.ReadLine();
    var age = Convert.ToInt32(Console.ReadLine());
    Greet(userName);
    System.Console.WriteLine();
    PrintNameAndAge(userName, age);
    System.Console.WriteLine();
    PrintToTen();
    System.Console.WriteLine();
    System.Console.WriteLine("Enter two numbers to sum");
    var num1 = Convert.ToInt32(Console.ReadLine());
    var num2 = Convert.ToInt32(Console.ReadLine());
    Sum(num1, num2);
    System.Console.WriteLine("Enter a sentence to sort");
    var text = Console.ReadLine();
    SortArray(text);
}

void SortArray(string nums){
    var arr = nums.Split(' ');
    Array.Sort(arr);
    foreach (var item in arr)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}

Main();