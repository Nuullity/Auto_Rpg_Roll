using System.Data;

namespace Auto_Rpg_Roll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char genero = 'a';
            int pontos_atributos = 27;
            int provisorio = 0;

            Personagem personagem = new Personagem();
            personagem.Raca = -1;

            /*
            Console.WriteLine(" -----------------------------------------------------");
            Console.WriteLine(" Nome:            Idade:             Classe:          ");
            Console.WriteLine(" Raça:            Pontos de Vida:                     ");
            Console.WriteLine("                                                      ");
            Console.WriteLine(" Suas Proeficiencias:                                 ");
            Console.WriteLine("  >                                                   ");
            Console.WriteLine("  >                                                   ");
            Console.WriteLine("  >                                                   ");
            Console.WriteLine("                                                      ");
            Console.WriteLine(" Carisma:                                             ");
            Console.WriteLine(" Esperteza:                                           ");
            Console.WriteLine(" Inteligência:                                        ");
            Console.WriteLine(" Força:                                               ");
            Console.WriteLine(" Agilidade:                                           ");
            Console.WriteLine(" Resistencia:                                         ");
            Console.WriteLine("                                                      ");
            Console.WriteLine(" -----------------------------------------------------");
            */



            // fazer com que o programa apenas prossiga com um genero valido
            while (genero != 'M' && genero != 'm' && genero != 'N' && genero != 'n' && genero != 'F' && genero != 'f')
            {


                Console.Write("Olá Qual seu genero ? ");
                Console.WriteLine("|M| |N| |F|");
                genero = char.Parse(Console.ReadLine());
                Console.Clear();


            }
            if (genero == 'F' || genero == 'f')
            {


                Console.WriteLine("Olá forasteira, esta pronta para CEIFAR algumas almas?");
            }
            else if (genero == 'N' || genero == 'n')
            {

                Console.WriteLine("Olá forasteire, esta pronte para CEIFAR algumas almas?");

            }
            else if (genero == 'M' || genero == 'm')
            {

                Console.WriteLine("Olá forasteiro, esta pronto para CEIFAR algumas almas?");
            }


            Console.Write("Qual o nome de seu Personagem ? ");
            personagem.Nome = Console.ReadLine();



            Console.Write("Qual será sua idade ? ");
            personagem.Idade = int.Parse(Console.ReadLine());

            Console.Clear();
            // fazer  atribuição de atributos, com base na funçao Atributo
            Console.WriteLine($"Voce irá definir agr os pontos de atributos de seu personagem");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("|          Valor Custo |    Valor Custo      |");
            Console.WriteLine("|        (1)  8     0  | (5)  12     4       |");
            Console.WriteLine("|        (2)  9     1  | (6)  13     5       |");
            Console.WriteLine("|        (3)  10    2  | (7)  14     7       |");
            Console.WriteLine("|        (4)  11    3  | (8)  15     9       |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|        Caso fique com Pontos negativos     |");
            Console.WriteLine("|   o software irá se fechar automaticamente |");
            Console.WriteLine("----------------------------------------------");

            Console.Write($"Voce possui {pontos_atributos} pontos, defina o valor para o atributo Carisma: ");
            personagem.C = provisorio = Atributo(int.Parse(Console.ReadLine()));
            pontos_atributos = pontos_atributos - Custo(provisorio);
            Console.Write($"Voce possui {pontos_atributos} pontos, defina o valor para o atributo Esperteza: ");
            personagem.E = provisorio = Atributo(int.Parse(Console.ReadLine()));
            pontos_atributos = pontos_atributos - Custo(provisorio);

            Console.Write($"Voce possui {pontos_atributos} pontos, defina o valor para o atributo Inteligência: ");
            personagem.I = provisorio = Atributo(int.Parse(Console.ReadLine()));
            pontos_atributos = pontos_atributos - Custo(provisorio);

            Console.Write($"Voce possui {pontos_atributos} pontos, defina o valor para o atributo Força: ");
            personagem.F = provisorio = Atributo(int.Parse(Console.ReadLine()));
            pontos_atributos = pontos_atributos - Custo(provisorio);

            Console.Write($"Voce possui {pontos_atributos} pontos, defina o valor para o atributo Agilidade: ");
            personagem.A = provisorio = Atributo(int.Parse(Console.ReadLine()));
            pontos_atributos = pontos_atributos - Custo(provisorio);
            Console.Write($"Voce possui {pontos_atributos} pontos, defina o valor para o atributo Resistência: ");
            personagem.C = provisorio = Atributo(int.Parse(Console.ReadLine()));
            pontos_atributos = pontos_atributos - Custo(provisorio);

            Console.Clear();

            if (pontos_atributos >= 0)
            {





                // Raça e classe são jogados na Class personagem e la é feito os processos
                //definir raça


                while (personagem.Raca == -1)
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("|                    >Escolha sua Raça<                       |");
                    Console.WriteLine("|                                                             |");
                    Console.WriteLine("|(1) - Anão da Colina               ( 8) - Humano             |");
                    Console.WriteLine("|(2) - Anão da Montanha             ( 9) - Draconato          |");
                    Console.WriteLine("|(3) - Alto Elfo                    (10) - Gnomo da Floresta  |");
                    Console.WriteLine("|(4) - Elfo da Floresta             (11) - Gnomo das Rochas   |");
                    Console.WriteLine("|(5) - Elfo Negro                   (12) - Meio Elfo          |");
                    Console.WriteLine("|(6) - Halfling dos Pés Leves       (13) - Meio Orc           |");
                    Console.WriteLine("|(7) - Halfling Robusto             (14) - Tiefling           |");
                    Console.WriteLine("---------------------------------------------------------------");



                    personagem.Raca = int.Parse(Console.ReadLine());
                    personagem.PontosRaca();



                }


                // CONTINUAR A APRTIR DAQUI, CRIAÇÃO DE SISTEMA DE CLASSES DE FORMA QUE LIMITE AS PROEFICIENCIAS DISPONIVEIS ASSIM COMO CALCULE A VIDA DO PLAYER, NECESSARIO VER COMANDO PARA GERAR NUMERO ALEATORIO EM UM RANGE)
                //definir classe 


                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("|                    >Escolha sua Classe<                     |");
                Console.WriteLine("|                                                             |");
                Console.WriteLine("|(1) - Bárbaro                      ( 7) - Guerreiro          |");
                Console.WriteLine("|(2) - Bardo                        ( 8) - Ladino             |");
                Console.WriteLine("|(3) - Bruxo                        ( 9) - Mago               |");
                Console.WriteLine("|(4) - Clérigo                      (10) - Monge              |");
                Console.WriteLine("|(5) - Druida                       (11) - Paladino           |");
                Console.WriteLine("|(6) - Feiticeiro                   (12) - Patrulheiro        |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Work In Progress................");




                personagem.Classe = int.Parse(Console.ReadLine());
                personagem.Classe = int.Parse(Console.ReadLine());
                personagem.Classe = int.Parse(Console.ReadLine());
















            }

            static int Atributo(int m)
            {

                switch (m)
                {

                    case 1:

                        m = 8;





                        break;
                    case 2:
                        m = 9;



                        break;
                    case 3:
                        m = 10;


                        break;
                    case 4:
                        m = 11;


                        break;
                    case 5:
                        m = 12;

                        break;
                    case 6:
                        m = 13;

                        break;
                    case 7:
                        m = 14;

                        break;
                    case 8:
                        m = 15;

                        break;
                        
                }
                return m;



            }
            static int Custo(int m)
            {
                switch (m)
                {

                    case 1:

                        m = -0;





                        break;
                    case 2:
                        m = -1;



                        break;
                    case 3:
                        m = -2;

                        break;
                    case 4:
                        m = -3;

                        break;
                    case 5:
                        m = -4;
                        break;
                    case 6:

                        m = -5;
                        break;
                    case 7:

                        m = -7;
                        break;
                    case 8:
                        m = -9; ;

                        break;

                }
                return m;


            }


        }

    }// fechar a gambiarra do if para custo de atributo

}