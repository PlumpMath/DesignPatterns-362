using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzOOP
{
    /* This is an object oriented implementation of the classic FizzBuzz problem.
     * The purpose of this is to provide an extensible set of checks that are encapulated in their own class.  Adding additional checks is
     * as simple as adding a new class and implementing the RunCheck method.
     **/
    class Program
    {
        static void Main(string[] args)
        {
            Check c = new Check();

            c.AddItemCheck(new Run15Check());
            c.AddItemCheck(new Run5Check());
            c.AddItemCheck(new Run3Check());

            for (int i = 0; i < 100; i++)
            {
                if (c.RunChecks(i) == false)
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
    /// <summary>
    /// A class to add values to validate to a list.  Includes a method to run the checks.
    /// </summary>
    class Check
    {
        public List<IBaseCheck> checksList;

        public Check()
        {
            checksList = new List<IBaseCheck>();
        }
        /// <summary>
        /// Adds check objects to a list of checks for later iteration.
        /// </summary>
        /// <param name="checkItem"></param>
        public void AddItemCheck(IBaseCheck checkItem)
        {
            this.checksList.Add(checkItem);
        }

        /// <summary>
        /// Iterate through the list of basechecks, perform the RunCheck method associated with that object.
        /// </summary>
        /// <returns></returns>
        public bool RunChecks(int checkValue)
        {
            bool successfulChecks = false;

            foreach (var item in this.checksList)
            {
                if ( item.RunCheck(checkValue) )
                {
                    successfulChecks = true;
                    break;
                }
            }

            return successfulChecks;
        }
    }

    /// <summary>
    /// The IBaseCheck interface runs a divisibility check on a number.  The RunCheck method is implemented in each check available.
    /// </summary>
    interface IBaseCheck
    {
        bool RunCheck(int checkValue);
    }

    /// <summary>
    /// These are 3 possible methods.  There is extensive code duplication between these three methods, so they can be abstracted out.
    /// </summary>
    class Run3Check : IBaseCheck
    {
        public bool RunCheck(int checkValue)
        {
            if (checkValue % 3 == 0)
            {
                Console.WriteLine("Fizz");
                return true;
            }
            return false;
        }
    }

    class Run5Check : IBaseCheck
    {
        public bool RunCheck(int checkValue)
        {
            if ( checkValue % 5 == 0)
            {
                Console.WriteLine("Buzz");
                return true;
            }

            return false;
        }
    }

    class Run15Check : IBaseCheck
    {
        public bool RunCheck(int checkValue)
        {
            if ( checkValue % 15 == 0)
            {
                Console.WriteLine("FizzBuzz");
                return true;
            }

            return false;
        }
    }
}
