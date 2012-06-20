﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bhm.Web.PosyandusService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PosyanduData", Namespace="http://schemas.datacontract.org/2004/07/Posyandus")]
    [System.SerializableAttribute()]
    public partial class PosyanduData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string desaPosyanduField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idPosyanduField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kabPosyanduField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kecPosyanduField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string namaPosyanduField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string provPosyanduField;
        
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
        public string desaPosyandu {
            get {
                return this.desaPosyanduField;
            }
            set {
                if ((object.ReferenceEquals(this.desaPosyanduField, value) != true)) {
                    this.desaPosyanduField = value;
                    this.RaisePropertyChanged("desaPosyandu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idPosyandu {
            get {
                return this.idPosyanduField;
            }
            set {
                if ((this.idPosyanduField.Equals(value) != true)) {
                    this.idPosyanduField = value;
                    this.RaisePropertyChanged("idPosyandu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kabPosyandu {
            get {
                return this.kabPosyanduField;
            }
            set {
                if ((object.ReferenceEquals(this.kabPosyanduField, value) != true)) {
                    this.kabPosyanduField = value;
                    this.RaisePropertyChanged("kabPosyandu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kecPosyandu {
            get {
                return this.kecPosyanduField;
            }
            set {
                if ((object.ReferenceEquals(this.kecPosyanduField, value) != true)) {
                    this.kecPosyanduField = value;
                    this.RaisePropertyChanged("kecPosyandu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string namaPosyandu {
            get {
                return this.namaPosyanduField;
            }
            set {
                if ((object.ReferenceEquals(this.namaPosyanduField, value) != true)) {
                    this.namaPosyanduField = value;
                    this.RaisePropertyChanged("namaPosyandu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string provPosyandu {
            get {
                return this.provPosyanduField;
            }
            set {
                if ((object.ReferenceEquals(this.provPosyanduField, value) != true)) {
                    this.provPosyanduField = value;
                    this.RaisePropertyChanged("provPosyandu");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PosyandusService.IPosyandusService")]
    public interface IPosyandusService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPosyandusService/ListPosyandu", ReplyAction="http://tempuri.org/IPosyandusService/ListPosyanduResponse")]
        string[] ListPosyandu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPosyandusService/GetPosyandu", ReplyAction="http://tempuri.org/IPosyandusService/GetPosyanduResponse")]
        Bhm.Web.PosyandusService.PosyanduData GetPosyandu(string nama);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPosyandusService/GetAllPosyandu", ReplyAction="http://tempuri.org/IPosyandusService/GetAllPosyanduResponse")]
        Bhm.Web.PosyandusService.PosyanduData[] GetAllPosyandu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPosyandusService/ListKecamatan", ReplyAction="http://tempuri.org/IPosyandusService/ListKecamatanResponse")]
        string[] ListKecamatan();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPosyandusService/InsertPosyandu", ReplyAction="http://tempuri.org/IPosyandusService/InsertPosyanduResponse")]
        void InsertPosyandu(string nama, string desa, string kec, string kab, string prov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPosyandusService/UpdatePosyandu", ReplyAction="http://tempuri.org/IPosyandusService/UpdatePosyanduResponse")]
        void UpdatePosyandu(int id, string nama, string desa, string kec, string kab, string prov);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPosyandusServiceChannel : Bhm.Web.PosyandusService.IPosyandusService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PosyandusServiceClient : System.ServiceModel.ClientBase<Bhm.Web.PosyandusService.IPosyandusService>, Bhm.Web.PosyandusService.IPosyandusService {
        
        public PosyandusServiceClient() {
        }
        
        public PosyandusServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PosyandusServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PosyandusServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PosyandusServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] ListPosyandu() {
            return base.Channel.ListPosyandu();
        }
        
        public Bhm.Web.PosyandusService.PosyanduData GetPosyandu(string nama) {
            return base.Channel.GetPosyandu(nama);
        }
        
        public Bhm.Web.PosyandusService.PosyanduData[] GetAllPosyandu() {
            return base.Channel.GetAllPosyandu();
        }
        
        public string[] ListKecamatan() {
            return base.Channel.ListKecamatan();
        }
        
        public void InsertPosyandu(string nama, string desa, string kec, string kab, string prov) {
            base.Channel.InsertPosyandu(nama, desa, kec, kab, prov);
        }
        
        public void UpdatePosyandu(int id, string nama, string desa, string kec, string kab, string prov) {
            base.Channel.UpdatePosyandu(id, nama, desa, kec, kab, prov);
        }
    }
}