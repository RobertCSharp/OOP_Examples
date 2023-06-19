using System.Security.AccessControl;

namespace Curs70
{
    public class Elev
    { 
        private string firstName;
        private string lastName;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public Elev(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public override string ToString()
        {
            return $"firstName: {firstName} lastName: {lastName} age: {age}";
        }
    }
}