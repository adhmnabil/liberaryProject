namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            char userInput = ' ';
            do
            {
                Console.WriteLine("Kindly choose what you need to do:\r\n    P - Print numbers\r\n    A - Add a number\r\n    M - Display mean of the numbers\r\n    S - Display the smallest number\r\n    L - Display the largest number\r\n    C - Clear the list\r\n    F - Find the index of the number\r\n    I - Find number by index\r\n    Q - Quit ");
                userInput = char.ToUpper(char.Parse(Console.ReadLine()));

                switch (userInput)
                {
                    case 'P':
                        if (list.Count > 0)
                        {
                            string data = string.Join(" ", list);
                            Console.WriteLine($"[ {data} ]");
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }
                        break;

                    case 'A':
                        Console.WriteLine("Kindly add the number you need to add");
                        int input = int.Parse(Console.ReadLine());
                        bool duplicate = list.Contains(input);

                        if (duplicate)
                        {
                            Console.WriteLine("Sorry, the number is already in the list and you cannot add it.");
                        }
                        else
                        {
                            list.Add(input);
                            Console.WriteLine("Number added!");
                        }
                        break;

                    case 'S':
                        if (list.Count > 0)
                        {
                            int smallest = list.Min();
                            Console.WriteLine(smallest);
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }
                        break;

                    case 'L':
                        if (list.Count > 0)
                        {
                            int largest = list.Max();
                            Console.WriteLine(largest);
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }
                        break;

                    case 'M':
                        if (list.Count > 0)
                        {
                            double mean = list.Average();
                            Console.WriteLine(mean);
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }
                        break;

                    case 'C':
                        list.Clear();
                        Console.WriteLine("List is now empty. Thanks!");
                        break;

                    case 'F':
                        if (list.Count > 0)
                        {
                            Console.WriteLine("Enter the number to find the index of:");
                            int numberToFind = int.Parse(Console.ReadLine());
                            int index = list.IndexOf(numberToFind);
                            if (index != -1)
                            {
                                Console.WriteLine($"Index number is {index}");
                            }
                            else
                            {
                                Console.WriteLine("Number not found");
                            }
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }
                        break;

                    case 'I':
                        if (list.Count > 0)
                        {
                            Console.WriteLine("Enter the index number");
                            int index = int.Parse(Console.ReadLine());
                            if (index < list.Count)
                            {
                                Console.WriteLine("Here is your number:");
                                Console.WriteLine(list[index]);
                            }
                            else
                            {
                                Console.WriteLine("Sorry, list is shorter than the provided index.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }
                        break;

                    case 'Q':
                        Console.WriteLine("Thank you for your time!");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

            } while (userInput != 'Q');
        }
    }
}