﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultiServiceClient.CompanyServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CompanyServiceReference.ICompanyGetName")]
    public interface ICompanyGetName {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyGetName/GetName", ReplyAction="http://tempuri.org/ICompanyGetName/GetNameResponse")]
        string GetName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyGetName/GetName", ReplyAction="http://tempuri.org/ICompanyGetName/GetNameResponse")]
        System.Threading.Tasks.Task<string> GetNameAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICompanyGetNameChannel : MultiServiceClient.CompanyServiceReference.ICompanyGetName, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CompanyGetNameClient : System.ServiceModel.ClientBase<MultiServiceClient.CompanyServiceReference.ICompanyGetName>, MultiServiceClient.CompanyServiceReference.ICompanyGetName {
        
        public CompanyGetNameClient() {
        }
        
        public CompanyGetNameClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CompanyGetNameClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyGetNameClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyGetNameClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetName(string name) {
            return base.Channel.GetName(name);
        }
        
        public System.Threading.Tasks.Task<string> GetNameAsync(string name) {
            return base.Channel.GetNameAsync(name);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CompanyServiceReference.ICompanyGetDate")]
    public interface ICompanyGetDate {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyGetDate/GetDate", ReplyAction="http://tempuri.org/ICompanyGetDate/GetDateResponse")]
        string GetDate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyGetDate/GetDate", ReplyAction="http://tempuri.org/ICompanyGetDate/GetDateResponse")]
        System.Threading.Tasks.Task<string> GetDateAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICompanyGetDateChannel : MultiServiceClient.CompanyServiceReference.ICompanyGetDate, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CompanyGetDateClient : System.ServiceModel.ClientBase<MultiServiceClient.CompanyServiceReference.ICompanyGetDate>, MultiServiceClient.CompanyServiceReference.ICompanyGetDate {
        
        public CompanyGetDateClient() {
        }
        
        public CompanyGetDateClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CompanyGetDateClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyGetDateClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyGetDateClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetDate() {
            return base.Channel.GetDate();
        }
        
        public System.Threading.Tasks.Task<string> GetDateAsync() {
            return base.Channel.GetDateAsync();
        }
    }
}