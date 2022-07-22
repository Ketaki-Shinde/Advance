using System;


namespace Class_Training_Day1
{
    class WhileLoop
    {
        public static void Main1()
        {
            int counter;
            //counter = 0;
            /* while(counter>-5)
             {
                 Console.WriteLine("Hello");
                 counter--;
             }*/
            /* while(counter <6)
              {
                  Console.WriteLine(counter++);
              }*/

            /* while(counter <=10)
              {
                 // counter++;
                  if (counter % 2 == 0)
                  {
                      Console.WriteLine(counter);

                  }
                  counter++;
              }*/
            /* while (counter < 10)
             {
                 counter = counter + 2;
                 Console.WriteLine(counter);
             }*/
            counter = 1;
           while (counter<=10 )
            {
                
                if (counter %2==0)
                {
                    Console.WriteLine(counter+" Even");
                }
                else
                {
                    Console.WriteLine(counter+" Odd");
                }
                counter++;
            }
        }
    }
}
