using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version5
{
    /*!
\brief Клас відповідає за обробку виключень пов'язаних з вагою користувача
\author Ishchenko Vladyslav
\version 5
\date 15 грудня 2017
*/
    class WeightException:Exception
    {
        /// <summary>
        /// Конструктор ініціалізації
        /// </summary>
        /// <param name="message">Повідомлення про помилку</param>
        public WeightException(string message):
            base(message)
        {

        }
    }
}
