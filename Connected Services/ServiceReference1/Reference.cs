﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace reportcrystal.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost/", ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/MostrarDatos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet MostrarDatos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/MostrarDatos", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> MostrarDatosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/InsertarDatos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool InsertarDatos(int matricula, string nombre, int edad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/InsertarDatos", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> InsertarDatosAsync(int matricula, string nombre, int edad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/ActualizarDatos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool ActualizarDatos(int matricula, string nombre, int edad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/ActualizarDatos", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ActualizarDatosAsync(int matricula, string nombre, int edad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/EliminarDatos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool EliminarDatos(int matricula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/EliminarDatos", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> EliminarDatosAsync(int matricula);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : reportcrystal.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<reportcrystal.ServiceReference1.WebService1Soap>, reportcrystal.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet MostrarDatos() {
            return base.Channel.MostrarDatos();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> MostrarDatosAsync() {
            return base.Channel.MostrarDatosAsync();
        }
        
        public bool InsertarDatos(int matricula, string nombre, int edad) {
            return base.Channel.InsertarDatos(matricula, nombre, edad);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarDatosAsync(int matricula, string nombre, int edad) {
            return base.Channel.InsertarDatosAsync(matricula, nombre, edad);
        }
        
        public bool ActualizarDatos(int matricula, string nombre, int edad) {
            return base.Channel.ActualizarDatos(matricula, nombre, edad);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarDatosAsync(int matricula, string nombre, int edad) {
            return base.Channel.ActualizarDatosAsync(matricula, nombre, edad);
        }
        
        public bool EliminarDatos(int matricula) {
            return base.Channel.EliminarDatos(matricula);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarDatosAsync(int matricula) {
            return base.Channel.EliminarDatosAsync(matricula);
        }
    }
}
