﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL.CatalogoProductoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CatalogoProductoService.IExa_CatalogoProducto")]
    public interface IExa_CatalogoProducto {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExa_CatalogoProducto/Add", ReplyAction="http://tempuri.org/IExa_CatalogoProducto/AddResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Proyecto_ENT.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Proyecto_ENT.Exa_CatalogoProducto))]
        Proyecto_ENT.Result Add(Proyecto_ENT.Exa_CatalogoProducto catalogoProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExa_CatalogoProducto/Add", ReplyAction="http://tempuri.org/IExa_CatalogoProducto/AddResponse")]
        System.Threading.Tasks.Task<Proyecto_ENT.Result> AddAsync(Proyecto_ENT.Exa_CatalogoProducto catalogoProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExa_CatalogoProducto/Update", ReplyAction="http://tempuri.org/IExa_CatalogoProducto/UpdateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Proyecto_ENT.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Proyecto_ENT.Exa_CatalogoProducto))]
        Proyecto_ENT.Result Update(Proyecto_ENT.Exa_CatalogoProducto catalogoProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExa_CatalogoProducto/Update", ReplyAction="http://tempuri.org/IExa_CatalogoProducto/UpdateResponse")]
        System.Threading.Tasks.Task<Proyecto_ENT.Result> UpdateAsync(Proyecto_ENT.Exa_CatalogoProducto catalogoProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExa_CatalogoProducto/GetAll", ReplyAction="http://tempuri.org/IExa_CatalogoProducto/GetAllResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Proyecto_ENT.Exa_CatalogoProducto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        Proyecto_ENT.Result GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExa_CatalogoProducto/GetAll", ReplyAction="http://tempuri.org/IExa_CatalogoProducto/GetAllResponse")]
        System.Threading.Tasks.Task<Proyecto_ENT.Result> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExa_CatalogoProducto/GetById", ReplyAction="http://tempuri.org/IExa_CatalogoProducto/GetByIdResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Proyecto_ENT.Exa_CatalogoProducto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        Proyecto_ENT.Result GetById(int IdProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExa_CatalogoProducto/GetById", ReplyAction="http://tempuri.org/IExa_CatalogoProducto/GetByIdResponse")]
        System.Threading.Tasks.Task<Proyecto_ENT.Result> GetByIdAsync(int IdProducto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IExa_CatalogoProductoChannel : PL.CatalogoProductoService.IExa_CatalogoProducto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Exa_CatalogoProductoClient : System.ServiceModel.ClientBase<PL.CatalogoProductoService.IExa_CatalogoProducto>, PL.CatalogoProductoService.IExa_CatalogoProducto {
        
        public Exa_CatalogoProductoClient() {
        }
        
        public Exa_CatalogoProductoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Exa_CatalogoProductoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Exa_CatalogoProductoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Exa_CatalogoProductoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Proyecto_ENT.Result Add(Proyecto_ENT.Exa_CatalogoProducto catalogoProducto) {
            return base.Channel.Add(catalogoProducto);
        }
        
        public System.Threading.Tasks.Task<Proyecto_ENT.Result> AddAsync(Proyecto_ENT.Exa_CatalogoProducto catalogoProducto) {
            return base.Channel.AddAsync(catalogoProducto);
        }
        
        public Proyecto_ENT.Result Update(Proyecto_ENT.Exa_CatalogoProducto catalogoProducto) {
            return base.Channel.Update(catalogoProducto);
        }
        
        public System.Threading.Tasks.Task<Proyecto_ENT.Result> UpdateAsync(Proyecto_ENT.Exa_CatalogoProducto catalogoProducto) {
            return base.Channel.UpdateAsync(catalogoProducto);
        }
        
        public Proyecto_ENT.Result GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Proyecto_ENT.Result> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public Proyecto_ENT.Result GetById(int IdProducto) {
            return base.Channel.GetById(IdProducto);
        }
        
        public System.Threading.Tasks.Task<Proyecto_ENT.Result> GetByIdAsync(int IdProducto) {
            return base.Channel.GetByIdAsync(IdProducto);
        }
    }
}
