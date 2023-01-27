using System;


namespace Auto_Rpg_Roll
{
    class Personagem
    {






        public string Nome;
        public int Idade;
        public int Classe;
        public int Raca;
        public int PontosVida;
        public int BonusRaca;
        public int BonusClasse;
        public int BonusProeficiencia;
        public int C, E, I, F, A, R ;




        public int PontosRaca()
        {

            switch (Raca)
            {

                case 1:

                   R = R + 2;
                   E = E + 1;
                    break;
                case 2:


                    F = F + 2;
                    R = R + 2;
                    break;
                case 3:


                    A = A + 2;
                    I = I + 1;
                    


                    break;
                case 4:



                     A = A + 2;

                     E = E + 1;



                    break;
                case 5:


                     A = A + 2;

                     C = C + 1;
                    break;

                case 6:


                     A = A + 2;

                     C = C + 1;

                    break;
                case 7:


                    A = A + 2;

                     R = R + 1;



                    break;
                case 8:


                     C = C + 1;
                     E = E + 1;
                     I = I + 1;
                     F = F + 1;
                     A = A + 1;
                     R = R + 1;



                    break;
                case 9:


                    F = F + 2; 
                    C = C + 1;

                     


                    break;
                case 10:


                     A = A + 1;
                     I = I + 2;


                    break;
                case 11:


                     R = R + 1;
                     I = I + 2;



                    break;
                case 12:

                     R = R + 2;
                     R = R + 2;



                    break;
                case 13:

                     F = F + 2;

                    // BNE = Bonus Meio elfo
                    Console.WriteLine("Escolha 1  entre C E I F A R para aumentar em 1 ponto:");
                    char BNE1 = Char.Parse(Console.ReadLine());
                    Console.WriteLine("Escolha 1  entre C E I F A R para aumentar em 1 ponto:");
                    char BNE2 = Char.Parse(Console.ReadLine());
                    // eu odeio meio elfos

                    if (BNE1 == 'C' || BNE1 == 'c')      { C = C + 1; }
                    else if (BNE1 == 'E' || BNE1 == 'e') { E = E + 1; }
                    else if (BNE1 == 'I' || BNE1 == 'i') { I = I + 1; }
                    else if (BNE1 == 'F' || BNE1 == 'f') { F = F + 1; }
                    else if (BNE1 == 'A' || BNE1 == 'a') { A = A + 1; }
                    else if (BNE1 == 'R' || BNE1 == 'r') { R = R + 1; }

                    if (BNE2 == 'C' || BNE2 == 'c') { C = C + 1; }
                    else if (BNE2 == 'E' || BNE2 == 'e') { E = E + 1; }
                    else if (BNE2 == 'I' || BNE2 == 'i') { I = I + 1; }
                    else if (BNE2 == 'F' || BNE2 == 'f') { F = F + 1; }
                    else if (BNE2 == 'A' || BNE2 == 'a') { A = A + 1; }
                    else if (BNE2 == 'R' || BNE2 == 'r') { R = R + 1; }


                    break;



                case 14:

                     I = I + 1;
                     C = C + 2;


                    break;
                default:
                    Console.WriteLine("raça invalida");
                    Raca = -1;
                    break;








            }
            
             return 0; 
        }









    }


}
