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

            char input;
            do
            {
                Console.WriteLine("Enter The Your Choice   ");
                Console.WriteLine("Enter :: 0 ::  Exit");
                Console.WriteLine("Enter :: 1 ::  check Year Leap year or not ");
                Console.WriteLine("Enter :: 2 ::  Quadratic Equation");
                Console.WriteLine("Enter :: 3 ::  Eculidiean Distance ");
                Console.WriteLine("Enter :: 4 ::  Distincit Triplates ");
                Console.WriteLine("Enter :: 5 ::  Gambler");
                Console.WriteLine("Enter :: 6 ::  Prime Factor ");
                Console.WriteLine("Enter :: 7 ::  Harmonic Series ");
                Console.WriteLine("Enter :: 8 ::  Power of Two ");
                Console.WriteLine("Enter :: 9 ::  Replace of string ");
                Console.WriteLine("Enter :: 10 ::  Factorial ");
                Console.WriteLine("Enter :: 11 ::  Fibonacci Series ");
                Console.WriteLine("Enter :: 12 ::  check Pallindrom ");
                Console.WriteLine("Enter :: 13 ::  Flip Coins ");
                Console.WriteLine("Enter :: 14 ::  Check Prime Or Not ");
                Console.WriteLine("Enter :: 15 ::  Primne In between ");
                Console.WriteLine("Enter :: 16 ::  Reverse of String  ");
                Console.WriteLine("Enter :: 17 ::  Anagram Detection ");
                Console.WriteLine("Enter :: 18 ::  Pallindrom Anagram");
                Console.WriteLine("Enter :: 19 ::  Binary Search");
                Console.WriteLine("Enter :: 20 ::  Insertion Sort");
                Console.WriteLine("Enter :: 21 ::  Bubble Sort");
                Console.WriteLine("Enter :: 22 ::  Sqrt Using Netwons Method");
                Console.WriteLine("Enter :: 23 ::  Tempratur Conversion");
                Console.WriteLine("Enter :: 24 ::   monthly Payment");
                Console.WriteLine("Enter :: 25 ::  Decimat to Binary");
                Console.WriteLine("Enter :: 26 ::  Swap Nibbles And Find Resultant Number ");
                Console.WriteLine("Enter :: 27 ::  Reverse of the word ");
                Console.WriteLine("Enter :: 28 ::  Print Initials i.e Enter Mahatama Gandhi Find M.Gandhi ");
                Console.WriteLine("Enter :: 29 ::  Permutaion of the String ");
                Console.WriteLine("Enter :: 30 ::  Max and Min value in The array  ");
                Console.WriteLine("Enter :: 31 ::  Collect Chanange Money or Vending Machine Problem ");
                Console.WriteLine("Enter :: 32 ::  Find The day of the Week ");
                Console.WriteLine("Enter :: 33 ::  Find Duplicate ");
                Console.WriteLine("Enter :: 34 ::  Find Prime Anagram ");

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
                        PrimePallindrom PA = new PrimePallindrom();
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

                    case 31:
                        VendingMachine VM = new VendingMachine();
                        VM.vendingMachine();
                        break;
                    case 32:
                        DayOfWeek DoW = new DayOfWeek();
                        DoW.DayOfweek();
                        break;
                    case 33:
                        FindDuplicateInTheArray Duplicate = new FindDuplicateInTheArray();
                        Duplicate.findDuplicate();
                        break;
                    case 34:
                        PrimeAnagram PerimeAnagram = new PrimeAnagram();
                        PerimeAnagram.primeAnagram();
                        break;


                    default:
                        Console.WriteLine("You Choose Wrong Option");
                        break;


                
                }
                Console.WriteLine("Do u Want To Continue Y/N");
                input = Convert.ToChar(Console.ReadLine());
            } while (input.Equals('Y') || input.Equals('y'));




            


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
