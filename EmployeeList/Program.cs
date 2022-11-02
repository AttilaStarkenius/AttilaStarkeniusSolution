namespace EmployeeList
{
    internal class Program
    {
        static PayRoll payRoll = new PayRoll();

        static void Main(string[] args)
        {


            //payRoll.AddEmployee("Kalle", 35);

            SeedData();

            do
            {
                ShowMainMeny();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        break;

                        case "2":   PrintEmployees();
                        break;

                    case "Q": Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (true);   
            
        }

        private static void PrintEmployees()
        {
            List<Employee> employees = payRoll.GetEmployees();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }

        private static void ShowMainMeny()
        {
            Console.WriteLine("1. add employee");
            Console.WriteLine("2. print employee");
            Console.WriteLine("3. quit");
        }

        private static void SeedData()
        {
            payRoll.AddEmployee("Anna", 36000);
            payRoll.AddEmployee("Begnt", 30000);
        }

        //private static void TestM()
        //{
        //    string payRoll = "Hej";
        //}
    }
}