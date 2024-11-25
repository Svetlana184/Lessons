namespace ClassLab6_2
{
    public class ClassLib
    {
        public static int IndexMax(int[,] mas)
        {
            int max = mas[0,0];
            int sumIndex = -1;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                        sumIndex = i+j;
                    }
                }
            }
            return sumIndex;
        }
        public static double[] SumRows(double[,] mas)
        {
            double[] sumRow = new double[mas.GetLength(0)];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                double s = 0;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    s+= mas[i, j];
                }
                sumRow[i] = s;
            }
            return sumRow;
        }
        public static double Res(double[] mas)
        {
            double max= mas[0];
            double min = mas[0];
            int indexMin = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
               if (mas[i] > max) max = mas[i];
               if (mas[i] < min)
               {
                    min = mas[i];
                    indexMin = i;
               }
            }
            return max - indexMin;
        }
    }
}
