using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class PredefinedValues
    {
       public static String[] predefinedConvNames = { "Mean Removal Sharpen", "Edge Detection Horizontal","Edge Detection Vertical","Edge Detection Diagonal", "Gaussian Smoothing", "Blur", "East Emboss","South Emboss","South-East Emboss", "Identity" };
        public static int numOfPredefinedArg = 0; 
        public ArrayList AList = null;
        private double[,] meanRemovalSharpen =
           {
            {-1,-1,-1},
            {-1,9,-1},
            {-1,-1,-1}
           };
        private double[,] edgeDetectionHor =
                       {
            {0,-1,0},
            {0,1,0},
            {0,0,0}
           };
        private double[,] edgeDetectionVer =
                       {
            {0,0,0},
            {-1,1,0},
            {0,0,0}
           };

        private double[,] edgeDetectionDiag =
                       {
            {-1,0,0},
            {0,1,0},
            {0,0,0}
           };


        private double[,] gaussianSmoothing =
                    {
            {0,1,0},
            {1,4,1},
            {0,-1,0}
           };

       private double[,] blur =
                    {
            {1,1,1},
            {1,1,1},
            {1,1,1}
           };

       private double[,] embossEast =
                     {
            {-1,0,1},
            {-1,1,1},
            {-1,0,1}
           };
        private double[,] embossSouth =
                     {
            {-1,-1,-1},
            {0,1,0},
            {1,1,1}
           };
        private double[,] embossEastSouth =
                       {
            {-1,-1,0},
            {-1,1,1},
            {0,1,1}
           };

        private  double[,] identity =
                    {
            {0,0,0},
            {0,1,0},
            {0,0,0}
           };


        public PredefinedValues()
        {
            numOfPredefinedArg = predefinedConvNames.Length;
            AList = new ArrayList();
            AList.Add(meanRemovalSharpen);
            AList.Add(edgeDetectionDiag);
            AList.Add(edgeDetectionHor);
            AList.Add(edgeDetectionVer);
            AList.Add(gaussianSmoothing);
            AList.Add(blur);
            AList.Add(embossEast);
            AList.Add(embossSouth);
            AList.Add(embossEastSouth);
            AList.Add(identity);

             


        }

    }
}
