/*Objetivo:
Crie um programa de console que gera um número aleatório e desafia o usuário a adivinhá-lo.
*/

Console.WriteLine("Vamos jogar um jogo! estou pensando em um numero de 1 ate 100, tente adivinhar! ");
Console.WriteLine("quer jogar? s ou n");
string play = Console.ReadLine();
if (play.ToLower() == "s" )
{
bool again = true;

while (again)  //laço de repetição
{
    Random instance = new Random();     // cria um numero aleatório
    int secretNumber = instance.Next(1, 101);

    int guess = 0; //armazena o numero do usuario
    while (guess != secretNumber)   // laço de repetição enquanto não acerta
    {
        Console.Write("que numero? : ");
        string awnser = (Console.ReadLine());
        if (int.TryParse(awnser, out guess))    // transofrma a resposta do usuario em int
        {
            if (guess < secretNumber)
            {
                Console.WriteLine("o número é maior!");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("o numero é menor!");
            }
        }
        else
        {
            Console.WriteLine("digite um numero de verdade.");
        }
    }
    Console.WriteLine("Parabéns! acertou o numero");

    Console.Write("quer jogar de novo? ");
    string anotherTry = Console.ReadLine();

    if (anotherTry.ToLower() != "s")  // se o jogador quiser sojar de novo, repete, se nao, da clear no codigo
    {
        again = false;
    }
    else
    {
        Console.Clear();
    }
}
Console.WriteLine("obrigado por jogar");
}
else
{
    Console.WriteLine("Toma no seu cu então");
}