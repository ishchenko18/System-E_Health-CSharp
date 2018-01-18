using System;
using System.Collections;
using System.Collections.Generic;

namespace Version5
{
    /*!
\brief ���� ����� ����� � ��� ����������� ����������
\author Ishchenko Vladyslav
\version 5
\date 15 ������ 2017
*/
    public class Clinic
    {
        /// <summary>
        /// ����������� �� ������������
        /// </summary>
        public Clinic()
        {
            medic.Add(new Doctor("Nazar", "Kolokolov", "Therapist", 1));
            name="Unknown";
        }



        /// <summary>
        /// ����������� ��ﳿ
        /// </summary>
        /// <param name="clinic">��*��� ���������</param>
        public Clinic(Clinic clinic)
        {
            medic = clinic.medic;
            listOfDoctors = clinic.listOfDoctors;
        }


        /// <summary>
        /// ��������� �������� ��� ����� �����(��������� �����)
        /// </summary>
        public static string Name
        {
            set { name = value; }
        }

        /// <summary>
        /// ��������� ����� ��� ���������� ����� �����
        /// </summary>
        public static string ClinicName()
        {
            return name;
        }

        /// <summary>
        /// ��������� ������ ����� �����
        /// </summary>
        public void GetDoctors()
        {
            Console.WriteLine("===========Doctors, who works in {0} clinic=========", name);

            foreach(string str in listOfDoctors)
                Console.WriteLine(str+"  ");
        }

        /// <summary>
        /// ��������� ����� �� ������
        /// </summary>
        public void SetDoctors()
        {
            string nameDoctor = medic[0].FirstName + " " + medic[0].SurName;
            listOfDoctors.Add(nameDoctor);
        }

        public List<Doctor> medic = new List<Doctor>();///<��*��� �����
        private static string name;///<����� �����
        private List<string> listOfDoctors = new List<string>();///<������ ����� �����

    }
}