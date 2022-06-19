using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesAndValueTypesExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //value type is stored on stack, so valueA will be 10 even after it is
            //copied and assigned to valueB and incremented 
            var valueA = 10;
            var valueB = valueA;
            valueB++;
            Console.WriteLine("{0}, {1}",valueA, valueB);

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;

            array2[0] = 0; //First element of array1 will be 0, because reference types
                           //are stored in heap.
                           //
                           //1. object  is created and initialized in heap with only one
                           //hex address
                           //2. CLR (runtime) creates a varriable on a stack identified
                           //as array1
                           //3. The value in that memory location is a memory address
                           // - the same address of the object (actual array) in the heap
                           //4. array1 points the references to object on the heap
                           //5. When we copy the array1 to array2 the runtime creates another
                           //variable on the stack identified as array2 and inside that
                           //variable there's a memory address that is the same as the
                           //address on the object in the heap
                           //

            Console.WriteLine("{0} {1}", array1[0], array2[0]);
        }
    }
}