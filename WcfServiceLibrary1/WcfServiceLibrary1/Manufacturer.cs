using Newtonsoft.Json;
using Npgsql;
using System;
using System.ServiceModel;


namespace WcfServiceLibrary1
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Manufacturer : SManufacturer
    {
        string Name = "";
        string Country = "";

        public void NewManufacturer(string name, string country)
        {            
            Name = name;
            Country = country;
        }

        public void Save()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "INSERT INTO public.manufacturer(name, country, is_del) VALUES(@name, @country, false);";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@country", Country);
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

        public void Update(string newname, string country, string oldname)
        {            
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "UPDATE public.manufacturer name=@newname, country=@country WHERE name=@oldname;";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@newname", newname);
            command.Parameters.AddWithValue("@country", country);
            command.Parameters.AddWithValue("@oldname", oldname);
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
            string[,] mas = new string[2, 1000];
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand("SELECT name, country FROM manufacturer WHERE is_del=false LIMIT 1000", conn);
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

        public void delete(string name)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=Admin;Password=Admin;Database=computers;");
            NpgsqlCommand command = new NpgsqlCommand();
            string SQL = "UPDATE public.manufacturer SET is_del = true WHERE name=@oldname;";
            command.CommandText = SQL;
            command.Parameters.AddWithValue("@oldname", name);
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
            return Name +" "+ Country;
        }

    }
}
