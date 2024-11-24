using System;
using static System.Console;

namespace case2
{
    class Program
    {
        static void Main(string[] args)
        {
          var K = int.Parse(ReadLine());
          switch (K)
          {
              case 1:
                  WriteLine("Bad");
                  break;
              case 2:
                  WriteLine("Good");
                  break;
              case 3:
                  WriteLine("Better");
                  break;
              case 4:
                  WriteLine("Great");
                  break;
              case 5:
                  WriteLine("Perfect");
                  break;
              default:
                  WriteLine("Error you can choose 1 or 2 or 3 or 4 or 5.");
                  break;
          }
          {
                
          }

        }
    }
}