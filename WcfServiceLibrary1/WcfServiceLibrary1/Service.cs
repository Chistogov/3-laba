using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    //++
    [ServiceContract]
    public interface SManufacturer
    {

        string Manufacturer_Name
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Manufacturer_Country
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        [OperationContract]
        void Save();

        [OperationContract]
        void Update();

        [OperationContract]
        void delete(string name);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();

        [OperationContract]
        string getByName(string name);
    }
    //++
    [ServiceContract]
    public interface SVideocard
    {
        string Videocard_Manufacturer
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Videocard_Model
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Videocard_Memory
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }        

        string Videocard_Clock_Freq
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Videocard_Memory_type
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        [OperationContract]
        void Save();

        [OperationContract]
        void Update();

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();

        [OperationContract]
        string getByName(string model);
    }
    //++
    [ServiceContract]
    public interface SPowerSupply
    {
        string PowerSupply_Manufacturer
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string PowerSupply_Model
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string PowerSupply_Power
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        [OperationContract]
        void Save();

        [OperationContract]
        void Update();

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();

        [OperationContract]
        string getByName(string model);
    }
    //++
    [ServiceContract]
    public interface SHousing
    {

        string Housing_Manufacturer
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Housing_Model
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Housing_Color
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        [OperationContract]
        void Save();

        [OperationContract]
        void Update();

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();

        [OperationContract]
        string getByName(string model);
    }
    //++
    [ServiceContract]
    public interface SHarddrive
    {

        string Harddrive_Manufacturer
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Harddrive_Model
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Harddrive_Interface
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Harddrive_Capacity
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        [OperationContract]
        void Save();

        [OperationContract]
        void Update();

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();

        [OperationContract]
        string getByName(string model);
    }
    //++
    [ServiceContract]
    public interface SDiskstorage
    {

        string Diskstorage_Manufacturer
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Diskstorage_Model
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Diskstorage_Type
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        [OperationContract]
        void Save();

        [OperationContract]
        void Update();

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();

        [OperationContract]
        string getByName(string model);
    }
    //++
    [ServiceContract]
    public interface SProcessor
    {
        string Processor_Manufacturer
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Processor_Model
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Processor_Socket
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Processor_Clock_Freq
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Processor_Cache
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        [OperationContract]
        void Save();

        [OperationContract]
        void Update();

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();

        [OperationContract]
        string getByName(string model);
    }
    //++
    [ServiceContract]
    public interface SRam
    {
        string Ram_Manufacturer
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Ram_Model
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Ram_Memory
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Ram_Clock_Freq
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Ram_Memory_type
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        [OperationContract]
        void Save();

        [OperationContract]
        void Update();

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();

        [OperationContract]
        string getByName(string model);
    }
    //++
    [ServiceContract]
    public interface SMotherboard
    {
        string Motherboard_Manufacturer
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Motherboard_Model
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Motherboard_Socket
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Motherboard_Max_clock_freq
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Motherboard_Memory_type
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string Motherboard_Bios
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        [OperationContract]
        void Save();

        [OperationContract]
        void Update();

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();

        [OperationContract]
        string getByName(string model);
    }
    //++
    [ServiceContract]
    public interface SComputer
    {

        [OperationContract]
        void Update(string name);

        [OperationContract]
        void Save();

        string C_Name
        {
            [OperationContract]
            get;
            [OperationContract]
            set;            
        }

        string VideocardModel
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string PowersupplyModel
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string HousingModel
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string HarddriveModel
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string DiskstorageModel
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string ProcessorModel
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string RamModel
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        string MotherboardModel
        {
            [OperationContract]
            get;
            [OperationContract]
            set;
        }

        [OperationContract]
        void delete(string name);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();

        [OperationContract]
        string getByName(string name);
    }
}
