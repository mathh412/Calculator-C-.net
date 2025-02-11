// See https://aka.ms/new-console-template for more information

Menu();
//Menu
void Menu()
{
    Console.Clear();
    Console.WriteLine("Escolha a operação:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Resto da divisão");
    Console.WriteLine("6 - Potenciação");
    Console.WriteLine("0 - Sair");
    string Key = Console.ReadKey().Key.ToString();
    if (Key == "D0")
    {
        return;
    }
    if (!(Key == "D1" || Key == "D2" || Key == "D3" || Key == "D4" || Key == "D5" || Key == "D6" || Key == "D0"))
        Menu();
    Conta(Key);
}
void Conta(string Operação)
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro número e depois aperte enter: ");
    int Num1= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o segundo número e depois aperte enter: ");
    int Num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("O resultado é: ");
    switch (Operação)
    {
        case "D1":
            Console.WriteLine((Num1 + Num2));
            Console.WriteLine("pressione qualquer tecla para reiniciar");
            break;

        case "D2":
            Console.WriteLine((Num1 - Num2));
            Console.WriteLine("pressione qualquer tecla para reiniciar");
            break;

        case "D3":
            Console.WriteLine((Num1 * Num2));
            Console.WriteLine("pressione qualquer tecla para reiniciar");
            break;

        case "D4":
            if(Num2 == 0)
               Console.WriteLine("Não é possível dividir por 0");
            else
                Console.WriteLine((Num1 / Num2));
            Console.WriteLine("pressione qualquer tecla para reiniciar");
            break;

        case "D5":
            if (Num2 == 0)
                Console.WriteLine("Não é possível tirar resto de divisões por 0");
            else
                Console.WriteLine((Num1 % Num2));
            Console.WriteLine("pressione qualquer tecla para reiniciar");
            break;

        case "D6":
            Console.WriteLine((Math.Pow(Num1,Num2)));
            Console.WriteLine("pressione qualquer tecla para reiniciar");
            break;
    }
    Console.ReadKey();
    Menu();

}