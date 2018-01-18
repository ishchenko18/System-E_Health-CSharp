using System;
using System.Collections.Generic;


namespace Version5
{
    /*!
\brief Клас описує необхідні медичні параметри користувача та всю історію обстежень
\author Ishchenko Vladyslav
\version 5
\date 15 грудня 2017
*/
    public class E_Card
    {
        /// <summary>
        /// Конструктор за змовчуванням
        /// </summary>
        public E_Card()
        {
            age = 0;
            lastvisit = 0;
            groupOfBlood = 0;
            rh = 'u';
            weight = 0.0f;
            height = 0.0f;
            sex = "Unknown";
        }

        /// <summary>
        /// Конструктор копії
        /// </summary>
        /// <param name="card">Об*єкт копіювання</param>
        public E_Card(E_Card card)
        {
            groupOfBlood = card.groupOfBlood;
            rh = card.rh;
            weight = card.weight;
            height = card.height;
            sex = card.sex;
            chronicIllness = card.chronicIllness;
            dailypressure = card.dailypressure;
            nightpressure = card.nightpressure;
            dailypulse = card.dailypulse;
            nightpulse = card.nightpulse;
            encephalographs = card.encephalographs;
            caplogrammes = card.caplogrammes;
            urinalysis = card.urinalysis;
            diagnosis = card.diagnosis;
            appointments = card.appointments;
            resultsofsurveys = card.resultsofsurveys;
        }

        /// <summary>
        /// Перевантажений метод отримання хеш-коду
        /// </summary>
        /// <returns>Хеш-код об'єкта</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Перевантаження методу порівняння об'єктів
        /// </summary>
        /// <param name="obj">Об'єкт для порівняння</param>
        /// <returns>Булеве значення рівності об'єктів за критерієм</returns>
        public override bool Equals(object obj)
        {
            E_Card card = obj as E_Card;

            if (card == null)
                return false;

            return card.LastVisit == this.lastvisit;
        }

        /// <summary>
        /// Перевантажений оператор порівняння
        /// </summary>
        /// <param name="obj">Об'єкт класу E_Card</param>
        /// <param name="value">Цілочисельне значення  для порівняння</param>
        /// <returns>Булевий результат порівняння</returns>
        public static bool operator ==(E_Card obj, int value)
        {
            return (obj.LastVisit == value);
        }

        /// <summary>
        /// Перевантажений оператор порівняння
        /// </summary>
        /// <param name="obj">Об'єкт класу E_Card</param>
        /// <param name="value">Цілочисельне значення  для порівняння</param>
        /// <returns>Булевий результат порівняння</returns>
        public static bool operator !=(E_Card obj, int value)
        {
            return (obj.LastVisit != value);
        }

