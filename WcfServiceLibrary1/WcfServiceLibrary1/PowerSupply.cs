﻿using Newtonsoft.Json;
using Npgsql;
using System;
using System.ServiceModel;
using System.Text.RegularExpressions;

namespace WcfServiceLibrary1
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class PowerSupply : SPowerSupply
    {
        string Manufacturer = "";
        string Model = "";
        string Power = "";

        public string PowerSupply_Manufacturer
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

        public string PowerSupply_Model
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

        public string PowerSupply_Power
        {
            get
            {
                return Power;
            }

            set
            {
                Power = value;
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
            string SQL = "INSERT INTO public.powersupply(manufacturer, model, power, is_del) VALUES(@manufacturer, @model, @power, false);";
            command.CommandText = SQL;
            string id_manufacturer = GetManufacturerID(Manufacturer);
            command.Parameters.AddWithValue("@manufacturer", id_manufacturer);
            command.Parameters.AddWithValue("@model", Model);
            command.Parameters.AddWithValue("@power", Power);
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
            string SQL = "UPDATE public.powersupply SET manufacturer = @manufacturer, power = @power WHERE model = @model; ";
            command.CommandText = SQL;
            string id_manufacturer = GetManufacturerID(Manufacturer);
            command.Parameters.AddWithValue("@manufacturer", id_manufacturer);
            command.Parameters.AddWithValue("@power", Power);
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
            NpgsqlCommand command = new NpgsqlCommand("SELECT manufacturer.name, powersupply.model, powersupply.power FROM public.powersupply, public.manufacturer WHERE (powersupply.is_del=false) and powersupply.manufacturer = manufacturer.id LIMIT 1000", conn);
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
            string SQL = "SELECT manufacturer.name, powersupply.model, powersupply.power FROM public.powersupply, public.manufacturer WHERE (powersupply.is_del=false) and (powersupply.manufacturer = manufacturer.id) and (model = @model);";
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
                            Power = Regex.Replace(Convert.ToString(reader.GetValue(2)), "[ ]+", " ");
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
            string SQL = "UPDATE public.powersupply SET is_del = true WHERE model=@model;";
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
            return Manufacturer + " " + Model + " " + Power;
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
