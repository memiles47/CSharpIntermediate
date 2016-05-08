using System.Collections;

namespace StackExercise
{
    class Stack
    {
        public ArrayList List { get; set; }

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
            //Pop object from the stack
            return new object();
        }

        public void Clear()
        {
            //Clear the stack
        }
    }
}