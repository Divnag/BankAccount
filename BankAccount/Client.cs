using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Client
    {
        //fields
        private string clientName = "DIVYA";
       
        private string address = "Cleveland ohio";

        //properties

        public string ClientName
        {
            get { return this.clientName; }
        }

        

        public string Address
        {
            get { return this.address; }
        }



        //constructors

        public Client()
        {

        }


        public Client(String clientName,  string address)
        {
            this.clientName = clientName;
            
            this.address = address;

        }


        public  void ClientInfo()
        {
           
                Console.WriteLine("User Information");
                Console.WriteLine("Name:" + clientName+"\nAddress:"+address);


            
        }
    }
}

