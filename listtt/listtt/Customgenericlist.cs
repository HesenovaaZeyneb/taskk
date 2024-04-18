using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listtt
{
    internal class Customgenericlist<T>
    {
        T[] array;

        public Customgenericlist()
        {
            array = Array.Empty<T>();
        }
        public void Add(T item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[^1] = item;

        }
        public T find(Predicate<T> match)
        {
            foreach (T item in array)
            {
                if (match(item)) { return item; }
            }

            return default(T);


        }
        public List<T> findall(Predicate<T> match)
            
        {
            Customgenericlist<T> resultList = new Customgenericlist<T>();       
            for(int i=0; i<array.Length; i++)
            {
                
                if (match(array[i]))
                {
                    resultList.Add(array[i]);
                }
            }
            return resultList;          
        }
        public T remove(Predicate<T> match)
        {
            T[] arrays = new T[0];
            int index = 0;
            foreach (T item in array)
            {
                if (!match(item))
                {
                    arrays[index] = item;
                    index++;
                }
            }
            array = arrays;
            return default(T);
        } 
        public List<T> removeall(Predicate<T> match)
        {

            Customgenericlist<T> resultList = new Customgenericlist<T>();
            T[] arrays = new T[0];
            int index = 0;
            foreach (T item in array)
            {
                if (match(item))

                {
                    arrays[index] = item;
                    index++;
                }

            }
            array = arrays;
            return resultList;
           
        }
    } 

}
