public static class Matematica{
// delegaçao de tarefas
    public delegate double Callback(double num1,double num2);

    // condiçao 
    public static string Calc(double num1,double num2,
    Func<double,double,double> operacao,
    Action<double>? showResult=null
    ){
        double resultado = operacao(num1,num2);
        Validation(resultado,"O valor não pode ser negativo",Negativo);
        showResult?.Invoke(resultado);
        return $"R${resultado}";
    }

    // validaçao da excessao
    public static void Validation(double ValTotal,string menssagemErro,Predicate<double> validar)
    {
        if(ValTotal < 0){

            // excessao pra resultado negativo
            throw new Exception(menssagemErro);
        }
    }

    // calculo da soma de dois numeros
    public static double Soma(double num1,double num2) => num1 + num2;

    // calculo da subtraçao de dois numeros
    public static double Sub(double num1,double num2) => num1 - num2;

    // predicate que so retorna valores booleanos
    public static bool Negativo(double valor) => valor < 0;
}