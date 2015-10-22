using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UI
    {
        DroidCollection dC = new DroidCollection();

        // this is the main menu, giving the user basic command functions
        public void MainMenu()
        {
            Console.WriteLine("Please Choose a Command");
            Console.WriteLine("");
            Console.WriteLine("1: Add a Droid to the List");
            Console.WriteLine("2: Delete a Droid from the List");
            Console.WriteLine("3: View the List");
            Console.WriteLine("4: EXIT");
            Console.WriteLine("");

            string answer = Convert.ToString(Console.ReadLine());   // based on the answer input, the corresponding
                                                                        // Method is called, or asks for new input
            if (answer == "1")
            {
                AddDroid();
            }

            else
            {
                if (answer == "2")
                {
                    DeleteDroid();
                }

                else
                {
                    if (answer == "3")
                    {
                        ViewList();
                    }

                    else
                    {
                        if (answer == "4")
                        {
                            ExitProgram();
                        }

                        else
                        {
                            // if answer given is not recognized, displays this message
                            Console.WriteLine("Input not recongnized, please try again" + Environment.NewLine);
                            MainMenu();
                        }
                    }
                    
                }
            }

            Console.Clear();
            MainMenu();
        }

        // this method is designed to add a new droid to the droid list
        private void AddDroid()
        {
            
            Console.WriteLine("Input Droid ID Number");
            string droidNumber = Convert.ToString(Console.ReadLine().ToUpper());

            Console.WriteLine("Select Droid Type");
            Console.WriteLine("1: Protocol");
            Console.WriteLine("2: Utility");
            string droidType = Convert.ToString(Console.ReadLine());

            string droidModel = "NULL";

            if (droidType == "2")
            {
                droidType = "Utility";
                Console.WriteLine("Select Droid Model");
                Console.WriteLine("1: Janitor");
                Console.WriteLine("2: Astromech");
                droidModel = Convert.ToString(Console.ReadLine());

                if (droidModel == "1")
                {
                    Janitor newDroid = new Janitor();
                }

                else
                {
                    Astromech newDroid = new Astromech();
                }
            }

            else
            {
                Protocol newDroid = new Protocol();
            }

            Console.WriteLine("Input Droid's Body Color");
            string droidBColor = Convert.ToString(Console.ReadLine().ToUpper());

            Console.WriteLine("Input Droid's Detail Color");
            string droidDColor = Convert.ToString(Console.ReadLine().ToUpper());

            Console.WriteLine("Input Droid's Primary Material");
            string droidMaterial = Convert.ToString(Console.ReadLine().ToUpper());

            

            string content = droidNumber + " " + droidType + " " + droidModel + " " + droidBColor + " " + droidDColor + " " + droidMaterial;

            dC.Add(content);
        }

        // this method is designed to delete a droid from the droid list based on entry number
        private void DeleteDroid()
        {
            ViewList();

            Console.WriteLine();
            Console.WriteLine("Input Droid Entry Number to Delete");
            int entryNumber = Convert.ToUInt16(Console.ReadLine());
            dC.Delete(entryNumber);

            ViewList();
        }

        // this method is designed to view the droid list
        private void ViewList()
        {
            Console.WriteLine("All Available Droids");
            Console.WriteLine("");
            Console.WriteLine("Droid Model:  Droid Price: Body Color:  Detail Color:    Material:");
            Console.WriteLine("");

            for (Node x = dC.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

            Console.WriteLine("Press Any Key to Continue");
            Console.ReadLine();
        }


        private void ExitProgram()
        {
            Environment.Exit(0);
        }
    }
}
