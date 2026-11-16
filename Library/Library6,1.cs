namespace Library
{
    public class Class1
    {
        public static double G(double[] a)
        {

            double mult(double[] x)
            {
                double sum = 1;

                for (int i = 0; i < x.Length; i++)
                {
                    sum *= x[i];
                }

                return sum;
            }

            double sum(double[] x)
            {
                double sum = 1;

                for (int i = 0; i < x.Length; i++)
                {
                    sum += Math.Pow(x[i], 2);
                }

                return sum;
            }

            double answer = Math.Log(5,3) * Math.Abs(mult(a) - sum(a));

            return answer;
        }
    }
}
