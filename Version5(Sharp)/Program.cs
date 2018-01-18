using System;
using System.Diagnostics;

namespace Version5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string InputString;
            int InputNumber = 0, periodOfVisit, days, counter = 0;
            var rand = new Random();

            //=====================Виведення загальної інформації//
            Console.Title = "E-Health(by Ishchenko Vladyslav)";
            Console.WriteLine("Author: Ishchenko Vladyslav\nGroup: IS-63\nCourse: 2");
            Console.WriteLine("E-mail: vladik.ishchenko.2017@gmail.com");
            Console.WriteLine("Number of telephone: +380974386890");
            // Process.Start(@"C:\Users\Vladislav\Desktop\Study\2 курс\ООП\Ishchenko IS-63\RealisationSharp\Version2(Sharp)\Version2(Sharp)\task.txt");
            //================================================//
            
            Clinic clinic = new Clinic();
            User user = new User("Vladyslav","Ishchenko");
            SystemE_Health syst = new SystemE_Health();

            Console.ReadLine();
            Console.Clear();

            Clinic.Name = "Healthy&Happy";

            Console.WriteLine("Name of your clinic: {0}", Clinic.ClinicName());
            Console.WriteLine("\n====Information about Doctor====");
            Console.WriteLine(clinic.medic[0].ToString());

            Console.ReadLine();
            Console.Clear();

            //============Реєстрація в системі=================//
            Console.WriteLine("You should register in system\n");

            do
            {
                Console.Write("Enter your firstname: ");
                user.chipForIdentification.FirstName = Console.ReadLine();
                if (user.chipForIdentification.FirstName == "")
                {
                    Console.WriteLine("Field \"firstname\" should not be empty.");
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            } while (!flag);

            do
            {
                Console.Write("Enter your surname: ");
                user.chipForIdentification.SurName = Console.ReadLine();
                if (user.chipForIdentification.SurName == "")
                {
                    Console.WriteLine("Field \"surname\" should not be empty.");
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            } while (!flag);
            do
            {
                try
                {
                    Console.Write("Enter year of your Birthday: ");
                    InputNumber = Int32.Parse(Console.ReadLine());
                    flag = true;
                    if(InputNumber < 0)
                    {
                        throw new Exception("Year of birthday can't be negative number");
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    flag = false;
                    Console.ReadLine();
                }
            } while (!flag);

            user.chipForIdentification.QRcod = rand.Next(000000, 1000000);//формування унікального коду чипа
            user.chipForIdentification.Birthday = InputNumber;
            syst.card[0].Age = (DateTime.Now.Year - InputNumber);//підрахування віку користувача, в залежності від дати народження

            Console.WriteLine("\nValidity of chip: {0}",user.chipForIdentification.ReturnTermChip());
            Console.WriteLine("Unique code of chip: {0}\n", user.chipForIdentification.QRcod);
            Console.ReadLine();

            user.Firstname = user.chipForIdentification.FirstName;
            user.Surname = user.chipForIdentification.SurName;
            Console.Clear();

            Console.WriteLine("Secondly, fill out the card.");
            Console.ReadLine();


            syst.card[0].Write();
            Console.Clear();
            //================================================//

            Console.WriteLine("=====Process of registration=====");
            syst.AnimationOfRegistration();//Виведення анціміції обробки даних

            Console.Clear();

            do
            {
                Console.Clear();
                Console.WriteLine("=====Welcome to system {0} {1}=====", user.Firstname, user.Surname);

                do
                {
                    Console.ReadLine();
                    Console.Clear();

                    //Вибір пункту меню
                    Console.WriteLine("Choose one of variety:\n1 - Change data in electronic card\n2 - Show information from electronic card\n3 - Next Step");

                    InputString = Console.ReadLine();
                    switch(InputString)
                    {
                        case "1":
                            syst.card[0].Change();//зміна даних в картці
                            break;
                        case "2":
                            syst.card[0].Read();
                            break;
                        case "3":
                            break;
                        default:
                            Console.WriteLine("You chose wrong variant. Please, choose one of the variant");
                            break;
                    }
                
                } while (InputString != "3");

                syst.SetEtalon();//встанволення еталонних значень

                days = rand.Next(0, 4) + 3;//визначення к-ті днів для зняття результатів

                //=================Зняття результатів аналізів=======================//
                while(counter != days)
                {
                    Console.Clear();

                    Console.WriteLine("==========Geting results from devices==========");
                    syst.AnimationOfRegistration();

                    Console.Clear();
                    bool value=false;

                    if(rand.Next(2)==1)
                    {
                        value = true;
                    }
                    syst.bracelet[0].TakeTests(((short)rand.Next(51,96)),((short)rand.Next(51,121)));
                    syst.bed[0].TakeTests(value,(short)rand.Next(51,96),(short)rand.Next(51,121));
                    syst.toilet[0].TakeTests(rand.Next(6), rand.Next(6));

                    Console.WriteLine("Results of analysis on " + (syst.card[0].GetSizeDailyPulse()+1) +" day");
                    
                    Console.WriteLine("=====Results from Smart Bracelet=====");
                    Console.WriteLine("   Pulse    Pressure");
                    Console.WriteLine("    {0}        {1}",syst.bracelet[0].Pulse,syst.bracelet[0].Pressure);
                    
                    Console.WriteLine("=====Results from Smart Bed=====");
                    Console.WriteLine("   Pulse     Pressure     Encephalography  ");
                    Console.WriteLine("    {0}        {1}             {2}", syst.bed[0].Pulse, syst.bed[0].Pressure, syst.bed[0].Encephalograph);
                    
                    Console.WriteLine("=====Results from Smart Toilet=====");
                    Console.WriteLine("    Urinalys    Caplogramme    ");
                    Console.WriteLine("      {0}           {1}  ",syst.toilet[0].Urinalysis,syst.toilet[0].Caplogramme);

                    Console.ReadLine();

                    syst.DataInCard();//занесення даних в картку
                    counter++;
                }
                //=========================================================//

                Console.ReadLine();
                Console.Clear();
                syst.card[0].Read();//виведення інформації з картки

                if(!syst.Compare())//визначення порушень в аналізах
                {
                    Console.Clear();
                    Console.WriteLine("=====All recommendation from system Electronic Medician=====");
                    Console.WriteLine(syst.RecomendationOfTreatment());//Виведення рекомендацій системи
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("=====INVITATION=====");
                    Console.WriteLine(syst.InvitationToDoctor);//Запрошення до лікаря

                    do
                    {
                        try
                        {
                            Console.WriteLine("Will you go to the doctor? y/n");
                            InputString = Console.ReadLine();
                            if (InputString != "y" && InputString != "n")
                            {
                                throw new Exception("You should choose 'y' or 'n'");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.ReadLine();
                        }
                    } while (InputString != "y" && InputString != "n");

                    //==========Проходження огляду у лікуючого лікаря============
                    if(InputString=="y")
                    {
                        string diagnos;
                        Console.Clear();
                        user.VisitDoctor();
                        diagnos = clinic.medic[0].Examination();
                        syst.card[0].SetDiagnos(diagnos);
                        Console.WriteLine("Result of examination in doctor: {0}", diagnos);
                        syst.card[0].SetAppointment(clinic.medic[0].MakeAppointment());
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Ok. You will not visit to doctor. You have such right.");
                        Console.ReadLine();
                    }
                    //=============================================================
                }
                else
                {
                    Console.WriteLine("All results is normal");
                    Console.ReadLine();
                }

                //==========Визначення періоду для планових оглядів=============
                if(syst.card[0].GetSizeChronicIllnes()!=0)
                {
                    periodOfVisit = 6;
                    syst.card[0].LastVisit = rand.Next(4, 7);
                }
                else
                {
                    periodOfVisit = 12;
                    syst.card[0].LastVisit = rand.Next(10, 13);
                }
                //===========================================================

                //==========Проходження планового медичного огляду==========
                if(syst.card[0] == periodOfVisit)
                {
                    Console.Clear();
                    do
                    {
                        try
                        {
                            Console.WriteLine("Your last medical examination was {0} month ago. Will you go to the examination? y/n");
                            InputString = Console.ReadLine();
                            if(InputString != "y" && InputString != "n")
                            {
                                throw new Exception("You should choose 'y' or 'n'");
                            }
                        }catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.ReadLine();
                        }
                    } while (InputString != "y" && InputString != "n");

                    if(InputString == "y")
                    {
                        Console.Clear();
                        Console.WriteLine("====You will be going to the clinic====");
                        user.Survey();//проходження огляду в клінікі

                        //=========Визначення результату обстеження=============
                        switch(rand.Next(1,4))
                        {
                            case 1:
                                syst.ResultsOfSurvey("Everythink is ok. All results is normal");//встановлення результату огляду
                                Console.ReadLine();
                                break;
                            case 2:
                                syst.ResultsOfSurvey("You have some bad results of analysis. You should visit to your treatment doctor");//встановлення результату огляду
                                Console.ReadLine();
                                break;
                            case 3:
                                //=============Перевірка коректності вводу================        
                                 syst.ResultsOfSurvey("Results of analysis are not normal. We recommend going to clinic.");

                                 do
                                 {
                                     try
                                     {
                                         Console.WriteLine("Are you agree? y/n");
                                         InputString = Console.ReadLine();
                                         if (InputString != "y" && InputString != "n")
                                         {
                                             throw new Exception("You should choose 'y' or 'n'");
                                         }
                                     }
                                     catch (Exception ex)
                                     {
                                         Console.WriteLine(ex.Message);
                                         Console.ReadLine();
                                     }
                                 } while (InputString != "y" && InputString != "n");
                                //==========================================================
                                break;
                            default:
                                break;
                        }
                        //==================================
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You won't be going to the clinic. It's your choice");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Your last medical examination was {0} month ago.\nAfter {1}  month will be examination in clinic",syst.card[0].LastVisit,periodOfVisit - syst.card[0].LastVisit);
                    Console.ReadLine();
                }

                //=============================================================

                Console.Clear();

                do
                {
                    Console.WriteLine("Choose one of variety:\n1 - Change data in electronic card\n2 - Show information from electronic card\n3 - Next Step");
                    InputString = Console.ReadLine();

                    switch (InputString)
					{
					case "1":
						syst.card[0].Change();//зміна даних в картці
						break;
					case "2":
						syst.card[0].Read();//виведення даних з картки
						Console.ReadLine();
						break;
					case "3":
						break;
					default:
						Console.WriteLine("Please, choose one of the variants");
						break;
					}
                }while(InputString!="3");
            
                Console.ReadLine();

                Console.Clear();

                do
                {
                    try
                    {
                        Console.WriteLine("Do you wanna repeat the program? y/n");
                        InputString = Console.ReadLine();
                        if (InputString != "y" && InputString != "n")
                        {
                            throw new Exception("You should choose 'y' or 'n'");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                    }
                } while (InputString != "y" && InputString != "n");

            } while (InputString == "y");

            Console.ReadLine();
            }
        }

    }

