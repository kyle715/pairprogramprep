using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        { 


        }
        
    }
    public class transaction
    {
        public double amount { get; set; }

        public string name { get; set; }

        public DateTime date { get; set; }
    }

    public class bankAccount
    {
        TransactionQueue Transactions;

        public double Balance { get; set; }

        public string Id { get; set;}
    }
    public class TransactionQueue
    {

        public void request(string r)
        {
            Deque();
        }
        public void request(transaction tranny)
        {
            enque(tranny);
        }
        List<transaction> trans;
        private void enque(transaction newItem)
        {
            trans.Add(newItem);
        }
        private void Deque()
        {
            trans.RemoveAt(0);
        }

    }
}
