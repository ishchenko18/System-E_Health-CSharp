using System;

namespace Version5
{
    /*!
\brief Клас відповідає за зняття основних внутрішніх аналізів
\author Ishchenko Vladyslav
\version 5
\date 15 грудня 2017
*/
    public class SmartToilet
    {
        /// <summary>
        /// Конструктор за змовчуванням
        /// </summary>
        public SmartToilet()
        {
            urinalysis = 0;
            caplogramme = 0;
        }

        /// <summary>
        /// Конструктор ініціалізації
        /// </summary>
        /// <param name="urinalysis">Результат загального аналізу сечі</param>
        /// <param name="caplogramme">Результат каплограми</param>
        public SmartToilet(int urinalysis, int caplogramme)
        {
            this.urinalysis = urinalysis;
            this.caplogramme = caplogramme;
        }

        /// <summary>
        /// Конструктор копії
        /// </summary>
        /// <param name="toilet">Об*єкт копіювання</param>
        public SmartToilet(SmartToilet toilet)
        {
            urinalysis = toilet.urinalysis;
            caplogramme = toilet.caplogramme;
        }


        /// <summary>
        /// Метод відповідає за зняття аналізів
        /// </summary>
        public void TakeTests(int urinalys, int caplogramme)
        {
            urinalysis = urinalys;
            this.caplogramme = caplogramme;
        }

        /// <summary>
        ///  Метод відповідає за зняття аналізів(Перевантажений метод)
        /// </summary>
        /// <param name="urinalys">Результат загального аналізу сечі</param>
        public void TakeTests(int urinalys)
        {
            urinalysis = urinalys;
            caplogramme = 0;
        }

        /// <summary>
        /// Акссесор для ЗАС
        /// </summary>
        public int Urinalysis
        {
            get { return urinalysis; }
            set { urinalysis = value; }
        }

        /// <summary>
        /// Акссесор для каплограми
        /// </summary>
        public int Caplogramme
        {
            get { return caplogramme; }
            set { caplogramme = value; }
        }

        private int urinalysis;///<Результат аналізу сечі
        private int caplogramme;///<Результат аналізу каплограми

    }
}