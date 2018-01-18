using System;
using System.Collections.Generic;
using System.Collections;

namespace Version5
{
    /*!
\brief ���� ������� �� ������� �������� ����������
\author Ishchenko Vladyslav
\version 5
\date 15 ������ 2017
*/
    public class SystemE_Health
    {
        /// <summary>
        /// ����������� �� ������������
        /// </summary>
        public SystemE_Health()
        {
            card.Add(new E_Card());//��������� ��*���� ���������� ������
            bed.Add(new SmartBed());//��������� ��*���� ����� ����
            toilet.Add(new SmartToilet());//��������� ��*���� ����� �������
            bracelet.Add(new SmartBracelet());//��������� ��*���� ����� ��������
        }

        /// <summary>
        /// ������� �������� ��������� ������� ����� �� ������� ��������� �������(���������� �-���)
        /// </summary>
        /// <param name="index">���� ���������� ������</param>
        /// <returns>��������� ���������� ������ ������</returns>
        bool CompareDailyPressure(int index)
        {
	        return (card[0].GetDailyPressure(card[0].GetSizeDailyPressure() - index) < etalon[0] || card[0].GetDailyPressure(card[0].GetSizeDailyPressure() - index) > etalon[1]);
        }

        /// <summary>
        ///������� �������� ��������� ������ ����� �� ������� ��������� �������(���������� �-���)
        /// </summary>
        /// <param name="index">���� ���������� ������</param>
        /// <returns>��������� ���������� ������ ������</returns>
        bool CompareNightPressure(int index)
        {
	        return (card[0].GetNightPressure(card[0].GetSizeNightPressure() - index) < etalon[0] || card[0].GetNightPressure(card[0].GetSizeNightPressure() - index) > etalon[1]);
        }

        /// <summary>
        /// ������� �������� ��������� ������� ������ �� ������� ��������� �������(���������� �-���)
        /// </summary>
        /// <param name="index">���� ���������� ������</param>
        /// <returns>��������� ���������� ������ ������</returns>
        bool CompareDailyPulse(int index)
        {
	        return (card[0].GetDailyPulse(card[0].GetSizeDailyPulse() - index) < etalon[2] || card[0].GetDailyPulse(card[0].GetSizeDailyPulse() - index) > etalon[3]);
        }

        /// <summary>
        /// ������� �������� ��������� ������ ������ �� ������� ��������� �������(���������� �-���)
        /// </summary>
        /// <param name="index">���� ���������� ������</param>
        /// <returns>��������� ���������� ������ ������</returns>
        bool CompareNightPulse(int index)
        {
	        return (card[0].GetNightPulse(card[0].GetSizeNightPulse() - index) < etalon[2] || card[0].GetNightPulse(card[0].GetSizeNightPulse() - index) > etalon[3]);
        }

        /// <summary>
        /// ������� �������� ���������� �������������(���������� �-���)
        /// </summary>
        /// <param name="index">���� ���������� ������</param>
        /// <returns>��������� ���������� ������ ������</returns>
        bool CompareEncephalogram(int index)
        {
	        return (card[0].GetEncephalograph(card[0].GetSizeEncephalograph() - index));
        }

        /// <summary>
        /// ������� �������� �������� ������ ���������� ���������� ������ ����(���������� �-���)
        /// </summary>
        /// <param name="index">���� ���������� ������</param>
        /// <returns>��������� ���������� ������ ������</returns>
        bool CompareUrinalysis(int index)
        {
	        return (card[0].GetUrinalysis(card[0].GetSizeUrinalysis() - index) < etalon[4]);
        }

        /// <summary>
        /// ������� �������� �������� ������ ���������� ����������(���������� �-���)
        /// </summary>
        /// <param name="index">���� ���������� ������</param>
        /// <returns>��������� ���������� ������ ������</returns>
        bool CompareCaplogramme(int index)
        {
	        return (card[0].GetCaplogramme(card[0].GetSizeCaplogramme() - index) < etalon[4]);
        }

