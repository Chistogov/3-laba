﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Computers.Processor {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Processor.SProcessor")]
    public interface SProcessor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SProcessor/NewProcessor", ReplyAction="http://tempuri.org/SProcessor/NewProcessorResponse")]
        void NewProcessor(string manufacturer, string model, string socket, string clock_Freq, string cache);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SProcessor/NewProcessor", ReplyAction="http://tempuri.org/SProcessor/NewProcessorResponse")]
        System.Threading.Tasks.Task NewProcessorAsync(string manufacturer, string model, string socket, string clock_Freq, string cache);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SProcessor/Save", ReplyAction="http://tempuri.org/SProcessor/SaveResponse")]
        void Save();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SProcessor/Save", ReplyAction="http://tempuri.org/SProcessor/SaveResponse")]
        System.Threading.Tasks.Task SaveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SProcessor/Update", ReplyAction="http://tempuri.org/SProcessor/UpdateResponse")]
        void Update(string manufacturer, string newmodel, string socket, string clock_Freq, string cache, string oldmodel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SProcessor/Update", ReplyAction="http://tempuri.org/SProcessor/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(string manufacturer, string newmodel, string socket, string clock_Freq, string cache, string oldmodel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SProcessor/delete", ReplyAction="http://tempuri.org/SProcessor/deleteResponse")]
        void delete(string model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SProcessor/delete", ReplyAction="http://tempuri.org/SProcessor/deleteResponse")]
        System.Threading.Tasks.Task deleteAsync(string model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SProcessor/toString", ReplyAction="http://tempuri.org/SProcessor/toStringResponse")]
        string toString();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SProcessor/toString", ReplyAction="http://tempuri.org/SProcessor/toStringResponse")]
        System.Threading.Tasks.Task<string> toStringAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SProcessor/get", ReplyAction="http://tempuri.org/SProcessor/getResponse")]
        string get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SProcessor/get", ReplyAction="http://tempuri.org/SProcessor/getResponse")]
        System.Threading.Tasks.Task<string> getAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SProcessorChannel : Computers.Processor.SProcessor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SProcessorClient : System.ServiceModel.ClientBase<Computers.Processor.SProcessor>, Computers.Processor.SProcessor {
        
        public SProcessorClient() {
        }
        
        public SProcessorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SProcessorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SProcessorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SProcessorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void NewProcessor(string manufacturer, string model, string socket, string clock_Freq, string cache) {
            base.Channel.NewProcessor(manufacturer, model, socket, clock_Freq, cache);
        }
        
        public System.Threading.Tasks.Task NewProcessorAsync(string manufacturer, string model, string socket, string clock_Freq, string cache) {
            return base.Channel.NewProcessorAsync(manufacturer, model, socket, clock_Freq, cache);
        }
        
        public void Save() {
            base.Channel.Save();
        }
        
        public System.Threading.Tasks.Task SaveAsync() {
            return base.Channel.SaveAsync();
        }
        
        public void Update(string manufacturer, string newmodel, string socket, string clock_Freq, string cache, string oldmodel) {
            base.Channel.Update(manufacturer, newmodel, socket, clock_Freq, cache, oldmodel);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(string manufacturer, string newmodel, string socket, string clock_Freq, string cache, string oldmodel) {
            return base.Channel.UpdateAsync(manufacturer, newmodel, socket, clock_Freq, cache, oldmodel);
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
