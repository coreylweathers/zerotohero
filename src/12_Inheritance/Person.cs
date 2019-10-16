using System;

namespace _12_Inheritance
{
    public class Person 
    {
    	protected string _firstName;
        protected string _lastName;
        protected int _id;
        
        public Person(){}
        public Person(string firstName, string lastName, int identification){
                _firstName = firstName;
                _lastName = lastName;
                _id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + _lastName + ", " + _firstName + "\nID: " + _id); 
        }
    }
}