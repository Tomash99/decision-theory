using System;
using System.Collections;
using System.IO;

namespace derevomykola
{
    class Program
    {
       static double[] fileData;
        public static void Main(string[] args)
        {
            GetData();
            
            ArrayList one = new ArrayList(); // для запису результатів всіх попередніх методів (доходів )
            one.Add(First());
            one.Add(Second());
            one.Add(Third());
            one.Add(Fourth());

            ArrayList two = new ArrayList(); // для запису назв варіантів
            two.Add("Варiант A");
            two.Add("Варiант B");
            two.Add("Варiант C(а)");
            two.Add("Варiант C(b)");

            ArrayList onee = new ArrayList();
            onee.AddRange(one);
            onee.Sort();
            double max = (double)onee[3];
            int maxindex = one.IndexOf(max);
            string variant = (string)two[maxindex];

            Console.WriteLine($"Найкращий варiант розвитку - {variant}, з доходом в {max} тис.");

        }

        public static double[] GetData() // метод для зчитування і запису чисел в масив 
        {
            string filePath = Path.GetFullPath("1.txt");

            using var fileReader = new StreamReader(filePath);
            string file = fileReader.ReadToEnd();
            string[] lines = file.Split('\n');

             fileData = new double[lines.Length];

            for (int i = 0; i < fileData.Length; i++)
            {
                fileData[i] = Convert.ToDouble(lines[i]);
            }
            return fileData; 
        }

           public static double First()
            { 
                GetData();
                int n = 5;
                double m1 = fileData[0], d1 = fileData[1], p1 = fileData[2], d2 = fileData[3], p2 = fileData[4];


                double dohid1 = d1 * n;
                double zbutku1 = d2 * n;
                double clean_dohid1 = (p1 * dohid1 + p2 * zbutku1) - m1;

                Console.WriteLine($"Дохiд при розвитку подiй А = {clean_dohid1} тис.");
            Console.WriteLine($"m1={m1} d1={d1} p1={p1} d2={d2} p2={p2}");
            return clean_dohid1;

            }


            public static double Second() 
            {  
                GetData();
                int n = 5;

                double m2 = fileData[5], d1 = fileData[6], p1 = fileData[7], d2 = fileData[8], p2 = fileData[9];

                double dohid2 = d1 * n;
                double zbutku2 = d2 * n;
                double clean_dohid2 = (p1 * dohid2 + p2 * zbutku2) - m2;
                Console.WriteLine($"Дохiд при розвитку подiй B = {clean_dohid2} тис.");
            Console.WriteLine($"m2={m2} d1={d1} p1={p1} d2={d2} p2={p2}");
                return clean_dohid2;
            }


        
             public static double Third()
             {
                GetData();
                int n = 4; 
            double m1 = fileData[0], d1 = fileData[1], p1 = fileData[12], d2 = fileData[3], p2 = fileData[13], p3 = fileData[10];
                      
                double dohid3 = d1 * n,
                       zbutku3 = d2 * n,
                       clean_dohid3 = p3 * (p1 * dohid3 + p2 * zbutku3 - m1);
                Console.WriteLine($"Дохiд при розвитку подiй C(а) = {clean_dohid3} тис.");
          
          
            return clean_dohid3;
             }



            public static double Fourth()
            {
                GetData();
            int n = 4; 

               double m2 = fileData[5], d1 = fileData[6], p1 = fileData[12], d2 = fileData[8], p2 = fileData[13],p3 = fileData[10];
                

                double dohid4 = d1 * n;
                double zbutku4 = d2 * n;
                double clean_dohid4 = p3 * ((p1 * dohid4 + p2 * zbutku4) - m2);

                Console.WriteLine($"Дохiд при розвитку подiй C(b) = {clean_dohid4} тис.");
               return clean_dohid4;
            }
            


           

      
    }
}
