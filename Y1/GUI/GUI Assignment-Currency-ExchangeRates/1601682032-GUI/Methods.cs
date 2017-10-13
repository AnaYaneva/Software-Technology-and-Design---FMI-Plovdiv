using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace _1601682032_GUI
{
    public class Methods
    {
        public static void EnterData()
        {
            string line = Console.ReadLine();

            while (!line.Equals(""))
            {
                string[] info = line.Split('-');
                Vars.data.Add(new Data(info[0], Convert.ToDateTime(info[1]), double.Parse(info[2])));
                line = Console.ReadLine();
            }
        }

        public static void SaveDataSerialized()
        {
            try
            {
                using (FileStream stream = new FileStream(Vars.fileNameSerialized, FileMode.Truncate))//
                {

                }

                using (Stream stream = File.Open(Vars.fileNameSerialized, FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, Vars.data);
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }

        public static void ReadDataSerialized()
        {
            try
            {
                using (FileStream stream = new FileStream(Vars.fileNameSerialized, FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    Vars.data.Clear();
                    Vars.data = (List<Data>)bin.Deserialize(stream);

                }
            }

            catch (IOException e)
            {
                //MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
            }
        }

        public static void ReadData()
        {
            Vars.data.Clear();

            using (FileStream stream = new FileStream(Vars.fileNameUnserialized, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] tokens = reader.ReadLine().Split('-');
                        string currency = tokens[0].Trim();
                        DateTime date = DateTime.Parse(tokens[1]);
                        double exRate = double.Parse(tokens[2]);

                        Vars.data.Add(new Data(currency, date, exRate));
                    }
                }
            }
        }

        public static void ReadData(string filename)
        {
            Vars.data.Clear();

            using (FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] tokens = reader.ReadLine().Split('-');
                        string currency = tokens[0].Trim();
                        //DateTime date = DateTime.ParseExact(tokens[1], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                        DateTime date = DateTime.Parse(tokens[1]);
                        double exRate = double.Parse(tokens[2]);

                        Vars.data.Add(new Data(currency, date, exRate));
                    }
                }
            }
        }

        public static void SaveData()
        {
            Vars.data = Vars.data.OrderBy(d => d.currency)
                           .ThenByDescending(d => d.date).ToList();

            using (FileStream stream = new FileStream(Vars.fileNameUnserialized, FileMode.Truncate))//
            {

            }

            using (FileStream stream = new FileStream(Vars.fileNameUnserialized, FileMode.Append))//
            {
                using (StreamWriter writer = new StreamWriter(stream))//
                {
                    foreach (var item in Vars.data)
                    {
                        writer.WriteLine($"{item.currency} - {item.date.ToString("dd/MM/yyyy")} - {item.exchangeRate:N3}");
                    }
                }
            }
        }

        public static void SaveData(string filename)
        {
            Vars.data = Vars.data.OrderBy(d => d.currency)
                           .ThenByDescending(d => d.date).ToList();

            using (FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))//
            {

            }
            using (FileStream stream = new FileStream(filename, FileMode.Truncate))//
            {

            }

            using (FileStream stream = new FileStream(filename, FileMode.Append))//
            {
                using (StreamWriter writer = new StreamWriter(stream))//
                {
                    foreach (var item in Vars.data)
                    {
                        writer.WriteLine($"{item.currency} - {item.date.ToString("dd/MM/yyyy")} - {item.exchangeRate:N3}");
                    }
                }
            }
        }

        public static void MessageSaved()
        {
            MessageBox.Show("Данните са записани", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
    