        /// <summary>
        /// Метод відповідає за занесення даних до електронної картки
        /// </summary>
        public void Write()
        {
            string exit="";
            bool flag = true;
            Console.Clear();
            Console.WriteLine("=====You should enter beginner data for elecronic card=====");
            Console.WriteLine("Your age: {0}", age);

            do
            {
                try
                {
                    Console.Write("Your group of blood: ");
                    GroupOfBlood = Int32.Parse(Console.ReadLine());//введення групи крові
                    flag = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    flag = false;
                    Console.WriteLine();
                }
            } while (!flag);

            do
            {
                try
                {
                    Console.Write("Your rhesus factor('+' or '-'): ");
                    Rh = Char.Parse(Console.ReadLine());//введення резус фактору
                    flag = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    flag = false;
                    Console.WriteLine();
                }
            } while (!flag);

            do
            {
                try
                {
                    Console.Write("Your weight: ");
                    Weight = float.Parse(Console.ReadLine());//введення ваги
                    flag = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    flag = false;
                    Console.WriteLine();
                }
            } while (!flag);

            do
            {
                try
                {
                    Console.Write("Your height: ");
                    Height = float.Parse(Console.ReadLine());//введення зросту
                    flag = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    flag = false;
                    Console.WriteLine();
                }
            } while (!flag);

            do
            {
                try
                {
                    Console.Write("What's your gender(male or female):");
                    Sex = Console.ReadLine();//введення статі
                    flag = true;
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    flag = false;
                    Console.WriteLine();
                }
            } while (!flag);

            do
            {
                try
                {
                    Console.WriteLine("Do you have chronic illnes? y/n");
                    exit = Console.ReadLine();

                    if (exit != "y" && exit != "n")
                    {
                        throw new Exception("You should choose 'y' or 'n'");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            } while (exit != "y" && exit != "n");

            if(exit == "y")
            {
                string exitInside="",ill;
                do
                {
                    Console.Write("Enter name of your ill: ");
                    ill = Console.ReadLine();//введення назви захворювання
                    SetChronicIllness(ill);
                    do
                    {
                        try
                        {
                            Console.WriteLine("You wanna to add more disease? y/n");
                            exitInside = Console.ReadLine();
                            if (exit != "y" && exit != "n")
                            {
                                throw new Exception("You should choose 'y' or 'n'");
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine();
                        }
                    } while (exitInside != "y" && exitInside != "n");

                }while(exitInside=="y");
            }

            for (int i = 0; i < 7; i++ )
            {
                badresults[i] = true;
            }
        }
        
        /// <summary>
        ///  Метод відповідає за перегляд даних, що містить електронна картка
        /// </summary>
        public void Read()
        {
            Console.WriteLine("========Information from you electronic card========");
            Console.WriteLine("Age: "+age+"\nWeight: "+weight);
            Console.WriteLine("Height: {0}\nGroup ofBlood: {1}", height, groupOfBlood);
            Console.WriteLine("Rhesus factor: {0}\nSex: {1}", rh, sex);
            Console.WriteLine("====list of your daily pressure====");
            
            foreach(short el in dailypressure)
            {
                Console.Write(el + "  ");
            }
            Console.WriteLine();

            Console.WriteLine("====list of your night pressure====");

            foreach (short el in nightpressure)
            {
                Console.Write(el + "  ");
            }
            Console.WriteLine();

            Console.WriteLine("====list of your daily pulse====");

            foreach (short el in dailypulse)
            {
                Console.Write(el + "  ");
            }
            Console.WriteLine();

            Console.WriteLine("====list of your night pulse====");

            foreach (short el in nightpulse)
            {
                Console.Write(el + "  ");
            }
            Console.WriteLine();
            
            Console.WriteLine("====list of results your encelographs====");

            foreach (bool el in encephalographs)
            {
                Console.Write(el + "  ");
            }
            Console.WriteLine();
            
            Console.WriteLine("====list of results your caplogrammes====");

            foreach (short el in caplogrammes)
            {
                Console.Write(el + "  ");
            }
            Console.WriteLine();
            
            Console.WriteLine("====list of results your urinalysis====");

            foreach (short el in urinalysis)
            {
                Console.Write(el + "  ");
            }
            Console.WriteLine();
            
            Console.WriteLine("====list of your diagnosis====");
            GetDiagnos();
            Console.WriteLine();

            Console.WriteLine("====list of your appointments====");
            GetAppointment();
            Console.WriteLine();

            Console.WriteLine("====list of result surveys====");
            GetResultsOfSurveys();
            Console.WriteLine();

            Console.ReadLine();
        }

        /// <summary>
        /// Метод відповідає за зміну даних в електронній картці
        /// </summary>
        public void Change()
        {
            string choose="";
            bool flag;

            do
            {
                Console.Clear();
                Console.WriteLine("=========Changing information in electronic card==========");
                Console.WriteLine("What do you want change in card:\n1 - Age\n2 - Weight\n3 - Height\n4 - Exit\n");
                choose = Console.ReadLine();

                switch(choose)
                {
                    case "1":
                        do
                        {
                            try
                            {
                                Console.WriteLine("Your current  age: {0}\nEnter age: ", age);
                                Age = Int32.Parse(Console.ReadLine());//зміна віку
                                flag = true;
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.ReadLine();
                                flag = false;
                            }
                        } while (!flag);
                        break;
                    case "2":
                        do
                        {
                            try
                            {
                                Console.WriteLine("Your current  weight: {0}\nEnter weight: ", weight);
                                Weight = float.Parse(Console.ReadLine());//зміна ваги
                                flag = true;
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.ReadLine();
                                flag = false;
                            }
                        } while (!flag);
                        break;
                    case "3":
                        do
                        {
                            try
                            {
                                Console.WriteLine("Your current  height: {0}\nEnter height: ", weight);
                                Height = float.Parse(Console.ReadLine());//зміна зросту
                                flag = true;
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.ReadLine();
                                flag = false;
                            }
                        } while (!flag);
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("You chose wrong symbol!");
                        break;
                }
            }while(choose!="4");

            Console.Clear();
        }

        /// <summary>
        /// Визначення к-ті денних тисків
        /// </summary>
        /// <returns>К-ть денних тисків</returns>
        public int GetSizeDailyPressure()
        {
            return dailypressure.Count;
        }

        /// <summary>
        /// Визначення к-ті денних пульсів
        /// </summary>
        /// <returns>К-ть денних пульсів</returns>
        public int GetSizeDailyPulse()
        {
            return dailypulse.Count;
        }

        /// <summary>
        /// Визначення к-ті нічних тисків
        /// </summary>
        /// <returns>К-ть нічних тисків</returns>
        public int GetSizeNightPressure()
        {
            return nightpressure.Count;
        }

        /// <summary>
        /// Визначення к-ті нічних пульсів
        /// </summary>
        /// <returns>К-ть нічних пульсів</returns>
        public int GetSizeNightPulse()
        {
            return nightpulse.Count;
        }

        /// <summary>
        /// Визначення к-ті результатів енцефалограм
        /// </summary>
        /// <returns>К-ть результатів енцефалограм</returns>
        public int GetSizeEncephalograph()
        {
            return encephalographs.Count;
        }

        /// <summary>
        /// Визначення к-ті результатів ЗАС
        /// </summary>
        /// <returns>К-ть результатів ЗАС</returns>
        public int GetSizeUrinalysis()
        {
            return urinalysis.Count;
        }

        /// <summary>
        /// Вищначення к-ті результатів каплограм
        /// </summary>
        /// <returns>К-ть результатів каплограми</returns>
        public int GetSizeCaplogramme()
        {
            return caplogrammes.Count;
        }

        /// <summary>
        /// Визначення к-ті діагнозів
        /// </summary>
        /// <returns>К-ть діагнозів</returns>
        public int GetSizeDiagnosis()
        {
            return diagnosis.Count;
        }

        /// <summary>
        /// Визначення к-ті хронічних захворювань
        /// </summary>
        /// <returns>К-ть хронічних захворювань</returns>
        public int GetSizeChronicIllnes()
        {
            return chronicIllness.Count;
        }

        /// <summary>
        /// Акссесор для віку
        /// </summary>
        public int Age
        {
            get { return age; }
            set 
            { 
                if(value < 0)
                {
                    throw new AgeException("Age can't be negative number");
                }
                else
                {
                    age = value;
                }
            }
        }

        /// <summary>
        /// Акссесор для групи крові
        /// </summary>
        public int GroupOfBlood
        {
            get{ return groupOfBlood; }
            set
            {
                if (value != 1 && value != 2 && value != 3 && value != 4)
                {
                    throw new GroupOfBloodException("Group of blood can be 1,2,3 or 4");
                }
                else
                {
                    groupOfBlood = value;
                }

            }
        }

        /// <summary>
        /// Акссесор для резус фактору
        /// </summary>
        public char Rh
        {
            get{ return rh; }
            set
            {
                if (value != '-' && value != '+')
                {
                    throw new RhesusFactorException("Rhesus factor should be '-' or '+'");
                }
                else
                {
                    rh = value;
                }
            }
        }

        /// <summary>
        /// Акссесор для ваги 
        /// </summary>
        public float Weight
        {
            get{ return weight; }
            set
            {  
                if(value<=0)
                {
                    throw new WeightException("Weight should be positive number");
                }
                else
                {
                    weight = value;
                }
            }
        }

        /// <summary>
        /// Акссесор для зросту
        /// </summary>
        public float Height
        {
            get{ return height; }
            set
            {
                if(value<=0)
                {
                    throw new HeightException("Height should be positive number");
                }
                else
                {
                    height = value;
                }
            }
        }

        /// <summary>
        /// Акссесор для статі
        /// </summary>
        public string Sex
        {
            get{ return sex; }
            set
            { 
                if(value != "male" && value != "female")
                {
                    throw new GenderException("Gender should be only 'male' or 'female'");
                }
                else
                {
                    sex = value;
                }
            }
        }

        /// <summary>
        /// Акссесор для к-ті місяців з часу останнього мед.огляду
        /// </summary>
        public int LastVisit
        {
            get { return lastvisit; }
            set { lastvisit = value; }
        }

        /// <summary>
        /// Виведення списку хронічних захворювань
        /// </summary>
        public void GetChronicIllness()
        {
            foreach (string str in chronicIllness)
                Console.WriteLine(str + " ");
        }

        /// <summary>
        /// Додавання хронічного захворювання
        /// </summary>
        /// <param name="element">Хронічне захворювання</param>
        public void SetChronicIllness(string element)
        {
            chronicIllness.Add(element);
        }

        /// <summary>
        /// Отримання денного тиску
        /// </summary>
        /// <param name="index">Індекс в списку денних тисків</param>
        /// <returns>Значення денного тиску</returns>
        public short GetDailyPressure(int index)
        {
            return dailypressure[index];
        }

        /// <summary>
        /// Додавання денного тиску
        /// </summary>
        /// <param name="element">Значення денного тиску</param>
        public void SetDailyPressure(short element)
        {
            dailypressure.Add(element);
        }

        /// <summary>
        /// Отримання нічного тиску
        /// </summary>
        /// <param name="index">Індекс в списку нічних тисків</param>
        /// <returns>Значення нічного тиску</returns>
        public short GetNightPressure(int index)
        {
            return nightpressure[index];
        }

        /// <summary>
        /// Додавання нічного тиску
        /// </summary>
        /// <param name="element">Значення нічного тиску</param>
        public void SetNightPressure(short element)
        {
            nightpressure.Add(element);
        }

        /// <summary>
        /// Отримання денного пульсу
        /// </summary>
        /// <param name="index">Індекс в списку денних пульсів</param>
        /// <returns>Значення денного пульсу</returns>
        public short GetDailyPulse(int index)
        {
            return dailypulse[index];
        }

        /// <summary>
        /// Додавання нічного пульсу
        /// </summary>
        /// <param name="element">Результат нічного пульсу</param>
        public void SetDailyPulse(short element)
        {
            dailypulse.Add(element);
        }

        /// <summary>
        /// Отримання нічного пульсу
        /// </summary>
        /// <param name="index">Індекс в списку нічних пульсів</param>
        /// <returns>Значення нічного пульсу</returns>
        public short GetNightPulse(int index)
        {
            return nightpulse[index];
        }

        /// <summary>
        /// Додавання нічного пульсу
        /// </summary>
        /// <param name="element">Результат нічного пульсу</param>
        public void SetNightPulse(short element)
        {
            nightpulse.Add(element);
        }

        /// <summary>
        /// Отримання результату енцефалограми(предикатна ф-ція)
        /// </summary>
        /// <param name="index">Індекс елесенту в списку енцефалограм</param>
        /// <returns>Значення енцефалограми</returns>
        public bool GetEncephalograph(int index)
        {
            return encephalographs[index];
        }

        /// <summary>
        /// Додавання результату енцефалограми
        /// </summary>
        /// <param name="element">Результат енцефалограми</param>
        public void SetEncephalograph(bool element)
        {
            encephalographs.Add(element);
        }


        /// <summary>
        /// Отримання результату каплограми
        /// </summary>
        /// <param name="index">Індекс елементу в списку каплограм</param>
        /// <returns>Значення каплограми</returns>
        public int GetCaplogramme(int index)
        {
            return caplogrammes[index];
        }

        /// <summary>
        /// Додавання каплограми до списку
        /// </summary>
        /// <param name="element">Результат каплограми</param>
        public void SetCaplogramme(int element)
        {
            caplogrammes.Add(element);
        }

        /// <summary>
        /// Отримання результату ЗАС
        /// </summary>
        /// <param name="index">Індекс елемента в списку ЗАС</param>
        /// <returns>Результа ЗАС</returns>
        public int GetUrinalysis(int index)
        {
            return urinalysis[index];
        }

        /// <summary>
        /// Додавання результату ЗАС
        /// </summary>
        /// <param name="element">Результат ЗАС</param>
        public void SetUrinalysis(int element)
        {
            urinalysis.Add(element);
        }

        /// <summary>
        /// Виведення списку діагнозів
        /// </summary>
        public void GetDiagnos()
        {
            foreach (string str in diagnosis)
                Console.WriteLine(str + " ");
        }

        /// <summary>
        /// Додавання діагнозу до списку
        /// </summary>
        /// <param name="element">Діагноз</param>
        public void SetDiagnos(string element)
        {
            diagnosis.Add(element);
        }

        /// <summary>
        /// Виведення списку призначень лікаря
        /// </summary>
        public void GetAppointment()
        {
            foreach (string str in appointments)
                Console.WriteLine(str + " ");
        }

        /// <summary>
        /// Додавання нового призначення
        /// </summary>
        /// <param name="element">Призначення лікаря</param>
        public void SetAppointment(string element)
        {
            appointments.Add(element);
        }

        /// <summary>
        /// Виведення списку результатів планових обстеженнь
        /// </summary>
        public void GetResultsOfSurveys()
        {
            foreach (string str in resultsofsurveys)
                Console.WriteLine(str + " ");
        }

        /// <summary>
        /// Додавання результату обстеження
        /// </summary>
        /// <param name="element">Результат обстеження</param>
        public void SetresultsOfSurveys(string element)
        {
            resultsofsurveys.Add(element);
        }

        /// <summary>
        /// Отримання булевого значення результату аналіза(предикатна ф-ція)
        /// </summary>
        /// <param name="index">Індекс елемента в списку</param>
        /// <returns>Булеве значення результату аналіза</returns>
        public bool GetBadresults(int index)
        {
            return badresults[index];
        }

        /// <summary>
        /// Додавання булевого значення результату аналіза
        /// </summary>
        /// <param name="element">Булеве значення результату аналіза</param>
        /// <param name="index">Індекс елеменат в масиві</param>
        public void SetBadresults(bool element, int index)
        {
            badresults[index] = element;
        }

        private int lastvisit;///<К-ть місяців з часу останнього мед.огляду
        private int age;///<Вік користувача
        private int groupOfBlood;///<Група крові
        private char rh;///<Резус-фактор
        private float weight;///<Вага  користувача
        private float height;///<Зріст користувача
        private string sex;///<Стать користувача
        private bool[] badresults = new bool[7];
        private List<string> chronicIllness = new List<string>();///<Хронічні захворювання користувача та його батьків
        private List<short> dailypressure = new List<short>();///<Денний тиск
        private List<short> nightpressure = new List<short>();///<Нічний тиск
        private List<short> dailypulse = new List<short>();///<Денний пульс
        private List<short> nightpulse = new List<short>();///<Нічний пульс
        private List<bool> encephalographs = new List<bool>();///<Результати енцелографіки
        private List<int> caplogrammes = new List<int>();///<Результати каплограми
        private List<int> urinalysis = new List<int>();///<Результати аналізів
        private List<string> diagnosis = new List<string>();///<Діагнози
        private List<string> appointments = new List<string>();///<Призначення
        private List<string> resultsofsurveys = new List<string>();///<Результати огляду

    }
}