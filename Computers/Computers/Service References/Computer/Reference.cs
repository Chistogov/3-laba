﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Computers.Computer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Computer.SComputer")]
    public interface SComputer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/NewComputer", ReplyAction="http://tempuri.org/SComputer/NewComputerResponse")]
        void NewComputer(string name, string videocard, string powersupply, string housing, string harddrive, string diskstorage, string processor, string ram, string motherboard);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/NewComputer", ReplyAction="http://tempuri.org/SComputer/NewComputerResponse")]
        System.Threading.Tasks.Task NewComputerAsync(string name, string videocard, string powersupply, string housing, string harddrive, string diskstorage, string processor, string ram, string motherboard);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/Update", ReplyAction="http://tempuri.org/SComputer/UpdateResponse")]
        void Update(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/Update", ReplyAction="http://tempuri.org/SComputer/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/Save", ReplyAction="http://tempuri.org/SComputer/SaveResponse")]
        void Save();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/Save", ReplyAction="http://tempuri.org/SComputer/SaveResponse")]
        System.Threading.Tasks.Task SaveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_C_Name", ReplyAction="http://tempuri.org/SComputer/get_C_NameResponse")]
        string get_C_Name();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_C_Name", ReplyAction="http://tempuri.org/SComputer/get_C_NameResponse")]
        System.Threading.Tasks.Task<string> get_C_NameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_C_Name", ReplyAction="http://tempuri.org/SComputer/set_C_NameResponse")]
        void set_C_Name(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_C_Name", ReplyAction="http://tempuri.org/SComputer/set_C_NameResponse")]
        System.Threading.Tasks.Task set_C_NameAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_VideocardModel", ReplyAction="http://tempuri.org/SComputer/get_VideocardModelResponse")]
        string get_VideocardModel();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_VideocardModel", ReplyAction="http://tempuri.org/SComputer/get_VideocardModelResponse")]
        System.Threading.Tasks.Task<string> get_VideocardModelAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_VideocardModel", ReplyAction="http://tempuri.org/SComputer/set_VideocardModelResponse")]
        void set_VideocardModel(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_VideocardModel", ReplyAction="http://tempuri.org/SComputer/set_VideocardModelResponse")]
        System.Threading.Tasks.Task set_VideocardModelAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_PowersupplyModel", ReplyAction="http://tempuri.org/SComputer/get_PowersupplyModelResponse")]
        string get_PowersupplyModel();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_PowersupplyModel", ReplyAction="http://tempuri.org/SComputer/get_PowersupplyModelResponse")]
        System.Threading.Tasks.Task<string> get_PowersupplyModelAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_PowersupplyModel", ReplyAction="http://tempuri.org/SComputer/set_PowersupplyModelResponse")]
        void set_PowersupplyModel(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_PowersupplyModel", ReplyAction="http://tempuri.org/SComputer/set_PowersupplyModelResponse")]
        System.Threading.Tasks.Task set_PowersupplyModelAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_HousingModel", ReplyAction="http://tempuri.org/SComputer/get_HousingModelResponse")]
        string get_HousingModel();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_HousingModel", ReplyAction="http://tempuri.org/SComputer/get_HousingModelResponse")]
        System.Threading.Tasks.Task<string> get_HousingModelAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_HousingModel", ReplyAction="http://tempuri.org/SComputer/set_HousingModelResponse")]
        void set_HousingModel(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_HousingModel", ReplyAction="http://tempuri.org/SComputer/set_HousingModelResponse")]
        System.Threading.Tasks.Task set_HousingModelAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_HarddriveModel", ReplyAction="http://tempuri.org/SComputer/get_HarddriveModelResponse")]
        string get_HarddriveModel();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_HarddriveModel", ReplyAction="http://tempuri.org/SComputer/get_HarddriveModelResponse")]
        System.Threading.Tasks.Task<string> get_HarddriveModelAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_HarddriveModel", ReplyAction="http://tempuri.org/SComputer/set_HarddriveModelResponse")]
        void set_HarddriveModel(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_HarddriveModel", ReplyAction="http://tempuri.org/SComputer/set_HarddriveModelResponse")]
        System.Threading.Tasks.Task set_HarddriveModelAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_DiskstorageModel", ReplyAction="http://tempuri.org/SComputer/get_DiskstorageModelResponse")]
        string get_DiskstorageModel();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_DiskstorageModel", ReplyAction="http://tempuri.org/SComputer/get_DiskstorageModelResponse")]
        System.Threading.Tasks.Task<string> get_DiskstorageModelAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_DiskstorageModel", ReplyAction="http://tempuri.org/SComputer/set_DiskstorageModelResponse")]
        void set_DiskstorageModel(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_DiskstorageModel", ReplyAction="http://tempuri.org/SComputer/set_DiskstorageModelResponse")]
        System.Threading.Tasks.Task set_DiskstorageModelAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_ProcessorModel", ReplyAction="http://tempuri.org/SComputer/get_ProcessorModelResponse")]
        string get_ProcessorModel();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_ProcessorModel", ReplyAction="http://tempuri.org/SComputer/get_ProcessorModelResponse")]
        System.Threading.Tasks.Task<string> get_ProcessorModelAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_ProcessorModel", ReplyAction="http://tempuri.org/SComputer/set_ProcessorModelResponse")]
        void set_ProcessorModel(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_ProcessorModel", ReplyAction="http://tempuri.org/SComputer/set_ProcessorModelResponse")]
        System.Threading.Tasks.Task set_ProcessorModelAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_RamModel", ReplyAction="http://tempuri.org/SComputer/get_RamModelResponse")]
        string get_RamModel();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_RamModel", ReplyAction="http://tempuri.org/SComputer/get_RamModelResponse")]
        System.Threading.Tasks.Task<string> get_RamModelAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_RamModel", ReplyAction="http://tempuri.org/SComputer/set_RamModelResponse")]
        void set_RamModel(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_RamModel", ReplyAction="http://tempuri.org/SComputer/set_RamModelResponse")]
        System.Threading.Tasks.Task set_RamModelAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_MotherboardModel", ReplyAction="http://tempuri.org/SComputer/get_MotherboardModelResponse")]
        string get_MotherboardModel();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get_MotherboardModel", ReplyAction="http://tempuri.org/SComputer/get_MotherboardModelResponse")]
        System.Threading.Tasks.Task<string> get_MotherboardModelAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_MotherboardModel", ReplyAction="http://tempuri.org/SComputer/set_MotherboardModelResponse")]
        void set_MotherboardModel(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/set_MotherboardModel", ReplyAction="http://tempuri.org/SComputer/set_MotherboardModelResponse")]
        System.Threading.Tasks.Task set_MotherboardModelAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/delete", ReplyAction="http://tempuri.org/SComputer/deleteResponse")]
        void delete(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/delete", ReplyAction="http://tempuri.org/SComputer/deleteResponse")]
        System.Threading.Tasks.Task deleteAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/toString", ReplyAction="http://tempuri.org/SComputer/toStringResponse")]
        string toString();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/toString", ReplyAction="http://tempuri.org/SComputer/toStringResponse")]
        System.Threading.Tasks.Task<string> toStringAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get", ReplyAction="http://tempuri.org/SComputer/getResponse")]
        string get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/get", ReplyAction="http://tempuri.org/SComputer/getResponse")]
        System.Threading.Tasks.Task<string> getAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/getByName", ReplyAction="http://tempuri.org/SComputer/getByNameResponse")]
        string getByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SComputer/getByName", ReplyAction="http://tempuri.org/SComputer/getByNameResponse")]
        System.Threading.Tasks.Task<string> getByNameAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SComputerChannel : Computers.Computer.SComputer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SComputerClient : System.ServiceModel.ClientBase<Computers.Computer.SComputer>, Computers.Computer.SComputer {
        
        public SComputerClient() {
        }
        
        public SComputerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SComputerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SComputerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SComputerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void NewComputer(string name, string videocard, string powersupply, string housing, string harddrive, string diskstorage, string processor, string ram, string motherboard) {
            base.Channel.NewComputer(name, videocard, powersupply, housing, harddrive, diskstorage, processor, ram, motherboard);
        }
        
        public System.Threading.Tasks.Task NewComputerAsync(string name, string videocard, string powersupply, string housing, string harddrive, string diskstorage, string processor, string ram, string motherboard) {
            return base.Channel.NewComputerAsync(name, videocard, powersupply, housing, harddrive, diskstorage, processor, ram, motherboard);
        }
        
        public void Update(string name) {
            base.Channel.Update(name);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(string name) {
            return base.Channel.UpdateAsync(name);
        }
        
        public void Save() {
            base.Channel.Save();
        }
        
        public System.Threading.Tasks.Task SaveAsync() {
            return base.Channel.SaveAsync();
        }
        
        public string get_C_Name() {
            return base.Channel.get_C_Name();
        }
        
        public System.Threading.Tasks.Task<string> get_C_NameAsync() {
            return base.Channel.get_C_NameAsync();
        }
        
        public void set_C_Name(string value) {
            base.Channel.set_C_Name(value);
        }
        
        public System.Threading.Tasks.Task set_C_NameAsync(string value) {
            return base.Channel.set_C_NameAsync(value);
        }
        
        public string get_VideocardModel() {
            return base.Channel.get_VideocardModel();
        }
        
        public System.Threading.Tasks.Task<string> get_VideocardModelAsync() {
            return base.Channel.get_VideocardModelAsync();
        }
        
        public void set_VideocardModel(string value) {
            base.Channel.set_VideocardModel(value);
        }
        
        public System.Threading.Tasks.Task set_VideocardModelAsync(string value) {
            return base.Channel.set_VideocardModelAsync(value);
        }
        
        public string get_PowersupplyModel() {
            return base.Channel.get_PowersupplyModel();
        }
        
        public System.Threading.Tasks.Task<string> get_PowersupplyModelAsync() {
            return base.Channel.get_PowersupplyModelAsync();
        }
        
        public void set_PowersupplyModel(string value) {
            base.Channel.set_PowersupplyModel(value);
        }
        
        public System.Threading.Tasks.Task set_PowersupplyModelAsync(string value) {
            return base.Channel.set_PowersupplyModelAsync(value);
        }
        
        public string get_HousingModel() {
            return base.Channel.get_HousingModel();
        }
        
        public System.Threading.Tasks.Task<string> get_HousingModelAsync() {
            return base.Channel.get_HousingModelAsync();
        }
        
        public void set_HousingModel(string value) {
            base.Channel.set_HousingModel(value);
        }
        
        public System.Threading.Tasks.Task set_HousingModelAsync(string value) {
            return base.Channel.set_HousingModelAsync(value);
        }
        
        public string get_HarddriveModel() {
            return base.Channel.get_HarddriveModel();
        }
        
        public System.Threading.Tasks.Task<string> get_HarddriveModelAsync() {
            return base.Channel.get_HarddriveModelAsync();
        }
        
        public void set_HarddriveModel(string value) {
            base.Channel.set_HarddriveModel(value);
        }
        
        public System.Threading.Tasks.Task set_HarddriveModelAsync(string value) {
            return base.Channel.set_HarddriveModelAsync(value);
        }
        
        public string get_DiskstorageModel() {
            return base.Channel.get_DiskstorageModel();
        }
        
        public System.Threading.Tasks.Task<string> get_DiskstorageModelAsync() {
            return base.Channel.get_DiskstorageModelAsync();
        }
        
        public void set_DiskstorageModel(string value) {
            base.Channel.set_DiskstorageModel(value);
        }
        
        public System.Threading.Tasks.Task set_DiskstorageModelAsync(string value) {
            return base.Channel.set_DiskstorageModelAsync(value);
        }
        
        public string get_ProcessorModel() {
            return base.Channel.get_ProcessorModel();
        }
        
        public System.Threading.Tasks.Task<string> get_ProcessorModelAsync() {
            return base.Channel.get_ProcessorModelAsync();
        }
        
        public void set_ProcessorModel(string value) {
            base.Channel.set_ProcessorModel(value);
        }
        
        public System.Threading.Tasks.Task set_ProcessorModelAsync(string value) {
            return base.Channel.set_ProcessorModelAsync(value);
        }
        
        public string get_RamModel() {
            return base.Channel.get_RamModel();
        }
        
        public System.Threading.Tasks.Task<string> get_RamModelAsync() {
            return base.Channel.get_RamModelAsync();
        }
        
        public void set_RamModel(string value) {
            base.Channel.set_RamModel(value);
        }
        
        public System.Threading.Tasks.Task set_RamModelAsync(string value) {
            return base.Channel.set_RamModelAsync(value);
        }
        
        public string get_MotherboardModel() {
            return base.Channel.get_MotherboardModel();
        }
        
        public System.Threading.Tasks.Task<string> get_MotherboardModelAsync() {
            return base.Channel.get_MotherboardModelAsync();
        }
        
        public void set_MotherboardModel(string value) {
            base.Channel.set_MotherboardModel(value);
        }
        
        public System.Threading.Tasks.Task set_MotherboardModelAsync(string value) {
            return base.Channel.set_MotherboardModelAsync(value);
        }
        
        public void delete(string name) {
            base.Channel.delete(name);
        }
        
        public System.Threading.Tasks.Task deleteAsync(string name) {
            return base.Channel.deleteAsync(name);
        }
        
        public string toString() {
            return base.Channel.toString();
        }
        
        public System.Threading.Tasks.Task<string> toStringAsync() {
            return base.Channel.toStringAsync();
        }
        
        public string get() {
            return base.Channel.get();
        }
        
        public System.Threading.Tasks.Task<string> getAsync() {
            return base.Channel.getAsync();
        }
        
        public string getByName(string name) {
            return base.Channel.getByName(name);
        }
        
        public System.Threading.Tasks.Task<string> getByNameAsync(string name) {
            return base.Channel.getByNameAsync(name);
        }
    }
}