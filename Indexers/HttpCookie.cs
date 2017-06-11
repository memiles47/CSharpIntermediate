using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        //This can be initialized in a contstructor as well - either way
        private readonly Dictionary<string, string> _dictionary;
        //private Dictionary<string, string> _dictionary = new Dictionary<string, string>();


        public HttpCookie()
        {
            //I will leave the initialization above
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            //Expression body can be used here
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}