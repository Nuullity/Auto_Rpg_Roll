using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Rpg_Roll
{
    public class Function
    {

       



            public string Genero(string m)
            {

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




                return m;
            }
            public int Atributo(int m)
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
            public int Custo(int m)
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
                        m = -100;

                        return m;
                }
                return m;


            }
            public int Modificador(int m, int n)
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
