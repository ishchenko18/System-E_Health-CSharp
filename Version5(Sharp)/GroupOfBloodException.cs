using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version5
{
    /*!
\brief Клас відповідає за обробку виключень пов'язаних з групою крові користувача
\author Ishchenko Vladyslav
\version 5
\date 15 грудня 2017
*/
    class GroupOfBloodException:Exception
    {
        /// <summary>
        /// Конструктор ініціалізації
        /// </summary>
        /// <param name="message">Повідомлення про помилку</param>
        public GroupOfBloodException(string message):
            base(message)
        {
            
        }
    }
}
