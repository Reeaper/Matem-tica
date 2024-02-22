namespace Main;

class Program
{
    static void Main (string[]args)
    {
        Matematica.Calc(5,5, Matematica.Soma,(resultado) => Console.WriteLine(resultado));
        Matematica.Calc(5,5,(num1,num2) => num1 - num2);
    }
}