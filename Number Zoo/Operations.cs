using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Zoo
{
    class Operations
    {
        Random random = new Random();

        public List<int> GenerateZoo (int size)
        {
            List<int> Zoo = new List<int>();

            if(size == 1)
            {
                FillZoo(Zoo, size);
                ReleaseNumber(Zoo);
            }
            else if (size == 2)
            {
                FillZoo(Zoo, size);
                ReleaseNumber(Zoo);
            }
            else
            {
                FillZoo(Zoo, size);
                ShuffleZoo(Zoo);
                ReleaseNumber(Zoo);
            }

            return Zoo;
        }

        private void FillZoo (List<int> zoo, int size)
        {
            for(int i = 1; i <= size; i++)
            {
                zoo.Add(i);
            }
        }

        private void ShuffleZoo (List<int> zoo)
        {
            for (int i = 0; i < zoo.Count(); i++)
            {
                int randomCage1 = random.Next(1, zoo.Count-1);
                int randomCage2 = randomCage1 + 1;

                int savedCage = zoo[randomCage1];
                zoo[randomCage1] = zoo[randomCage2];
                zoo[randomCage2] = savedCage;
            }
        }

        private void ReleaseNumber (List<int> zoo)
        {
            int escapee = random.Next(1, zoo.Count);

            zoo.Remove(escapee);
        }

        public int HuntNumber (List<int> zoo)
        {
            for (int i = 1; i <= zoo.Count+1; i++)
            {
                if (zoo.Contains(i) != true)
                {
                    return i;   
                }
            }

            return 0;
        }

        public void PrintZoo (List<int> zoo)
        {
            Console.Write("| |");

            foreach (int item in zoo)
            {
                Console.Write(item + "|");
            }

            Console.WriteLine("\n");
            Console.WriteLine("ALERT *" + HuntNumber(zoo) + "* has escaped!\n");

        }





    }
}
