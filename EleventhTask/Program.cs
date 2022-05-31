using System;

namespace EleventhTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите количество усредняемых пиздюлей, которое вы получите от жизни, если не будете читать:");
            string пиздюлиныinput = Console.ReadLine();
            int пиздюлины = Convert.ToInt32(пиздюлиныinput);
            Console.WriteLine();
            double[] doublesArray = new double[пиздюлины];
            for (int i = 0; i < пиздюлины; i++)
            {
                Console.Write(" введите число типа double №" + i + 1 + ": ");
                string val = Console.ReadLine();
                double value = Convert.ToDouble(val);
                doublesArray[i] = value;
            }
            double sum = 0;
            for (int i = 0; i < пиздюлины; i++)
            {
                sum = sum + doublesArray[i];
            }

            double average = sum / пиздюлины;
            Console.WriteLine();
            Console.Write(average + " является средним числом пиздюлей из " + doublesArray[0]);
            for (int i = 1; i<пиздюлины; i++)
            {
                Console.Write("+" + doublesArray[i]);
            }
            Console.WriteLine(") / " + пиздюлины);
            Console.WriteLine("нажмите <enter> для выхода в окно, если вы после этого не сели читать блять,ведь вы ленивый пидорас . . .");
            Console.Read();

        }
    }
}