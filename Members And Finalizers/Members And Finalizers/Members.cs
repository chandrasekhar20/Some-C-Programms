using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members_And_Finalizers
{
    class Members
    {
        //Private members....
        private string memberName;
        private string jobTitle;
        private int salary;

        //Public members....
        public int age;

        //Member - Property -> Exposes jobtitle safely ->Property start with a capital letter....
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }
        //Public method->Can be called from other classes....
        public void Introducing(bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hii my name is {0} , and my job title is {1}. Iam {2} years old" , memberName , jobTitle , age);
            }
        }
        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is :"+salary);
        }
        //Member Constructor....
        public Members()
        {
            age = 20;
            memberName = "Chandu";
            salary = 50000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }
        //Member -> finalizer -> destructor....
        ~Members()
        {
            //Cleanup statements....
            Console.WriteLine("Deconstruction of members objects");
            Debug.Write("Destruction of members object");
        }
    }
}
