using Newtonsoft.Json;
using Npgsql;
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text.RegularExpressions;

namespace WcfServiceLibrary1
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Computer : SComputer
    {
        string Name = "";
        string Videocard = "";
        string Powersupply = "";
        string Housing = "";
        string Harddrive = "";
        string Diskstorage = "";
        string Processor = "";
        string Ram = "";
        string Motherboard = "";

        public void NewComputer(string name, string videocard, string powersupply, string housing, string harddrive, string diskstorage, string processor, string ram, string motherboard)
        {
            Name = name;
            Videocard = videocard;
            Powersupply = powersupply;
            Housing = housing;
            Harddrive = harddrive;
            Diskstorage = diskstorage;
            Processor = processor;
            Ram = ram;
            Motherboard = motherboard;
        }
        
        public string C_Name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public string VideocardModel
        {
            get
            {
                return Videocard;
            }

            set
            {
                Videocard = value;
            }
        }

        public string PowersupplyModel
        {
            get
            {
                return Powersupply;
            }

            set
            {
                Powersupply = value;
            }
        }

        public string HousingModel
        {
            get
            {
                return Housing;
            }

            set
            {
                Housing = value;
            }
        }

        public string HarddriveModel
        {
            get
            {
                return Harddrive;
            }

            set
            {
                Harddrive = value;
            }
        }

        public string DiskstorageModel
        {
            get
            {
                return Diskstorage;
            }

            set
            {
                Diskstorage = value;
            }
        }

        public string ProcessorModel
        {
            get
            {
                return Processor;
            }

            set
            {
                Processor = value;
            }
        }

        public string RamModel
        {
            get
            {
                return Ram;
            }

            set
            {
                Ram = value;
            }
        }

        public string MotherboardModel
        {
            get
            {
                return Motherboard;
            }

            set
            {
                Motherboard = value;
            }
        }

        public string toString()
        {
            return Name + " " + Videocard + " " + Powersupply + " " + Housing + " " + Harddrive + " " + Diskstorage + " " + Processor + " " + Ram + " " + Motherboard;
        }
        
        public void Save()
        {
            if (Name == "")
            {
                throw new Exception("Объект не создан!");
            }
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "INSERT INTO public.computer(name, id_videocard, id_powersupply, id_housing, id_harddrive, id_diskstorage, id_processor, id_ram, id_motherboard, is_del) VALUES(@name, @id_videocard, @id_powersupply, @id_housing, @id_harddrive, @id_diskstorage, @id_processor, @id_ram, @id_motherboard, false); ";
            command.CommandText = SQL;
            int id_videocard = GetVideocardID(Videocard);
            int id_powersupply = GetPowersupplyID(Powersupply);
            int id_housing = GetHousingID(Housing);
            int id_harddrive = GetHarddriveID(Harddrive);
            int id_diskstorage = GetDiskstorageID(Diskstorage);
            int id_processor = GetProcessorID(Processor);
            int id_ram = GetRamID(Ram);
            int id_motherboard = GetMotherboardID(Motherboard);
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@id_videocard", id_videocard);
            command.Parameters.AddWithValue("@id_powersupply", id_powersupply);
            command.Parameters.AddWithValue("@id_housing", id_housing);
            command.Parameters.AddWithValue("@id_harddrive", id_harddrive);
            command.Parameters.AddWithValue("@id_diskstorage", id_diskstorage);
            command.Parameters.AddWithValue("@id_processor", id_processor);
            command.Parameters.AddWithValue("@id_ram", id_ram);
            command.Parameters.AddWithValue("@id_motherboard", id_motherboard);
            command.Connection = conn;
            NpgsqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                reader.Close();
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public void Update(string name)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();            
            string SQL = "UPDATE public.computer SET id_videocard = @id_videocard, id_powersupply = @id_powersupply, id_housing = @id_housing, id_harddrive = @id_harddrive, id_diskstorage = @id_diskstorage, id_processor = @id_processor, id_ram = @id_ram, id_motherboard = @id_motherboard WHERE name = @name;";
            command.CommandText = SQL;
            int id_videocard = GetVideocardID(Videocard);
            int id_powersupply = GetPowersupplyID(Powersupply);
            int id_housing = GetHousingID(Housing);
            int id_harddrive = GetHarddriveID(Harddrive);
            int id_diskstorage = GetDiskstorageID(Diskstorage);
            int id_processor = GetProcessorID(Processor);
            int id_ram = GetRamID(Ram);
            int id_motherboard = GetMotherboardID(Motherboard);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@id_videocard", id_videocard);
            command.Parameters.AddWithValue("@id_powersupply", id_powersupply);
            command.Parameters.AddWithValue("@id_housing", id_housing);
            command.Parameters.AddWithValue("@id_harddrive", id_harddrive);
            command.Parameters.AddWithValue("@id_diskstorage", id_diskstorage);
            command.Parameters.AddWithValue("@id_processor", id_processor);
            command.Parameters.AddWithValue("@id_ram", id_ram);
            command.Parameters.AddWithValue("@id_motherboard", id_motherboard);
            command.Connection = conn;
            NpgsqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                reader.Close();
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        
        public string get()
        {
            string[,] mas = new string[9, 110000];
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand("SELECT computer.name, videocard.model, powersupply.model, housing.model, harddrive.model, diskstorage.model, processor.model, ram.model, motherboard.model  FROM public.computer, public.videocard, public.powersupply, public.housing, public.harddrive, public.diskstorage, public.processor, public.ram, public.motherboard  WHERE(computer.id_videocard = videocard.id) and(computer.id_powersupply = powersupply.id) and(computer.id_housing = housing.id) and(computer.id_harddrive = harddrive.id) and(computer.id_diskstorage = diskstorage.id) and(computer.id_processor = processor.id) and(computer.id_ram = ram.id) and(computer.id_motherboard = motherboard.id) and(computer.is_del = false);", conn);
            NpgsqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                int i = reader.VisibleFieldCount;

                if (i > 0 && reader.HasRows)
                {
                    for (int l = 0; l < i; l++)
                        mas[l, 0] = reader.GetName(l);

                    int row = 1;
                    while (reader.Read())
                    {
                        for (int cell = 0; cell < i; cell++)
                        {
                            //Array.Resize<int>(ref mas, mas.Length + 2);
                            mas[cell, row] = Regex.Replace(Convert.ToString(reader.GetValue(cell)), "[ ]+", " "); 
                        }
                        row++;
                    }
                }
                else throw new Exception("Таких записей не найдено!");
                reader.Close();
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
            finally
            {
                conn.Close();
            }
            return JsonConvert.SerializeObject(mas);
        }

        public string getByName(string name)
        {
            string[,] mas = new string[10, 3];
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand("SELECT computer.name, videocard.model, powersupply.model, housing.model, harddrive.model, diskstorage.model, processor.model, ram.model, motherboard.model  FROM public.computer, public.videocard, public.powersupply, public.housing, public.harddrive, public.diskstorage, public.processor, public.ram, public.motherboard  WHERE(computer.id_videocard = videocard.id) and(computer.id_powersupply = powersupply.id) and(computer.id_housing = housing.id) and(computer.id_harddrive = harddrive.id) and(computer.id_diskstorage = diskstorage.id) and(computer.id_processor = processor.id) and(computer.id_ram = ram.id) and(computer.id_motherboard = motherboard.id) and(computer.is_del = false) and (computer.name = @name);", conn);
            NpgsqlDataReader reader = null;
            command.Parameters.AddWithValue("@name", name);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                int i = reader.VisibleFieldCount;

                if (i > 0 && reader.HasRows)
                {
                    for (int l = 0; l < i; l++)
                        mas[l, 0] = reader.GetName(l);

                    int row = 1;
                    while (reader.Read())
                    {
                        for (int cell = 0; cell < i; cell++)
                        {
                            mas[cell, row] = Regex.Replace(Convert.ToString(reader.GetValue(cell)), "[ ]+", " "); 
                            Name = Regex.Replace(Convert.ToString(reader.GetValue(0)), "[ ]+", " "); 
                            Videocard = Regex.Replace(Convert.ToString(reader.GetValue(1)), "[ ]+", " "); 
                            Powersupply = Regex.Replace(Convert.ToString(reader.GetValue(2)), "[ ]+", " "); 
                            Housing = Regex.Replace(Convert.ToString(reader.GetValue(3)), "[ ]+", " "); 
                            Harddrive = Regex.Replace(Convert.ToString(reader.GetValue(4)), "[ ]+", " "); 
                            Diskstorage = Regex.Replace(Convert.ToString(reader.GetValue(5)), "[ ]+", " "); 
                            Processor = Regex.Replace(Convert.ToString(reader.GetValue(6)), "[ ]+", " "); 
                            Ram = Regex.Replace(Convert.ToString(reader.GetValue(7)), "[ ]+", " "); 
                            Motherboard = Regex.Replace(Convert.ToString(reader.GetValue(8)), "[ ]+", " "); 
                        }
                        row++;
                    }
                }
                else throw new Exception("Таких записей не найдено!");
                reader.Close();
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
            finally
            {
                conn.Close();
            }
            return JsonConvert.SerializeObject(mas);
        }

        public void delete(string name)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "UPDATE public.computer SET is_del = true WHERE name=@name;";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@name", name);
            command.Connection = conn;
            NpgsqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                reader.Close();
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private int GetVideocardID(string model)
        {
            int id = 0;
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "SELECT id FROM videocard WHERE model=@model";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@model", model);
            command.Connection = conn;
            NpgsqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private int GetPowersupplyID(string model)
        {
            int id = 0;
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "SELECT id FROM powersupply WHERE model=@model";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@model", model);
            command.Connection = conn;
            NpgsqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private int GetHousingID(string model)
        {
            int id = 0;
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "SELECT id FROM housing WHERE model=@model";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@model", model);
            command.Connection = conn;
            NpgsqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private int GetHarddriveID(string model)
        {
            int id = 0;
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "SELECT id FROM harddrive WHERE model=@model";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@model", model);
            command.Connection = conn;
            NpgsqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private int GetDiskstorageID(string model)
        {
            int id = 0;
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "SELECT id FROM diskstorage WHERE model=@model";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@model", model);
            command.Connection = conn;
            NpgsqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private int GetProcessorID(string model)
        {
            int id = 0;
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "SELECT id FROM processor WHERE model=@model";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@model", model);
            command.Connection = conn;
            NpgsqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private int GetRamID(string model)
        {
            int id = 0;
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "SELECT id FROM ram WHERE model=@model";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@model", model);
            command.Connection = conn;
            NpgsqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private int GetMotherboardID(string model)
        {
            int id = 0;
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "SELECT id FROM motherboard WHERE model=@model";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@model", model);
            command.Connection = conn;
            NpgsqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

    }
}
