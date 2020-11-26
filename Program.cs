using System;

namespace passagens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("---------------Sistema de passagens aéreas----------------");
            Console.WriteLine("----------------------------------------------------------"); 
            Console.ResetColor();

            //Variáveis Globais
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];
            int i = 0;

            //Validação de senha
            bool senhaValida = false;
            do
            {
            Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();
            senhaValida = EfetuarLogin(senha);
            } while (!senhaValida);
            Console.Clear();

            //Menu
            int escolha;
            do{
                Console.WriteLine("Menu inicial");
                Console.WriteLine("Selecione uma das opções");
                System.Console.WriteLine("[1] - Cadastrar passagens");
                System.Console.WriteLine("[2] - Listar passagens");
                System.Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch(escolha)
                {
                    case 1:
                        //Cadastrar Passagens
                        string resposta;
                        do
                        {
                            if(i < 5)
                            {
                                System.Console.WriteLine($"Digite o nome do {i+1}° passageiro: ");
                                nomes[i] = Console.ReadLine();
                                System.Console.WriteLine($"Digite a origem do {i+1}? passageiro: ");
                                origem[i] = Console.ReadLine();
                                System.Console.WriteLine($"Digite o destino do {i+1}° passageiro: ");
                                destino[i] = Console.ReadLine();
                                System.Console.WriteLine($"Digite a data da viagem do {i+1}° passageiro: ");
                                data[i] = Console.ReadLine();
                                i++;
                            } else {
                                System.Console.WriteLine("Limite de passagens excedido!");
                            }

                            System.Console.WriteLine("Gostaria de cadastrar outro passageiro? s/n");
                            resposta = Console.ReadLine();

                        } while(resposta == "s");
                    break;

                    case 2:
                        //Listar Passagens
                        for( var cont = 0 ; cont < 5 ; cont++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            System.Console.WriteLine($"Passageiros: {nomes[cont]}");
                            System.Console.WriteLine($"Origem das viagens: {origem[cont]}");
                            System.Console.WriteLine($"Destino das viagens: {destino[cont]}");
                             System.Console.WriteLine($"Data das viagens: {data[cont]}");
                            Console.ResetColor();
                        };
                    break;

                    case 0:
                        //Sair
                        Console.Clear();
                    break;

                    default:

                    break;
                }

            } while (escolha != 0);





            //Funções
            bool EfetuarLogin(string senha){
               if(senha == "123456"){
                   Console.ForegroundColor = ConsoleColor.Green;
                   Console.WriteLine("Logado com sucesso!");
                   Console.ResetColor();
                   return true;
                }else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Senha inválida!");
                    Console.ResetColor();
                    return false;
                }
            }//Fim da função de efetuar login

            void CadastrarPassageiros()
            {

            }
        }
    }
}
