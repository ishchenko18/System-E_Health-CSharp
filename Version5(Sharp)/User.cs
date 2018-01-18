using System;

namespace Version5
{
    /*!
\brief ���� ����� ����������� �������
\author Ishchenko Vladyslav
\version 5
\date 15 ������ 2017
*/
    public class User
    {
        /// <summary>
        /// ��������� �����������
        /// </summary>
        static User()
        {
 
        }

        /// <summary>
        /// ����������� �����������
        /// </summary>
        /// <param name="firstname">��*� �����������</param>
        /// <param name="surname">������� �����������</param>
        public User(string _firstname, string _surname)
        {
            chipForIdentification = new ChipForIdentification();
            firstname = _firstname;
            surname = _surname;
       }

        /// <summary>
        /// ����������� ��ﳿ
        /// </summary>
        /// <param name="user">��*��� ���������</param>
        public User(User user)
        {
            chipForIdentification = user.chipForIdentification;
            firstname = user.firstname;
            surname = user.surname;
        }

        /// <summary>
        /// ����� ������� �� ����������� ���������� ������������
        /// </summary>
        public void Survey()
        {
            Console.WriteLine("You undergo a medical examination");
        }

        /// <summary>
        /// ����� ������� �� ���������� ����� ������������
        /// </summary>
        public void VisitDoctor()
        {
            Console.WriteLine("You undergo medical examination in the treatment doctor");
        }

        /// <summary>
        /// �������� ���� �����������
        /// </summary>
        public string Firstname
        {
            get{ return firstname; }
            set { firstname = value; }
        }

        /// <summary>
        /// �������� ������� �����������
        /// </summary>
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public Doctor doctor;///<��*��� ����� Doctor
        public ChipForIdentification chipForIdentification;///<��*��� ����� ChipForIdentification
        public SystemE_Health systemE_Health;///<��*��� ����� SystemE_Health

        private string firstname;///<��*� �����������
        private string surname;///<������� �����������

    }
}