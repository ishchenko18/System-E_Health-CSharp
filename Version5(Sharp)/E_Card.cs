using System;
using System.Collections.Generic;


namespace Version5
{
    /*!
\brief ���� ����� �������� ������ ��������� ����������� �� ��� ������ ���������
\author Ishchenko Vladyslav
\version 5
\date 15 ������ 2017
*/
    public class E_Card
    {
        /// <summary>
        /// ����������� �� ������������
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
        /// ����������� ��ﳿ
        /// </summary>
        /// <param name="card">��*��� ���������</param>
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
        /// �������������� ����� ��������� ���-����
        /// </summary>
        /// <returns>���-��� ��'����</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// �������������� ������ ��������� ��'����
        /// </summary>
        /// <param name="obj">��'��� ��� ���������</param>
        /// <returns>������ �������� ������ ��'���� �� �������</returns>
        public override bool Equals(object obj)
        {
            E_Card card = obj as E_Card;

            if (card == null)
                return false;

            return card.LastVisit == this.lastvisit;
        }

        /// <summary>
        /// �������������� �������� ���������
        /// </summary>
        /// <param name="obj">��'��� ����� E_Card</param>
        /// <param name="value">ֳ���������� ��������  ��� ���������</param>
        /// <returns>������� ��������� ���������</returns>
        public static bool operator ==(E_Card obj, int value)
        {
            return (obj.LastVisit == value);
        }

        /// <summary>
        /// �������������� �������� ���������
        /// </summary>
        /// <param name="obj">��'��� ����� E_Card</param>
        /// <param name="value">ֳ���������� ��������  ��� ���������</param>
        /// <returns>������� ��������� ���������</returns>
        public static bool operator !=(E_Card obj, int value)
        {
            return (obj.LastVisit != value);
        }

        /// <summary>
        /// ����� ������� �� ��������� ����� �� ���������� ������
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
                    GroupOfBlood = Int32.Parse(Console.ReadLine());//�������� ����� ����
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
                    Rh = Char.Parse(Console.ReadLine());//�������� ����� �������
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
                    Weight = float.Parse(Console.ReadLine());//�������� ����
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
                    Height = float.Parse(Console.ReadLine());//�������� ������
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
                    Sex = Console.ReadLine();//�������� ����
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
                    ill = Console.ReadLine();//�������� ����� ������������
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
        ///  ����� ������� �� �������� �����, �� ������ ���������� ������
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
        /// ����� ������� �� ���� ����� � ���������� ������
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
                                Age = Int32.Parse(Console.ReadLine());//���� ���
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
                                Weight = float.Parse(Console.ReadLine());//���� ����
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
                                Height = float.Parse(Console.ReadLine());//���� ������
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
        /// ���������� �-� ������ �����
        /// </summary>
        /// <returns>�-�� ������ �����</returns>
        public int GetSizeDailyPressure()
        {
            return dailypressure.Count;
        }

        /// <summary>
        /// ���������� �-� ������ ������
        /// </summary>
        /// <returns>�-�� ������ ������</returns>
        public int GetSizeDailyPulse()
        {
            return dailypulse.Count;
        }

        /// <summary>
        /// ���������� �-� ����� �����
        /// </summary>
        /// <returns>�-�� ����� �����</returns>
        public int GetSizeNightPressure()
        {
            return nightpressure.Count;
        }

        /// <summary>
        /// ���������� �-� ����� ������
        /// </summary>
        /// <returns>�-�� ����� ������</returns>
        public int GetSizeNightPulse()
        {
            return nightpulse.Count;
        }

        /// <summary>
        /// ���������� �-� ���������� ������������
        /// </summary>
        /// <returns>�-�� ���������� ������������</returns>
        public int GetSizeEncephalograph()
        {
            return encephalographs.Count;
        }

        /// <summary>
        /// ���������� �-� ���������� ���
        /// </summary>
        /// <returns>�-�� ���������� ���</returns>
        public int GetSizeUrinalysis()
        {
            return urinalysis.Count;
        }

