using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class TowerOfHanoi
    {
        public TowerOfHanoi()
        {
            Console.WriteLine("Enter the number of discs to use. Less than 5 is good");
            string input = Console.ReadLine();
            int discNumber = Int32.Parse(input);

            //Make the first call to moveDisc to start the solution of the problem
            moveDisc(discNumber, 'A', 'B', 'C');

        }

        private void moveDisc(int n, char source, char auxillary, char destination)
        {
            //If this is true, we have hit the base case. All printing is done in the base case.
            if (n == 1)
            {
                //Print out the move.
                Console.WriteLine("Move disc from tower {0} to tower {1}", source, destination);
            }
            else
            {   // Make a recursive call to move n-1 discs from the source peg, to the aux peg
                moveDisc(n - 1, source, destination, auxillary);
                //Make a recursive call to move 1(bottom) disc form source to destination
                moveDisc(1, source, auxillary, destination);
                //Make a recursive call to move n-1 discs from auxillary to destination
                moveDisc(n - 1, auxillary, source, destination);
            }
        }
    }
}
