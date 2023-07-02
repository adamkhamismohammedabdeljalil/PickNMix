using System.Collections;

namespace PickNMix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stuffs=new ArrayList();
            stuffs.Add(1);
            stuffs.Add("car");
            stuffs.Add(true);
            stuffs.Add(23d);

            foreach(var stuff in stuffs)
            {
                Console.WriteLine(stuff);
            }
        }
    }
}