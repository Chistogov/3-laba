﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Computers.Motherboard {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Motherboard.SMotherboard")]
    public interface SMotherboard {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SMotherboard/NewMotherboard", ReplyAction="http://tempuri.org/SMotherboard/NewMotherboardResponse")]
        void NewMotherboard(string manufacturer, string model, string socket, string max_clock_Freq, string memory_type, string bios);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SMotherboard/NewMotherboard", ReplyAction="http://tempuri.org/SMotherboard/NewMotherboardResponse")]
        System.Threading.Tasks.Task NewMotherboardAsync(string manufacturer, string model, string socket, string max_clock_Freq, string memory_type, string bios);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SMotherboard/Save", ReplyAction="http://tempuri.org/SMotherboard/SaveResponse")]
        void Save();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SMotherboard/Save", ReplyAction="http://tempuri.org/SMotherboard/SaveResponse")]
        System.Threading.Tasks.Task SaveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SMotherboard/Update", ReplyAction="http://tempuri.org/SMotherboard/UpdateResponse")]
        void Update(string manufacturer, string newmodel, string socket, string max_clock_freq, string memory_type, string bios, string oldmodel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SMotherboard/Update", ReplyAction="http://tempuri.org/SMotherboard/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(string manufacturer, string newmodel, string socket, string max_clock_freq, string memory_type, string bios, string oldmodel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SMotherboard/delete", ReplyAction="http://tempuri.org/SMotherboard/deleteResponse")]
        void delete(string model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SMotherboard/delete", ReplyAction="http://tempuri.org/SMotherboard/deleteResponse")]
        System.Threading.Tasks.Task deleteAsync(string model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SMotherboard/toString", ReplyAction="http://tempuri.org/SMotherboard/toStringResponse")]
        string toString();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SMotherboard/toString", ReplyAction="http://tempuri.org/SMotherboard/toStringResponse")]
        System.Threading.Tasks.Task<string> toStringAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SMotherboard/get", ReplyAction="http://tempuri.org/SMotherboard/getResponse")]
        string get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SMotherboard/get", ReplyAction="http://tempuri.org/SMotherboard/getResponse")]
        System.Threading.Tasks.Task<string> getAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SMotherboardChannel : Computers.Motherboard.SMotherboard, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SMotherboardClient : System.ServiceModel.ClientBase<Computers.Motherboard.SMotherboard>, Computers.Motherboard.SMotherboard {
        
        public SMotherboardClient() {
        }
        
        public SMotherboardClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SMotherboardClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SMotherboardClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SMotherboardClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void NewMotherboard(string manufacturer, string model, string socket, string max_clock_Freq, string memory_type, string bios) {
            base.Channel.NewMotherboard(manufacturer, model, socket, max_clock_Freq, memory_type, bios);
        }
        
        public System.Threading.Tasks.Task NewMotherboardAsync(string manufacturer, string model, string socket, string max_clock_Freq, string memory_type, string bios) {
            return base.Channel.NewMotherboardAsync(manufacturer, model, socket, max_clock_Freq, memory_type, bios);
        }
        
        public void Save() {
            base.Channel.Save();
        }
        
        public System.Threading.Tasks.Task SaveAsync() {
            return base.Channel.SaveAsync();
        }
        
        public void Update(string manufacturer, string newmodel, string socket, string max_clock_freq, string memory_type, string bios, string oldmodel) {
            base.Channel.Update(manufacturer, newmodel, socket, max_clock_freq, memory_type, bios, oldmodel);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(string manufacturer, string newmodel, string socket, string max_clock_freq, string memory_type, string bios, string oldmodel) {
            return base.Channel.UpdateAsync(manufacturer, newmodel, socket, max_clock_freq, memory_type, bios, oldmodel);
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