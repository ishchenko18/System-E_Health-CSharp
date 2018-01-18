using System;
using System.Collections.Generic;
using System.Collections;

namespace Version5
{
    /*!
\brief Клас відповідає за обробку отриманої інформації
\author Ishchenko Vladyslav
\version 5
\date 15 грудня 2017
*/
    public class SystemE_Health
    {
        /// <summary>
        /// Конструктор за змовчуванням
        /// </summary>
        public SystemE_Health()
        {
            card.Add(new E_Card());//створення об*єкту електронної картки
            bed.Add(new SmartBed());//створення об*єкту смарт ліжка
            toilet.Add(new SmartToilet());//створення об*єкту смарт туалету
            bracelet.Add(new SmartBracelet());//створення об*єкту смарт браслету
        }

        /// <summary>
        /// Функція перевірки належності денного тиску до проміжку еталонних значень(предикатна ф-ція)
        /// </summary>
        /// <param name="index">День результату аналіза</param>
        /// <returns>Належність результату аналіза нормам</returns>
        bool CompareDailyPressure(int index)
        {
	        return (card[0].GetDailyPressure(card[0].GetSizeDailyPressure() - index) < etalon[0] || card[0].GetDailyPressure(card[0].GetSizeDailyPressure() - index) > etalon[1]);
        }

        /// <summary>
        ///Функція перевірки належності нічного тиску до проміжку еталонних значень(предикатна ф-ція)
        /// </summary>
        /// <param name="index">День результату аналіза</param>
        /// <returns>Належність результату аналіза нормам</returns>
        bool CompareNightPressure(int index)
        {
	        return (card[0].GetNightPressure(card[0].GetSizeNightPressure() - index) < etalon[0] || card[0].GetNightPressure(card[0].GetSizeNightPressure() - index) > etalon[1]);
        }

        /// <summary>
        /// Функція перевірки належності денного пульсу до проміжку еталонних значень(предикатна ф-ція)
        /// </summary>
        /// <param name="index">День результату аналіза</param>
        /// <returns>Належність результату аналіза нормам</returns>
        bool CompareDailyPulse(int index)
        {
	        return (card[0].GetDailyPulse(card[0].GetSizeDailyPulse() - index) < etalon[2] || card[0].GetDailyPulse(card[0].GetSizeDailyPulse() - index) > etalon[3]);
        }

        /// <summary>
        /// Функція перевірки належності нічного пульсу до проміжку еталонних значень(предикатна ф-ція)
        /// </summary>
        /// <param name="index">День результату аналіза</param>
        /// <returns>Належність результату аналіза нормам</returns>
        bool CompareNightPulse(int index)
        {
	        return (card[0].GetNightPulse(card[0].GetSizeNightPulse() - index) < etalon[2] || card[0].GetNightPulse(card[0].GetSizeNightPulse() - index) > etalon[3]);
        }

        /// <summary>
        /// Функція перевірки результату енцефалограми(предикатна ф-ція)
        /// </summary>
        /// <param name="index">День результату аналіза</param>
        /// <returns>Належність результату аналіза нормам</returns>
        bool CompareEncephalogram(int index)
        {
	        return (card[0].GetEncephalograph(card[0].GetSizeEncephalograph() - index));
        }

        /// <summary>
        /// Функція перевірки загальної оцінки результату загального аналізу сечі(предикатна ф-ція)
        /// </summary>
        /// <param name="index">День результату аналіза</param>
        /// <returns>Належність результату аналіза нормам</returns>
        bool CompareUrinalysis(int index)
        {
	        return (card[0].GetUrinalysis(card[0].GetSizeUrinalysis() - index) < etalon[4]);
        }

        /// <summary>
        /// Функція перевірки загальної оцінки результату каплограми(предикатна ф-ція)
        /// </summary>
        /// <param name="index">День результату аналіза</param>
        /// <returns>Належність результату аналіза нормам</returns>
        bool CompareCaplogramme(int index)
        {
	        return (card[0].GetCaplogramme(card[0].GetSizeCaplogramme() - index) < etalon[4]);
        }

