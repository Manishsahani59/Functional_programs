using System;

namespace Functional_programs
{
    class Program
    {
        Utility utility = new Utility();
        public static void Main()
        {
            // string value;
            // int choice;
         
                Console.WriteLine("Enter The Your Choice   ");
                Console.WriteLine("Enter :: 1 :: for check Year Leap year or not ");
                Console.WriteLine("Enter :: 2 :: for Quadratic Equation");
                Console.WriteLine("Enter :: 3 :: for Eculidiean Distance ");
                Console.WriteLine("Enter :: 4 :: for Distincit Triplates ");
                Console.WriteLine("Enter :: 5 :: for Gambler");
                Console.WriteLine("Enter :: 6 :: for Prime Factor ");
                Console.WriteLine("Enter :: 7 :: for Harmonic Series ");
                Console.WriteLine("Enter :: 8 :: for Poewr of Two ");
                Console.WriteLine("Enter :: 9 :: for Replace of string ");
                Console.WriteLine("Enter :: 10 :: for Factorial ");
                Console.WriteLine("Enter :: 11 :: for Fibonacci Series ");
                Console.WriteLine("Enter :: 12 :: for check Pallindrom ");
                Console.WriteLine("Enter :: 13 :: for Flip Coins ");
                Console.WriteLine("Enter :: 14 :: for Check Prime Or Not ");
                Console.WriteLine("Enter :: 15 :: for Primne In between ");
                Console.WriteLine("Enter :: 16 :: for Reverse of String  ");
                Console.WriteLine("Enter :: 17 :: for Anagram Detection ");
                Console.WriteLine("Enter :: 18 :: for Pallindrom Anagram");
                Console.WriteLine("Enter :: 19 :: for Binary Search");
                Console.WriteLine("Enter :: 20 :: for Insertion Sort");
                Console.WriteLine("Enter :: 21 :: for Bubble Sort");
                Console.WriteLine("Enter :: 22 :: for Sqrt Using Netwons Method");
                Console.WriteLine("Enter :: 23 :: for Tempratur Conversion");
                Console.WriteLine("Enter :: 24 :: for monthly Payment");
                Console.WriteLine("Enter :: 25 :: for Decimat to Binary");
                Console.WriteLine("Enter :: 26 :: for Swap Nibbles And Find Resultant Number ");
                Console.WriteLine("Enter :: 27 :: for Reverse of the word ");
                Console.WriteLine("Enter :: 28 :: for Print Initials i.e Enter Mahatama Gandhi Find M.Gandhi ");
                Console.WriteLine("Enter :: 29 :: for Permutaion of the String ");
                Console.WriteLine("Enter :: 30 :: for Max and Min value in The array  ");

            Console.WriteLine("If You To Exit Y");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        LeapYear leapyear = new LeapYear();
                        leapyear.IsLeapYear();
                        break;

                    case 2:
                        QuadraticEquacation QE = new QuadraticEquacation();
                        QE.quadraticEqucation();

                        break;
                    case 3:
                        EuclidieanDistance ED = new EuclidieanDistance();
                        ED.Euclidieandistance();
                        break;

                    case 4:
                        Triplates TF = new Triplates();
                        Triplates.FindTriplate();
                        break;
                    case 5:
                        Gambler gambler = new Gambler();
                        gambler.gambler();
                        break;

                    case 6:
                        PrimeFactor pF = new PrimeFactor();
                        pF.primefactor();
                        break;

                    case 7:
                        HarmonicSeries hS = new HarmonicSeries();
                        hS.Harmonicseries();
                        break;

                    case 8:
                        PowerOfTwo pWT = new PowerOfTwo();
                        pWT.POTwo();
                        break;

                    case 9:
                        ReplaceString RPS = new ReplaceString();
                        RPS.replacestring();
                        break;

                    case 10:
                        Factorial fact = new Factorial();
                        fact.factorial();
                        break;

                    case 11:
                        FibanocciSeries fibb = new FibanocciSeries();
                        fibb.Fibanocci();
                        break;

                    case 12:
                        PallindromNo pallindrom = new PallindromNo();
                        pallindrom.pallindrom();
                        break;

                    case 13:
                        FlipCoins fLIP = new FlipCoins();
                        fLIP.Flipcoins();
                        break;

                    case 14:
                        IsPrime isP = new IsPrime();
                        isP.isPrime();
                        break;

                    case 15:
                        PrimeInBetwwen PIB = new PrimeInBetwwen();
                        PIB.primeInBetween();
                        break;

                    case 16:
                        ReverseOfString RevS = new ReverseOfString();
                        RevS.ReverseString();
                        break;

                case 17:
                    AnagramDetection Anagram = new AnagramDetection();
                    Anagram.AnagramString();
                    break;


                case 18:
                    PallindromAnagram PA = new PallindromAnagram();
                    PA.PallPrime();
                    break;


                case 19:
                    BinarySearch bS = new BinarySearch();
                    bS.Binarysearch();
                    break;

                case 20:
                    InsertionSort INS = new InsertionSort();
                    INS.Insertionsort();
                    break;
                case 21:
                    Bubblesort buS = new Bubblesort();
                    buS.bubblesort();
                    break;

                case 22:
                    sqrtusingNetwonsMethod netwons = new sqrtusingNetwonsMethod();
                    netwons.netwonmethod();
                    break;
                case 23:
                    TempraturConversion tempconversion = new TempraturConversion();
                    tempconversion.tempratureConversion();
                    break;
                case 24:
                    MonthlyPayment mp = new MonthlyPayment();
                    mp.monthlyPayemnt();
                    break;
                    
                case 25:
                    DecimalToBinary DToB = new DecimalToBinary();
                    DToB.DecimalTobinary();
                    break;
                case 26:
                    swapNibbles spn = new swapNibbles();
                    spn.swapnibble();
                    break;
                case 27:
                    ReverseOfword revW = new ReverseOfword();
                    revW.ReverseofWord();
                    break;
                case 28:
                    PrintInitials Printinit = new PrintInitials();
                    Printinit.printinitilas();
                    break;
                case 29:
                    PermutationofString permution = new PermutationofString();
                    permution.permutation();
                    break;
                case 30:
                    Max_min minmax = new Max_min();
                    minmax.Max_MIn();
                    break;


                /* case 22:
                     VendingMachine VM = new VendingMachine();
                     VM.vendingMachine();
                     break;
 */

                default:
                        Console.WriteLine("You Choose Wrong Option");
                    break;
                }
          








            //   Console.WriteLine(utility.IsLeapYear(2005));
            //  Console.WriteLine("The Factorial is -----> " +utility.factorial(5));    
            //  Console.WriteLine(Utility.RecFact(5));
            // Utility.FacbanocciSeries(1000);
            //  Console.WriteLine(utility.pallindrom(121));
            //  utility.stopWatch();
            //  utility.FlipCoins(200);
            // Console.Write(utility.isPrime(123));
            //  utility.primeInbetween(50,100);
            // utility.TraversingOfArray();
            //   utility.TraversingOfArray(arr1);
            // Console.WriteLine(Utility.ReverseString(name));
            //   Console.WriteLine(Utility.isPallindromString(name));
            //  utility.RepalceString(name);
            //  Console.WriteLine(Utility.poweroftwo(10));
            //  Utility.HarmonicSeries(15);
            //   utility.primeFactor(15);
            // utility.Gambler(500,2000,50);
            // Console.WriteLine(Utility.EuclidieanDistance(5, 5));
            //  Utility.QuadratucEqucation(1, 5, 4); 
        }

    }
}
