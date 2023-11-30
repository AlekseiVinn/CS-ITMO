using System.ComponentModel.DataAnnotations;

enum CallType
{ 
    City = 5,
    Mobile = 1
}


enum TarifficationType
{
    Regular, //	Повременный: «городской» (5 руб./мин.) и «мобильный» (1 руб./мин.)
    HalveAfter10Min, // После10МинутВ2РазаДешевле: после 10 минут звонка на городской номер каждая вторая минута бесплатно; в остальном как Повременный;
    PayLessFor5Min // ПлатиМеньшеДо5Минут: до 5 минут разговора в 2 раза дешевле тарифа Повременный, после - в 2 раза дороже 
}

class Tariffication
{
    public static double Payment(CallType call, int time, TarifficationType tariff = TarifficationType.Regular)
    {
        if (tariff == TarifficationType.Regular || (tariff == TarifficationType.HalveAfter10Min && time <= 10))
        {
            return (double)call * time;
        }
        else if (tariff == TarifficationType.HalveAfter10Min && time > 10)
        {
            double result = (double)call * 10;
            for (int i = 1; i <= (time - 10); i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                result += ((double)call * i);
            }
            return result;
        }
        else
        {
            if (time <= 5)
            {
                double result = (double)call * time / 2;
                return result;
            }
            else 
            {
                double result = (double)call * 5 / 2;
                for (int i = 1; i <= (time - 5); i++)
                {
                    result += ((double)call * 2 * i);
                }
                return result;
            }
        }
    }

}
