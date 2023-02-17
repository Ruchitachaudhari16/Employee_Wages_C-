namespace EmployeeWages
{
    internal class Program
    {
       const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
         const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 2;
        static void Main(string[] args)
        {
           
            //variables
            int emp_hrs = 0;
            int emp_wage = 0;
            int total_emp_Wage = 0;
            Random random = new Random();
            int empCheck = random.Next(0,3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    emp_hrs = 4;
                    break;
                case IS_FULL_TIME:
                    emp_hrs = 8;
                    break;
                default:
                    emp_hrs = 0;
                    break;
            
        }
            emp_wage = emp_hrs * EMP_RATE_PER_HOUR;
            total_emp_Wage =+emp_wage;   
            
           Console.WriteLine("Employee Wage Is :" + emp_wage);

        }
    }
}