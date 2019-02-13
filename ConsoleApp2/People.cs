using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class People : Human
    {

    
        
        public People(): base("")
        {
            Console.WriteLine("1");

        }
        public People(int account) : this(account, "")
        {
            this.account = account;
            Console.WriteLine("2");
        }
        public People(int account, string IIN)
        {
            this.account = account;
            this.IIN = IIN;
            Console.WriteLine("3");
        }
        const string docNumber = "412512";
        readonly string passNumber = ""; //можно изменить только в конструкторе
        private string IIN_;
        public string IIN
        {
            get {
                return IIN_;
            }
            set {
                if (value.Length < 12) { throw new Exception("Длина ИИН мала"); }
                IIN_ = value;
            }

        }
        public int Index { get; set; }
        public int account { get; set; }
        public int Age { get; private set; }
        private DateTime DOB_;
        public DateTime DOB
        {
            get
            {
                return DOB_;
            }
            set
            {
                Age = DateTime.Now.Year - value.Year;
                DOB_ = value;
            }
        }

        public People()
        {
            passNumber = "2512";
        }
        void Test()
        {
            race = "";
        }


        public void Test2(ref int balance) // ref - ссылка
        {
            balance = balance * 2;
        }
        public static int getAge() //доступен без вызова конструктора
        {
            return 20;
        }

        //ref и out


    }
}
