using System;

namespace Version5
{
    /*!
\brief Клас відповідає за зняття аналізів вдень
\author Ishchenko Vladyslav
\version 5
\date 15 грудня 2017
*/
    public class SmartBracelet:SmartDevice
    {
        /// <summary>
        /// Конструктор за змовчуванням
        /// </summary>
        public SmartBracelet():
            base()
        {

        }

        /// <summary>
        /// Конструктор ініціалізації
        /// </summary>
        /// <param name="pulse">Результат денного пульсу</param>
        /// <param name="pressure">Результат денного тиску</param>
        public SmartBracelet(short pulse, short pressure):
            base(pulse,pressure)
        {

        }
        /// <summary>
        /// Конструктор копії
        /// </summary>
        /// <param name="bracelet">Об*єкт копії </param>
        public SmartBracelet(SmartBracelet bracelet)
        {
            pulse = bracelet.pulse;
            pressure = bracelet.pressure;
        }

        /// <summary>
        /// Метод відповідає за зняття аналізів(переозначений метод)
        /// </summary>
        public override void TakeTests(short pulse, short pressure)
        {
            this.pulse = pulse;
            this.pressure = pressure;
        }

    }
}