        /// <summary>
        /// Метод для нормального функціонування організму користувача(предикатна ф-ція)
        /// </summary>
        /// <returns></returns>
        public bool Compare()
        {
            bool result = true;

            if ((CompareDailyPressure(1) && CompareDailyPressure(2)) ||
                 (CompareDailyPressure(2) && CompareDailyPressure(3)) ||
                 (CompareDailyPressure(1) && CompareDailyPressure(3)))//перевірка результатів денного тиску на належність межі етеалонного значення
            {
                card[0].SetBadresults(false, 0);//встановлення булевого значення результату аналізу
                result = false;
            }

            if ((CompareNightPressure(1) && CompareNightPressure(2)) ||
                 (CompareNightPressure(2) && CompareNightPressure(3)) ||
                 (CompareNightPressure(1) && CompareNightPressure(3)))//перевірка результатів нічного тиску на належність межі етеалонного значення
            {
                card[0].SetBadresults(false, 1);//встановлення булевого значення результату аналізу
                result = false;
            }

            if ((CompareDailyPulse(1) && CompareDailyPulse(2)) ||
                 (CompareDailyPulse(2) && CompareDailyPulse(3)) ||
                 (CompareDailyPulse(1) && CompareDailyPulse(3)))//перевірка результатів денного пульсу на належність межі етеалонного значення
            {
                card[0].SetBadresults(false, 2);//встановлення булевого значення результату аналізу
                result = false;
            }

            if ((CompareNightPulse(1) && CompareNightPulse(2)) ||
                 (CompareNightPulse(2) && CompareNightPulse(3))||
                 (CompareNightPulse(1) && CompareNightPulse(3)))//перевірка результатів нічного пульсу на належність межі етеалонного значення
            {
                card[0].SetBadresults(false, 3);//встановлення булевого значення результату аналізу
                result = false;
            }

            if (!(CompareEncephalogram(1) && CompareEncephalogram(2)) || !(CompareEncephalogram(2) && CompareEncephalogram(3)) || !(CompareEncephalogram(2) && CompareEncephalogram(3)))//перевірка результатів енцелограмми на належність еталонному значенню
            {
                card[0].SetBadresults(false, 4);//встановлення булевого значення результату аналізу
                result = false;
            }

            if ((CompareUrinalysis(1) && CompareUrinalysis(2)) || (CompareUrinalysis(1) && CompareUrinalysis(3)) || (CompareUrinalysis(3) && CompareUrinalysis(2)))//перевірка результатів загального аналізу сечі на належність межі етеалонного значення
            {
                card[0].SetBadresults(false, 6);//встановлення булевого значення результату аналізу
                result = false;
            }

            if ((CompareCaplogramme(1) && CompareCaplogramme(2)) || (CompareCaplogramme(1) && CompareCaplogramme(3)) || (CompareCaplogramme(3) && CompareCaplogramme(2)))//перевірка результатів каплограмми на належність межі етеалонного значення
            {
                card[0].SetBadresults(false, 5);//встановлення булевого значення результату аналізу
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Метод відповідає за відображення результатів обстеження
        /// </summary>
        public void ResultsOfSurvey(string resultSurvey)
        {
            Console.WriteLine(resultSurvey);
            card[0].SetresultsOfSurveys(resultSurvey);
        }
        /// <summary>
        /// Метод відповідає за занесення даних до електронної картки
        /// </summary>
        private void DataInCardUtilita()
        {
            /*====Занесення даних до карти======*/
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
        /// Метод відповідає за виведення анімації процесу обробки даних
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
        /// Отримання еталонного значення аналіза
        /// </summary>
        /// <param name="index">Індекс елемента в списку</param>
        /// <returns>Еталонне значення аналіза</returns>
        public int GetEtalon(int index)
        {
            return etalon[index];
        }

        /// <summary>
        /// Встановлення еталонних значень
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
        /// Визначення необхідних рекомендацій щодо лікування
        /// </summary>
        /// <returns>Рекомендація щодо лікування</returns>
        public string RecomendationOfTreatment()
        {
	        string pressure="", pulse="", encephlaogram="", urinalys="", kaplogram="";//змінні для рекомендаій щодо лікування

	        if (card[0].GetBadresults(0) == false || card[0].GetBadresults(1) == false)//перевірка булевого результату аналізів денного та нічного тисків
	        {
		        pressure = "Your pressure isn't normal. Recommended drugs: Losartan or Valsartan, or Telmisartan.\n";//рекомендація щодо лікування
	        }

	        if (card[0].GetBadresults(2) == false || card[0].GetBadresults(3) == false)//перевірка булевого результату аналізів денного та нічного пульсів
	        {
		        pulse = "Your pulse isn't normal. Recommended drugs: Panangin or Persen\n";//рекомендація щодо лікування
	        }

	        if (card[0].GetBadresults(4) == false)//перевірка булевого результату аналізів енцелограми
	        {
		        encephlaogram = "Your brain needs in vitamins for normal activity. Recomended drugs: Tiamin, Niacin, Piridoksin\n";//рекомендація щодо лікування
	        }

	        if (card[0].GetBadresults(5) == false)//перевірка булевого результату аналізів каплограмми
	        {
		        kaplogram = "Your kaplogramm isn't normal. Recomended drugs: Nemozol or Vormil, or Mebendazol\n";//рекомендація щодо лікування
	        }

	        if (card[0].GetBadresults(6) == false)//перевірка булевого результату ЗАС
	        {
		        urinalys = "Your general urine analysis isn't normal. Recomended drugs: Allopurinol or Blemaren\n";//рекомендація щодо лікування
	        }

	        recomendation = pressure + pulse + encephlaogram + urinalys + kaplogram;//об*єднання рекомендацій в одну

	        return recomendation;
        }

        /// <summary>
        /// Акссесор для запрошення на огляд до лікуючого лікаря
        /// </summary>
        public string InvitationToDoctor
        {
            get { return invitationToDoctor; }
            set { invitationToDoctor = value; }
        }

        /// <summary>
        /// Акссесор для запрошенян на планови огляд
        /// </summary>
        public string InvitationToClinic
        {
            get { return invitationToCinic; }
            set { invitationToCinic = value; }
        }

        /// <summary>
        /// Акссесор для рекомендації від системи
        /// </summary>
        public string Recomendation
        {
            get { return recomendation; }
            set { recomendation = value; }
        }

        public List<E_Card> card = new List<E_Card>();///<Об*єкт електронної картки
        public List<SmartBed> bed = new List<SmartBed>();///<Об*єкт смарт ліжка
        public List<SmartBracelet> bracelet = new List<SmartBracelet>();///<Об*єкт смарт браслету
        public List<SmartToilet> toilet = new List<SmartToilet>();///<Об*єкт смарт туалету

        private List<int> etalon = new List<int>();///<Еталонні значення результатів аналізів
        private string invitationToDoctor = "You need in undergo medical examination in your treatment doctor";///<Текст запрошення на медичний огляд до лікуючого лікаря
        private string invitationToCinic = "You need in undergo medical examination in your clinic";///<Текст запрошення на плановий медичний огляд
        private string recomendation;///Рекомендація щодо лікування або необхідність пройти огляд у лікуючого лікаря

    }
}