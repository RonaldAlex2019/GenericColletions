using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTest
{
    public class Stack <T>
    {
        private int top; //location of top element 
        private T[] elements; // array that stores stack elements 

        // parameterless constructor create a stact of the defaul size 
        public Stack() : this(10) // defaul stack size 
        {
            // empaty construtor; calls constructor at line 20 to perform init 
        }

        //construtor create a stack of specifed number of elements 

        public Stack(int stackSize)
        {
            if (stackSize <= 0 ) // validate StackSize
            {
                throw new ArgumentException("Stack size must be positive.");

            }

            elements = new T[stackSize];
            top = -1; 
        }

        //push elements onto the stack ; if unsuccesful,
        // throw fullStackExeption


        public void Push (T pushValue)
        {
            if (top == elements.Length - 1) // stack is full 
            {
                throw new FullStackException($"Stack is full, cannot push {pushValue}");
            }

            ++top; // increment top
            elements[top] = pushValue; // place pushValue on stack 
        }

        // return the top element if not empty 
        //else throw 

        public T Pop()
        {
            if(top == -1)  // stack is empty
            {
                throw new EmptyStackExeption("Stack is empty , cannot pop");
            }

            --top; // decrement top
            return elements[top + 1 ]; // return top value 
        }
    }
}
