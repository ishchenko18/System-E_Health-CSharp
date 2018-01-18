using System;
using System.Collections;
using System.Collections.Generic;

namespace Version5
{
    /*!
\brief Клас описує клініку в якій обстежується користувач
\author Ishchenko Vladyslav
\version 5
\date 15 грудня 2017
*/
    public class Clinic
    {
        /// <summary>
        /// Конструктор за змовчуванням
        /// </summary>
        public Clinic()
        {
            medic.Add(new Doctor("Nazar", "Kolokolov", "Therapist", 1));
            name="Unknown";
        }



        /// <summary>
        /// Конструктор копії
        /// </summary>
        /// <param name="clinic">Об*єкт копіювання</param>
        public Clinic(Clinic clinic)
        {
            medic = clinic.medic;
            listOfDoctors = clinic.listOfDoctors;
        }


        /// <summary>
        /// Статичний акссесор для назви клініки(статичний метод)
        /// </summary>
        public static string Name
        {
            set { name = value; }
        }

        /// <summary>
        /// Статичний метод для визначення назви клініки
        /// </summary>
        public static string ClinicName()
        {
            return name;
        }

        /// <summary>
        /// Виведення списку лікарів клініки
        /// </summary>
        public void GetDoctors()
        {
            Console.WriteLine("===========Doctors, who works in {0} clinic=========", name);

            foreach(string str in listOfDoctors)
                Console.WriteLine(str+"  ");
        }

        /// <summary>
        /// Додавання лікаря до списку
        /// </summary>
        public void SetDoctors()
        {
            string nameDoctor = medic[0].FirstName + " " + medic[0].SurName;
            listOfDoctors.Add(nameDoctor);
        }

        public List<Doctor> medic = new List<Doctor>();///<Об*єкт лікаря
        private static string name;///<Назва клініки
        private List<string> listOfDoctors = new List<string>();///<Список лікарів клініки

    }
}