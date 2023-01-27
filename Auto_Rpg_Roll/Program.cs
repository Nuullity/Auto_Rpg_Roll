namespace Auto_Rpg_Roll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char genero = 'a';
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


            Console.Write("Qual o nome de seu Personagem ?");
            personagem.Nome = Console.ReadLine();



            Console.Write("Qual será sua idade ?");
            personagem.Idade = int.Parse(Console.ReadLine());




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
















        }
    }
}