using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    public class Program
    {
        static void Main(string[] ags)
        {
            //sampleintlist();
            //sample_partitioning();
            //sample_ordering();
            //sample_aggregation();
            //sample_elements();
            //sample_quantifiers();
            //sample_groupby();
            //Employee e=new Employee();
            //Department d=new Department();
            //SampleEmployeeList();
            //Employee employee = new Employee();
            //employee.noOfemployeeinDept();
            SampleEmployeeList_lamda();
            noOfemployeeinDep_lamda();
        }
        private static void sampleintlist()
        {
            List<int> list = new List<int>();
            list.Add(120);
            list.Add(250);
            list.Add(30);
            list.Add(400);
            list.Add(50);
            list.Add(6);

            //var numquerry = from num in list select num;
            //var numquerry = list.select(x => x);

            //var numquerry = from num in list where x > 2 select num;

            var numquerry = list.Where(x => x > 2).ToList();

            //defferes exe - not exec until querry is executed
            //early execution -add tolist()

            list.Add(20);
            foreach (int num in numquerry)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
        }
        private static void sample_partitioning()
        {
            //Skip: Skips specified number of elements in a collection.
            string[] name = { "akshay", "shreedhar", "pramod", "surya", "hari", "goutham", "simran", "arshit" };
            var result1 = name.Skip(2);
            Console.WriteLine("Skips the first 4 words:");
            foreach (string word in result1)
                Console.WriteLine(word);

            //SkipWhile: Skips elements in a collection while specified condition is met.
            var result2 = name.SkipWhile(w => w.Length == 6);
            Console.WriteLine("Skips the words while the condition is set:");
            foreach (string word in result2)
                Console.WriteLine(word);

            //Take: Takes specified number of elements in a collection, starting from first element.
            var result3 = name.Take(3);
            Console.WriteLine("Takes the first 3 names only:");
            foreach (string word in result3)
                Console.WriteLine(word);

            //TakeWhile: Takes elements in a collection while specified condition is met, starting from first element.
            var result4 = name.TakeWhile(w => w.Length > 4);
            Console.WriteLine("Takes names one by one, and stops when condition is no longer met:");
            foreach (string word in result4)
                Console.WriteLine(word);
            Console.WriteLine();

        }
        private static void sample_ordering()
        {
            //OrderBy: Sorts a collection in ascending order.
            int[] numbers = { 23, 13, 23434, 1212, 24, 43, 34 };
            var result1 = numbers.OrderBy(n => n);
            Console.WriteLine("Ordered list of numbers is :");
            foreach (int num in result1)
                Console.WriteLine(num);

            //OrderByDescending: Sorts a collection in descending order.
            var result3 = numbers.OrderByDescending(n => n);
            Console.WriteLine("Ordered list of numbers in decending order is :");
            foreach (int num in result3)
                Console.WriteLine(num);

            //order by dates
            var date = new DateTime[] {new DateTime(2020, 5, 15),new DateTime(2020, 3, 25),new DateTime(2022, 1, 5),
                        new DateTime(2020, 8, 15),new DateTime(2022, 5, 15),};
            var result2 = date.OrderBy(d => d);
            Console.WriteLine("Ordered list of dates:");
            foreach (DateTime dat in result2)
                Console.WriteLine(dat.ToString("yyyy/MM/dd"));

            //Reverse: Reverses elements in a collection.
            var result4 = numbers.Reverse();
            Console.WriteLine("Numbers in reverse order:");
            foreach (int num in result4)
                Console.WriteLine(num);

            //ThenBy: Use after earlier sorting, to further sort a collection in ascending order.
            var result5 = date.OrderBy(d => d.Year).ThenBy(d => d.Month);
            Console.WriteLine("List of dates first ordered by year and then by month:");
            foreach (DateTime dat in result5)
                Console.WriteLine(dat.ToString("yyyy/MM/dd"));

            //ThenByDescending: Use after earlier sorting, to further sort a collection in descending order.
            var result6 = date.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);
            Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dat in result6)
                Console.WriteLine(dat.ToString("yyyy/MM/dd"));
            Console.WriteLine();
        }
        private static void sample_aggregation()
        {
            //Aggregate: Performs a specified operation to each element in a collection, while carrying the result forward.
            int[] numbers = { 2, 4, 5, 6, 8, 7, 4, 9 };
            var result1 = numbers.Aggregate((a, b) => a + b);
            Console.WriteLine($"Aggregated numbers by addition : {result1}");

            //Average: Computes the average value for a numeric collections.
            var result2 = numbers.Average();
            Console.WriteLine($"Average of numbers is : {result2}");

            //Count: Returns the number of elements in a collection.
            var result3 = numbers.Count();
            Console.WriteLine($"Count of numbers is : {result3}");

            //Max: Finds the largest value in a collection.
            var result5 = numbers.Max();
            Console.WriteLine($"Maximum value is : {result5}");

            //Min: Finds the smallest value in a collection.
            var result6 = numbers.Min();
            Console.WriteLine($"Minimum value is : {result6}");

            //Sum: Calculates the total for a numeric collections.
            var result7 = numbers.Sum();
            Console.WriteLine($"Sum of the numbers is : {result7}");

            //LongCount: Returns the number of elements in collections larger than Int32.MaxValue.
            var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 3));
            Int64 result4 = largeArr.LongCount();
            Console.WriteLine($"Counting largeArr elements:  {result4}");
            Console.WriteLine();
        }
        private static void sample_elements()
        {
            //ElementAt: Retrieves element from a collection at specified (zero-based) index.
            string[] name = { "akshay", "shreedhar", "pramod", "surya", "hari", "goutham", "simran", "arshit" };
            var result1 = name.ElementAt(3);
            Console.WriteLine($"Element at index 3 is : {result1}");

            //ElementAtOrDefault: Retrieves element from a collection at specified (zero-based) index, but gets default value if out-of-range.
            var result2 = name.ElementAtOrDefault(2);
            Console.WriteLine($"Element at index 2 is : {result2}");
            //var result21 = name.ElementAtOrDefault(10);
            //Console.WriteLine($"Element at index 10 in the array does not exist:{ result21 == null }");

            //First: Retrieves first element from a collection. Throws exception if collection is empty.
            var result3 = name.First();
            Console.WriteLine($" First Element in the array is : {result3}");

            //First(Conditional): Retrieves first element from a collection. Throws exception if collection is empty.
            var result4 = name.First(n => n.Length == 7);
            Console.WriteLine($" First Element with length of 7 letters is : {result4}");

            //FirstOrDefault: Retrieves first element from a collection, or default value if collection is empty.
            string[] empty = { };
            var result5 = name.FirstOrDefault();
            Console.WriteLine($"First Element  is : {result5}");
            var result51 = empty.FirstOrDefault();
            Console.WriteLine($"First element in the empty array does not exist : {result51 == null}");

            //Last: Retrieves last element from a collection. Throws exception if collection is empty.
            var result6 = name.Last();
            Console.WriteLine($" Last Element in the array is : {result6}");

            //LastOrDefault: Retrieves last element from a collection, or default value if collection is empty.
            var result7 = name.LastOrDefault();
            var result71 = name.LastOrDefault(n => n.Length == 6);
            Console.WriteLine($"Last Element in the array is : {result7}  and Last element in the empty array having a length of 6 is : {result71} ");

            //Single: Retrieves only element in a collection. Throws exception if not exactly one element in collection.
            string[] names1 = { "Akshay" };
            string[] names2 = { "akshay", "shreedhar", "pramod" };
            
            var result8 = names1.Single();
            try
            {
                var result81=names2.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                var result82 = empty.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            //SingleOrDefault: Retrieves only element in a collection, or default value if collection is empty.
            var result9 = names1.SingleOrDefault();
            var result91 = empty.SingleOrDefault();
            Console.WriteLine($"The only name in the array is: {result9}");
            Console.WriteLine($"As array is empty, SingleOrDefault yields null: {result91 == null}");
            try
            {
                var result92 = names2.SingleOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }
        private static void sample_quantifiers()
        {
            //All: Checks if all elements in a collection satisfies a specified condition.
            string[] name = { "akshay", "shreedhar", "pramod", "surya", "hari", "goutham", "simran", "arshit" };
            var result10=name.All(n=> n.Length == 6);
            Console.WriteLine($"Does all the Names have 6 letters : {result10}");

            //Any: Checks if any elements in a collection satisifies a specified condition.
            var result11 = name.Any(n => n.StartsWith("s"));
            Console.WriteLine($"Does any of the Names begins with letter 'B' : {result11}");

            //Contains: Checks if any elements in a collection satisifies a specified value.
            var result12 = name.Contains("akshay");
            Console.WriteLine($"The list contains the name 'akshay' :{result12}");
            Console.WriteLine();
        }
        private static void sample_groupby()
        {
            List<string> words=new List<string> { "basket","blueberry","chimpanze","abacus","banana","apple","cheese"};
            var wordgroups = from u in words group u by u[0] into g select new {firstletter=g.Key,Words=g};
            foreach(var item in wordgroups)
            {
                Console.WriteLine("words that start with" + "letter '{0}':", item.firstletter);
                foreach (var w in item.Words)
                {
                    Console.WriteLine(w);
                }
            }
            var nooflettergroup =from u in words group u by u.Length into g select new {length=g.Key,words=g};
            foreach (var item in nooflettergroup)
            {
                Console.WriteLine("words that have" + "length '{0}' is:", item.length);
                foreach (var w in item.words)
                {
                    Console.WriteLine(w);
                }
            }

        }
        private static List<Department> GetListofDepartment()

        {
            List<Department> depts = new List<Department>();

            depts.Add(new Department("Trainer", "Karthika"));

            depts.Add(new Department("Finance", "Kavitha"));

            depts.Add(new Department("Technical", "Latha"));

            depts.Add(new Department("HR", "Madhavi"));

            return depts;

        }
        public static List<Employee> GetListofEmployees()

        {

            List<Employee> emps = new List<Employee>();

            emps.Add(new Employee(1, "John", "Trainer"));

            emps.Add(new Employee(2, "Mark", "Finance"));

            emps.Add(new Employee(3, "Peter", "Technical"));

            emps.Add(new Employee(4, "Bob", "Technical"));

            emps.Add(new Employee(5, "Robert", "Finance"));

            emps.Add(new Employee(6, "Jason", "Trainer"));
            return emps;

        }
        private static void SampleEmployeeList()
        {
            List<Employee> emp = GetListofEmployees();
            List<Department> depts = GetListofDepartment();
            var employeetavle = from e in emp
                                join d in depts on e.Dept equals d.Dept
                                select new
                                {
                                    Name = e.Name,
                                    Manager = d.Manager
                                };
            foreach (var item in employeetavle)
            { Console.WriteLine(item.Name + " manager is " + item.Manager); }

        }
        private static void SampleEmployeeList_lamda()
        {
            List<Employee> emp = GetListofEmployees();
            List<Department> depts = GetListofDepartment();
            var joined = emp.Join(depts, x => x.Dept,y=> y.Dept,
                (emp,depts) => new
                {
                Name = emp.Name,
                Manager = depts.Manager
                });
            foreach (var item in joined)
            { Console.WriteLine(item.Name + " manager is " + item.Manager); }

        }

        private static void noOfemployeeinDep_lamda()
        {
            List<Employee> emp = GetListofEmployees();
            List<Department> depts = GetListofDepartment();
            var employetable = emp.GroupBy(g=>g.Dept).Select(g => new {Department=g.Key,Name=g});
            foreach (var item in employetable)
            {
                int count = 0;
                Console.WriteLine(" eMPLOYEES in '{0}' department  is:", item.Department);
                foreach (var w in item.Name)
                {
                    count++;
                }

                Console.WriteLine(count);
            }
        }
        private static void noOfemployeeinDept()
        {
            List<Employee> emp = GetListofEmployees();
            int count;
            var employeegroup = from e in emp group e by e.Dept into g select new { Department = g.Key, Name = g };
            foreach (var item in employeegroup)
            {
                count = 0;
                Console.WriteLine(" eMPLOYEES in '{0}' department  is:", item.Department);
                foreach (var w in item.Name)
                {
                    count++;
                }

                Console.WriteLine(count);
            }

        }
    }

    }
