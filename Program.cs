using System;
using System.Text.RegularExpressions;

namespace lab2_3ValidatingInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;   //decaring my variables
            string email;
            string phone;
            string date;
            bool valid;

            //=================================================================name
            do  //loop through name until we get correct name
            {


                Console.Write("Please enter a valid Name: ");  //ask for name

                name = Console.ReadLine();

                Regex tester = new Regex(@"^[A-Z][a-zA-Z\s]{0,29}$"); //setting pattern

                //Console.WriteLine(tester.IsMatch(name));

                valid = tester.IsMatch(name);

                if (valid == false)  //statement for invalid names
                {
                    Console.WriteLine("Sorry, name is not valid!\n");
                }

            } while (valid == false);

            Console.WriteLine("Name is valid!\n"); //statement for valid name

            //=================================================================== email

            do //loop through email until we get a valid email
            {


                Console.Write("Please enter a valid email: "); //ask for email

                email = Console.ReadLine();

                Regex tester = new Regex(@"^\w{5,30}@\w{5,10}\.\w{2,3}$"); //setting pattern


                valid = tester.IsMatch(email);

                if (valid == false)  //statement for invalid names
                {
                    Console.WriteLine("Sorry, email is not valid!\n");
                }

            } while (valid == false);

            Console.WriteLine("Email is valid!\n"); //statement for valid email

            //==================================================================== phone

            
           
            do //loop through email until we get a valid phone
            {

                Console.Write("Please enter a valid phone number: "); //ask for phone

                phone = Console.ReadLine();

                Regex tester = new Regex(@"^\({0,1}\d\d\d\){0,1}(-{0,1}|\.{0,1}|\\{0,1}|\/{0,1})\d\d\d(-{0,1}|\.{0,1}|\\{0,1}|\/{0,1})\d\d\d\d$"); //setting pattern


                valid = tester.IsMatch(phone);

                //if(valid == false) //these aren't needed now with the extra code above
                //{
                //    tester = new Regex(@"^\({0,1}\d\d\d\){0,1}\.{0,1}\d\d\d\.\d\d\d\d$"); //setting pattern

                //    valid = tester.IsMatch(phone);
                //}

                //if (valid == false)
                //{
                //    tester = new Regex(@"^\d\d\d\d\d\d\d$"); //setting pattern

                //    valid = tester.IsMatch(phone);
                //}

                if (valid == false)  //statement for invalid names
                {
                    Console.WriteLine("Sorry, phone is not valid!\n");
                }

            } while (valid == false);

            Console.WriteLine("Phone is valid!\n"); //statement for valid email

            //======================================================================== date
                      

            do //loop through email until we get a valid phone
            {

                Console.Write("Please enter a valid date: "); //ask for date

                date = Console.ReadLine();

                //Regex tester = new Regex(@"^[0-3]{0,1}[0-9]-{0,1}\.{0,1}\\{0,1}\/{0,1}[0-1]{0,1}[0-9]-{0,1}\.{0,1}\\{0,1}\/{0,1}\d\d\d\d$"); //setting pattern
                Regex tester = new Regex(@"^(3[01]|[12][0-9]|0{0,1}[1-9])(-{0,1}|\.{0,1}|\\{0,1}|\/{0,1})(1[0-2]|0{0,1}[1-9])(-{0,1}|\.{0,1}|\\{0,1}|\/{0,1})[0-9]{4}$"); //setting pattern


                valid = tester.IsMatch(date);

                if (valid == false)  //statement for invalid names
                {
                    Console.WriteLine("Sorry, date is not valid!\n");
                }

            } while (valid == false);

            Console.WriteLine("Date is valid!\n"); //statement for valid email


        }
    }
}
