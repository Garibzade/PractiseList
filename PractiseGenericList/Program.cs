using PractiseGenericList.Models;
using System.Collections;

namespace PractiseGenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList(typeof(Int32));
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add("salam");

            GenericList<int> IntArr = new GenericList<int>();
            IntArr.Add(12);

        }
    }
}