        /// <summary>
        /// ����� ��� ����������� �������������� �������� �����������(���������� �-���)
        /// </summary>
        /// <returns></returns>
        public bool Compare()
        {
            bool result = true;

            if ((CompareDailyPressure(1) && CompareDailyPressure(2)) ||
                 (CompareDailyPressure(2) && CompareDailyPressure(3)) ||
                 (CompareDailyPressure(1) && CompareDailyPressure(3)))//�������� ���������� ������� ����� �� ��������� ��� ����������� ��������
            {
                card[0].SetBadresults(false, 0);//������������ �������� �������� ���������� ������
                result = false;
            }

            if ((CompareNightPressure(1) && CompareNightPressure(2)) ||
                 (CompareNightPressure(2) && CompareNightPressure(3)) ||
                 (CompareNightPressure(1) && CompareNightPressure(3)))//�������� ���������� ������ ����� �� ��������� ��� ����������� ��������
            {
                card[0].SetBadresults(false, 1);//������������ �������� �������� ���������� ������
                result = false;
            }

            if ((CompareDailyPulse(1) && CompareDailyPulse(2)) ||
                 (CompareDailyPulse(2) && CompareDailyPulse(3)) ||
                 (CompareDailyPulse(1) && CompareDailyPulse(3)))//�������� ���������� ������� ������ �� ��������� ��� ����������� ��������
            {
                card[0].SetBadresults(false, 2);//������������ �������� �������� ���������� ������
                result = false;
            }

            if ((CompareNightPulse(1) && CompareNightPulse(2)) ||
                 (CompareNightPulse(2) && CompareNightPulse(3))||
                 (CompareNightPulse(1) && CompareNightPulse(3)))//�������� ���������� ������ ������ �� ��������� ��� ����������� ��������
            {
                card[0].SetBadresults(false, 3);//������������ �������� �������� ���������� ������
                result = false;
            }

            if (!(CompareEncephalogram(1) && CompareEncephalogram(2)) || !(CompareEncephalogram(2) && CompareEncephalogram(3)) || !(CompareEncephalogram(2) && CompareEncephalogram(3)))//�������� ���������� ������������ �� ��������� ���������� ��������
            {
                card[0].SetBadresults(false, 4);//������������ �������� �������� ���������� ������
                result = false;
            }

            if ((CompareUrinalysis(1) && CompareUrinalysis(2)) || (CompareUrinalysis(1) && CompareUrinalysis(3)) || (CompareUrinalysis(3) && CompareUrinalysis(2)))//�������� ���������� ���������� ������ ���� �� ��������� ��� ����������� ��������
            {
                card[0].SetBadresults(false, 6);//������������ �������� �������� ���������� ������
                result = false;
            }

            if ((CompareCaplogramme(1) && CompareCaplogramme(2)) || (CompareCaplogramme(1) && CompareCaplogramme(3)) || (CompareCaplogramme(3) && CompareCaplogramme(2)))//�������� ���������� ����������� �� ��������� ��� ����������� ��������
            {
                card[0].SetBadresults(false, 5);//������������ �������� �������� ���������� ������
                result = false;
            }

            return result;
        }

        /// <summary>
        /// ����� ������� �� ����������� ���������� ����������
        /// </summary>
        public void ResultsOfSurvey(string resultSurvey)
        {
            Console.WriteLine(resultSurvey);
            card[0].SetresultsOfSurveys(resultSurvey);
        }
        /// <summary>
        /// ����� ������� �� ��������� ����� �� ���������� ������
        /// </summary>
        private void DataInCardUtilita()
        {
            /*====��������� ����� �� �����======*/
            card[0].SetDailyPulse(bracelet[0].Pulse);
            card[0].SetDailyPressure(bracelet[0].Pressure);
            card[0].SetNightPulse(bed[0].Pulse);
            card[0].SetNightPressure(bed[0].Pressure);
            card[0].SetEncephalograph(bed[0].Encephalograph);
            card[0].SetCaplogramme(toilet[0].Caplogramme);
            card[0].SetUrinalysis(toilet[0].Urinalysis);
        }

        public void DataInCard()
        {
            DataInCardUtilita();
        }

