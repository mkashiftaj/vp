using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace vpAssignmentkashif
{
    class Program
    {
        static void Main(string[] args)
        {
           // getbday();
            ArrayList sibAges = new ArrayList();
            int siblings=0;
            Console.WriteLine("Enter number of siblings ");
            siblings =int.Parse( Console.ReadLine());
            DateTime [] storingBirthdays=new DateTime[siblings];
            DateTime db;

            for (int i = 0; i < siblings; i++)
            {
                Console.WriteLine("Enter Date Of Birth of sibling "+i);
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                db = Convert.ToDateTime(Console.ReadLine());
                storingBirthdays[i]=db;
                sibAges.Add(db);
            }

            int  currentdate = DateTime.Now.Year;
            for (int i = 0; i < siblings; i++)
			{
			  TimeSpan difference = DateTime.Now - storingBirthdays[i];
              int Totaldays = difference.Days;
              Console.WriteLine ("Total days : " + Totaldays);
              int years = Totaldays / 365;
              
              int remainingdays = Totaldays % 365;
              int extraDays = remainingdays;
              int months = remainingdays / 30;
              
              int days = extraDays % 30;
              Console.WriteLine(" Sibling "+(i+1)+" : Years" + years + ", Months " + months + "and Days" + days);
             
			}
            calAgeDiff(sibAges);
            Console.ReadLine();
        }
        

        public static void calAgeDiff(ArrayList obj)
        {
            obj.Sort();

            for (int i = 0; i < obj.Count; i++)
            {
                if (i+1 < obj.Count)
                {
                    DateTime previous = DateTime.Parse(obj[i].ToString());
                    DateTime next = DateTime.Parse(obj[i+1].ToString());

                      TimeSpan difference = next - previous;
                      int Totaldays = difference.Days;
                      Console.WriteLine ("Total days : " + Totaldays);
                      int years = Totaldays / 365;
              
                      int remainingdays = Totaldays % 365;
                      int extraDays = remainingdays;
                      int months = remainingdays / 30;
              
                      int days = extraDays % 30;
                      Console.WriteLine(" Differenc of Ages between siblings "+i +" & " + i+1 +"is  : Years" + years + ", Months " + months + "and Days" + days);
                }
            }


        }

    }
    
}