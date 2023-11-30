namespace Customer
{
    class Customer
    {
        public string Name { get; set; }
        public double Balance { get; private set; }
        private TarifficationType Tariff;
            

        public Customer(string name, double balance = 100, TarifficationType tariff = 0)
        {
            Name = name;
            Balance = balance;
            Tariff = tariff;
        }

        public string TariffStr()
        {
            int a = ((int)Tariff);

            return a switch
                {
                    0 => "Повременный",
                    1 => "После10МинутВ2РазаДешевле",
                    2 => "ПлатиМеньшеДо5Минут"
                };
        }

        public override string ToString()
        {
            return string.Format("Клиент: {0} находится на тарифном плане \"{2}\" имеет баланс: {1}", Name, Balance, TariffStr());
        }

        public void ChangeTariff()
        {
            Console.WriteLine("Выбирите тариф, на который хотите перейти: \n"+
                "0\t–\tПовременный: «городской» (5 руб./мин.) и «мобильный» (1 руб./мин.);\r\n" +
                "1\t–\tПосле10МинутВ2РазаДешевле: после 10 минут звонка на городской номер каждая вторая минута бесплатно; в остальном как Повременный;\r\n" +
                "2\t–\tПлатиМеньшеДо5Минут: до 5 минут разговора в 2 раза дешевле тарифа Повременный, после - в 2 раза дороже.\r\n"
                );
            int n = int.Parse(Console.ReadLine());
            if (n < 0 || n > 2)
            {
                Console.WriteLine("Введено неверное значение\n");
                ChangeTariff();
            }
            else
            {
                Tariff = (TarifficationType)n; 
            } 
        }

        public void RecordPayment(double amountPaid)
        {
            if (amountPaid > 0)
                Balance += amountPaid;
        }

        public void RecordCall(char callType, int minutes)
        {
            if (callType == 'Г')
            {
                double payment = Tariffication.Payment((CallType)5, minutes, Tariff);
                Balance -= payment;
                //Balance -= minutes * 5;
            }

            else if (callType == 'М')
            {
                double payment = Tariffication.Payment((CallType)1, minutes, Tariff);
                Balance -= payment;
                //Balance -= minutes * 1;
            }
        }
    }

    class Customer1
    {
        static void Main(string[] args)
        {
            Customer Ivan = new Customer("Иван Петров", 500);
            Customer Elena = new Customer("Елена Иванова");
            Ivan.RecordCall('Г', 12);
            Elena.RecordCall('М', 25);

            Console.WriteLine(Ivan);
            Console.WriteLine(Elena);


        }
    }
}
