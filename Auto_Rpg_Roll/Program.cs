using System.Data;

namespace Auto_Rpg_Roll
{
    internal class Program
    {
           static void Main(string[] args)
        {

            char genero = 'a';
            int provisorio = 0;
            int pontos_atributos = -1; ; // gambiarra para while 

            Personagem personagem = new Personagem();
            personagem.Raca = -1;
            personagem.Classe = -1;

            
            /*
            Console.WriteLine(" -----------------------------------------------------");
            Console.WriteLine(" Nome:            Idade:             Classe:          ");
            Console.WriteLine(" Raça:            Pontos de Vida:                     ");
            Console.WriteLine("                                                      ");
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



            while (pontos_atributos < 0 || pontos_atributos > 27)
            {
                pontos_atributos = 27;
                personagem.C = 0;
                personagem.E = 0;
                personagem.I = 0;
                personagem.F = 0;
                personagem.A = 0;
                personagem.R = 0;


                // fazer  atribuição de atributos, com base na funçao Atributo
                Console.WriteLine($"Voce irá definir agr os pontos de atributos de seu personagem");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("|          Valor Custo |    Valor Custo      |");
                Console.WriteLine("|            8     0   |     12     4        |");
                Console.WriteLine("|            9     1   |     13     5        |");
                Console.WriteLine("|            10    2   |     14     7        |");
                Console.WriteLine("|            11    3   |     15     9        |");
                Console.WriteLine("|                                            |");
                Console.WriteLine("|              >Digite o Valor<              |");
                Console.WriteLine("|      Caso fique com Pontos negativos       |");
                Console.WriteLine("|  o software irá se resetar automaticamente |");
                Console.WriteLine("----------------------------------------------");

                Console.Write($"Voce possui {pontos_atributos} pontos, defina o valor para o atributo Carisma: ");

                provisorio = (int.Parse(Console.ReadLine()));
                personagem.C = Atributo(provisorio);
                pontos_atributos = pontos_atributos + Custo(provisorio);


                Console.Write($"Voce possui {pontos_atributos} pontos, defina o valor para o atributo Esperteza: ");
                provisorio = (int.Parse(Console.ReadLine()));
                personagem.E = Atributo(provisorio);
                pontos_atributos = pontos_atributos + Custo(provisorio);


                Console.Write($"Voce possui {pontos_atributos} pontos, defina o valor para o atributo Inteligência: ");
                provisorio = (int.Parse(Console.ReadLine()));
                personagem.I = Atributo(provisorio);
                pontos_atributos = pontos_atributos + Custo(provisorio);


                Console.Write($"Voce possui {pontos_atributos} pontos, defina o valor para o atributo Força: ");
                provisorio = (int.Parse(Console.ReadLine()));
                personagem.F = Atributo(provisorio);
                pontos_atributos = pontos_atributos + Custo(provisorio);

                Console.Write($"Voce possui {pontos_atributos} pontos, defina o valor para o atributo Agilidade: ");
                provisorio = (int.Parse(Console.ReadLine()));
                personagem.A = Atributo(provisorio);
                pontos_atributos = pontos_atributos + Custo(provisorio);


                Console.Write($"Voce possui {pontos_atributos} pontos, defina o valor para o atributo Resistência: ");
                provisorio = (int.Parse(Console.ReadLine()));
                personagem.R = Atributo(provisorio);
                pontos_atributos = pontos_atributos + Custo(provisorio);
                Console.Clear();
            }









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
                //mete modificador nos atruibutos
                personagem.BC = Modificador(personagem.C, personagem.BC);

                personagem.BE = Modificador(personagem.E, personagem.BE);

                personagem.BI = Modificador(personagem.I, personagem.BI);

                personagem.BF = Modificador(personagem.F, personagem.BF);

                personagem.BA = Modificador(personagem.A, personagem.BA);

                personagem.BR = Modificador(personagem.R, personagem.BR);

            }


            // CONTINUAR A APRTIR DAQUI, CRIAÇÃO DE SISTEMA DE CLASSES DE FORMA QUE LIMITE AS PROEFICIENCIAS DISPONIVEIS ASSIM COMO CALCULE A VIDA DO PLAYER, NECESSARIO VER COMANDO PARA GERAR NUMERO ALEATORIO EM UM RANGE)
            //definir classe 





            while (personagem.Classe == -1)
            {

                Console.Clear();

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
                personagem.Classe = int.Parse(Console.ReadLine());
                personagem.BonusClasse();



            }

            Console.Clear();


            personagem.NomeClasse();


            personagem.NomeRaca();


            Console.WriteLine(" -----------------------------------------------------");
            Console.WriteLine($" Nome: {personagem.Nome}                             ");
            Console.WriteLine($" Classe: {personagem.classeName}                     ");
            Console.WriteLine($" Idade: {personagem.Idade}                           ");
            Console.WriteLine($" Pontos de Vida: {personagem.PontosVida}             ");
            Console.WriteLine($" Raça: {personagem.RacaName}                         ");
            Console.WriteLine($"                                                     ");
            Console.WriteLine($"                                                     ");
            Console.WriteLine($" Carisma:      {personagem.C} - Modificador ({personagem.BC})  ");
            Console.WriteLine($" Esperteza:    {personagem.E} - Modificador ({personagem.BE})  ");
            Console.WriteLine($" Inteligência: {personagem.I} - Modificador ({personagem.BI})  ");
            Console.WriteLine($" Força:        {personagem.F} - Modificador ({personagem.BF})  ");
            Console.WriteLine($" Agilidade:    {personagem.A} - Modificador ({personagem.BA})  ");
            Console.WriteLine($" Resistencia:  {personagem.R} - Modificador ({personagem.BR})  ");
            Console.WriteLine("                                                      ");
            Console.WriteLine(" -----------------------------------------------------");









            Console.ReadLine();


        }















        static int Atributo(int m)
        {

            switch (m)
            {

                case 8:

                    m = 8;





                    break;
                case 9:
                    m = 9;



                    break;
                case 10:
                    m = 10;


                    break;
                case 11:
                    m = 11;


                    break;
                case 12:
                    m = 12;

                    break;
                case 13:
                    m = 13;

                    break;
                case 14:
                    m = 14;

                    break;
                case 15:
                    m = 15;

                    break;

            }
            return m;



        }
        static int Custo(int m)
        {
            switch (m)
            {

                case 8:

                    m = 0;





                    break;
                case 9:
                    m = -1;



                    break;
                case 10:
                    m = -2;

                    break;
                case 11:
                    m = -3;

                    break;
                case 12:
                    m = -4;
                    break;
                case 13:

                    m = -5;
                    break;
                case 14:

                    m = -7;
                    break;
                case 15:
                    m = -9; ;

                    break;

            }
            return m;


        }
        static int Modificador(int m, int n)
        {



            if (m == 1) { n = -5; }
            else if (m >= 2 && m <= 3) { n = -4; }
            else if (m >= 4 && m <= 5) { n = -3; }
            else if (m >= 6 && m <= 7) { n = -2; }
            else if (m >= 8 && m <= 9) { n = -1; }
            else if (m >= 10 && m <= 11) { n = 0; }
            else if (m >= 12 && m <= 13) { n = 1; }
            else if (m >= 14 && m <= 15) { n = 2; }


            return n;


        }


    }



}