using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWarsConsoleApp
{
    public class Kata
    {
        // looking to do 20 level 8 katas before ranking up.
        // how many kyus completed?: https://www.codewars.com/users/Xcoder62/completed
        // scroll down to load all kyus then ctrl-F to find all of them
        // last updated: 12/11/2023
        // kyu 8 : 26/25
        // kyu 7 : 12/25
        // rank 5  up system staritng with 7
        // try 5 kyu 7s and for each one complete with 30mins, if all 5 complete, go to kyu 6 and continue
        // if failed 1 kyu (ie failed the 2nd one), do the remaining 3, then start over at kyu 7 for the next 5.
        // if failed to get 5 in a row 3 times, decrease by 2 kyu and try again.
        // take 30 mins to solve, if not, look at solution, write it over then try again next day


        // kyu 6 : 0/20
        // kyu 5 : 0/20
        // kyu 4 : 0/20
        // kyu 3 : 0/20

        public static char GetGrade(int s1, int s2, int s3)
        {
            //List<int> inputs = new List<int>() { s1, s2, s3 };
            //double average = inputs.Average();
            //Console.WriteLine(average);
            //if (average >= 90 && average <= 100)
            //{
            //    return 'A';
            //}
            //else if (average >= 80 && average < 90)
            //{
            //    return 'B';
            //}
            //else if (average >= 70 && average < 80)
            //{
            //    return 'C';
            //}
            //else if (average >= 60 && average < 70)
            //{
            //    return 'D';
            //}
            //else if (average >= 0 && average < 60)
            //{
            //    return 'F';
            //}
            //return ' ';

            var s = (s1 + s2 + s3) / 3;
            if (60 > s) return 'F';
            if (70 > s) return 'D';
            if (80 > s) return 'C';
            if (90 > s) return 'B';
            return 'A';

        }

        public static string Rps(string p1, string p2)
        {
            //if (p1 == p2) return "Draw!";
            //if (p1 == "rock" && p2 == "scissors") return "Player 1 won!";
            //if (p1 == "rock" && p2 == "paper") return "Player 2 won!";
            //if (p1 == "scissors" && p2 == "paper") return "Player 1 won!";
            //if (p1 == "scissors" && p2 == "rock") return "Player 2 won!";
            //if (p1 == "paper" && p2 == "rock") return "Player 1 won!";
            //if (p1 == "paper" && p2 == "scissors") return "Player 2 won!";


            //return null;

            if (p1 == p2)
                return "Draw!";

            if (((p1 == "rock") && (p2 == "scissors")) ||
                ((p1 == "scissors") && (p2 == "paper")) ||
                ((p1 == "paper") && (p2 == "rock")))
            {
                return "Player 1 won!";

            }
            else
            {
                return "Player 2 won!";
            }

        }

        public static string[] StringToArray(string str)
        {
            var stringArray = str.Split(" ");
            return stringArray;


        }

        public static string greet()
        {
            return "hello world!";
        }

        public static string greet2(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }


        public static string FindNeedle(object[] haystack)
        {
            return $"found the needle at position {Array.IndexOf(haystack, "needle")}";
        }

        public static bool lovefunc(int flower1, int flower2)
        {
            //bool isFirstEven = false;
            //bool isSecondEven = false;

            //if (flower1 % 2 == 0)
            //{
            //    isFirstEven = true;
            //} else
            //{
            //    isFirstEven = false;
            //}

            //if (flower2 % 2 == 0)
            //{
            //    isSecondEven = true;

            //} else
            //{
            //    isSecondEven = false;
            //}

            //if (!isFirstEven && isSecondEven)
            //{
            //    return true;
            //} else if (isFirstEven && !isSecondEven)
            //{
            //    return true;
            //} else
            //{
            //    return false;
            //}

            if (flower1 % 2 == 0 && flower2 % 2 != 0) return true;
            if (flower1 % 2 != 0 && flower2 % 2 == 0) return true;
            return false;
        }

        public static string NumberToString(int num)
        {
            return Convert.ToString(num);
        }

        public static double SumArray(double[] array)
        {
            //double sum = 0;
            //foreach (double x in array)
            //{
            //    sum += x;
            //}
            //return sum;
            return array.Sum();
        }

        public static int kataMin(int[] list)
        {
            return list.Min();
        }

        public static int kataMax(int[] list)
        {
            return list.Max();
        }

        public static int AreaOrPerimeter(int l, int w)
        {
            //if (l == w)
            //{
            //    return l * w;
            //} else
            //{
            //    return (l * 2) + (w * 2);
            //}
            return l == w ? l * w : (l + w) * 2;

        }

        public static string Disemvowel(string str)
        {
            string pattern = @"[aeiou]";
            //return Regex.Replace(str, pattern, "");

            return Regex.Replace(str, pattern, "", RegexOptions.IgnoreCase);
        }

        public static int GetVowelCount(string str)
        {
            // kata answer
            return str.Count(letter => "aeiou".Contains(letter));


            //regex answer

            //int vowelCount = 0;
            //var patternMatch = Regex.Matches(str, @"[aeiou]");
            //vowelCount = patternMatch.Count();
            //return vowelCount;

        }

        public static int NumberOfPeopleLeftOnBus(List<int[]> peopleListInOut)
        {
            //int inTotal = 0;
            //int outTotal = 0;

            //foreach (int[] pair in peopleListInOut)
            //{
            //    inTotal += pair[0];
            //    outTotal += pair[1];
            //}

            //return inTotal - outTotal;

            int finalCount = 0;
            for (int i = 0; i < peopleListInOut.Count; i++)
            {
                finalCount += peopleListInOut[i][0];
                finalCount -= peopleListInOut[i][1];
            }
            return finalCount;


        }

        public static int[] InvertValues(int[] input)
        {
            //int[] result = new int[input.Length];
            //for (int i = 0; i < input.Length; i++)
            //{
            //    result[i] = input[i] * -1;
            //}
            //return result;
            return input.Select(n => -n).ToArray();
        }

        public static string dnaToRna(string dna)
        {
            return dna.Replace('T', 'U');
        }

        //17
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            //List<int> result = new List<int>();
            //result = numbers.ToList();
            //if (result.Count != 0) {
            //    var smallestRating = result.Min();
            //    result.Remove(smallestRating);
            //}
            //return result;
            List<int> result = numbers.ToList();
            if (result.Count > 0)
            {
                result.Remove(result.Min());
            }

            return result;

        }

        // 18
        public static int RentalCarCost(int d)
        {
            //int result = 0;
            int result = 40 * d;
            if (d >= 7)
            {
                result = result - 50;
            }
            else if (d >= 3)
            {
                result = result - 20;
            }
            return result;

        }

        // 19
        public static string Bmi(double weight, double height)
        {
            //double bmi = (weight) / (Math.Pow(height, 2));
            //if (bmi > 30)
            //{
            //    return "Obese";
            //} else if (bmi <= 30 && bmi > 25)
            //{
            //    return "Overweight";
            //} else if (bmi <= 25 && bmi > 18.5)
            //{
            //    return "Normal";
            //} else if (bmi < 18.5)
            //{
            //    return "Underweight";
            //}
            //return "";

            double bmi = (weight) / Math.Pow(height, 2);
            // always go from the smallest to biggest
            if (bmi <= 18.5)
            {
                return "Underweight";
            }
            if (bmi <= 25)
            {
                return "Normal";
            }
            if (bmi <= 30)
            {
                return "Overweight";
            }
            return "Obese";

        }


        //20
        public static bool Feast(string beast, string dish)
        {
            //if (beast[0] == dish[0] && beast[beast.Length-1] == dish[dish.Length-1])
            //{
            //    return true;
            //}
            //return false;

            return beast[0] == dish[0] && beast[beast.Length - 1] == dish[dish.Length - 1];
        }


        // 21 (7 or above only)
        public static int DescendingOrder(int num)
        {
            //string result = "";
            //if (num == 0) return 0;
            //string input = Convert.ToString(num);
            //while(!string.IsNullOrEmpty(input))
            //{
            //    char[] test = input.ToCharArray();
            //    var maxNumber = test.Max();
            //    result += maxNumber;
            //    input = input.Remove(input.IndexOf(maxNumber),1);
            //}
            //return Convert.ToInt32(result);

            // 1 liner split into parts
            // orders each char from greatest to least
            var input = num.ToString().OrderByDescending(x => x);
            // combine the chars together starting from the greatest to least
            var result = string.Concat(input);

            var onelinesolution = int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
            
            return int.Parse(result);

        }

        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            //if (BinaryArray.Length == 0) return 0;
            //double sum = 0;
            //int exponential = BinaryArray.Length - 1;
            //foreach (var binaryNum in BinaryArray) 
            //{
            //    if (binaryNum == 1) sum += Math.Pow(2, exponential);
            //    exponential--;
            //}
            //return Convert.ToInt32(sum);

            //var concateString = string.Join("", BinaryArray);
            //var base2Conversion = Convert.ToInt32(concateString, 2);
            //return base2Conversion;

            // one liner
            //turn Convert.ToInt32(string.Join("", BinaryArray), 2);

            int sum = 0;

            // solution b
            for (int i = BinaryArray.Length - 1, p = 0; i > -1; i--, p++) {
                if (BinaryArray[i] > 0) sum += (int)Math.Pow(2, p);
            }

            return sum;

            

        }
        

        public static string ReverseWords(string str)
        {
            //var dividedWords = str.Split(' ');
            //var reversedWords = new List<string>();
            //foreach (string word in dividedWords)
            //{
            //    var reversedWord = new string(word.Reverse().ToArray());
            //    reversedWords.Add(reversedWord);
            //}

            //var result = string.Join(" ", reversedWords);
            //return result;

            // one liner step by step
            var listOfReversedStrings = str.Split(' ').Select(x => new string(x.Reverse().ToArray()));
            return string.Join(" ", listOfReversedStrings);

        }

        public static int NbYear(int p0, double percent, int aug, int p)
        {
            if (p0 >= p) return 0;
            int yearsRequired = 0;
            double totalPopulation = p0;

            double increasePerYear = percent / 100;
            while (totalPopulation < p)
            {
                // 1 + percentage + aug
                totalPopulation = Math.Floor(totalPopulation + totalPopulation * increasePerYear + aug);
                yearsRequired++;
            }


            return yearsRequired;

        }

        public static double[] tipCalculator(double bill, double percent)
        {
            double increasedBy = percent / 100;
            double tipAmt = Math.Round(bill * increasedBy,2);

            double totalAmt = bill + tipAmt;
            
            return new double[] { tipAmt, totalAmt };

            // 13.00, 28% == $3.64 , $16.64
        }

        public static string seriesSum (int n)
        {
            // kata solution
            //double ret = 0;
            //if n is 0, this sum part is never reached
            //for (var i = 1; i <= n; i++)
            //{
            //    1 + 1 / 4 + 1 / 7 + 1 / 10 + 1 / 13 + 1 / 16 + ...
            //    ret += 1f / (3 * i - 2);
            //}
            //return ret.ToString("0.00");



            if (n == 0) return "0.00";
            if (n == 1) return "1.00";
            if (n == 2) return "1.25";
            if (n > 2)
            {
                double sum = 0.00;
                double demo = 7.00;
                List<double> seriesList = new List<double>();
                double beginningOfSum = 1.00 + (1.00 / 4.00);
                seriesList.Add(beginningOfSum);
                for (int i = 0; i < n - 2; i++)
                {
                    double nextSeriesNum = (1.00 / (demo + (3.00 * i)));
                    seriesList.Add(nextSeriesNum);
                }
                sum = seriesList.Sum();
                //return Math.Round(sum, 2).ToString(); // shows 2.10 as 2.1 instead of 2.10
                return Math.Round(sum, 2).ToString("0.00");// shows 2.10
            }
            return "0.00";
        }

        public static int Stray(int[] numbers)
        {

            // kata solution
            // [17, 17, 3, 17, 17, 17, 17]
            var numof17 = numbers.Count(x => x == 17);
            return numbers.First(x => numbers.Count(i => i == x) == 1);
            
            
            //var groupedDict = numbers.GroupBy(x => x).Select(x => new { key = x.Key, val = x.Count()});
            
            //foreach (var item in groupedDict)
            //{
            //    if (item.val == 1) {
            //        return item.key;
            //    }
            //}

            return 0;
        }

        public static int Grow(int[] x)
        {
            // a = 1, b = 2, next a is a *b = 2
            // a = 2, b = 3 next a is a*b = 6
            // a = 6, b = 4 next a is 24
            // 24 is result as 4 was the last number in [1,2,3,4]
            return x.Aggregate((a, b) => a * b);

            //if (x.Length == 0) return 0;
            //int result = 1;
            //foreach (var num in x)
            //{
            //    result *= num;
            //}
            //return result;
        }

        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            uint totalPossibleDisance = mpg * fuelLeft;
            return totalPossibleDisance >= distanceToPump;
        }

        public static int OtherAngle(int a, int b)
        {
            return 180 - (a + b);
        }

        public static int CenturyFromYear(int year)
        {

            return (year - 1) / 100 + 1;
            //int century = year / 100;
            //if (year % 100 != 0)
            //{
            //    century++;
            //}

            //return century;
        }

        public static string GetMiddle(string s)
        {
            if (s.Length % 2 == 0)
            {
                int middleIndex = (s.Length / 2) - 1;
                return s.Substring(middleIndex, 2);
            } else
            {
                int middleIndex = (s.Length / 2);
                return s.Substring(middleIndex,1);

            }



        }

        public static string MakeUpperCase(string str)
        {
            return str.ToUpper();
        }

        public static string Accum(string s)
        {
            if (s.Length < 1) return "";
            StringBuilder sb = new StringBuilder();
            int count = 1;
            foreach(char c in s.ToLower())
            {
                sb.Append(Char.ToUpper(c), 1)
                    .Append(c, count++ - 1) // the ++ increments count after count-1 is executed
                    .Append('-');

               
            }


            return sb.ToString().TrimEnd('-');
            
            
            // abCd
            //string result = "";
            //for (int i = 0; i < s.Length; i++ )
            //{
            //    result += s[i].ToString().ToUpper();
            //    result += String.Concat(Enumerable.Repeat(s[i].ToString().ToLower(), i));
            //    result += "-";
            //}
            //result = result.TrimEnd('-');

            //return result;
        }

        public static double basicOp(char operation, double value1, double value2)
        {


            switch(operation)
            {
                case '+': return value1 + value2;
                case '-': return value1 - value2;
                case '*': return value1 * value2;
                case '/': return value1 / value2;
                default:
                    throw new System.ArgumentException("Unknown op", operation.ToString());
            }


            //if (operation == '+')
            //{
            //    return value1 + value2;
            //} else if (operation == '-')
            //{
            //    return value1 - value2;
            //} else if (operation == '*')
            //{
            //    return value1 * value2;
            //} else if (operation == '/')
            //{
            //    return value1 / value2;
            //}


            return 0.0;
        }

        public static int[] CountBy(int x, int n)
        {
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = x * (i + 1); 
            }

            return result;

        }

        public static int SquareSum(int[] numbers)
        {
            return numbers.Sum(x => x * x);

            //int result = 0;
            //foreach (int item in numbers)
            //{
            //    result += item * item;
            //}
            //return result;
        }

        // RANK 5 UP START
        // Retry 0/3
        // Kyu 7 2/5
        // Fail?: N
     
        // pass
        public static bool IsIsogram(string str)
        {

            // these two should be the same, if not means there was multiple
            

            if (string.IsNullOrEmpty(str)) return true;
            var grouped = str.GroupBy(x => Char.ToLower(x));
            
            // my answer
            var result = str.GroupBy(x => Char.ToLower(x)).All(c => c.Count() == 1);

            // kata
            return str.ToLower().Distinct().Count() == str.Length; 


        }

        // pass
        public static string ToJadenCase(string phrase)
        {

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);

            //var listofWords = phrase.Split(' ');
            //string result = "";
            //foreach (string word in listofWords)
            //{
            //    result += word[0].ToString().ToUpper() + word.Substring(1) + " ";
            //}
            //result = result.TrimEnd(' ');
            //return result;
        }

    }
}
