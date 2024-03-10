using Microsoft.IdentityModel.Tokens;
using System.Collections;

namespace ContosoUniversity
{
    public class Class
    {
        public static int[] CountPosSumNeg(double[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return new int[0];
            }

            int[] result = new int[2];
            foreach (int i in arr)
            {
                if (i > 0)
                {
                    result[0] += i;
                }
                else
                {
                    result[1] += i;
                }
            }
            return result;
    }
    }

}
