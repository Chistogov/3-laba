using Newtonsoft.Json;
using Npgsql;
using System;
using System.ServiceModel;
using System.Text.RegularExpressions;

namespace WcfServiceLibrary1
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Processor : SProcessor
    {
        string Manufacturer = "";
        string Model = "";
        string Socket = "";
        string Clock_Freq = "";
        string Cache = "";

        public string Processor_Manufacturer
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

        public string Processor_Model
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

        public string Processor_Socket
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

        public string Processor_Clock_Freq
        {
            get
            {
                return Clock_Freq;
            }

            set
            {
                Clock_Freq = value;
            }
        }

        public string Processor_Cache
        {
            get
            {
                return Cache;
            }

            set
            {
                Cache = value;
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
            string SQL = "INSERT INTO public.processor(manufacturer, model, socket, clock_freq, cache, is_del) VALUES(@manufacturer, @model, @socket, @clock_freq, @cache, false); ";
            command.CommandText = SQL;
            string id_manufacturer = GetManufacturerID(Manufacturer);
            command.Parameters.AddWithValue("@manufacturer", id_manufacturer);
            command.Parameters.AddWithValue("@model", Model);
            command.Parameters.AddWithValue("@socket", Socket);
            command.Parameters.AddWithValue("@clock_freq", Clock_Freq);
            command.Parameters.AddWithValue("@cache", Cache);
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
            string SQL = "UPDATE public.processor SET manufacturer = @manufacturer, socket = @socket, clock_freq = @clock_freq, cache = @cache WHERE model = @model;";
            command.CommandText = SQL;
            string id_manufacturer = GetManufacturerID(Manufacturer);
            command.Parameters.AddWithValue("@manufacturer", id_manufacturer);
            command.Parameters.AddWithValue("@socket", Socket);
            command.Parameters.AddWithValue("@clock_freq", Clock_Freq);
            command.Parameters.AddWithValue("@cache", Cache);
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
            string[,] mas = new string[5, 1000];
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand("SELECT manufacturer.name, processor.model, processor.socket, processor.clock_freq, processor.cache FROM public.processor, public.manufacturer WHERE (processor.is_del=false) and processor.manufacturer = manufacturer.id LIMIT 1000", conn);
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
            string SQL = "SELECT manufacturer.name, processor.model, processor.socket, processor.clock_freq, processor.cache FROM public.processor, public.manufacturer WHERE (processor.is_del=false) and (processor.manufacturer = manufacturer.id) and (model = @model);";
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
                            Clock_Freq = Regex.Replace(Convert.ToString(reader.GetValue(3)), "[ ]+", " ");
                            Cache = Regex.Replace(Convert.ToString(reader.GetValue(4)), "[ ]+", " "); ;
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
            string SQL = "UPDATE public.processor SET is_del = true WHERE model=@model;";
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
            return Manufacturer + " " + Model + " " + Socket + " " + Clock_Freq + " " + Cache;
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
