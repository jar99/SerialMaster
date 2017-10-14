using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialMaster
{
    public class DataStore<T>
    {
        private object _lock = new object();
        private List<T> _data = new List<T>();
        public void Add(T data)
        {
            lock (_lock)
            {
                _data.Add(data);
            }
        }

        public T[] TakeWork()
        {
            T[] result;
            lock (_lock)
            {
                result = _data.ToArray();
                _data.Clear();
            }
            return result;
        }
    }
}
