using System;
using System.Diagnostics.Eventing.Reader;
using System.Security.AccessControl;

class Program {

    public static string lerNumero() {
        return Console.ReadLine();
        }
    public static void Main(string[] args) {

        Random random = new Random();
        int numeroAleatorio = random.Next(1, 100);
        int tentativas = 0;
        int palpite = 0;

        Console.WriteLine(@"
░░█ █▀█ █▀▀ █▀█   █▀▄ ▄▀█   ▄▀█ █▀▄ █ █░█ █ █▄░█ █░█ ▄▀█ █▀▀ ▄▀█ █▀█
█▄█ █▄█ █▄█ █▄█   █▄▀ █▀█   █▀█ █▄▀ █ ▀▄▀ █ █░▀█ █▀█ █▀█ █▄▄ █▀█ █▄█");
        Console.Write("\nOlá! Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("\n{0}, seja bem vindo(a) ao jogo da adivinhação. Nosso gerador de números gerará um número de 1 à 100 e você precisará acertar.", nome);
        Console.WriteLine("Boa sorte!");

        while (palpite != numeroAleatorio) {
            Console.Write("\nDigite seu palpite: ");
            string entradaPalpite = lerNumero();

            if (int.TryParse(entradaPalpite, out palpite)) {
                tentativas++;
                if (palpite == numeroAleatorio) {
                    Console.WriteLine("\nParabéns {0}! Você acertou em {1} tentativas!", nome, tentativas);
                    }
                else if (palpite < numeroAleatorio) {

                    if (numeroAleatorio - palpite <= 5) {
                        Console.WriteLine("Seu palpite foi MENOR do que o número gerado, mas está muito próximo {0}!!!", nome);
                        }
                    else {
                        Console.WriteLine("Seu palpite foi MENOR do que o número gerado! Tente novamente!");
                        }
                    }
                else if (palpite > numeroAleatorio) {

                    if (palpite - numeroAleatorio <= 5) {
                        Console.WriteLine("Seu palpite foi MAIOR do que o número gerado, mas está muito próximo {0}!!!", nome);
                        }
                    else {
                        Console.WriteLine("Seu palpite foi MAIOR do que o número gerado! Tente novamente!");
                        }
                    }
                }
            else {
                Console.WriteLine("Algo deu errado, insira um número válido!");
                }
            }
        }

    }
