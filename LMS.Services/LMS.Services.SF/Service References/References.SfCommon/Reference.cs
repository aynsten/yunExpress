﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Services.SF.References.SfCommon {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.expressservice.integration.sf.com/", ConfigurationName="References.SfCommon.IService")]
    public interface IService {
        
        // CODEGEN: 命名空间  的元素名称 arg0 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        LMS.Services.SF.References.SfCommon.sfexpressServiceResponse sfexpressService(LMS.Services.SF.References.SfCommon.sfexpressService request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class sfexpressService {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="sfexpressService", Namespace="http://service.expressservice.integration.sf.com/", Order=0)]
        public LMS.Services.SF.References.SfCommon.sfexpressServiceBody Body;
        
        public sfexpressService() {
        }
        
        public sfexpressService(LMS.Services.SF.References.SfCommon.sfexpressServiceBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class sfexpressServiceBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string arg0;
        
        public sfexpressServiceBody() {
        }
        
        public sfexpressServiceBody(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class sfexpressServiceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="sfexpressServiceResponse", Namespace="http://service.expressservice.integration.sf.com/", Order=0)]
        public LMS.Services.SF.References.SfCommon.sfexpressServiceResponseBody Body;
        
        public sfexpressServiceResponse() {
        }
        
        public sfexpressServiceResponse(LMS.Services.SF.References.SfCommon.sfexpressServiceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class sfexpressServiceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public sfexpressServiceResponseBody() {
        }
        
        public sfexpressServiceResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : LMS.Services.SF.References.SfCommon.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<LMS.Services.SF.References.SfCommon.IService>, LMS.Services.SF.References.SfCommon.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LMS.Services.SF.References.SfCommon.sfexpressServiceResponse LMS.Services.SF.References.SfCommon.IService.sfexpressService(LMS.Services.SF.References.SfCommon.sfexpressService request) {
            return base.Channel.sfexpressService(request);
        }
        
        public string sfexpressService(string arg0) {
            LMS.Services.SF.References.SfCommon.sfexpressService inValue = new LMS.Services.SF.References.SfCommon.sfexpressService();
            inValue.Body = new LMS.Services.SF.References.SfCommon.sfexpressServiceBody();
            inValue.Body.arg0 = arg0;
            LMS.Services.SF.References.SfCommon.sfexpressServiceResponse retVal = ((LMS.Services.SF.References.SfCommon.IService)(this)).sfexpressService(inValue);
            return retVal.Body.@return;
        }
    }
}