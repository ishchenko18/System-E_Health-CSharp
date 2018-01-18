using System;

namespace Version5
{
    /*!
\brief Клас відповідає за зняття результатів аналізів під час сну
\author Ishchenko Vladyslav
\version 5
\date 15 грудня 2017
*/
    public class SmartBed:SmartDevice
    {
        /// <summary>
        /// Конструктор за змовчуванням
        /// </summary>
        public SmartBed():
            base()
        {
            encephalograph = false;
        }

        /// <summary>
        /// Конструктор ініціалізації
        /// </summary>
        /// <param name="encephalograph">Результат енцефалографії</param>
        /// <param name="pulse">Результат нічного пульсу</param>
        /// <param name="pressure">Результат нічного тиску</param>
        public SmartBed(bool encephalograph, short pulse, short pressure):
               base(pulse,pressure)
        {
            this.encephalograph = encephalograph;
            this.pressure = pressure;
            this.pulse = pulse;
        }

        /// <summary>
        /// Конструктор копії
        /// </summary>
        /// <param name="bed">Об*єкт копіювання</param>
        public SmartBed(SmartBed bed)
        {
            encephalograph = bed.encephalograph;
            pulse = bed.pulse;
            pressure = bed.pressure;
        }

        /// <summary>
        /// Зняття результатів аналізів за допомогою ліжка(переозначення функції)
        /// </summary>
        /// <param name="encephalograph">Результат енцефалограми</param>
        /// <param name="pulse">Результат нічного пульсу</param>
        /// <param name="pressure">Результат нічного тиску</param>
        public override void TakeTests(bool encephalograph, short pulse, short pressure)
        {
            this.pressure = pressure;
            this.pulse = pulse;
            this.encephalograph = encephalograph;
        }

        /// <summary>
        /// Акссесор для енцефалограми(предикатна ф-ція)
        /// </summary>
        public bool Encephalograph
        {
            get { return encephalograph; }
            set { encephalograph = value; }
        }

        private bool encephalograph;///<Результат енцелографіки

    }
}