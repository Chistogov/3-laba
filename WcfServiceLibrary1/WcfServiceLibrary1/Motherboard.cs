using Newtonsoft.Json;
using Npgsql;
using System;
using System.ServiceModel;
using System.Text.RegularExpressions;

namespace WcfServiceLibrary1
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Motherboard : SMotherboard
    {
        string Manufacturer = "";
        string Model = "";
        string Socket = "";
        string Max_clock_freq = "";
        string Memory_type = "";
        string Bios = "";

        public string Motherboard_Manufacturer
        {
            get
            {
                return Manufacturer;
            }

            set
            {
                Manufacturer = value;
            }
        }

        public string Motherboard_Model
        {
            get
            {
                return Model;
            }

            set
            {
                Model = value;
            }
        }

        public string Motherboard_Socket
        {
            get
            {
                return Socket;
            }

            set
            {
                Socket = value;
            }
        }

        public string Motherboard_Max_clock_freq
        {
            get
            {
                return Max_clock_freq;
            }

            set
            {
                Max_clock_freq = value;
            }
        }

        public string Motherboard_Memory_type
        {
            get
            {
                return Memory_type;
            }

            set
            {
                Memory_type = value;
            }
        }

        public string Motherboard_Bios
        {
            get
            {
                return Bios;
            }

            set
            {
                Bios = value;
            }
        }

        public void Save()
        {
            if (Manufacturer == "" || Model == "")
            {
                throw new Exception("Объект не создан!");
            }
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "INSERT INTO public.motherboard(manufacturer, model, socket, max_clock_freq, memory_type, bios, is_del) VALUES(@manufacturer, @model, @socket, @max_clock_freq, @memory_type, @bios, false); ";
            command.CommandText = SQL;
            string id_manufacturer = GetManufacturerID(Manufacturer);
            command.Parameters.AddWithValue("@manufacturer", id_manufacturer);
            command.Parameters.AddWithValue("@model", Model);
            command.Parameters.AddWithValue("@socket", Socket);
            command.Parameters.AddWithValue("@max_clock_freq", Max_clock_freq);
            command.Parameters.AddWithValue("@memory_type", Memory_type);
            command.Parameters.AddWithValue("@bios", Bios);
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

        public void Update()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "UPDATE public.motherboard SET manufacturer = @manufacturer, socket = @socket, max_clock_freq = @max_clock_freq, memory_type = @memory_type, bios = @bios WHERE model = @model;";
            command.CommandText = SQL;
            string id_manufacturer = GetManufacturerID(Manufacturer);
            command.Parameters.AddWithValue("@manufacturer", id_manufacturer);
            command.Parameters.AddWithValue("@socket", Socket);
            command.Parameters.AddWithValue("@max_clock_freq", Max_clock_freq);
            command.Parameters.AddWithValue("@memory_type", Memory_type);
            command.Parameters.AddWithValue("@bios", Bios);
            command.Parameters.AddWithValue("@model", Model);
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
            string[,] mas = new string[7, 1000];
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand("SELECT manufacturer.name, motherboard.model, motherboard.socket, motherboard.max_clock_freq, motherboard.memory_type, motherboard.bios FROM public.motherboard, public.manufacturer WHERE (motherboard.is_del=false) and motherboard.manufacturer = manufacturer.id LIMIT 1000", conn);
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

        public string getByName(string model)
        {
            string[,] mas = new string[10, 3];
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "SELECT manufacturer.name, motherboard.model, motherboard.socket, motherboard.max_clock_freq, motherboard.memory_type, motherboard.bios FROM public.motherboard, public.manufacturer WHERE (motherboard.is_del=false) and (motherboard.manufacturer = manufacturer.id) and (model = @model);";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@model", model);
            command.Connection = conn;
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
                            mas[cell, row] = Regex.Replace(Convert.ToString(reader.GetValue(cell)), "[ ]+", " ");
                            Manufacturer = Regex.Replace(Convert.ToString(reader.GetValue(0)), "[ ]+", " ");
                            Model = Regex.Replace(Convert.ToString(reader.GetValue(1)), "[ ]+", " ");
                            Socket = Regex.Replace(Convert.ToString(reader.GetValue(2)), "[ ]+", " ");
                            Max_clock_freq = Regex.Replace(Convert.ToString(reader.GetValue(3)), "[ ]+", " ");
                            Memory_type = Regex.Replace(Convert.ToString(reader.GetValue(4)), "[ ]+", " ");
                            Bios = Regex.Replace(Convert.ToString(reader.GetValue(5)), "[ ]+", " ");
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

        public void delete(string model)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "UPDATE public.motherboard SET is_del = true WHERE model=@model;";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@model", model);
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

        public string toString()
        {
            return Manufacturer + " " + Model + " " + Socket + " " + Max_clock_freq + " " + Memory_type + " " + Bios;
        }

        private string GetManufacturerID(string name)
        {
            string id = "";
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "SELECT id FROM manufacturer WHERE name=@name";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@name", name);
            command.Connection = conn;
            NpgsqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToString(reader.GetValue(0));
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