        /// <summary>
        /// ���������� �-� ���������� ���������
        /// </summary>
        /// <returns>�-�� ���������� ����������</returns>
        public int GetSizeCaplogramme()
        {
            return caplogrammes.Count;
        }

        /// <summary>
        /// ���������� �-� �������
        /// </summary>
        /// <returns>�-�� �������</returns>
        public int GetSizeDiagnosis()
        {
            return diagnosis.Count;
        }

        /// <summary>
        /// ���������� �-� �������� �����������
        /// </summary>
        /// <returns>�-�� �������� �����������</returns>
        public int GetSizeChronicIllnes()
        {
            return chronicIllness.Count;
        }

        /// <summary>
        /// �������� ��� ���
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
        /// �������� ��� ����� ����
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
        /// �������� ��� ����� �������
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
        /// �������� ��� ���� 
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
        /// �������� ��� ������
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
        /// �������� ��� ����
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
        /// �������� ��� �-� ������ � ���� ���������� ���.������
        /// </summary>
        public int LastVisit
        {
            get { return lastvisit; }
            set { lastvisit = value; }
        }

        /// <summary>
        /// ��������� ������ �������� �����������
        /// </summary>
        public void GetChronicIllness()
        {
            foreach (string str in chronicIllness)
                Console.WriteLine(str + " ");
        }

        /// <summary>
        /// ��������� ��������� ������������
        /// </summary>
        /// <param name="element">������� ������������</param>
        public void SetChronicIllness(string element)
        {
            chronicIllness.Add(element);
        }

        /// <summary>
        /// ��������� ������� �����
        /// </summary>
        /// <param name="index">������ � ������ ������ �����</param>
        /// <returns>�������� ������� �����</returns>
        public short GetDailyPressure(int index)
        {
            return dailypressure[index];
        }

        /// <summary>
        /// ��������� ������� �����
        /// </summary>
        /// <param name="element">�������� ������� �����</param>
        public void SetDailyPressure(short element)
        {
            dailypressure.Add(element);
        }

        /// <summary>
        /// ��������� ������ �����
        /// </summary>
        /// <param name="index">������ � ������ ����� �����</param>
        /// <returns>�������� ������ �����</returns>
        public short GetNightPressure(int index)
        {
            return nightpressure[index];
        }

        /// <summary>
        /// ��������� ������ �����
        /// </summary>
        /// <param name="element">�������� ������ �����</param>
        public void SetNightPressure(short element)
        {
            nightpressure.Add(element);
        }

        /// <summary>
        /// ��������� ������� ������
        /// </summary>
        /// <param name="index">������ � ������ ������ ������</param>
        /// <returns>�������� ������� ������</returns>
        public short GetDailyPulse(int index)
        {
            return dailypulse[index];
        }

        /// <summary>
        /// ��������� ������ ������
        /// </summary>
        /// <param name="element">��������� ������ ������</param>
        public void SetDailyPulse(short element)
        {
            dailypulse.Add(element);
        }

        /// <summary>
        /// ��������� ������ ������
        /// </summary>
        /// <param name="index">������ � ������ ����� ������</param>
        /// <returns>�������� ������ ������</returns>
        public short GetNightPulse(int index)
        {
            return nightpulse[index];
        }

        /// <summary>
        /// ��������� ������ ������
        /// </summary>
        /// <param name="element">��������� ������ ������</param>
        public void SetNightPulse(short element)
        {
            nightpulse.Add(element);
        }

        /// <summary>
        /// ��������� ���������� �������������(���������� �-���)
        /// </summary>
        /// <param name="index">������ �������� � ������ ������������</param>
        /// <returns>�������� �������������</returns>
        public bool GetEncephalograph(int index)
        {
            return encephalographs[index];
        }

        /// <summary>
        /// ��������� ���������� �������������
        /// </summary>
        /// <param name="element">��������� �������������</param>
        public void SetEncephalograph(bool element)
        {
            encephalographs.Add(element);
        }


