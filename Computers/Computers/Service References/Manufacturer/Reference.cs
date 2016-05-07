﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Computers.Manufacturer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Manufacturer.SManufacturer")]
    public interface SManufacturer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SManufacturer/NewManufacturer", ReplyAction="http://tempuri.org/SManufacturer/NewManufacturerResponse")]
        void NewManufacturer(string name, string country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SManufacturer/NewManufacturer", ReplyAction="http://tempuri.org/SManufacturer/NewManufacturerResponse")]
        System.Threading.Tasks.Task NewManufacturerAsync(string name, string country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SManufacturer/Save", ReplyAction="http://tempuri.org/SManufacturer/SaveResponse")]
        void Save();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SManufacturer/Save", ReplyAction="http://tempuri.org/SManufacturer/SaveResponse")]
        System.Threading.Tasks.Task SaveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SManufacturer/Update", ReplyAction="http://tempuri.org/SManufacturer/UpdateResponse")]
        void Update(string newname, string country, string oldname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SManufacturer/Update", ReplyAction="http://tempuri.org/SManufacturer/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(string newname, string country, string oldname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SManufacturer/delete", ReplyAction="http://tempuri.org/SManufacturer/deleteResponse")]
        void delete(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SManufacturer/delete", ReplyAction="http://tempuri.org/SManufacturer/deleteResponse")]
        System.Threading.Tasks.Task deleteAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SManufacturer/toString", ReplyAction="http://tempuri.org/SManufacturer/toStringResponse")]
        string toString();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SManufacturer/toString", ReplyAction="http://tempuri.org/SManufacturer/toStringResponse")]
        System.Threading.Tasks.Task<string> toStringAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SManufacturer/get", ReplyAction="http://tempuri.org/SManufacturer/getResponse")]
        string get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SManufacturer/get", ReplyAction="http://tempuri.org/SManufacturer/getResponse")]
        System.Threading.Tasks.Task<string> getAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SManufacturerChannel : Computers.Manufacturer.SManufacturer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SManufacturerClient : System.ServiceModel.ClientBase<Computers.Manufacturer.SManufacturer>, Computers.Manufacturer.SManufacturer {
        
        public SManufacturerClient() {
        }
        
        public SManufacturerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SManufacturerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SManufacturerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SManufacturerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void NewManufacturer(string name, string country) {
            base.Channel.NewManufacturer(name, country);
        }
        
        public System.Threading.Tasks.Task NewManufacturerAsync(string name, string country) {
            return base.Channel.NewManufacturerAsync(name, country);
        }
        
        public void Save() {
            base.Channel.Save();
        }
        
        public System.Threading.Tasks.Task SaveAsync() {
            return base.Channel.SaveAsync();
        }
        
        public void Update(string newname, string country, string oldname) {
            base.Channel.Update(newname, country, oldname);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(string newname, string country, string oldname) {
            return base.Channel.UpdateAsync(newname, country, oldname);
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
    }
}
