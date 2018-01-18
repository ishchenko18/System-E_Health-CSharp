using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version5
{
/*!
\brief Описує характеристики деяких смарт застосувань(Клас для наслідування)
\author Ishchenko Vladyslav
\version 5
\date 15 грудня 2017
*/
    public class SmartDevice
    {
        protected short pulse;///Результат пульсу
        protected short pressure;///Результат тиску

        /// <summary>
        /// Конструктор за змовчуванням
        /// </summary>
        public SmartDevice()
        {
            pulse = 0;
            pressure = 0;
        }

        /// <summary>
        /// Конструктор ініціалізації
        /// </summary>
        /// <param name="pulse">Результат пульсу</param>
        /// <param name="pressure">Результат тиску</param>
        public SmartDevice(short pulse, short pressure)
        {
            this.pulse = pulse;
            this.pressure = pressure;
        }

        /// <summary>
        /// Аксесор для пульсу
        /// </summary>
        public short Pulse
        {
            get { return pulse; }
            set { pulse = value; }
        }

        /// <summary>
        /// Аксесор для тиску
        /// </summary>
        public short Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        /// <summary>
        /// Віртуальна функція для зняття даних за допомогою застосування
        /// </summary>
        /// <param name="encephal">Результат енцефалограми</param>
        /// <param name="pulse">Результат пульсу</param>
        /// <param name="pressure">Результат тиску</param>
        public virtual void TakeTests(bool encephal, short pulse, short pressure)
        {
            this.pressure = pressure;
            this.pulse = pulse;
        }

        /// <summary>
        /// Віртуальна функція для зняття даних за допомогою застосування
        /// </summary>
        /// <param name="pulse">Результат пульсу</param>
        /// <param name="pressure">Результат тиску</param>
        public virtual void TakeTests(short pulse, short pressure)
        {

        }
    }
}
