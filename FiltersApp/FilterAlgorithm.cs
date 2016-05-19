using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    public class FilterAlgorithm
    {
        private MainWindow form;
        private Bitmap mainPicture;
        private int width = 0;
        private int height = 0;
        private  int divisor = 1;
        private int offset = 0;
        private int anchorX = -3;
        private int anchorY = -3;


        public FilterAlgorithm(MainWindow form, Bitmap mainPicture,  int divisor = 1, int offset = 0, int anchorX = -1, int anchorY = -1)
        {
            this.mainPicture = mainPicture;
            this.form = form;
            this.width = mainPicture.Width;
            this.height = mainPicture.Height;
            this.divisor = divisor;
            this.offset = offset;
            this.anchorX = anchorX;
            this.anchorY = anchorY;
            

        }



        public Bitmap filterAlgorithm(double[,] filter)
        {


            int FilterX = filter.GetLength(0);
            int FilterY = filter.GetLength(1);

            double red = 0;
            double green = 0;
            double blue = 0;

            double Nred = 0;
            double Ngreen = 0;
            double Nblue = 0;
            double factor = 0;
            double divider = 0;
            int filterPosX = 0;
            int filterPosY = 0;



            Bitmap currentPic = (Bitmap)mainPicture.Clone();
            Bitmap output = (Bitmap)mainPicture.Clone();
            Color Col = new Color();

            if(anchorX == -1 || anchorY == -1)
            {
                anchorX = FilterX / 2;
                anchorY = FilterY / 2;
            }



         

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    red = 0;
                    green = 0;
                    blue = 0;



                    for (int fy = -anchorY; fy <= FilterY - 1 - anchorY; fy++)
                    {
                        for (int fx = -anchorX; fx <= FilterX - 1 - anchorX; fx++)
                        {
                            filterPosX = fx + anchorX;
                            filterPosY = fy + anchorY;

                            if (x == 0 && y == 0)
                                divider += filter[filterPosX, filterPosY];

                            if (x + fx < 0 || x + fx >= width || y + fy < 0 || y + fy >= height)
                                continue;



                            Col = currentPic.GetPixel(x + fx, y + fy);

                            factor = filter[filterPosX, filterPosY];

                            red += Col.R * factor;
                            green += Col.G * factor;
                            blue += Col.B * factor;



                        }
                    }


                    if (divider != 0)
                    {
                        Nred = max(min(red / divider / divisor + offset, 255), 0);
                        Ngreen = max(min(green / divider / divisor + offset, 255), 0);
                        Nblue = max(min(blue / divider / divisor + offset, 255), 0);
                    }
                    else
                    {
                        Nred = max(min(red / divisor + offset, 255), 0);
                        Ngreen = max(min(green / divisor + offset, 255), 0);
                        Nblue = max(min(blue / divisor + offset, 255), 0);
                    }


                    output.SetPixel(x, y, Color.FromArgb(Convert.ToInt32(Nred), Convert.ToInt32(Ngreen), Convert.ToInt32(Nblue)));
                }


           

            }


            return output;
        }







        public Bitmap GrayScale()
        {
            Bitmap output = (Bitmap)mainPicture.Clone();

            Color Col = new Color();
            int sum;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    Col = mainPicture.GetPixel(x, y);
                    sum = Convert.ToInt32(max(min(0.21 * Col.R + 0.72 * Col.G + 0.07 * Col.B, 255), 0));


                    output.SetPixel(x, y, Color.FromArgb(sum, sum, sum));
                }


            }
            return output;
        }


        public Bitmap Inversion()
        {
           Bitmap output = (Bitmap)mainPicture.Clone();

            Color Col = new Color();


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    Col = mainPicture.GetPixel(x, y);



                    output.SetPixel(x, y, Color.FromArgb(255 - Col.R, 255 - Col.G, 255 - Col.B));
                }


            }
            return output;
        }


        public Bitmap Brightness(int variation)
        {
            Bitmap output = (Bitmap)mainPicture.Clone();

            Color Col = new Color();
            int red = 0, green =0, blue =0;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    Col = mainPicture.GetPixel(x, y);

                    red = Convert.ToInt32(max(min(Col.R + variation, 255), 0));
                    green = Convert.ToInt32(max(min(Col.G +  variation, 255), 0));
                    blue = Convert.ToInt32(max(min(Col.B + variation, 255), 0));

            output.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            

            }
            return output;
        }

        public Bitmap Contrast(int variation)
        {
            Bitmap output = (Bitmap)mainPicture.Clone();
            double Var2 = Convert.ToDouble(variation);

            Var2 = (100.0f + Var2) / 100.0f;
            Var2 *= Var2;

            Color Col = new Color();
            int red = 0, green = 0, blue = 0;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {




                    Col = mainPicture.GetPixel(x, y);

                    red = Convert.ToInt32(max(min((((Col.R/255.0f - 0.5f) * Var2) + 0.5f) * 255.0f, 255), 0));
                    green = Convert.ToInt32(max(min((((Col.G / 255.0f - 0.5f) * Var2) + 0.5f) * 255.0f, 255), 0));
                    blue = Convert.ToInt32(max(min((((Col.B / 255.0f - 0.5f) * Var2) + 0.5f) * 255.0f, 255), 0));

                    output.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }


            }
            return output;
        }


        public Bitmap GammaCorrection(double variation)
        {
            Bitmap output = (Bitmap)mainPicture.Clone();
            double gammaCorrection = 1/variation;

          


            Color Col = new Color();
            int red = 0, green = 0, blue = 0;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    Col = mainPicture.GetPixel(x, y);

                    red = Convert.ToInt32(max(min(255.0 * System.Math.Pow(Col.R / 255.0, 1.0 / variation) + 0.5,255),0));
                    green = Convert.ToInt32(max(min(255.0 * System.Math.Pow(Col.G / 255.0, 1.0 / variation) + 0.5, 255), 0));
                    blue = Convert.ToInt32(max(min(255.0 * System.Math.Pow(Col.B / 255.0, 1.0 / variation) + 0.5, 255), 0));


                    output.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }


            }
            return output;
        }


      

        public static double max(double x, double y)
        {
            return x >= y ? x : y;
        }

        public static double min(double x, double y)
        {
            return x <= y ? x : y;
        }
        
        public static int max(int x, int y)
        {
            return x >= y ? x : y;
        }

        public static int min(int x, int y)
        {
            return x <= y ? x : y;
        }


    }
}
