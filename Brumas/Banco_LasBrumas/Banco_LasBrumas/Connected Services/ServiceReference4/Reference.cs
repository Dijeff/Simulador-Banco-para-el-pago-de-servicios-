﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Banco_LasBrumas.ServiceReference4 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference4.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/suma", ReplyAction="http://tempuri.org/IService1/sumaResponse")]
        double suma(double valA, double valB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/suma", ReplyAction="http://tempuri.org/IService1/sumaResponse")]
        System.Threading.Tasks.Task<double> sumaAsync(double valA, double valB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/resta", ReplyAction="http://tempuri.org/IService1/restaResponse")]
        double resta(double valA, double valB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/resta", ReplyAction="http://tempuri.org/IService1/restaResponse")]
        System.Threading.Tasks.Task<double> restaAsync(double valA, double valB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/consulta", ReplyAction="http://tempuri.org/IService1/consultaResponse")]
        string consulta(int numero_servicio, string proveedor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/consulta", ReplyAction="http://tempuri.org/IService1/consultaResponse")]
        System.Threading.Tasks.Task<string> consultaAsync(int numero_servicio, string proveedor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pago", ReplyAction="http://tempuri.org/IService1/pagoResponse")]
        string pago(string account, string proveedor, int factura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pago", ReplyAction="http://tempuri.org/IService1/pagoResponse")]
        System.Threading.Tasks.Task<string> pagoAsync(string account, string proveedor, int factura);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Banco_LasBrumas.ServiceReference4.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Banco_LasBrumas.ServiceReference4.IService1>, Banco_LasBrumas.ServiceReference4.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double suma(double valA, double valB) {
            return base.Channel.suma(valA, valB);
        }
        
        public System.Threading.Tasks.Task<double> sumaAsync(double valA, double valB) {
            return base.Channel.sumaAsync(valA, valB);
        }
        
        public double resta(double valA, double valB) {
            return base.Channel.resta(valA, valB);
        }
        
        public System.Threading.Tasks.Task<double> restaAsync(double valA, double valB) {
            return base.Channel.restaAsync(valA, valB);
        }
        
        public string consulta(int numero_servicio, string proveedor) {
            return base.Channel.consulta(numero_servicio, proveedor);
        }
        
        public System.Threading.Tasks.Task<string> consultaAsync(int numero_servicio, string proveedor) {
            return base.Channel.consultaAsync(numero_servicio, proveedor);
        }
        
        public string pago(string account, string proveedor, int factura) {
            return base.Channel.pago(account, proveedor, factura);
        }
        
        public System.Threading.Tasks.Task<string> pagoAsync(string account, string proveedor, int factura) {
            return base.Channel.pagoAsync(account, proveedor, factura);
        }
    }
}
