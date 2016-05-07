using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface SManufacturer
    {  

        [OperationContract]
        void NewManufacturer(string name, string country);

        [OperationContract]
        void Save();

        [OperationContract]
        void Update(string newname, string country, string oldname);

        [OperationContract]
        void delete(string name);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();
    }

    [ServiceContract]
    public interface SVideocard
    {

        [OperationContract]
        void NewVideocard(string manufacturer, string model, string memory, string clock_Freq, string memory_type);

        [OperationContract]
        void Save();

        [OperationContract]
        void Update(string manufacturer, string newmodel, string memory, string clock_Freq, string memory_type, string oldmodel);

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();
    }

    [ServiceContract]
    public interface SPowerSupply
    {

        [OperationContract]
        void NewPowerSupply(string manufacturer, string model, string power);

        [OperationContract]
        void Save();

        [OperationContract]
        void Update(string manufacturer, string newmodel, string power, string oldmodel);

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();
    }

    [ServiceContract]
    public interface SHousing
    {

        [OperationContract]
        void NewHousing(string manufacturer, string model, string color);

        [OperationContract]
        void Save();

        [OperationContract]
        void Update(string manufacturer, string newmodel, string color, string oldmodel);

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();
    }

    [ServiceContract]
    public interface SHarddrive
    {

        [OperationContract]
        void NewHarddrive(string manufacturer, string model, string interfce, string capacity);

        [OperationContract]
        void Save();

        [OperationContract]
        void Update(string manufacturer, string newmodel, string newinterface, string capacity, string oldmodel);

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();
    }

    [ServiceContract]
    public interface SDiskstorage
    {

        [OperationContract]
        void NewDiskstorage(string manufacturer, string model, string type);

        [OperationContract]
        void Save();

        [OperationContract]
        void Update(string manufacturer, string newmodel, string type, string oldmodel);

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();
    }

    [ServiceContract]
    public interface SProcessor
    {

        [OperationContract]
        void NewProcessor(string manufacturer, string model, string socket, string clock_Freq, string cache);

        [OperationContract]
        void Save();

        [OperationContract]
        void Update(string manufacturer, string newmodel, string socket, string clock_Freq, string cache, string oldmodel);

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();
    }

    [ServiceContract]
    public interface SRam
    {

        [OperationContract]
        void NewRam(string manufacturer, string model, string memory, string clock_Freq, string memory_type);

        [OperationContract]
        void Save();

        [OperationContract]
        void Update(string manufacturer, string newmodel, string socket, string clock_Freq, string cache, string oldmodel);

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();
    }

    [ServiceContract]
    public interface SMotherboard
    {

        [OperationContract]
        void NewMotherboard(string manufacturer, string model, string socket, string max_clock_Freq, string memory_type, string bios);

        [OperationContract]
        void Save();

        [OperationContract]
        void Update(string manufacturer, string newmodel, string socket, string max_clock_freq, string memory_type, string bios, string oldmodel);

        [OperationContract]
        void delete(string model);

        [OperationContract]
        string toString();

        [OperationContract]
        string get();
    }

    [ServiceContract]
    public interface SComputer
    {

        [OperationContract]
        void NewComputer(string name, string videocard, string powersupply, string housing, string harddrive, string diskstorage, string processor, string ram, string motherboard);

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
