using System;

namespace Version5
{
    /*!
\brief Клас описує користувача системи
\author Ishchenko Vladyslav
\version 5
\date 15 грудня 2017
*/
    public class User
    {
        /// <summary>
        /// Статичний конструктор
        /// </summary>
        static User()
        {
 
        }

        /// <summary>
        /// Конструктор ініціалізації
        /// </summary>
        /// <param name="firstname">Ім*я користувача</param>
        /// <param name="surname">Прізвище користувача</param>
        public User(string _firstname, string _surname)
        {
            chipForIdentification = new ChipForIdentification();
            firstname = _firstname;
            surname = _surname;
       }

        /// <summary>
        /// Конструктор копії
        /// </summary>
        /// <param name="user">Об*єкт копіювання</param>
        public User(User user)
        {
            chipForIdentification = user.chipForIdentification;
            firstname = user.firstname;
            surname = user.surname;
        }

        /// <summary>
        /// Метод відповідає за проходження обстеження користувачем
        /// </summary>
        public void Survey()
        {
            Console.WriteLine("You undergo a medical examination");
        }

        /// <summary>
        /// Метод відповідає за відвідування лікаря користувачем
        /// </summary>
        public void VisitDoctor()
        {
            Console.WriteLine("You undergo medical examination in the treatment doctor");
        }

        /// <summary>
        /// Акссесор імені користувача
        /// </summary>
        public string Firstname
        {
            get{ return firstname; }
            set { firstname = value; }
        }

        /// <summary>
        /// Акссесор прізвища користувача
        /// </summary>
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public Doctor doctor;///<Об*єкт класу Doctor
        public ChipForIdentification chipForIdentification;///<Об*єкт класу ChipForIdentification
        public SystemE_Health systemE_Health;///<Об*єкт класу SystemE_Health

        private string firstname;///<Ім*я користувача
        private string surname;///<Прізвище користувача

    }
}