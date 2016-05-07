﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Computers.Diskstorage {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Diskstorage.SDiskstorage")]
    public interface SDiskstorage {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SDiskstorage/NewDiskstorage", ReplyAction="http://tempuri.org/SDiskstorage/NewDiskstorageResponse")]
        void NewDiskstorage(string manufacturer, string model, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SDiskstorage/NewDiskstorage", ReplyAction="http://tempuri.org/SDiskstorage/NewDiskstorageResponse")]
        System.Threading.Tasks.Task NewDiskstorageAsync(string manufacturer, string model, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SDiskstorage/Save", ReplyAction="http://tempuri.org/SDiskstorage/SaveResponse")]
        void Save();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SDiskstorage/Save", ReplyAction="http://tempuri.org/SDiskstorage/SaveResponse")]
        System.Threading.Tasks.Task SaveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SDiskstorage/Update", ReplyAction="http://tempuri.org/SDiskstorage/UpdateResponse")]
        void Update(string manufacturer, string newmodel, string type, string oldmodel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SDiskstorage/Update", ReplyAction="http://tempuri.org/SDiskstorage/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(string manufacturer, string newmodel, string type, string oldmodel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SDiskstorage/delete", ReplyAction="http://tempuri.org/SDiskstorage/deleteResponse")]
        void delete(string model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SDiskstorage/delete", ReplyAction="http://tempuri.org/SDiskstorage/deleteResponse")]
        System.Threading.Tasks.Task deleteAsync(string model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SDiskstorage/toString", ReplyAction="http://tempuri.org/SDiskstorage/toStringResponse")]
        string toString();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SDiskstorage/toString", ReplyAction="http://tempuri.org/SDiskstorage/toStringResponse")]
        System.Threading.Tasks.Task<string> toStringAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SDiskstorage/get", ReplyAction="http://tempuri.org/SDiskstorage/getResponse")]
        string get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SDiskstorage/get", ReplyAction="http://tempuri.org/SDiskstorage/getResponse")]
        System.Threading.Tasks.Task<string> getAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SDiskstorageChannel : Computers.Diskstorage.SDiskstorage, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SDiskstorageClient : System.ServiceModel.ClientBase<Computers.Diskstorage.SDiskstorage>, Computers.Diskstorage.SDiskstorage {
        
        public SDiskstorageClient() {
        }
        
        public SDiskstorageClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SDiskstorageClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SDiskstorageClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SDiskstorageClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void NewDiskstorage(string manufacturer, string model, string type) {
            base.Channel.NewDiskstorage(manufacturer, model, type);
        }
        
        public System.Threading.Tasks.Task NewDiskstorageAsync(string manufacturer, string model, string type) {
            return base.Channel.NewDiskstorageAsync(manufacturer, model, type);
        }
        
        public void Save() {
            base.Channel.Save();
        }
        
        public System.Threading.Tasks.Task SaveAsync() {
            return base.Channel.SaveAsync();
        }
        
        public void Update(string manufacturer, string newmodel, string type, string oldmodel) {
            base.Channel.Update(manufacturer, newmodel, type, oldmodel);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(string manufacturer, string newmodel, string type, string oldmodel) {
            return base.Channel.UpdateAsync(manufacturer, newmodel, type, oldmodel);
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