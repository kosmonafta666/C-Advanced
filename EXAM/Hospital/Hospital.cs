namespace Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Hospital
    {
        public static void Main(string[] args)
        {
            //dictionary for doctor;
            var doctors = new Dictionary<string, HashSet<string>>();

            //dictionary for department;
            var departments = new Dictionary<string, HashSet<string>>();

            //var for patients count;
            var patientCount = 0;

            //read the commands;
            var command = "";

            while ((command = Console.ReadLine()) != "Output")
            {
                //var for splitted command;
                var token = command
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var for department;
                var department = token[0];

                //var for doctor;
                var doctor = String.Format(@"{0} {1}", token[1], token[2]);

                //var for patient;
                var patient = token[3];

                patientCount++;

                //fill the doctors dictionary;
                if (!doctors.ContainsKey(doctor))
                {
                    doctors.Add(doctor, new HashSet<string>());

                    doctors[doctor].Add(patient);
                }
                else
                {
                    doctors[doctor].Add(patient);
                }

                //fill the department dictionary;
                if (!departments.ContainsKey(department)) 
                {
                    departments.Add(department, new HashSet<string>());

                    departments[department].Add(patient);
                }
                else
                {
                    if (departments[department].Count < 60)
                    {
                        departments[department].Add(patient);
                    }
                }

            }//end of first while loop;

            //read the output commands;
            var output = "";

            while ((output = Console.ReadLine()) != "End")
            {
                //var for splitted output;
                var token = output
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (token.Length == 2)
                {
                    //var for room number;
                    var roomNumber = 0;

                    //bool if second output is digit;
                    var isDigit = int.TryParse(token[1], out roomNumber);
                   
                    if (!isDigit)
                    {
                        //new collections for patients of the current doctor;
                        var patients = doctors[String.Format("{0} {1}", token[0], token[1])]
                            .OrderBy(x => x);

                        //print the doctor patients;
                        foreach (var patient in patients)
                        {
                            Console.WriteLine(patient);
                        }
                    }
                    else
                    {
                        //new collections for current room patients;
                        var currentRoom = departments[token[0]]
                            .Skip((roomNumber - 1) * 3)
                            .Take(3)
                            .OrderBy(x => x)
                            .ToList();

                        //print the currnet room patients;
                        foreach (var item in currentRoom)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
                else if (token.Length == 1)
                {
                    //new collections for current department patients;
                    var currentDepartment = departments[token[0]].ToList();

                    //print the current department patients;
                    foreach (var item in currentDepartment)
                    {
                        Console.WriteLine(item);
                    }
                }             
            }
        }
    }
}
