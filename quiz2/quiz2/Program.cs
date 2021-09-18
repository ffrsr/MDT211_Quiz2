using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int InputNumRose = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Total Rose :{0}", InputNumRose);
            int InputNUmSunFlower = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Total Sun Flower :{0}",InputNUmSunFlower);

            List<DataRose> dataRoses = new List<DataRose>();
            DataRose WhiteRose = new DataRose(1, "ดอกกุหลาบสีขาว", "สวยงามมาก", 2, "10.5", "6");

            List<DataSunFlower> dataSunFlowers = new List<DataSunFlower>();
            DataSunFlower SmallSunFlower = new DataSunFlower(1, "ดอกทานตะวันเล็ก", "สวยงาม", 1, "2.0", "2.0");

            dataRoses.Add(WhiteRose);
            dataSunFlowers.Add(SmallSunFlower);

            foreach(DataRose dataRose in dataRoses)
            {
                Console.WriteLine("ID :{0} ",dataRose.ID);
                Console.WriteLine("Plant name :{0} ", dataRose.Name);
                Console.WriteLine("Plant description :{0} ", dataRose.Description);
                Console.WriteLine("Amount :{0} ", dataRose.Amount);
                Console.WriteLine("Height :{0} ", dataRose.Height);
                Console.WriteLine("Circumference :{0} ", dataRose.Circumference);
            }

            foreach (DataSunFlower dataSunFlower in dataSunFlowers)
            {
                Console.WriteLine("ID :{0} ", dataSunFlower.ID);
                Console.WriteLine("Plant name :{0} ", dataSunFlower.Name);
                Console.WriteLine("Plant description :{0} ", dataSunFlower.Description);
                Console.WriteLine("Amount :{0} ", dataSunFlower.Amount);
                Console.WriteLine("Height :{0} ", dataSunFlower.Height);
                Console.WriteLine("Circumference :{0} ", dataSunFlower.Circumference);
            }

            Console.ReadLine();
        }
    }

    class DataRose
    {
        public int ID;
        public string Name;
        public string Description;
        public int Amount;
        public string Height;
        public string Circumference;

        
        public DataRose(int valueID, string valueName, string valueDescription, int valueAmount, string valueHeight, string valueCircumference)
        {
            ID = valueID;
            Name = valueName;
            Description = valueDescription;
            Amount = valueAmount;
            Height = valueHeight;
            Circumference = valueCircumference;
            
        }

    }

    class DataSunFlower
    {
        public int ID;
        public string Name;
        public string Description;
        public int Amount;
        public string Height;
        public string Circumference;


        public DataSunFlower(int valueID, string valueName, string valueDescription, int valueAmount, string valueHeight, string valueCircumference)
        {
            ID = valueID;
            Name = valueName;
            Description = valueDescription;
            Amount = valueAmount;
            Height = valueHeight;
            Circumference = valueCircumference;

        }
    }
}