        /// <summary>
        /// ��������� ���������� ����������
        /// </summary>
        /// <param name="index">������ �������� � ������ ���������</param>
        /// <returns>�������� ����������</returns>
        public int GetCaplogramme(int index)
        {
            return caplogrammes[index];
        }

        /// <summary>
        /// ��������� ���������� �� ������
        /// </summary>
        /// <param name="element">��������� ����������</param>
        public void SetCaplogramme(int element)
        {
            caplogrammes.Add(element);
        }

        /// <summary>
        /// ��������� ���������� ���
        /// </summary>
        /// <param name="index">������ �������� � ������ ���</param>
        /// <returns>�������� ���</returns>
        public int GetUrinalysis(int index)
        {
            return urinalysis[index];
        }

        /// <summary>
        /// ��������� ���������� ���
        /// </summary>
        /// <param name="element">��������� ���</param>
        public void SetUrinalysis(int element)
        {
            urinalysis.Add(element);
        }

        /// <summary>
        /// ��������� ������ �������
        /// </summary>
        public void GetDiagnos()
        {
            foreach (string str in diagnosis)
                Console.WriteLine(str + " ");
        }

        /// <summary>
        /// ��������� ������� �� ������
        /// </summary>
        /// <param name="element">ĳ�����</param>
        public void SetDiagnos(string element)
        {
            diagnosis.Add(element);
        }

        /// <summary>
        /// ��������� ������ ���������� �����
        /// </summary>
        public void GetAppointment()
        {
            foreach (string str in appointments)
                Console.WriteLine(str + " ");
        }

        /// <summary>
        /// ��������� ������ �����������
        /// </summary>
        /// <param name="element">����������� �����</param>
        public void SetAppointment(string element)
        {
            appointments.Add(element);
        }

        /// <summary>
        /// ��������� ������ ���������� �������� ����������
        /// </summary>
        public void GetResultsOfSurveys()
        {
            foreach (string str in resultsofsurveys)
                Console.WriteLine(str + " ");
        }

        /// <summary>
        /// ��������� ���������� ����������
        /// </summary>
        /// <param name="element">��������� ����������</param>
        public void SetresultsOfSurveys(string element)
        {
            resultsofsurveys.Add(element);
        }

        /// <summary>
        /// ��������� �������� �������� ���������� ������(���������� �-���)
        /// </summary>
        /// <param name="index">������ �������� � ������</param>
        /// <returns>������ �������� ���������� ������</returns>
        public bool GetBadresults(int index)
        {
            return badresults[index];
        }

        /// <summary>
        /// ��������� �������� �������� ���������� ������
        /// </summary>
        /// <param name="element">������ �������� ���������� ������</param>
        /// <param name="index">������ �������� � �����</param>
        public void SetBadresults(bool element, int index)
        {
            badresults[index] = element;
        }

        private int lastvisit;///<�-�� ������ � ���� ���������� ���.������
        private int age;///<³� �����������
        private int groupOfBlood;///<����� ����
        private char rh;///<�����-������
        private float weight;///<����  �����������
        private float height;///<���� �����������
        private string sex;///<����� �����������
        private bool[] badresults = new bool[7];
        private List<string> chronicIllness = new List<string>();///<������ ������������ ����������� �� ���� ������
        private List<short> dailypressure = new List<short>();///<������ ����
        private List<short> nightpressure = new List<short>();///<ͳ���� ����
        private List<short> dailypulse = new List<short>();///<������ �����
        private List<short> nightpulse = new List<short>();///<ͳ���� �����
        private List<bool> encephalographs = new List<bool>();///<���������� �������������
        private List<int> caplogrammes = new List<int>();///<���������� ����������
        private List<int> urinalysis = new List<int>();///<���������� ������
        private List<string> diagnosis = new List<string>();///<ĳ������
        private List<string> appointments = new List<string>();///<�����������
        private List<string> resultsofsurveys = new List<string>();///<���������� ������

    }
}