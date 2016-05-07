using Newtonsoft.Json;
using Npgsql;
using System;
using System.ServiceModel;

namespace WcfServiceLibrary1
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Videocard : SVideocard
    {
        string Manufacturer = "";
        string Model = "";
        string Memory = "";
        string Clock_Freq = "";
        string Memory_type = "";

        public void NewVideocard(string manufacturer, string model, string memory, string clock_Freq, string memory_type)
        {
            Manufacturer = manufacturer;
            Model = model;
            Memory = memory;
            Clock_Freq = clock_Freq;
            Memory_type = memory_type;
        }

        public void Save()
        {
            if (Manufacturer == "" || Model == "")
            {
                throw new Exception("Объект не создан!");
            }
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "INSERT INTO public.videocard(manufacturer, model, memory, clock_freq, memory_type, is_del) VALUES(@manufacturer, @model, @memory, @clock_freq, @memory_type, false);";
            command.CommandText = SQL;
            string id_manufacturer = GetManufacturerID(Manufacturer);
            command.Parameters.AddWithValue("@manufacturer", id_manufacturer);
            command.Parameters.AddWithValue("@model", Model);
            command.Parameters.AddWithValue("@memory", Memory);
            command.Parameters.AddWithValue("@clock_freq", Clock_Freq);
            command.Parameters.AddWithValue("@memory_type", Memory_type);
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

        public void Update(string manufacturer, string newmodel, string memory, string clock_Freq, string memory_type, string oldmodel)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "UPDATE public.videocard SET manufacturer = @manufacturer, model = @model, memory = @memory, clock_freq = @clock_freq, memory_type = @memory_type WHERE model = @oldmodel; ";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@manufacturer", manufacturer);
            command.Parameters.AddWithValue("@model", newmodel);
            command.Parameters.AddWithValue("@memory", memory);
            command.Parameters.AddWithValue("@clock_freq", clock_Freq);
            command.Parameters.AddWithValue("@memory_type", memory_type);
            command.Parameters.AddWithValue("@oldmodel", oldmodel);
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
            NpgsqlCommand command = new NpgsqlCommand("SELECT manufacturer.name, videocard.model, videocard.memory, videocard.clock_freq, videocard.memory_type FROM public.videocard, public.manufacturer WHERE (videocard.is_del=false) and videocard.manufacturer = manufacturer.id LIMIT 1000", conn);
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
                            mas[cell, row] = Convert.ToString(reader.GetValue(cell));
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
            string SQL = "UPDATE public.videocard SET is_del = true WHERE model=@model;";
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
            return Manufacturer + " " + Model + " " + Memory + " " + Clock_Freq + " " + Memory_type;
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
