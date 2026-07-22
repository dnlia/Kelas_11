using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_1
{
    internal class Zodiak
    {
            public string CekZodiak(int tgl, int bln)
            {
                if ((bln == 1 && tgl >= 20) || (bln == 2 && tgl <= 18))
                    return "Aquarius";
                else if ((bln == 2 && tgl >= 19) || (bln == 3 && tgl <= 20))
                    return "Pisces";
                else if ((bln == 3 && tgl >= 21) || (bln == 4 && tgl <= 19))
                    return "Aries";
                else if ((bln == 4 && tgl >= 20) || (bln == 5 && tgl <= 20))
                    return "Taurus";
                else if ((bln == 5 && tgl >= 21) || (bln == 6 && tgl <= 20))
                    return "Gemini";
                else if ((bln == 6 && tgl >= 21) || (bln == 7 && tgl <= 22))
                    return "Cancer";
                else if ((bln == 7 && tgl >= 23) || (bln == 8 && tgl <= 22))
                    return "Leo";
                else if ((bln == 8 && tgl >= 23) || (bln == 9 && tgl <= 22))
                    return "Virgo";
                else if ((bln == 9 && tgl >= 23) || (bln == 10 && tgl <= 22))
                    return "Libra";
                else if ((bln == 10 && tgl >= 23) || (bln == 11 && tgl <= 21))
                    return "Scorpio";
                else if ((bln == 11 && tgl >= 22) || (bln == 12 && tgl <= 21))
                    return "Sagitarius";
                else
                    return "Capricorn";
            }
      
    }

}
