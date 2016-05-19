namespace FiltersApp
{
    public class ReadyMatrix
    {
       
        public int divisor;
        public int offset;
        public int anchorX;
        public int anchorY;
        public string convultionName;
        public double[,] arr2d;

       

        public ReadyMatrix(string convultionName, double[,] arr2d, int divisor =1, int offset =0, int anchorX= 1, int anchorY=1)
        {
            this.convultionName = convultionName;
            this.divisor = divisor;
            this.offset = offset;
            this.anchorX = anchorX;
            this.anchorY = anchorY;
            this.arr2d = arr2d;
        }

       

    }
    
}
