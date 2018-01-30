using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    // The built-in List<T> class is a generic class that acts as a wrapper over the array class. You cannot use built-in List or Array methods. 

    public class CustomList<T> /*: IEnumerable<T>*/ // I want to use a custom-built list class that stores its values in an array, so that I can store any data type in my collection.
    {
        // member variables 
        private int arrayCount = 0;
        private static int arrayCapacity = 5;
        public static int newArrayCapacity;
        private T[] arr = new T[arrayCapacity]; // declare an array to store the data elements

        public T this[int i] // define the indexer to allow client code to use [] notation (instantiate an instance in order to use notation - such as in Program class)
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public int Count // I want a Count property implemented on the custom-built list class, so that I can get a count of the number of elements in my custom list class instance. 
        {
            get
            {
                return arrayCount;
            }
        }

        // constructor
        public CustomList()
        {
            
        }

        // member methods

        //public void InitializeArray()
        //{

        //}


        //public IEnumerator<T> GetEnumerator()
        //{
        //    for (int index = 0; index < arrayCapacity; index++)
        //    {
        //        yield return;
        //    }
        //}


        public T[] Add(T argument) // I want the ability to add an object to an instance of my custom-built list class. 
        {
            int newArrayCount = arrayCount + 1;
            if (newArrayCount >= (arrayCapacity / 2))
            {
                int newArrayCapacity = arrayCapacity * 2;
                T[] newArray = new T[newArrayCapacity];
                for (int i = 0; i <= arrayCount; i++)
                {
                    newArray[i] = arr[i];
                }
                newArray[newArrayCount - 1] = argument;
                for (int i = newArrayCount - 1; i <= newArrayCapacity - 1; i++)
                {
                    newArray[i] = default(T);
                }
                arr = newArray;
            }
            else
            {
                arr[newArrayCount - 1] = argument; 
            }
            return arr;
        }

        //public void SwapFunction<T>(ref T item1, ref T item2)
        //{
        //    T obj;
        //    obj = item1;
        //    item1 = item2;
        //    item2 = obj;
        //}


        public T[] Remove(T argument) // I want the ability to remove an object from an instance of my custom-built list class. IComparable?
        {
            // search array for values that match argument
            // delete all matches


            return arr;
        }

        public void Iterate() // I want the custom list class to be iterable. RETURN TYPE? Custom iteration functions cover this?
        {

        }

        public string OverrideToString() // I want to be able to override the ToString method that converts the contents of the custom list to a string.
        {
            // for each item in the list/array, iterate each character (custom iteration)
            string overrideToString = default(string);
            return overrideToString;
        }

        public void OverloadPlusOperator() // I want to be able to overload the + operator, so that I can add two instances of the custom list class together.
        {

        }

        public void OverloadMinusOperator() // I want to be able to overload the – operator, so that I can subtract one instance of a custom list class from another instance of a custom list class.
        {

        }

        public T[] Zip() // I want the ability to zip two custom list class instances together in the form of a zipper.
                         //     For example:
                         //  	I have List<int> odd = new List<int>() {1,3,5}; and List<int> even = new List<int>() {2,4,6}; 
                         //  	When lists odd and even are zipped together, your new list will contain values 1,2,3,4,5,6

                        // like slide 4 in the Custom Iterators slideshow
        {
            return arr;
        }



    }
}
