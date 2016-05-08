using System;
using System.Collections;

namespace StackExercise
{
    class Stack
    {
        public ArrayList List { get; set; }
        public object PoppedObj { get; set; }

        public Stack()
        {
            List = new ArrayList();
        }

        public void Push(object obj)
        {
            try
            {
                if (obj == null)
                    throw new InvalidOperationException();
                List.Add(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception Detected: {e.Message}");
                Console.ReadKey();
            }
        }

        public object Pop()
        {
            try
            {
                if (List.Count == 0)
                    throw new InvalidOperationException();

                PoppedObj = List[List.Count - 1];
                List.RemoveAt(List.Count - 1);
                return PoppedObj; 
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public void Clear()
        {
            List.Clear();
        }
    }
}