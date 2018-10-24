using System;

namespace SPZ_l1_v1.task1
{
    struct Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; }
        public double Y { get; }


        public bool IsInSpace()
        {
            double rad = 1.0;
            if ((Math.Pow(X, 2.0) + Math.Pow(Y, 2.0) <= Math.Pow(rad, 2.0) && X >= 0 && X <= 1.0 && Y <= 0 && Y >= -1.0)
                ||
                (Y >= 0 && Y <= 1 && X <= 0 && X >= -1 && (Math.Pow(X, 2) <= Y) && (Math.Pow(X, 2.0) + Math.Pow(Y, 2.0) <= Math.Pow(rad, 2.0))))
                return true;
            else
                return false;
        }
        public static void ShowSpaceRange()
        {
            Console.WriteLine(@"       
                          1

                 @@       .      +@                 
             @            .           +             
          @               .              @         
        @                 .                +@       
       @+@                .                @ @      
     @++++@               .              @@   +     
    @++++++@              .            @@      +    
   @++++++++@             .           @@        -   
   +++++++++++@           .         @@              
  @+++++++++++++@         .        @@            +  
  @++++++++++++++++@      .      @@               -  
-1@++++++++++++++++++@+@@@@@@@@@                  @ 1
  @                       ++++++++++++++++++++++++@  
  @                       ++++++++++++++++++++++++  
  +                       +++++++++++++++++++++++   
   @                      ++++++++++++++++++++++@   
    @                     +++++++++++++++++++++@    
     @                    ++++++++++++++++++++@     
      +                   +++++++++++++++++++@      
        @                 +++++++++++++++++@        
          @               +++++++++++++++@          
            @+            ++++++++++++@             
               @++        +++++++++@                
                    +  +-@@@@@ 
                         -1
            ______________________________

         |  Point shoud get into '+' field  |
            ______________________________
");
        }
    }

    class Task1
    {
        private static string NeedTo = "Определить попадание точки с координатами x, y в заданную область";
        public static void Test()
        {
            Console.WriteLine(NeedTo);
            Point.ShowSpaceRange();
            while (true)
            {
                
                Point P;
                string s;
                double x, y;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Press 1 to start");
                Console.BackgroundColor = ConsoleColor.Black;
                s = Console.ReadLine();

                if (s == "1")
                {
                    Console.WriteLine("Enter Coordinate X: ");
                   
                    bool Correct;
                    while (true)
                    {
                        Correct = Double.TryParse(Console.ReadLine(), out x);
                        if (!Correct)
                            Console.WriteLine("Try again");
                        else break;
                    }
                   
                    Console.WriteLine("Enter Coordinate Y: ");
                    while (true)
                    {
                        Correct = Double.TryParse(Console.ReadLine(), out y);
                        if (!Correct)
                            Console.WriteLine("Try again");
                        else break;
                    }
                    
                    P = new Point(x,y);

                    Console.WriteLine("Point X: " + P.X + " Y: " + P.Y );
                    if (P.IsInSpace() == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else Console.WriteLine("Uncorrect");

                }
                else break;
            }
           
        }
    }
}
