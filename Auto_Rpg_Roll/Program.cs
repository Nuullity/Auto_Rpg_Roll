using System.Data;

namespace Auto_Rpg_Roll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string genero = "a";
            int pontosAtributos = -1; ; // gambiarra para while 

            Function function = new Function();


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

            genero = function.Genero(genero);
            Console.WriteLine($"Olá forasteir{genero}, esta pront{genero} para CEIFAR algumas almas?");
           
            Console.Write("Qual o nome de seu Personagem ? ");
            personagem.Nome = Console.ReadLine();

            Console.Write("Qual será sua idade ? ");
            personagem.Idade = int.Parse(Console.ReadLine());
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
                pontosAtributos = pontosAtributos + function.Custo(personagem.C);




                Console.Write($"Voce possui {pontosAtributos} pontos, defina o valor para o atributo Esperteza: ");
                personagem.E = (int.Parse(Console.ReadLine()));
                pontosAtributos = pontosAtributos + function.Custo(personagem.E);


                Console.Write($"Voce possui {pontosAtributos} pontos, defina o valor para o atributo Inteligência: ");
                personagem.I = (int.Parse(Console.ReadLine()));
                pontosAtributos = pontosAtributos + function.Custo(personagem.I);


                Console.Write($"Voce possui {pontosAtributos} pontos, defina o valor para o atributo Força: ");
                personagem.F = (int.Parse(Console.ReadLine()));
                pontosAtributos = pontosAtributos + function.Custo(personagem.F);

                Console.Write($"Voce possui {pontosAtributos} pontos, defina o valor para o atributo Agilidade: ");
                personagem.A = (int.Parse(Console.ReadLine()));
                pontosAtributos = pontosAtributos + function.Custo(personagem.A);


                Console.Write($"Voce possui {pontosAtributos} pontos, defina o valor para o atributo Resistência: ");

                personagem.R = (int.Parse(Console.ReadLine()));
                pontosAtributos = pontosAtributos + function.Custo(personagem.R);




                Console.Clear();


            }
            // Raça e classe são jogados na Classe personagem e la é feito os processos

            //definir raça
            while (personagem.Raca == -1)
            {
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
                personagem.BC = function.Modificador(personagem.C, personagem.BC);

                personagem.BE = function.Modificador(personagem.E, personagem.BE);

                personagem.BI = function.Modificador(personagem.I, personagem.BI);

                personagem.BF = function.Modificador(personagem.F, personagem.BF);

                personagem.BA = function.Modificador(personagem.A, personagem.BA);

                personagem.BR = function.Modificador(personagem.R, personagem.BR);

                Console.Clear();


            }
            //definir classe 
            while (personagem.Classe == -1)
            {


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


                Console.Clear();

            }

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
    }
}
