﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace MySql.Data.Entity.Tests
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Model1Container : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Model1Container object using the connection string found in the 'Model1Container' section of the application configuration file.
        /// </summary>
        public Model1Container() : base("name=Model1Container", "Model1Container")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Model1Container object.
        /// </summary>
        public Model1Container(string connectionString) : base(connectionString, "Model1Container")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Model1Container object.
        /// </summary>
        public Model1Container(EntityConnection connection) : base(connection, "Model1Container")
        {
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Animal> Animals
        {
            get
            {
                if ((_Animals == null))
                {
                    _Animals = base.CreateObjectSet<Animal>("Animals");
                }
                return _Animals;
            }
        }
        private ObjectSet<Animal> _Animals;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Shelter> Shelters
        {
            get
            {
                if ((_Shelters == null))
                {
                    _Shelters = base.CreateObjectSet<Shelter>("Shelters");
                }
                return _Shelters;
            }
        }
        private ObjectSet<Shelter> _Shelters;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Animals EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAnimals(Animal animal)
        {
            base.AddObject("Animals", animal);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Shelters EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToShelters(Shelter shelter)
        {
            base.AddObject("Shelters", shelter);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="Animal")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Animal : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Animal object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="shelterId">Initial value of the ShelterId property.</param>
        public static Animal CreateAnimal(global::System.Int32 id, global::System.String name, global::System.Int32 shelterId)
        {
            Animal animal = new Animal();
            animal.Id = id;
            animal.Name = name;
            animal.ShelterId = shelterId;
            return animal;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ShelterId
        {
            get
            {
                return _ShelterId;
            }
            set
            {
                OnShelterIdChanging(value);
                ReportPropertyChanging("ShelterId");
                _ShelterId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ShelterId");
                OnShelterIdChanged();
            }
        }
        private global::System.Int32 _ShelterId;
        partial void OnShelterIdChanging(global::System.Int32 value);
        partial void OnShelterIdChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="Shelter")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Shelter : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Shelter object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Shelter CreateShelter(global::System.Int32 id)
        {
            Shelter shelter = new Shelter();
            shelter.Id = id;
            return shelter;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        #endregion
    
    }

    #endregion
    
}