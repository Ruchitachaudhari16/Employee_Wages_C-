namespace EmployeeWages
{
    internal class Program
    {
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 2;
        const int MAX_HR_IN_MONTH = 10;
        static void Main(string[] args)
        {

            //variables
            int emp_hrs = 0;
            int total_emp_hrs = 0;
            int totalworkingdays = 0;
            while (total_emp_hrs <= MAX_HR_IN_MONTH && totalworkingdays < NUM_OF_WORKING_DAYS)
            {
                totalworkingdays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
                total_emp_hrs += emp_hrs;
                Console.WriteLine("Day#:" + totalworkingdays + "Emp Hrs: " + emp_hrs);
            }
                
            int total_emp_Wage = total_emp_hrs * EMP_RATE_PER_HOUR;

                Console.WriteLine(" Total Employee Wage Is :" +total_emp_Wage);

            }
        }
    }
