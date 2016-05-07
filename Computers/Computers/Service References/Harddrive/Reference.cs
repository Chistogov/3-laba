﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Computers.Harddrive {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Harddrive.SHarddrive")]
    public interface SHarddrive {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SHarddrive/NewHarddrive", ReplyAction="http://tempuri.org/SHarddrive/NewHarddriveResponse")]
        void NewHarddrive(string manufacturer, string model, string interfce, string capacity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SHarddrive/NewHarddrive", ReplyAction="http://tempuri.org/SHarddrive/NewHarddriveResponse")]
        System.Threading.Tasks.Task NewHarddriveAsync(string manufacturer, string model, string interfce, string capacity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SHarddrive/Save", ReplyAction="http://tempuri.org/SHarddrive/SaveResponse")]
        void Save();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SHarddrive/Save", ReplyAction="http://tempuri.org/SHarddrive/SaveResponse")]
        System.Threading.Tasks.Task SaveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SHarddrive/Update", ReplyAction="http://tempuri.org/SHarddrive/UpdateResponse")]
        void Update(string manufacturer, string newmodel, string newinterface, string capacity, string oldmodel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SHarddrive/Update", ReplyAction="http://tempuri.org/SHarddrive/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(string manufacturer, string newmodel, string newinterface, string capacity, string oldmodel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SHarddrive/delete", ReplyAction="http://tempuri.org/SHarddrive/deleteResponse")]
        void delete(string model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SHarddrive/delete", ReplyAction="http://tempuri.org/SHarddrive/deleteResponse")]
        System.Threading.Tasks.Task deleteAsync(string model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SHarddrive/toString", ReplyAction="http://tempuri.org/SHarddrive/toStringResponse")]
        string toString();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SHarddrive/toString", ReplyAction="http://tempuri.org/SHarddrive/toStringResponse")]
        System.Threading.Tasks.Task<string> toStringAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SHarddrive/get", ReplyAction="http://tempuri.org/SHarddrive/getResponse")]
        string get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SHarddrive/get", ReplyAction="http://tempuri.org/SHarddrive/getResponse")]
        System.Threading.Tasks.Task<string> getAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SHarddriveChannel : Computers.Harddrive.SHarddrive, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SHarddriveClient : System.ServiceModel.ClientBase<Computers.Harddrive.SHarddrive>, Computers.Harddrive.SHarddrive {
        
        public SHarddriveClient() {
        }
        
        public SHarddriveClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SHarddriveClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SHarddriveClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SHarddriveClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void NewHarddrive(string manufacturer, string model, string interfce, string capacity) {
            base.Channel.NewHarddrive(manufacturer, model, interfce, capacity);
        }
        
        public System.Threading.Tasks.Task NewHarddriveAsync(string manufacturer, string model, string interfce, string capacity) {
            return base.Channel.NewHarddriveAsync(manufacturer, model, interfce, capacity);
        }
        
        public void Save() {
            base.Channel.Save();
        }
        
        public System.Threading.Tasks.Task SaveAsync() {
            return base.Channel.SaveAsync();
        }
        
        public void Update(string manufacturer, string newmodel, string newinterface, string capacity, string oldmodel) {
            base.Channel.Update(manufacturer, newmodel, newinterface, capacity, oldmodel);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(string manufacturer, string newmodel, string newinterface, string capacity, string oldmodel) {
            return base.Channel.UpdateAsync(manufacturer, newmodel, newinterface, capacity, oldmodel);
        }
        
        public void delete(string model) {
            base.Channel.delete(model);
        }
        
        public System.Threading.Tasks.Task deleteAsync(string model) {
            return base.Channel.deleteAsync(model);
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