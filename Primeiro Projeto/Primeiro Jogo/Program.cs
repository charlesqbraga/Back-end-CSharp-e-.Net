//Jogo do número secreto



Random aleatorio = new Random(); //Numeros random
int numeroSecreto = aleatorio.Next(1, 101); //Define o número secreto

do
{
    Console.Write("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine()); // converte no Parse.

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número em cheio.");
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número é maior do que o escolhido.");
    }
    else
    {
        Console.WriteLine("O número é menor do que o escolhido.");
    }

} while (true);

Console.WriteLine("O jogo acabou. Você acertou o número secreto, Parabens! :)");
