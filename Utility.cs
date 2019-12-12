using System;
public class Utility
{
    //******************************************  Start Max_Min of the array ******************************************/

    public static int Max(int[] arr)
    {
       
        int max=arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
           
            if (arr[i] > max)
            {
                max = arr[i];
            }
          
        }
        return max;

    }
    public static int Min(int[] arr)
    {

        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
           
            if (arr[i] < min)
            {
                min = arr[i];
            }

        }
        return min;


    }

    //******************************************  End Max_Min of the array ******************************************/


    //******************************************  Start Permutaitons of the string  ******************************************/
    public static String swap(String a, int i, int j)
    {
        char temp;
        char[] charArray = a.ToCharArray();
        temp = charArray[i];
        charArray[i] = charArray[j];
        charArray[j] = temp;
        string s = new string(charArray);
        return s;
    }

    public static void Permutions(String str,int l,int r)
    {


        int i;
        if (l == r)
        {
            Console.WriteLine(str);
        }
        else {
            for ( i = l; i <=r; i++)
            {
                 str= swap(str, l, r);
                Permutions(str, l + 1, r);
                  str=swap(str, l, r);
            }
        }
    }

   


    //******************************************  End Perumtations of the string  ******************************************/


    //******************************************  Start PrintInitials  ******************************************/

    public static void printinitials(string str)
    {
        str = ' ' + str;
        int postition = str.LastIndexOf(" ");
        for (int i = 0; i < postition; i++)
        {
            if(str[i] ==' ')
            { 
                Console.Write(str[i+1] + ". "  );
            }
           
        }
        Console.Write(str.Substring(postition));
    }

    //******************************************  END PrintInitilas  ******************************************/

    //******************************************  Start Reverse of the word  ******************************************/
    public static void reverseWord(string str) {
        string revstring = " ";
        string[] words = str.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            string revword=" ";
            for (int j = word.Length-1; j >= 0; j--)
            {
                revword = revword + word[j];
            }
            revstring = revstring + revword + " ";
           

           
        }
        Console.WriteLine(revstring);

    }

    //******************************************  End Reverse of the word  ******************************************/
    
        
        
   //******************************************  Start swap Nibbles  ******************************************/

    public static int swapNibbles(int x)
    {
       
        return ((x & 0x0F) << 4 |
           (x & 0xF0) >> 4);

    }

        //******************************************  End Swap Nibbles  ******************************************/


    //******************************************  Start Decimal TO Binary  ******************************************/
    public static void  decimatoBnry(int no)
    {
        int[] binary = new int[1000];
        int i = 0;
        while (no != 0)
        {
            binary[i] = no % 2;
            no = no / 2;
            i++;
        }
        Console.Write("The Binary of " +  no + " is ----->" );
        for (int j = i - 1; j >= 0; j--)
        {
            Console.Write(binary[j]);
        }
        
    }

    //******************************************  End Decimaol To Binary ******************************************/



    //******************************************  Start Monthly Payment  ******************************************/
    public static double MonthlyPay(double p,double Y,double R)
    {
        double n = 12 * Y;
        double r = R / (12 * 100);
        double pyment;
        pyment = (p * r )/ (1 - (Math.Pow(1 + r, -n)));
        return pyment;
            }
        
        
        //******************************************  End Monthly Payment  ******************************************/
    
        
        
        //******************************************  Start sqrt Netwons Method  ******************************************/
    public static double netwonmethod(double c)
    {

        double elipsion = 1e-15;
        double t = c;
        while (Math.Abs(t - c / t) > elipsion * t)
        {
            t = (c / t + t) / 2.0;
        }
        return t;
    }
    //******************************************  End sqrt Netwons Method ******************************************/


    //******************************************  Start Bubble  Of Integer ******************************************/
    public static void BubbleSortInrteger(int[] arr, int size)
    {
        int temp;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (arr[i] < arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            
        }

        for (int j = 0; j < size; j++)
        {
            Console.WriteLine(arr[j]);
        }
    }


    //******************************************  End Bubble  Of Integer ******************************************/


    //******************************************  Start Bubble  Of  String ******************************************/

    public static void BubbleSortString(string[] arr, int size)
    {
        string temp;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (arr[i].CompareTo(arr[j]) < 0)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(arr[i]);
        }
            
    }
        
        //****************************************** End  Bubble  Of  String ******************************************/


    //******************************************  Start Insertion  Of String ******************************************/

    public static void InsertionsortString(string[] arr, int size)
    {    int j;
        string temp;
        
        for (int i = 0; i < size; i++)

        {
            j = i; temp = arr[i];
            while (j > 0 && arr[j - 1].CompareTo(temp)>0)
            {
                arr[j] = arr[j - 1];
                j--;
            }
            arr[j] = temp;
        }
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }


    //******************************************  End Insertion  Of String ******************************************/
    //******************************************  Start Insertion  Of Integer ******************************************/

    public static void InsertionSortInrteger(int[] arr, int size)
    {
        int temp, j;
        for (int i = 1; i < size; i++)
        {
            j = i;
            temp = arr[i];
            while (j > 0 && arr[j-1] > temp)
            {
                arr[j] = arr[j - 1];
                j--;
            }
            arr[j] = temp;
        }
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }


    //******************************************  ENd Insertion  Of Interger ******************************************/
    //******************************************  Start BinarySearch  Of String ******************************************/
    public static int BinarySearchString(string[] arr, int n, string key)
    {
        int low = 0;
        int high = n;
        while(low<=high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == key)
                return mid;
            if (key.CompareTo(arr[mid]) > 0)
            {
                high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }

        return -1;
      
        
    }


        //******************************************  End BinarySearch  Of String ******************************************/



    //******************************************  Start BinarySearch  Of Integer ******************************************/
    public static int BinarySearchInrteger(int[] arr, int length, int key)
    {

        int mid = 0;
        int low = 0;
        int hight = length;
        while (low <=hight)
        {
            mid = (low + hight) / 2;
            if (arr[mid] == key)
                return mid;

            else if (key < arr[mid])
            {
                hight = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
           
        }


        return -1;
    }

    //******************************************  End BinarySearch  Of Integer ******************************************/

    //******************************************  Start Pallindrom Prime ******************************************/






    //******************************************  Start Pallindrom Prime ******************************************/

    public static void Pallindromprime(int N)
    {
        int temp=0,rev=0,b;
        int original,primeOriginal;
        for (int no = 10; no <= N; no++)
        {

            original = no;

            for (int j = 2; j <= no - 1; j++)
            {
                original = no;
                //  Console.WriteLine(original);

                primeOriginal = no;
                // Console.WriteLine(primeOriginal);

                if (primeOriginal % j == 0) {
                   
                    temp = temp + 1;
                }

            } while (no != 0)
            {
                b = no % 10;
                rev = rev * 10 + b;
                no = no / 10;
            }


            if (temp == 0 && rev == original)
            {
                Console.WriteLine(no);
            }
            else
            {
                temp = 0;
            }
           

        }


    }


    //******************************************  Start Pallindrom Prime******************************************/






    //******************************************  Start Anagram Detection ******************************************/
    public static bool IsAnagram(string s1, string s2)
    {
        bool result=true;
        if (s1.Length!= s2.Length)
        {
            return false;
        }
        else
        {
            char[] ch1 = s1.ToCharArray();
            char[] ch2 = s2.ToCharArray();
             Array.Sort(ch1);
              Array.Sort(ch2);

           result=Array.Equals(ch1, ch1);

            return result;
        }
      
     
    }

    //******************************************  End  Anagram Detection ******************************************/

    //*****************************************  Start WindChill ******************************************/



    //*****************************************  End WindChill ******************************************/

    //*****************************************  Start Quadratic Equcation a*x*x+b*x+c=0 ******************************************/

    public static void quadratucequcation(int a,int b,int c)
    {

        double x1=0;
        double x2=0;
        double d=b*b-(4 * a * c);
           Console.WriteLine(d);
        x1 = -((b + Math.Sqrt(d))/2.0*a);    
        x2 = -((b - Math.Sqrt(d))/2.0*a);
        Console.WriteLine("The Frist root of the Equcation is ----> " + x1);
        Console.WriteLine("The Second  root of the Equcation is ----> " + x2);


    }



    //*****************************************  End Quadratic Equcation a*x*x+b*x+c=0 ******************************************/

    //*(****************************************  Start Euclidiean Distance ******************************************/

    public double EuclidieanDistance(int x, int y)
    {
        double result;
        double X= Math.Pow(x, 2);  
        double Y= Math.Pow(y, 2);
        result = Math.Sqrt(x + y);

        return result;
    }
                        


    //*(****************************************  End Euclidiean Distance ******************************************/


    //*(****************************************  Start Triplates ******************************************/

    public static void DistnictTriplate(int[] arr,int N)
    {

        int temp = 0;
        for (int i = 0; i < N-2; i++)
        {
            for (int j = i + 1; j < N-1; j++)
            {
                for (int k = j + 1; k < N; k++)
                {
                    if (arr[i] + arr[j] + arr[k] == 0)
                    {
                        Console.WriteLine("i = " +i +" j = "+ j+ " k= "+k);
                        temp = temp + 1;
                    }
                }
            }
       }
        if (temp == 0)
        {
            Console.WriteLine("There is no Match Found ");
        }

    }



    //*(****************************************  End Triplates ******************************************/




    /*****************************************************  Start Gambler ******************************************/

    public void Gambler(int stack, int goal, int Trails)
    {
        Random rd = new Random();

        int win = 0;
        int loss = 0;
        int bet = 0,cash=0;

        for (int i = 1; i <= Trails; i++)
        {
            cash = stack;
            while (cash > 0 && cash < goal)
            {
                bet++;
                if (rd.Next(-100, 100) < 0)
                {
                    cash++;
                }
                else {
                    cash--;
                }
                if (cash == goal)
                {
                    win++;
                }
            }

           
        }
        Console.WriteLine(win + "You Win  out of " + Trails + "Trails");
        Console.WriteLine("The precentage of Win is " + win*100/Trails);
        Console.WriteLine("The precentage of Loss is " + bet*100/ Trails);
    }




    /*****************************************************  End  Gambler ******************************************/




    /****************************  Start PrimeFactor ***************************************/

    public void primeFactor(int N)
    {
      
        for (int i =2; i < N; i++)        {
            if (N % i == 0)
            {
               Console.Write( i+ " \t");
                N = N / i;
            }
           
        }
        if (N > 1)
        {
            Console.WriteLine(N);
        }
    }



    /****************************  End PrimeFactor ***************************************/



    //****************************************** Start Harmonic Series ************************************************//


    public static void HarmonicSeries(int N)
    {
        double result = 0.0;
        for (int i = 1; i < N; i++)
        {
            result = result + (double)1 / i;
          
            Console.Write(result + "+" );
        }
        Console.WriteLine("\n");
        Console.WriteLine("The Sum of the Series -----> " +result);

    }

    //****************************************** End Harmonic Series    ************************************************//







    //****************************************** Start power of 2 ************************************************//

    public static int poweroftwo(int N)
    {
        int power = 1;
        for (int i = 0; i <= N; i++)
        {
            Console.WriteLine("2^" + i + " = "+ power);
            power = power * 2;
            if (i == N)
            {
              
                break;
            }
         
        }
        return power;

    }

    //****************************************** End power of 2 ************************************************//





    //****** Start Replace User Name *********************************************************************/

    public static void RepalceString(string name,string newname)
    {
       
        //  return name;
      
        int newnamelength = newname.Length;
    
        if (newnamelength== 3)
        {
            string afterreplacename = name.Replace("username", newname);
            Console.WriteLine("After Replace the Name is " + afterreplacename);
            
        }
        else {
            Console.WriteLine("The Name must have only three Character");
        }


        
    }




    //****** End Replace User Name *********************************************************************/






    /* **************************************** Start Check Year Leap Or Not *****************************  */
    public bool IsLeapYear(int year)
    {

        if ((year % 4 == 0 || year %400==0) && (year%100 !=0))
        { return true; }
        else
        { return false;}
    }
    /* ****************************************  End Check Year Leap Or Not *****************************  */




    /* ****************************************  Start Factorial common Method   *****************************  */

    public int Factorial(int N)
    {
        int fact = 1;
        for (int i = 1; i <= N; i++)
        {
            fact = fact * i;
        }
        return fact;
    }

    /* ****************************************  End  Factorial  of common Method*****************************  */



    /* ****************************************  Start Factorial using Recursion *****************************  */

   public static int RecFact(int N)
    {
              if (N == 1)
            return 1;
        else
            return  N * RecFact(N - 1); 
    }


    /* ****************************************  End Factorial using Recursion *****************************  */


    /* ****************************************  Start Fibnoacci Series  *****************************  */


    public static void FacbanocciSeries(int N)
    {
        int a = 1, b = 1, c = 0;
        Console.Write(a + "\t" + b + "\t");
        for (int i = 1; i <= 1000; i++)
        {

            if (c < N) {
                c = a + b;
                if (c > N)
                    break;
            }
            
            Console.Write(c + "\t");
           
          
                a = b;
                b = c;
         
          
           
            
        }
    }




    /* ****************************************  Start Fibnoacci Series  *****************************  */


    /* ****************************************  Start Pallindrom Number  *****************************  */

   public bool pallindrom(int N)
    {
        int Original = N;
        int temp, rev=0;

     
        while (N != 0)
        {
            temp = N % 10;
            rev = rev * 10 + temp;
            N = N / 10;
        }
        if (rev == Original)
        {
            return true;
        }
        else
        {
            return false;
        }


    }



    /* ****************************************  End Pallindrom Number  *****************************  */


    /* ****************************************  Start stop Watch Number  *****************************  */

    public void stopWatch()
    {
        double statTime = DateTime.Now.Millisecond;
        double elapseTime = DateTime.Now.Millisecond - statTime;
        Console.WriteLine(elapseTime);
        

    }

    /* ****************************************  End stop Watch Number  *****************************  */


    /* ****************************************  Start Flip Coins  *****************************  */

    public void FlipCoins(int N)
    {
        Random rd = new Random();
        int head=0;
        int tail=0;
        for (int i = 1; i <= N; i++)
        {
            int flip = rd.Next(-12, 10);

            if (flip < 0.5)
            {
                tail++;
            }
            else
            {
                head++;
            }

           
        }

        Console.Write("The Percentage of Tail is -------> " + tail * 100 / N);
        Console.Write("The Percentage of head is -------> " + head * 100 / N);

    }

    /* ****************************************  End  Flip Coins  *****************************  */



    /* ****************************************  Start Prime Number  *****************************  */

    public bool isPrime(int N)
    {
        int temp = 0;
        for (int i = 2; i <= N - 1; i++)
        {
            if (N % i == 0)
            {
                temp = temp + 1;
            }
        }
        if (temp == 0)
        {
            return true;

        }
        else {
            return false;
        }
    }



    /* ****************************************  End Prime Number  *****************************  */




    /* ****************************************  Start Prime Number in Between *****************************  */

    public void primeInbetween(int start,int End)
    {
        int temp = 0;
        for (int no = start; no <= End; no++)
        {

            for (int j = 2; j <= no-1; j++)

            {
                if (no % j == 0)
                {
                    temp = temp + 1;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine(no);

            }
            else
            {
                temp = 0;
            }

        }
    }



    /* ****************************************  End Prime Number in between *****************************  */

    /* ****************************************  Start Traversing of The Array *****************************  */
    public void TraversingOfArray(int[] arr)
    {
      //  int[] a = { 1, 2, 3, 4, 5, 6, 7, 87, 45, 4, 5};

        Console.WriteLine("First Method foreach Loop"); 
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Second Method for Loop");
        for (int i = 0; i <arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine("Third Method while Loop");
        int j = 0;
        while(j!=arr.Length)
        {
            Console.WriteLine(arr[j]);
            j++;
        }

    }
    /* ****************************************  End Traversing of The Array *****************************  */

    /* ****************************************  Start Reverser of String *****************************  */

    public static String ReverseString(String s)
    {
        string rev = null;

        for (int i = s.Length - 1; i >=0; i--)
        {
            rev = rev + s[i];
        }
        return rev;
    }


    /* ****************************************  End Reverse of the string *****************************  */

    /* ****************************************  Start Pallindrom Of string *****************************  */

    public static bool isPallindromString(String s)
    {
        string oroginal = s;
        string rev = null;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            rev = rev + s[i];
        }
        if (oroginal==rev)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }


    /* ****************************************  End Pallindrom Of string  *****************************  */





}

