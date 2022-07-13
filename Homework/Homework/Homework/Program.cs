using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();

            myList.Add("name1");

            myList.Clear("name2");

            myList.Find("name3");

            myList.GetAllData();

           

        }

       
    }

    
}
