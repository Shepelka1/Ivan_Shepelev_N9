using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace ServiceLayer
{
    public class MainDbManager <T,K>
    {
        IDb<T, K> context;

        public MainDbManager(IDb<T, K> context)
        {
            this.context = context;
        }

        public void Create(T item)
        {
            try
            {
                context.Create(item);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public T Read(K key)
        {
            try
            {
                return context.Read(key);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<T> ReadAll()
        {
            try
            {
                return context.ReadAll();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Update(T item)
        {
            try
            {
                context.Update(item);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Delete(K key)
        {
            try
            {
                context.Delete(key);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
