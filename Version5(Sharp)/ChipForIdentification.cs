using System;

namespace Version5
{
 /*!
\brief Клас відповідає за роботу з чипом
\author Ishchenko Vladyslav
\version 5
\date 15 грудня 2017
*/
    public class ChipForIdentification
    {
        /// <summary>
        /// Конструктор за змовчуванням
        /// </summary>
        public ChipForIdentification()
        {
            firstname = "Unknown";
            surname = "Unknown";
            birthday = 0;
            qrcod = 0;
        }

        /// <summary>
        /// Конструктор ініціалізації
        /// </summary>
        /// <param name="firstname">Ім*я користувача чипу</param>
        /// <param name="surname">Прізвище користувача чипу</param>
        /// <param name="birthday">Дата народження користувача чипу</param>
        /// <param name="qrcod">Індивідуальний код чипу</param>
        public ChipForIdentification(string firstname,string surname,int birthday, int qrcod)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.birthday = birthday;
            this.qrcod = qrcod;
        }
        
        /// <summary>
        /// Метод для визначення константного значення терміну дії чипу
        /// </summary>
        /// <returns>Терміну дії чипу</returns>
        public int ReturnTermChip()
        {
            return term;
        }

        /// <summary>
        /// Акссесор для індивідуального коду чипу
        /// </summary>
        public int QRcod
        {
            get { return qrcod; }
            set { qrcod = value; }
        }

        /// <summary>
        /// Акссесор для року народження
        /// </summary>
        public int Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        /// <summary>
        /// Акссесор для імені користувача на чипові
        /// </summary>
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        /// <summary>
        /// Акссесор для прізвища користувача на чипові
        /// </summary>
        public string SurName
        {
            get { return surname; }
            set { surname = value; }
        }

        private string firstname;///< Ім*я користувач
        private string surname;///<Прізвище користувача
        private int birthday;///<Дата народження 
        private const int term = 100;///<Термін дії чипу(константний атрибут)
        private int qrcod;///<Унікальний код чипу

    }
}