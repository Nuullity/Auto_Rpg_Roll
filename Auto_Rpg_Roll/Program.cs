using System.Data;

namespace Auto_Rpg_Roll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string genero = "a";
            int pontosAtributos = -1; ; // gambiarra para while 

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
            while (genero != "M" && genero != "N" && genero != "F")
            {


                Console.Write("Olá Qual seu genero ? |M|  |F|: ");
                genero = (Console.ReadLine().ToUpper());
                Console.Clear();




            }

            genero = Genero(genero);
            Console.WriteLine($"Olá forasteir{genero}, esta pront{genero} para CEIFAR algumas almas?");
           

            Console.Write("Qual o nome de seu Personagem ? ");
            personagem.Nome = Console.ReadLine();



            Console.Write("Qual será sua idade ? ");
            personagem.Idade = Console.ReadLine();
            Console.Clear();



            while (pontosAtributos < 0 )
            {
                pontosAtributos = 27;
                personagem.C = 0;
                personagem.E = 0;
                personagem.I = 0;
                personagem.F = 0;
                personagem.A = 0;
                personagem.R = 0;


                // fazer  atribuição de atributos, com base na funçao Atributo
                Console.WriteLine($"Voce irá definir agr os pontos de atributos de seu personagem");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("|          Valor Custo  |   Valor Custo      | ");
                Console.WriteLine("|            8     0    |    12     4        | ");
                Console.WriteLine("|            9     1    |    13     5        | -Carisma");
                Console.WriteLine("|            10    2    |    14     7        | -Esperteza");
                Console.WriteLine("|            11    3    |    15     9        | -Inteligência");
                Console.WriteLine("|                                            | -Força");
                Console.WriteLine("|              >Digite o Valor<              | -Agilidade");
                Console.WriteLine("|      Caso fique com Pontos negativos       | -Resistência");
                Console.WriteLine("|  o software irá se resetar automaticamente | ");
                Console.WriteLine("---------------------------------------------- ");

                Console.Write($"Voce possui {pontosAtributos} pontos, defina o valor para o atributo Carisma: ");

                personagem.C = (int.Parse(Console.ReadLine()));
                pontosAtributos = pontosAtributos + Custo(personagem.C);




                Console.Write($"Voce possui {pontosAtributos} pontos, defina o valor para o atributo Esperteza: ");
                personagem.E = (int.Parse(Console.ReadLine()));
                pontosAtributos = pontosAtributos + Custo(personagem.E);


                Console.Write($"Voce possui {pontosAtributos} pontos, defina o valor para o atributo Inteligência: ");
                personagem.I = (int.Parse(Console.ReadLine()));
                pontosAtributos = pontosAtributos + Custo(personagem.I);


                Console.Write($"Voce possui {pontosAtributos} pontos, defina o valor para o atributo Força: ");
                personagem.F = (int.Parse(Console.ReadLine()));
                pontosAtributos = pontosAtributos + Custo(personagem.F);

                Console.Write($"Voce possui {pontosAtributos} pontos, defina o valor para o atributo Agilidade: ");
                personagem.A = (int.Parse(Console.ReadLine()));
                pontosAtributos = pontosAtributos + Custo(personagem.A);


                Console.Write($"Voce possui {pontosAtributos} pontos, defina o valor para o atributo Resistência: ");

                personagem.R = (int.Parse(Console.ReadLine()));
                pontosAtributos = pontosAtributos + Custo(personagem.R);




                Console.Clear();


            }









            // Raça e classe são jogados na Class personagem e la é feito os processos
            //definir raça


            while (personagem.Raca == -1)
            {
                Console.Clear();
                Console.WriteLine($"---------------------------------------------------------------");
                Console.WriteLine($"|                    >Escolha sua Raça<                       |");
                Console.WriteLine($"|                                                             |");
                Console.WriteLine($"|(1) - Anão da Colina               ( 8) - Human{genero}             |");
                Console.WriteLine($"|(2) - Anão da Montanha             ( 9) - Draconat{genero}          |");
                Console.WriteLine($"|(3) - Alt{genero} Elf{genero}                    (10) - Gnomo da Floresta  |");
                Console.WriteLine($"|(4) - Elf{genero} da Floresta             (11) - Gnomo das Rochas   |");
                Console.WriteLine($"|(5) - Elf{genero} Negr{genero}                   (12) - Meio Elf{genero}          |");
                Console.WriteLine($"|(6) - Halfling dos Pés Leves       (13) - Meio Orc           |");
                Console.WriteLine($"|(7) - Halfling Robust{genero}             (14) - Tiefling           |");
                Console.WriteLine($"---------------------------------------------------------------");



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

                Console.WriteLine($"---------------------------------------------------------------");
                Console.WriteLine($"|                    >Escolha sua Classe<                     |");
                Console.WriteLine($"|                                                             |");
                Console.WriteLine($"|(1) - Bárbar{genero}                      ( 7) - Guerreir{genero}          |");
                Console.WriteLine($"|(2) - Bard{genero}                        ( 8) - Ladin{genero}             |");
                Console.WriteLine($"|(3) - Brux{genero}                        ( 9) - Mag{genero}               |");
                Console.WriteLine($"|(4) - Clérig{genero}                      (10) - Monge              |");
                Console.WriteLine($"|(5) - Druida                       (11) - Paladin{genero}           |");
                Console.WriteLine($"|(6) - Feiticeir{genero}                   (12) - Patrulheir{genero}        |");
                Console.WriteLine($"---------------------------------------------------------------");
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














        static string Genero(string m) {
            
            switch (m)
            {
                case "M":


                    m = "o";
                    return m;
                    break;

                case "F":

                    m = "a";
                    return m;

                    break;

                case "N":
                    m = "e";
                    return m;
                    break;


            }
            
            
            
            
            return m; }
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

                    default: 
                    
                    
                    return m;
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
                default:
                    m= -100;

                    return m;
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
