﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarClient.CarServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/CarService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarClient.CarServiceReference.ElectricCar))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarClient.CarServiceReference.OilFuelCar))]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MarkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime YearOfProductionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CarClient.CarServiceReference.EngineType EngineTypeField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mark {
            get {
                return this.MarkField;
            }
            set {
                if ((object.ReferenceEquals(this.MarkField, value) != true)) {
                    this.MarkField = value;
                    this.RaisePropertyChanged("Mark");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime YearOfProduction {
            get {
                return this.YearOfProductionField;
            }
            set {
                if ((this.YearOfProductionField.Equals(value) != true)) {
                    this.YearOfProductionField = value;
                    this.RaisePropertyChanged("YearOfProduction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public CarClient.CarServiceReference.EngineType EngineType {
            get {
                return this.EngineTypeField;
            }
            set {
                if ((this.EngineTypeField.Equals(value) != true)) {
                    this.EngineTypeField = value;
                    this.RaisePropertyChanged("EngineType");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ElectricCar", Namespace="http://schemas.datacontract.org/2004/07/CarService")]
    [System.SerializableAttribute()]
    public partial class ElectricCar : CarClient.CarServiceReference.Car {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RangeInKilometersField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RangeInKilometers {
            get {
                return this.RangeInKilometersField;
            }
            set {
                if ((this.RangeInKilometersField.Equals(value) != true)) {
                    this.RangeInKilometersField = value;
                    this.RaisePropertyChanged("RangeInKilometers");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OilFuelCar", Namespace="http://schemas.datacontract.org/2004/07/CarService")]
    [System.SerializableAttribute()]
    public partial class OilFuelCar : CarClient.CarServiceReference.Car {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EnginePowerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EngineССField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EnginePower {
            get {
                return this.EnginePowerField;
            }
            set {
                if ((this.EnginePowerField.Equals(value) != true)) {
                    this.EnginePowerField = value;
                    this.RaisePropertyChanged("EnginePower");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EngineСС {
            get {
                return this.EngineССField;
            }
            set {
                if ((this.EngineССField.Equals(value) != true)) {
                    this.EngineССField = value;
                    this.RaisePropertyChanged("EngineСС");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EngineType", Namespace="http://schemas.datacontract.org/2004/07/CarService")]
    public enum EngineType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Electric = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OilFuel = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CarServiceReference.ICarService")]
    public interface ICarService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/GetCar", ReplyAction="http://tempuri.org/ICarService/GetCarResponse")]
        CarClient.CarServiceReference.Car GetCar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/GetCar", ReplyAction="http://tempuri.org/ICarService/GetCarResponse")]
        System.Threading.Tasks.Task<CarClient.CarServiceReference.Car> GetCarAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/SaveCar", ReplyAction="http://tempuri.org/ICarService/SaveCarResponse")]
        void SaveCar(CarClient.CarServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/SaveCar", ReplyAction="http://tempuri.org/ICarService/SaveCarResponse")]
        System.Threading.Tasks.Task SaveCarAsync(CarClient.CarServiceReference.Car car);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarServiceChannel : CarClient.CarServiceReference.ICarService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarServiceClient : System.ServiceModel.ClientBase<CarClient.CarServiceReference.ICarService>, CarClient.CarServiceReference.ICarService {
        
        public CarServiceClient() {
        }
        
        public CarServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CarClient.CarServiceReference.Car GetCar(int id) {
            return base.Channel.GetCar(id);
        }
        
        public System.Threading.Tasks.Task<CarClient.CarServiceReference.Car> GetCarAsync(int id) {
            return base.Channel.GetCarAsync(id);
        }
        
        public void SaveCar(CarClient.CarServiceReference.Car car) {
            base.Channel.SaveCar(car);
        }
        
        public System.Threading.Tasks.Task SaveCarAsync(CarClient.CarServiceReference.Car car) {
            return base.Channel.SaveCarAsync(car);
        }
    }
}