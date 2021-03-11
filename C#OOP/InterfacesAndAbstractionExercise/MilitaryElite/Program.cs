using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<ISoldier> list = new List<ISoldier>();
            List<Private> privates = new List<Private>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                string soldier = input[0];
                string id = input[1]; 
                string firstName = input[2];
                string lastName = input[3];                

                switch (soldier)
                {
                    case "Private":
                        decimal salary = decimal.Parse(input[4]);
                        Private privat = new Private(id, firstName, lastName, salary);
                        privates.Add(privat);
                        list.Add(privat);
                        break;

                    case "LieutenantGeneral":
                        decimal salaryLieut = decimal.Parse(input[4]);
                        LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salaryLieut);
                        string[] privatesIds = input.Skip(5).ToArray();
                        
                        for (int i = 0; i < privatesIds.Length; i++)
                        {
                            foreach (var privateSoldier in privates)
                            {
                                if (privateSoldier.Id == privatesIds[i])
                                {
                                    lieutenantGeneral.Privates.Add(privateSoldier);
                                }
                            }                          
                        }
                        list.Add(lieutenantGeneral);
                        break;

                    case "Engineer":
                        string corps = input[5];
                        if (corps == "Airforces" || corps == "Marines")
                        {
                            decimal salaryEngi = decimal.Parse(input[4]);
                            Engineer engineer = new Engineer(id, firstName, lastName, salaryEngi, corps);
                            string[] repairs = input.Skip(6).ToArray();

                            for (int i = 0; i < repairs.Length; i += 2)
                            {
                                string partName = repairs[i];
                                int workedHours = int.Parse(repairs[i + 1]);

                                Repair repair = new Repair(partName, workedHours);
                                engineer.Repairs.Add(repair);
                            }
                            list.Add(engineer);
                        }
                        
                        break;

                    case "Commando":
                        string corpsComm = input[5];
                        if (corpsComm == "Airforces" || corpsComm == "Marines")
                        {
                            decimal salaryComm = decimal.Parse(input[4]);
                            Commando commando = new Commando(id, firstName, lastName, salaryComm, corpsComm);
                            string[] missions = input.Skip(6).ToArray();

                            for (int i = 0; i < missions.Length; i += 2)
                            {
                                string codeName = missions[i];
                                string state = missions[i + 1];

                                if (state == "inProgress" || state == "Finished")
                                {
                                    Mission mission = new Mission(codeName, state);
                                    commando.Missions.Add(mission);
                                }    
                            }
                            list.Add(commando);
                        }
                        break;

                    case "Spy":
                        int codeNumber = int.Parse(input[4]);
                        Spy spy = new Spy(id, firstName, lastName, codeNumber);
                        list.Add(spy);
                        break;
                }


                input = Console.ReadLine().Split();
            }

            foreach (var soldier in list)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
