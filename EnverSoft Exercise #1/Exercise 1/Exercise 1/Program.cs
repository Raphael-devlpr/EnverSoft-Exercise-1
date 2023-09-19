using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // two arrays/lists as follows
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };         
            int[] list2 = new int[] { 3, 4, 5, 6, 7 }; 

            //a. Show the common elements in both lists.  E.g the common elements are "3 4 5", because they are contained in both lists. 

            //LINQ Intersect(), method to iterate over array
            int[] list3 = list1.Intersect(list2).ToArray();{//built in ToArray() method to convert results to an array

            foreach (var item in list3)
            {
                    Console.WriteLine(item);
                }   //Print Output







                //b. Show the elements from list 1, but is not found in list2.  E.g 1 2" 

                List<int> list = new List<int>();
                //create empty list –to store variables

                foreach (int num in list1)
            {

                //Array.Exists() – to determine whether the array elements match my conditions.
                if (!Array.Exists(list2, element => element == num)) //expression bodied function
                {
                    list.Add(num);
                }
            }
                //new int ‘result’ array  to store the list and convert
                int[] ints = list.ToArray();
                //converts list to array using ToArray() method  
                Console.WriteLine(string.Join(", ", ints));
        } //print result 





        //Show the elements from list 2, but is not found in list1.  E.g 6 7"

        //c. Complete here 

        List<int> list4 = new List<int>(); //create empty list –to  store variables

                foreach (int num in list2)
                {

//Array.Exists() – to determine whether the array elements match my conditions.
                    if (!Array.Exists(list1, element => element == num)) //expression bodied function
                    {
                        list4.Add(num);
                    }
}
//new int ‘result’ array  to store the list and convert
int[] result = list4.ToArray(); //converts list to array using ToArray() method  
Console.WriteLine(string.Join(", ", result)); //print result


Console.WriteLine("Press <ENTER> to continue");



