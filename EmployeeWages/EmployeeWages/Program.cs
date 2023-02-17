namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //variables
            int emp_hrs = 0;
            int emp_wage = 0;
            Random random = new Random();
            int empCheck = random.Next(0,3);
            if (empCheck == IS_PART_TIME)
            {
                emp_hrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                emp_hrs = 8;
            }
            else 
            {
                emp_hrs = 0;
            }
            emp_wage = emp_hrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage Is :" + emp_wage);

        }
    }
}