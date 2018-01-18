using System;

namespace Version5
{
 /*!
\brief ���� ������� �� ������ � �����
\author Ishchenko Vladyslav
\version 5
\date 15 ������ 2017
*/
    public class ChipForIdentification
    {
        /// <summary>
        /// ����������� �� ������������
        /// </summary>
        public ChipForIdentification()
        {
            firstname = "Unknown";
            surname = "Unknown";
            birthday = 0;
            qrcod = 0;
        }

        /// <summary>
        /// ����������� �����������
        /// </summary>
        /// <param name="firstname">��*� ����������� ����</param>
        /// <param name="surname">������� ����������� ����</param>
        /// <param name="birthday">���� ���������� ����������� ����</param>
        /// <param name="qrcod">������������� ��� ����</param>
        public ChipForIdentification(string firstname,string surname,int birthday, int qrcod)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.birthday = birthday;
            this.qrcod = qrcod;
        }
        
        /// <summary>
        /// ����� ��� ���������� ������������ �������� ������ 䳿 ����
        /// </summary>
        /// <returns>������ 䳿 ����</returns>
        public int ReturnTermChip()
        {
            return term;
        }

        /// <summary>
        /// �������� ��� �������������� ���� ����
        /// </summary>
        public int QRcod
        {
            get { return qrcod; }
            set { qrcod = value; }
        }

        /// <summary>
        /// �������� ��� ���� ����������
        /// </summary>
        public int Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        /// <summary>
        /// �������� ��� ���� ����������� �� �����
        /// </summary>
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        /// <summary>
        /// �������� ��� ������� ����������� �� �����
        /// </summary>
        public string SurName
        {
            get { return surname; }
            set { surname = value; }
        }

        private string firstname;///< ��*� ����������
        private string surname;///<������� �����������
        private int birthday;///<���� ���������� 
        private const int term = 100;///<����� 䳿 ����(����������� �������)
        private int qrcod;///<��������� ��� ����

    }
}