using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Assignment2_3
    {
        int balls, numberOfInnings, totalRuns,run;
        int[] count = new int[6];
        int[] runs = new int[6];
        int[] numberOfBalls = new int[6];
        
        double average;
         public void calculateAverage()
        {
            Console.WriteLine("Enter Number of Innings:");
            numberOfInnings = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < numberOfInnings; i++)
            {
                Console.WriteLine("Enter Number of balls played in Innings number: " + (i+1));
                numberOfBalls[i] = Convert.ToInt32(Console.ReadLine());
                balls = numberOfBalls[i];
                for(int j=0; j<balls; j++){
                    run = randomRun();
                    runs[i] = runs[i] + run;
                    switch (run)
                    {
                        case 0:
                            count[0]++ ;
                            break;
                        case 1:
                            count[1]++;
                            break;
                        case 2:
                            count[2]++;
                            break;
                        case 3:
                            count[3]++;
                            break;
                        case 4:
                            count[4]++;
                            break;
                        case 6:
                            count[5]++;
                            break;
                    }
                }
                
            }
        }
        
        public int randomRun()
        {
            
            Random randomNr = new Random();
            int r = randomNr.Next(0,7);
            while (r == 5)
            {
                r = randomNr.Next(0,7);
            }
            return r;
        }
        
        public void displayTotal()
        {

            int r = 0;
            balls = 0;
            for (int i = 0; i < numberOfInnings; i++)
            {
                Console.WriteLine("Runs scored in Innings: " +(i+1)+ " are: "+runs[i]);
                r = r + runs[i];
                totalRuns = r;
                balls = balls + numberOfBalls[i];
            }

            Console.WriteLine("Total runs scored: "+totalRuns);
            average = totalRuns / balls;
            Console.WriteLine("Strike Rate: " + average);
            for(int j =0; j < count.Length; j++)
            {
                int c = count[j]; 
                Console.WriteLine("Number of " + j+" are: "+c );
            }
        }
        

    }
}
