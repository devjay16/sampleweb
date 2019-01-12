using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Example
{
    class Checkedexception
    {
        // Use checked overflow context.
        static void Main()
        {
            checked
            {
                //Increment up tp max
                int num = 0;
                for (int i = 1; i < int.MaxValue; i++)
                {
                    num++;
                }
                //Increment up to max again (error)
                for (int i = 0; i < int.MaxValue; i++)
                {
                    num++;
                }

            }
        }
      }
}

