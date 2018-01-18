using System;

namespace Version5
{
    /*!
\brief ���� ������� �� ������ ������ �����
\author Ishchenko Vladyslav
\version 5
\date 15 ������ 2017
*/
    public class SmartBracelet:SmartDevice
    {
        /// <summary>
        /// ����������� �� ������������
        /// </summary>
        public SmartBracelet():
            base()
        {

        }

        /// <summary>
        /// ����������� �����������
        /// </summary>
        /// <param name="pulse">��������� ������� ������</param>
        /// <param name="pressure">��������� ������� �����</param>
        public SmartBracelet(short pulse, short pressure):
            base(pulse,pressure)
        {

        }
        /// <summary>
        /// ����������� ��ﳿ
        /// </summary>
        /// <param name="bracelet">��*��� ��ﳿ </param>
        public SmartBracelet(SmartBracelet bracelet)
        {
            pulse = bracelet.pulse;
            pressure = bracelet.pressure;
        }

        /// <summary>
        /// ����� ������� �� ������ ������(������������� �����)
        /// </summary>
        public override void TakeTests(short pulse, short pressure)
        {
            this.pulse = pulse;
            this.pressure = pressure;
        }

    }
}