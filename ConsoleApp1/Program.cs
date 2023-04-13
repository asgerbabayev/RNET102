namespace Program
{
    class Program
    {
        static void Main()
        {
            #region Task 1
            //Thread.Sleep(5000);
            //Task.Delay(5000);

            //int timeToWait = Convert.ToInt32(Console.ReadLine());

            //DateTime second = DateTime.Now.AddSeconds(timeToWait);

            //while (second > DateTime.Now) { }

            //Console.WriteLine(timeToWait);

            //Stopwatch stopwatch = Stopwatch.StartNew();

            //while (stopwatch.Elapsed.Seconds < timeToWait) { }
            //Console.WriteLine(stopwatch.Elapsed.Seconds); 
            #endregion

            #region Task 2
            //int passwordLenght = Convert.ToInt32(Console.ReadLine());
            //Random random = new Random();
            //const string CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            //StringBuilder stringBuilder = new StringBuilder();
            ////string password = "";
            //for (int i = 0; i < passwordLenght; i++)
            //{
            //    int index = random.Next(0, CHARACTERS.Length);
            //    stringBuilder.Append(CHARACTERS[index]);
            //}
            //Console.WriteLine(stringBuilder.ToString()); 
            #endregion

            #region Switch case
            //int choose = 1;
            //string uncle = "dayday";

            //switch (choose)
            //{
            //    case 1 when uncle == "dayday":
            //        Console.WriteLine("Transferred to HR");
            //        Console.WriteLine("Transferred to HR");
            //        Console.WriteLine("Transferred to HR");
            //        Console.WriteLine("Transferred to HR");
            //        Console.WriteLine("Transferred to HR");
            //        break;
            //    case 2:
            //        Console.WriteLine("Transferred to CTO");
            //        break;
            //    default:
            //        break;
            //}

            //string result = choose switch
            //{
            //    1 => "",
            //    2 => "",
            //    //discard
            //    _ => ""
            //}; 
            #endregion


            // Discard
            //int _ = 5;

            #region Cabinet - door
            //Console.Write("Enter the cabinet width (cm): ");
            //double cabinetWidth = double.Parse(Console.ReadLine());

            //Console.Write("Enter the cabinet height (cm): ");
            //double cabinetHeight = double.Parse(Console.ReadLine());

            //Console.Write("Enter the cabinet depth (cm): ");
            //double cabinetDepth = double.Parse(Console.ReadLine());

            //Console.Write("Enter the door width (cm): ");
            //double doorWidth = double.Parse(Console.ReadLine());

            //Console.Write("Enter the door height (cm): ");
            //double doorHeight = double.Parse(Console.ReadLine());

            //double fitProbability = 0.0;


            //if (cabinetWidth <= doorWidth && cabinetHeight <= doorHeight)
            //{
            //    Console.WriteLine("The cabinet can easily fit through the door.");
            //    fitProbability = 1.0;
            //}
            //else if (cabinetWidth > doorWidth || cabinetHeight > doorHeight)
            //{
            //    Console.WriteLine("The cabinet can't fit through the door.");
            //}
            //else
            //{
            //    double diagonal = Math.Sqrt(Math.Pow(cabinetWidth, 2) +
            //                                Math.Pow(cabinetHeight, 2) +
            //                                Math.Pow(cabinetDepth, 2));
            //    double fitWidth = (diagonal - cabinetDepth) / Math.Sqrt(2);

            //    if (fitWidth <= doorWidth)
            //    {
            //        fitProbability = (fitWidth / doorWidth) * (cabinetHeight / doorHeight);
            //        Console.WriteLine("Probability : %" + (fitProbability * 100).ToString("0.00"));
            //    }
            //    else
            //    {
            //        Console.WriteLine("The cabinet cannot fit through the door.");
            //    }
            //} 
            #endregion

            #region Task 1
            //string text = Console.ReadLine();

            //int count = 0;

            //foreach (char item in text)
            //{
            //    switch (item)
            //    {
            //        case 'a':
            //        case 'u':
            //        case 'e':
            //        case 'i':
            //        case 'o':
            //            break;
            //        default:
            //            count++;
            //            break;
            //    }
            //} 
            #endregion

            #region Task 2
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //char op = char.Parse(Console.ReadLine());
            //int result = op switch
            //{
            //    '+' => n1 + n2,
            //    '-' => n1 - n2,
            //    '*' => n1 * n2,
            //    '/' => n1 / n2,
            //};
            //switch (op)
            //{
            //    case '+':
            //        result = n1 + n2;
            //        break;
            //    case '-':
            //        result = n1 - n2;
            //        break;
            //    case '*':
            //        result = n1 * n2;
            //        break;
            //    case '/':
            //        result = n1 / n2;
            //        break;
            //}
            //Console.WriteLine(result); 
            #endregion

            #region Task 3
            //Console.WriteLine("Ay daxil edin : ");
            //int month = int.Parse(Console.ReadLine());

            //Console.WriteLine("Il daxil edin : ");
            //int year = int.Parse(Console.ReadLine());

            //bool days = DateTime.IsLeapYear(year);
            //Console.WriteLine(days);

            #endregion
        }
    }
}



