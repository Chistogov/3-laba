using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers
{
    public partial class UpdateComputer : Form
    {
        private Form1 refForm;
        public UpdateComputer(string name, Form1 refForm)
        {
            InitializeComponent();
            Name = name;
            this.refForm = refForm;
        }
        string Name = "";

        private void UpdateComputer_Load(object sender, EventArgs e)
        {
            try
            {
                loadProcessor();
                loadMotherboard();
                loadPowerSupply();
                loadRam();
                loadVideocard();
                loadHarddrive();
                loadDiskstorage();
                loadHousing();
                showOldConfig();
            }
            catch
            {
                MessageBox.Show("Нет отвера от сервера!");
                return;
            }
        }

        private void loadProcessor()
        {
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Processor/");
            var myChannelFactory = new ChannelFactory<Processor.SProcessor>(myBinding, myEndpoint);

            Processor.SProcessor client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 1; l < array.GetLength(1); l++)
                if (array[1, l] != null)
                    comboBox1.Items.Add(array[1, l]);

        }

        private void loadMotherboard()
        {
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Motherboard/");
            var myChannelFactory = new ChannelFactory<Motherboard.SMotherboard>(myBinding, myEndpoint);

            Motherboard.SMotherboard client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 1; l < array.GetLength(1); l++)
                if (array[1, l] != null)
                    comboBox2.Items.Add(array[1, l]);
        }

        private void loadPowerSupply()
        {
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/PowerSupply/");
            var myChannelFactory = new ChannelFactory<PowerSupply.SPowerSupply>(myBinding, myEndpoint);

            PowerSupply.SPowerSupply client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 1; l < array.GetLength(1); l++)
                if (array[1, l] != null)
                    comboBox3.Items.Add(array[1, l]);
        }

        private void loadRam()
        {
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Ram/");
            var myChannelFactory = new ChannelFactory<Ram.SRam>(myBinding, myEndpoint);

            Ram.SRam client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 1; l < array.GetLength(1); l++)
                if (array[1, l] != null)
                    comboBox4.Items.Add(array[1, l]);
        }

        private void loadVideocard()
        {
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Videocard/");
            var myChannelFactory = new ChannelFactory<Videocard.SVideocard>(myBinding, myEndpoint);

            Videocard.SVideocard client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 1; l < array.GetLength(1); l++)
                if (array[1, l] != null)
                    comboBox5.Items.Add(array[1, l]);
        }

        private void loadHarddrive()
        {
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Harddrive/");
            var myChannelFactory = new ChannelFactory<Harddrive.SHarddrive>(myBinding, myEndpoint);

            Harddrive.SHarddrive client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 1; l < array.GetLength(1); l++)
                if (array[1, l] != null)
                    comboBox6.Items.Add(array[1, l]);
        }

        private void loadDiskstorage()
        {
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Diskstorage/");
            var myChannelFactory = new ChannelFactory<Diskstorage.SDiskstorage>(myBinding, myEndpoint);

            Diskstorage.SDiskstorage client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 1; l < array.GetLength(1); l++)
                if (array[1, l] != null)
                    comboBox7.Items.Add(array[1, l]);
        }

        private void loadHousing()
        {
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Housing/");
            var myChannelFactory = new ChannelFactory<Housing.SHousing>(myBinding, myEndpoint);

            Housing.SHousing client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 1; l < array.GetLength(1); l++)
                if (array[1, l] != null)
                    comboBox8.Items.Add(array[1, l]);
        }

        private void showOldConfig()
        {
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Computer/");
            var myChannelFactory = new ChannelFactory<Computer.SComputer>(myBinding, myEndpoint);

            Computer.SComputer client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();                
                client.getByName(Name);
                richTextBox1.Text += "---" + Regex.Replace(Name, "[ ]+", " ") + "---" + "\n"; 
                richTextBox1.Text += "•Процессор - " + Regex.Replace(client.get_ProcessorModel(), "[ ]+", " ") + "\n";
                richTextBox1.Text += "•Материнская плата - " + Regex.Replace(client.get_MotherboardModel(), "[ ]+", " ") + "\n";
                richTextBox1.Text += "•Видеокарта - " + Regex.Replace(client.get_VideocardModel(), "[ ]+", " ") + "\n";
                richTextBox1.Text += "•Жесткий диск - " + Regex.Replace(client.get_HarddriveModel(), "[ ]+", " ") + "\n";
                richTextBox1.Text += "•Блок питания - " + Regex.Replace(client.get_PowersupplyModel(), "[ ]+", " ") + "\n";
                richTextBox1.Text += "•Оперативная память - " + Regex.Replace(client.get_RamModel(), "[ ]+", " ") + "\n";
                richTextBox1.Text += "•Дисковод - " + Regex.Replace(client.get_DiskstorageModel(), "[ ]+", " ") + "\n";
                richTextBox1.Text += "•Корпус - " + Regex.Replace(client.get_HousingModel(), "[ ]+", " ") + "\n";
                ((ICommunicationObject)client).Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }               
            }

            //string[,] array = JsonConvert.DeserializeObject<string[,]>(s);
            //string message = "";
            //for (int i = 1; i < array.GetLength(1); i++)
            //{
            //    if (array[0, i] != null)
            //    {
            //        for (int cell = 0; cell < array.GetLength(0); cell++)
            //            if (array[cell, i] != null)
            //                message += (array[cell, i]) + " ";
            //        message += "\n";
            //    }
            //}
            //MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Computer/");
            var myChannelFactory = new ChannelFactory<Computer.SComputer>(myBinding, myEndpoint);

            Computer.SComputer client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                client.set_ProcessorModel(comboBox1.Text);
                client.set_MotherboardModel(comboBox2.Text);
                client.set_PowersupplyModel(comboBox3.Text);
                client.set_RamModel(comboBox4.Text);
                client.set_VideocardModel(comboBox5.Text);
                client.set_HarddriveModel(comboBox6.Text);
                client.set_DiskstorageModel(comboBox7.Text);
                client.set_HousingModel(comboBox8.Text);
                s = client.toString();
                client.Update(Name);
                ((ICommunicationObject)client).Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
                MessageBox.Show("Нет отвера от сервера!");
                return;
            }

            MessageBox.Show(Regex.Replace(s, "[ ]+", " ") + "\n Успешно Обновлена");
            if (refForm != null)
            {
                try
                {
                    refForm.loadComputer();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Нет отвера от сервера!");
                    return;
                }
            }
        }
    }
}
