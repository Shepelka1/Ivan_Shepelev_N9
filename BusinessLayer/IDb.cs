using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IDb<T, K>
    {
        void Create(T item);
        void Update(T item);
        T Read(K key);
        List<T> ReadAll();
        void Delete(K key);
    }
}
