using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Солнце_Иван_1992с_Вариант_21
{
    class Imet
    {
        public static string GetScore(int K)
        {
            string Result = string.Empty;
            switch (K)
            {
                case 1:
                    Result = "Плохо";
                    break;
                case 2:
                    Result = "Неудовлетворительно";
                    break;
                case 3:
                    Result = "Удовлетворительно";
                    break;
                case 4:
                    Result = "Хорошо";
                    break;
                case 5:
                    Result = "Отлично";
                    break;
                default:
                    Result = "Ошибка";
                    break;
            }
            return Result;
        }
    }
}
