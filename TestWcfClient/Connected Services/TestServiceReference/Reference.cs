﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWcfClient.TestServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TestServiceReference.ITestService")]
    public interface ITestService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/get_num1", ReplyAction="http://tempuri.org/ITestService/get_num1Response")]
        int get_num1(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/get_num1", ReplyAction="http://tempuri.org/ITestService/get_num1Response")]
        System.Threading.Tasks.Task<int> get_num1Async(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/get_num2", ReplyAction="http://tempuri.org/ITestService/get_num2Response")]
        int get_num2(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/get_num2", ReplyAction="http://tempuri.org/ITestService/get_num2Response")]
        System.Threading.Tasks.Task<int> get_num2Async(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/get_num3", ReplyAction="http://tempuri.org/ITestService/get_num3Response")]
        int get_num3(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/get_num3", ReplyAction="http://tempuri.org/ITestService/get_num3Response")]
        System.Threading.Tasks.Task<int> get_num3Async(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/PutData", ReplyAction="http://tempuri.org/ITestService/PutDataResponse")]
        void PutData(string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/PutData", ReplyAction="http://tempuri.org/ITestService/PutDataResponse")]
        System.Threading.Tasks.Task PutDataAsync(string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/GetData", ReplyAction="http://tempuri.org/ITestService/GetDataResponse")]
        string GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/GetData", ReplyAction="http://tempuri.org/ITestService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITestServiceChannel : TestWcfClient.TestServiceReference.ITestService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestServiceClient : System.ServiceModel.ClientBase<TestWcfClient.TestServiceReference.ITestService>, TestWcfClient.TestServiceReference.ITestService {
        
        public TestServiceClient() {
        }
        
        public TestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int get_num1(int a) {
            return base.Channel.get_num1(a);
        }
        
        public System.Threading.Tasks.Task<int> get_num1Async(int a) {
            return base.Channel.get_num1Async(a);
        }
        
        public int get_num2(int a) {
            return base.Channel.get_num2(a);
        }
        
        public System.Threading.Tasks.Task<int> get_num2Async(int a) {
            return base.Channel.get_num2Async(a);
        }
        
        public int get_num3(int a) {
            return base.Channel.get_num3(a);
        }
        
        public System.Threading.Tasks.Task<int> get_num3Async(int a) {
            return base.Channel.get_num3Async(a);
        }
        
        public void PutData(string data) {
            base.Channel.PutData(data);
        }
        
        public System.Threading.Tasks.Task PutDataAsync(string data) {
            return base.Channel.PutDataAsync(data);
        }
        
        public string GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
    }
}