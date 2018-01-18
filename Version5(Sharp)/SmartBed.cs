using System;

namespace Version5
{
    /*!
\brief ���� ������� �� ������ ���������� ������ �� ��� ���
\author Ishchenko Vladyslav
\version 5
\date 15 ������ 2017
*/
    public class SmartBed:SmartDevice
    {
        /// <summary>
        /// ����������� �� ������������
        /// </summary>
        public SmartBed():
            base()
        {
            encephalograph = false;
        }

        /// <summary>
        /// ����������� �����������
        /// </summary>
        /// <param name="encephalograph">��������� ��������������</param>
        /// <param name="pulse">��������� ������ ������</param>
        /// <param name="pressure">��������� ������ �����</param>
        public SmartBed(bool encephalograph, short pulse, short pressure):
               base(pulse,pressure)
        {
            this.encephalograph = encephalograph;
            this.pressure = pressure;
            this.pulse = pulse;
        }

        /// <summary>
        /// ����������� ��ﳿ
        /// </summary>
        /// <param name="bed">��*��� ���������</param>
        public SmartBed(SmartBed bed)
        {
            encephalograph = bed.encephalograph;
            pulse = bed.pulse;
            pressure = bed.pressure;
        }

        /// <summary>
        /// ������ ���������� ������ �� ��������� ����(������������� �������)
        /// </summary>
        /// <param name="encephalograph">��������� �������������</param>
        /// <param name="pulse">��������� ������ ������</param>
        /// <param name="pressure">��������� ������ �����</param>
        public override void TakeTests(bool encephalograph, short pulse, short pressure)
        {
            this.pressure = pressure;
            this.pulse = pulse;
            this.encephalograph = encephalograph;
        }

        /// <summary>
        /// �������� ��� �������������(���������� �-���)
        /// </summary>
        public bool Encephalograph
        {
            get { return encephalograph; }
            set { encephalograph = value; }
        }

        private bool encephalograph;///<��������� �������������

    }
}