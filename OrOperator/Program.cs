


int math, biology, chemistry;

Console.WriteLine("Enter your Math results:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology results:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry results:");
chemistry = Int32.Parse(Console.ReadLine());

if ((chemistry >= 90 && math >= 90) || (chemistry >= 90 && biology >= 90) || (math >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulation! You got accepted");
}
else
{
    Console.WriteLine(" Your application cannot be approved.");
}

