using System;

namespace Version5
{
    /*!
\brief ���� ������� �� ������ �������� �������� ������
\author Ishchenko Vladyslav
\version 5
\date 15 ������ 2017
*/
    public class SmartToilet
    {
        /// <summary>
        /// ����������� �� ������������
        /// </summary>
        public SmartToilet()
        {
            urinalysis = 0;
            caplogramme = 0;
        }

        /// <summary>
        /// ����������� �����������
        /// </summary>
        /// <param name="urinalysis">��������� ���������� ������ ����</param>
        /// <param name="caplogramme">��������� ����������</param>
        public SmartToilet(int urinalysis, int caplogramme)
        {
            this.urinalysis = urinalysis;
            this.caplogramme = caplogramme;
        }

        /// <summary>
        /// ����������� ��ﳿ
        /// </summary>
        /// <param name="toilet">��*��� ���������</param>
        public SmartToilet(SmartToilet toilet)
        {
            urinalysis = toilet.urinalysis;
            caplogramme = toilet.caplogramme;
        }


        /// <summary>
        /// ����� ������� �� ������ ������
        /// </summary>
        public void TakeTests(int urinalys, int caplogramme)
        {
            urinalysis = urinalys;
            this.caplogramme = caplogramme;
        }

        /// <summary>
        ///  ����� ������� �� ������ ������(�������������� �����)
        /// </summary>
        /// <param name="urinalys">��������� ���������� ������ ����</param>
        public void TakeTests(int urinalys)
        {
            urinalysis = urinalys;
            caplogramme = 0;
        }

        /// <summary>
        /// �������� ��� ���
        /// </summary>
        public int Urinalysis
        {
            get { return urinalysis; }
            set { urinalysis = value; }
        }

        /// <summary>
        /// �������� ��� ����������
        /// </summary>
        public int Caplogramme
        {
            get { return caplogramme; }
            set { caplogramme = value; }
        }

        private int urinalysis;///<��������� ������ ����
        private int caplogramme;///<��������� ������ ����������

    }
}