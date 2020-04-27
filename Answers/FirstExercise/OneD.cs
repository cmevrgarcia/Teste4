using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Testes.CSharp.Teste2.ThirdGroup.Answers.FirstExercise
{
    public static class OneD
    {
        /// <summary>
        /// Extention Method that asks for date. Returns next work day
        /// </summary>
        /// <param name="today"></param>
        /// <returns></returns>
        public static DateTime NextWorkDay(this DateTime date)
        {
            DateTime NextUsefullDay = date;
            if (date == DateTime.DayOfWeek.Friday)
            {
                NextUsefullDay.AddDays(3);
            }
            else if (date == DateTime.DayOfWeek.Saturday)
            {
                NextUsefullDay.AddDays(2);
            }
            else
            {
                NextUsefullDay.AddDays(1);
            }
            return NextUsefullDay;
        }
    }
}