        /// <summary>
        /// ����� ������� �� ��������� ������� ������� ������� �����
        /// </summary>
        public void AnimationOfRegistration()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.SetCursorPosition(15 + i, 4);
                Console.Write("|");
                System.Threading.Thread.Sleep(300);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// ��������� ���������� �������� ������
        /// </summary>
        /// <param name="index">������ �������� � ������</param>
        /// <returns>�������� �������� ������</returns>
        public int GetEtalon(int index)
        {
            return etalon[index];
        }

        /// <summary>
        /// ������������ ��������� �������
        /// </summary>
        public void SetEtalon()
        {
            etalon.Add(110);
            etalon.Add(125);
            etalon.Add(60);
            etalon.Add(80);
            etalon.Add(3);
        }

        /// <summary>
        /// ���������� ���������� ������������ ���� ��������
        /// </summary>
        /// <returns>������������ ���� ��������</returns>
        public string RecomendationOfTreatment()
        {
	        string pressure="", pulse="", encephlaogram="", urinalys="", kaplogram="";//���� ��� ���������� ���� ��������

	        if (card[0].GetBadresults(0) == false || card[0].GetBadresults(1) == false)//�������� �������� ���������� ������ ������� �� ������ �����
	        {
		        pressure = "Your pressure isn't normal. Recommended drugs: Losartan or Valsartan, or Telmisartan.\n";//������������ ���� ��������
	        }

	        if (card[0].GetBadresults(2) == false || card[0].GetBadresults(3) == false)//�������� �������� ���������� ������ ������� �� ������ ������
	        {
		        pulse = "Your pulse isn't normal. Recommended drugs: Panangin or Persen\n";//������������ ���� ��������
	        }

	        if (card[0].GetBadresults(4) == false)//�������� �������� ���������� ������ �����������
	        {
		        encephlaogram = "Your brain needs in vitamins for normal activity. Recomended drugs: Tiamin, Niacin, Piridoksin\n";//������������ ���� ��������
	        }

	        if (card[0].GetBadresults(5) == false)//�������� �������� ���������� ������ �����������
	        {
		        kaplogram = "Your kaplogramm isn't normal. Recomended drugs: Nemozol or Vormil, or Mebendazol\n";//������������ ���� ��������
	        }

	        if (card[0].GetBadresults(6) == false)//�������� �������� ���������� ���
	        {
		        urinalys = "Your general urine analysis isn't normal. Recomended drugs: Allopurinol or Blemaren\n";//������������ ���� ��������
	        }

	        recomendation = pressure + pulse + encephlaogram + urinalys + kaplogram;//��*������� ������������ � ����

	        return recomendation;
        }

        /// <summary>
        /// �������� ��� ���������� �� ����� �� �������� �����
        /// </summary>
        public string InvitationToDoctor
        {
            get { return invitationToDoctor; }
            set { invitationToDoctor = value; }
        }

        /// <summary>
        /// �������� ��� ���������� �� ������� �����
        /// </summary>
        public string InvitationToClinic
        {
            get { return invitationToCinic; }
            set { invitationToCinic = value; }
        }

        /// <summary>
        /// �������� ��� ������������ �� �������
        /// </summary>
        public string Recomendation
        {
            get { return recomendation; }
            set { recomendation = value; }
        }

        public List<E_Card> card = new List<E_Card>();///<��*��� ���������� ������
        public List<SmartBed> bed = new List<SmartBed>();///<��*��� ����� ����
        public List<SmartBracelet> bracelet = new List<SmartBracelet>();///<��*��� ����� ��������
        public List<SmartToilet> toilet = new List<SmartToilet>();///<��*��� ����� �������

        private List<int> etalon = new List<int>();///<������� �������� ���������� ������
        private string invitationToDoctor = "You need in undergo medical examination in your treatment doctor";///<����� ���������� �� �������� ����� �� �������� �����
        private string invitationToCinic = "You need in undergo medical examination in your clinic";///<����� ���������� �� �������� �������� �����
        private string recomendation;///������������ ���� �������� ��� ����������� ������ ����� � �������� �����

    }
}