using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                checked
                {
                    //Increment up tp max
                    int num = 0;
                    for (int i = 0; i < int.MaxValue; i++)
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
    

