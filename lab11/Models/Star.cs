using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace lab11.Models
{
    public class Star
    {
        private Polygon polygon0 = new Polygon();
        public Polygon Polygon0
        {
            get
            {
                return polygon0;
            }
            set
            {
                polygon0 = value;
            }
        }

        public int x4_0 = 4; // координата x 4,  40, 20, 0, 36, 40, 0, 14, 40, 14
        public int y4_1 = 40; // координата y
        public int x1_2 = 20; // координата x
        public int y1_3 = 0; // координата y
        public int x3_4 = 36; // координата x
        public int y3_5 = 40; // координата y
        public int x5_6 = 0; // координата x
        public int y5_7 = 14; // координата y
        public int x2_8 = 40; // координата x
        public int y2_9 = 14; // координата y

        int dx = 2; // шаг смещения по x
        int dy = 2; // шаг смещения по y

        public void Speed2()
        {



            if (Math.Abs(dx) == 1 && Math.Abs(dy) == 1 && ((x4_0 % 2) == 0))
            {
                dx = dx * 2; // шаг смещения по x
                dy = dy * 2; // шаг смещения по y              
            }
            else
            {
                if (Math.Abs(dx) == 1 && Math.Abs(dy) == 1)
                {
                    y4_1 += dy;
                    y1_3 += dy;
                    y3_5 += dy;
                    y5_7 += dy;
                    y2_9 += dy;

                    x4_0 += dx;
                    x1_2 += dx;
                    x3_4 += dx;
                    x5_6 += dx;
                    x2_8 += dx;
                    dx = dx * 2; // шаг смещения по x
                    dy = dy * 2; // шаг смещения по y                    
                }


            }




        }

        public void Speed1()
        {
            if (Math.Abs(dx) == 2 && Math.Abs(dy) == 2)
            {
                dx = dx / 2; // шаг смещения по x
                dy = dy / 2; // шаг смещения по y         
            }

        }


        public Star()
        {
            Polygon0.Fill = Brushes.Black;

            Random rand = new Random();
            int a = 10 * rand.Next(0, 8);
            int b = 10 * rand.Next(0, 8);


            x4_0 += b;
            y4_1 += a;
            x1_2 += b;
            y1_3 += a;
            x3_4 += b;
            y3_5 += a;
            x5_6 += b;
            y5_7 += a;
            x2_8 += b;
            y2_9 += a;
        }
        public void Next()
        {
            int[] vs = new int[10];

            if (x1_2 == 124 && y1_3 == 174)
            {
                dx = -dx;
                dy = -dy;
            }
            if (x1_2 == 174 && y1_3 == 174)
            {
                dx = -dx;
                dy = -dy;
            }

            if (x2_8 == 124 && y2_9 == 124)
            {
                dx = -dx;
                dy = -dy;
            }
            if (x2_8 == 124 && y2_9 == 174)
            {
                dx = -dx;
                dy = -dy;
            }



            if ((x3_4 == 124 && y3_5 == 124) || (x3_4 == 174 && y3_5 == 174))
            {
                dx = -dx;
                dy = -dy;
            }
            if ((x4_0 == 174 && y4_1 == 174) || (x4_0 == 124 && y4_1 == 124))
            {
                dx = -dx;
                dy = -dy;
            }
            if (x5_6 == 174 && y5_7 == 174)
            {
                dx = -dx;
                dy = -dy;
            }
            if (x5_6 == 174 && y5_7 == 124)
            {
                dx = -dx;
                dy = -dy;
            }



            if (x2_8 > 124 && x2_8 < 174 && y2_9 == 124)
            {
                dy = -dy;
            }
            if (x5_6 > 124 && x5_6 < 174 && y5_7 == 124)
            {
                dy = -dy;
            }
            if ((x3_4 > 124 && x3_4 < 174 && y3_5 == 124) || x4_0 > 124 && x4_0 < 174 && y4_1 == 124)
            {
                dy = -dy;
            }
            if (x1_2 > 124 && x1_2 < 174 && y1_3 == 174)
            {
                dy = -dy;
            }
            if (x2_8 > 124 && x2_8 < 174 && y2_9 == 174)
            {
                dy = -dy;
            }
            if (x5_6 > 124 && x5_6 < 174 && y5_7 == 174)
            {
                dy = -dy;
            }

            if (y1_3 > 124 && y1_3 < 174 && x1_2 == 124)
            {
                dx = -dx;
            }
            if (y2_9 > 124 && y2_9 < 174 && x2_8 == 124)
            {
                dx = -dx;
            }
            if (y3_5 > 124 && y3_5 < 174 && x3_4 == 124)
            {
                dx = -dx;
            }
            if (y1_3 > 124 && y1_3 < 174 && x1_2 == 174)
            {
                dx = -dx;
            }
            if (y4_1 > 124 && y4_1 < 174 && x4_0 == 174)
            {
                dx = -dx;
            }
            if (y5_7 > 124 && y5_7 < 174 && x5_6 == 174)
            {
                dx = -dx;
            }







            if ((x2_8 >= 300) || (x3_4 >= 300))
                dx = -dx;
            //4x 5x
            if ((x4_0 < 0) || (x5_6 < 0))
                dx = -dx;
            x4_0 += dx;
            vs[0] = x4_0;

            x1_2 += dx;
            vs[2] = x1_2;

            x3_4 += dx;
            vs[4] = x3_4;

            x5_6 += dx;
            vs[6] = x5_6;

            x2_8 += dx;
            vs[8] = x2_8;

            //3y 4y
            if ((y3_5 >= 300) || (y4_1 >= 300))
                dy = -dy;
            //1y
            if ((y1_3 < 0))
                dy = -dy;
            y4_1 += dy;
            vs[1] = y4_1;
            y1_3 += dy;
            vs[3] = y1_3;
            y3_5 += dy;
            vs[5] = y3_5;
            y5_7 += dy;
            vs[7] = y5_7;
            y2_9 += dy;
            vs[9] = y2_9;

            Polygon0.Points = PointCollection.Parse(String.Join(",", vs));
        }
    }

}
