using HelloWorld;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using static System.Formats.Asn1.AsnWriter;

class Program
{

    public static bool gameOn;

    

    static string[,] arr = new string[,]
       {
            {" 1 ", "|", " 2 ", "|", " 3 " },
            {"---", "|", "---", "|", "---" },
            {" 4 ", "|", " 5 ", "|", " 6 " },
            {"---", "|", "---", "|", "---" },
            {" 7 ", "|", " 8 ", "|", " 9 " }
       };
    static void Main(string[] args)
    {

        bool gameOn = true;
        
        int counter = 0;

       

        while (gameOn)
        {   
            Console.WriteLine();
            ShowTable(arr);
            gameOn = CheckGameStatus(arr);

            if (counter == 9)
            {
                Console.WriteLine("It's a Draw!");
                gameOn = false;
            }

            if (gameOn == false)
            {
                Console.WriteLine("Enter 1 if you want to restart.");
                string restart = Console.ReadLine();
                if (restart == "1")
                {
                    gameOn = true;
                    counter = 0;
                    ResetTable();

                }
            }

            

            
            Console.WriteLine("Enter the number to put your sign on.");
            
            string strInput = Console.ReadLine();
            int intInput;

            if (!int.TryParse(strInput, out intInput))
            {
                Console.WriteLine("Enter a number");
            }
            

            switch (intInput)
            {
                case -1:
                    Console.WriteLine("Game Over!");
                    gameOn = false;
                    break;
                
                case 1:
                    if (arr[0, 0] != " X " && arr[0, 0] != " O ")
                    {
                        if (counter % 2 == 0)
                        {
                            arr[0, 0] = " X ";
                            counter++;
                            Console.WriteLine("Player 2 plays");
                        }
                        else
                        {
                            arr[0, 0] = " O ";
                            counter++;
                            Console.WriteLine("Player 1 plays");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This cell is occupied, choose another one");
                        break;
                    }
                   
                    break;

                case 2:
                    if (arr[0, 2] != " X " && arr[0, 2] != " O ")
                    {
                        if (counter % 2 == 0)
                        {
                            arr[0, 2] = " X ";
                            counter++;
                            Console.WriteLine("Player 2 plays");
                        }
                        else
                        {
                            arr[0, 2] = " O ";
                            counter++;
                            Console.WriteLine("Player 1 plays");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This cell is occupied, choose another one");
                    }

                    break;

                case 3:
                    if (arr[0, 4] != " X " && arr[0, 4] != " O ")
                    {
                        if (counter % 2 == 0)
                        {
                            arr[0, 4] = " X ";
                            counter++;
                            Console.WriteLine("Player 2 plays");
                        }
                        else
                        {
                            arr[0, 4] = " O ";
                            counter++;
                            Console.WriteLine("Player 1 plays");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This cell is occupied, choose another one");
                    }

                    break;

                case 4:
                    if (arr[2, 0] != " X " && arr[2, 0] != " O ")
                    {
                        if (counter % 2 == 0)
                        {
                            arr[2, 0] = " X ";
                            counter++;
                            Console.WriteLine("Player 2 plays");
                        }
                        else
                        {
                            arr[2, 0] = " O ";
                            counter++;
                            Console.WriteLine("Player 1 plays");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This cell is occupied, choose another one");
                    }

                    break;

                case 5:
                    if (arr[2, 2] != " X " && arr[2, 2] != " O ")
                    {
                        if (counter % 2 == 0)
                        {
                            arr[2, 2] = " X ";
                            counter++;
                            Console.WriteLine("Player 2 plays");
                        }
                        else
                        {
                            arr[2, 2] = " O ";
                            counter++;
                            Console.WriteLine("Player 1 plays");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This cell is occupied, choose another one");
                    }

                    break;

                case 6:
                    if (arr[2, 4] != " X " && arr[2, 4] != " O ")
                    {
                        if (counter % 2 == 0)
                        {
                            arr[2, 4] = " X ";
                            counter++;
                            Console.WriteLine("Player 2 plays");
                        }
                        else
                        {
                            arr[2, 4] = " O ";
                            counter++;
                            Console.WriteLine("Player 1 plays");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This cell is occupied, choose another one");
                    }

                    break;

                case 7:
                    if (arr[4, 0] != " X " && arr[4, 0] != " O ")
                    {
                        if (counter % 2 == 0)
                        {
                            arr[4, 0] = " X ";
                            counter++;
                            Console.WriteLine("Player 2 plays");
                        }
                        else
                        {
                            arr[4, 0] = " O ";
                            counter++;
                            Console.WriteLine("Player 1 plays");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This cell is occupied, choose another one");
                    }

                    break;

                case 8:
                    if (arr[4, 2] != " X " && arr[4, 2] != " O ")
                    {
                        if (counter % 2 == 0)
                        {
                            arr[4, 2] = " X ";
                            counter++;
                            Console.WriteLine("Player 2 plays");
                        }
                        else
                        {
                            arr[4, 2] = " O ";
                            counter++;
                            Console.WriteLine("Player 1 plays");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This cell is occupied, choose another one");
                    }

                    break;

                case 9:
                    if (arr[4, 4] != " X " && arr[4, 4] != " O ")
                    {
                        if (counter % 2 == 0)
                        {
                            arr[4, 4] = " X ";
                            counter++;
                            Console.WriteLine("Player 2 plays");
                        }
                        else
                        {
                            arr[4, 4] = " O ";
                            counter++;
                            Console.WriteLine("Player 1 plays");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This cell is occupied, choose another one");
                    }
                    
                    break;
                



            }
                
        }
    }

    public static void ShowTable(string[,] arr)
    {

        Console.Clear();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }
    }

    public static bool CheckGameStatus(string[,] arr)
    {
        for(int i = 0; i < arr.GetLength(0);i++)
        {
            if ( arr[i, 0] == arr[i, 2] && arr[i, 2] == arr[i, 4] && arr[i, 4] == " X ")
            {
                Console.WriteLine("Player 1 Won");
                return false;

            }
            else if (arr[i, 0] == arr[i, 2] && arr[i, 2] == arr[i, 4] && arr[i, 4] == " O ")
            {
                Console.WriteLine("Player 2 Won");
                return false;

            }

            else if (arr[0, i] == arr[2, i] && arr[2, i] == arr[4, i] && arr[4, i] == " X ")
            {
                Console.WriteLine("Player 1 Won");
                return false;

            }

            else if (arr[0, i] == arr[2, i] && arr[2, i] == arr[4, i] && arr[4, i] == " O ")
            {
                Console.WriteLine("Player 2 Won");
                return false;

            }
        }

        if ( arr[0,0] == arr[2, 2] && arr[2, 2] == arr[4, 4] && arr[4, 4] == " X ")
        {
            Console.WriteLine("Player 1 Won");
            return false;
        }

        else if (arr[0, 0] == arr[2, 2] && arr[2, 2] == arr[4, 4] && arr[4, 4] == " O ")
        {
            Console.WriteLine("Player 2 Won");
            return false;
        }

        if (arr[0, 4] == arr[2, 2] && arr[2, 2] == arr[4, 0] && arr[4, 0] == " X ")
        {
            Console.WriteLine("Player 1 Won");
            return false;
        }

        else if (arr[0, 4] == arr[2, 2] && arr[2, 2] == arr[4, 0] && arr[4, 0] == " O ")
        {
            Console.WriteLine("Player 2 Won");
            return false;
        }
        return true;
    }

    public static void ResetTable()
    {
        string[,] initialArr = new string[,]
        {
            {" 1 ", "|", " 2 ", "|", " 3 " },
            {"---", "|", "---", "|", "---" },
            {" 4 ", "|", " 5 ", "|", " 6 " },
            {"---", "|", "---", "|", "---" },
            {" 7 ", "|", " 8 ", "|", " 9 " }
        };
        arr = initialArr;
        ShowTable(arr);

    }

    

    

    

}