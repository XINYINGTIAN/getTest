﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLTVWGPT.TestSvcRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WCFTest")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TestSvcRef.ITestSvc")]
    public interface ITestSvc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestSvc/GetData", ReplyAction="http://tempuri.org/ITestSvc/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestSvc/GetData", ReplyAction="http://tempuri.org/ITestSvc/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestSvc/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ITestSvc/GetDataUsingDataContractResponse")]
        DLTVWGPT.TestSvcRef.CompositeType GetDataUsingDataContract(DLTVWGPT.TestSvcRef.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestSvc/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ITestSvc/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<DLTVWGPT.TestSvcRef.CompositeType> GetDataUsingDataContractAsync(DLTVWGPT.TestSvcRef.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestSvc/GetAppSettings", ReplyAction="http://tempuri.org/ITestSvc/GetAppSettingsResponse")]
        string GetAppSettings(string aKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestSvc/GetAppSettings", ReplyAction="http://tempuri.org/ITestSvc/GetAppSettingsResponse")]
        System.Threading.Tasks.Task<string> GetAppSettingsAsync(string aKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestSvc/WriteConfig", ReplyAction="http://tempuri.org/ITestSvc/WriteConfigResponse")]
        int WriteConfig(string aDm, string aNr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestSvc/WriteConfig", ReplyAction="http://tempuri.org/ITestSvc/WriteConfigResponse")]
        System.Threading.Tasks.Task<int> WriteConfigAsync(string aDm, string aNr);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITestSvcChannel : DLTVWGPT.TestSvcRef.ITestSvc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestSvcClient : System.ServiceModel.ClientBase<DLTVWGPT.TestSvcRef.ITestSvc>, DLTVWGPT.TestSvcRef.ITestSvc {
        
        public TestSvcClient() {
        }
        
        public TestSvcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TestSvcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestSvcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestSvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public DLTVWGPT.TestSvcRef.CompositeType GetDataUsingDataContract(DLTVWGPT.TestSvcRef.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<DLTVWGPT.TestSvcRef.CompositeType> GetDataUsingDataContractAsync(DLTVWGPT.TestSvcRef.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public string GetAppSettings(string aKey) {
            return base.Channel.GetAppSettings(aKey);
        }
        
        public System.Threading.Tasks.Task<string> GetAppSettingsAsync(string aKey) {
            return base.Channel.GetAppSettingsAsync(aKey);
        }
        
        public int WriteConfig(string aDm, string aNr) {
            return base.Channel.WriteConfig(aDm, aNr);
        }
        
        public System.Threading.Tasks.Task<int> WriteConfigAsync(string aDm, string aNr) {
            return base.Channel.WriteConfigAsync(aDm, aNr);
        }
    }
}
