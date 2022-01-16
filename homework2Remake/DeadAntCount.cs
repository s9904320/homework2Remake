using System;
using System.Linq;

namespace homework2Remake
{
    public class DeatAnt
    {
        public static int DeadAntCount(string ants)
        {
            int deadAnt = 0;
            int lifeAnt = 0;
            int[] partDeadAnt = { 0, 0, 0 };

            if (!String.IsNullOrEmpty(ants))
            {
                for (int i = 0; i < ants.Length; i++)
                {
                    if (ants.Substring(i, 1) == "a")
                    {
                        partDeadAnt[0] += 1;
                    }
                    if (ants.Substring(i, 1) == "n")
                    {
                        partDeadAnt[1] += 1;
                    }
                    if (ants.Substring(i, 1) == "t")
                    {
                        partDeadAnt[2] += 1;
                    }
                    if (i < ants.Length - 2)
                    {
                        if (ants.Substring(i, 3) == "ant")
                        {
                            lifeAnt++;
                        }
                    }
                }
                deadAnt = partDeadAnt.Max() - lifeAnt;

                return deadAnt;
            }
            else
            {
                return 0;
            }         
        }
    }
}
