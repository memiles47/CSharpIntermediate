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
            List.Add(obj);
        }

        public object Pop()
        {
            PoppedObj = List[List.Count - 1];
            List.RemoveAt(List.Count - 1);
            return PoppedObj;
        }

        public void Clear()
        {
            List.Clear();
        }
    }
}