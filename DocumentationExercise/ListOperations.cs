using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationExercise
{
    public static class ListOperations
    {
        public static void Print<T>(List<T> list)
        {
            if (list.Count == 0) return;
            for(int i = 0; i < list.Count - 1; i++)
            {
                Console.Write(list[i]);
                Console.Write(", ");
            }
            Console.WriteLine(list[list.Count - 1]);
        }

        public static double Average<T>(List<T> list)
        {
            if (list.Count == 0) throw new DivideByZeroException();
            double sum = 0;
            for (int i = 0; i < list.Count; i++) 
            {                
                sum += (dynamic)list[i];
            }
            return sum / list.Count;
        }

        public static void DoThingOne<T>(List<T> list)
        {
            for(int i = 0; i < list.Count/2; i++)
            {
                T tmp = list[i];
                list[i] = list[list.Count - 1 - i];
                list[list.Count - 1 - i] = tmp;
            }
        }

        public static void DoThingTwo<T>(List<T> list)
        {
            if (list.Count == 0) return;
            T tmp = list[0];
            for(int i = 1; i < list.Count; i++)
            {
                list[i - 1] = list[i];
            }
            list[list.Count - 1] = tmp;
        }

        public static void DoThingThree<T>(List<T> list)
        {
            Random random = new Random();
            for(int i = 0; i < list.Count; i++)
            {
                T tmp = list[i];
                var j = i;
                while(i == j) j = random.Next(list.Count);
                list[i] = list[j];
                list[j] = tmp;
            }
        }
    }
}
