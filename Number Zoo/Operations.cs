using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Zoo
{
    class Operations
    {
        public List<int> GenerateZoo (int size)
        {
            List<int> Zoo = new List<int>();

            FillZoo(Zoo, size);
            ReleaseNumber(Zoo, size);

            return Zoo;
        }

        private void FillZoo (List<int> zoo, int size)
        {
            for(int i = 1; i <= size; i++)
            {
                zoo.Add(i);
            }
        }

        private void ReleaseNumber (List<int> zoo, int size)
        {
            Random random = new Random();

            int escapee = random.Next(1, size);

            zoo.Remove(escapee);
        }

        public void PrintZoo (List<int> zoo)
        {
            foreach (int item in zoo)
            {
                Console.Write(item + "|");
            }
        }



    }
}
