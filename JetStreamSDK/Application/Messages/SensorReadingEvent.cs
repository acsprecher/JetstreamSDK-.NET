﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 
namespace TersoSolutions.Jetstream.SDK.Application.Messages.SensorReadingEvent
{
    using System.Xml.Serialization;
    
    /// <summary>
    /// SensorReading event is published when a sensor has provided Jetstream® with a new reading or a batch of readings. 
    /// </summary>
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Jetstream.TersoSolutions.com/v1.0/SensorReadingEvent")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://Jetstream.TersoSolutions.com/v1.0/SensorReadingEvent", IsNullable=false)]
    public partial class Jetstream : TersoSolutions.Jetstream.SDK.Application.Messages.JetstreamEvent
    {
        
        private JetstreamHeader headerField;
        
        private JetstreamSensorReadingEvent sensorReadingEventField;
        
        /// <remarks/>
        public JetstreamHeader Header {
            get {
                return this.headerField;
            }
            set {
                this.headerField = value;
            }
        }
        
        /// <remarks/>
        public JetstreamSensorReadingEvent SensorReadingEvent {
            get {
                return this.sensorReadingEventField;
            }
            set {
                this.sensorReadingEventField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Jetstream.TersoSolutions.com/v1.0/SensorReadingEvent")]
    public partial class JetstreamHeader {
        
        private string eventIdField;
        
        private System.DateTime eventTimeField;
        
        private string logicalDeviceIdField;
        
        private System.DateTime receivedTimeField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EventId {
            get {
                return this.eventIdField;
            }
            set {
                this.eventIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime EventTime {
            get {
                return this.eventTimeField;
            }
            set {
                this.eventTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LogicalDeviceId {
            get {
                return this.logicalDeviceIdField;
            }
            set {
                this.logicalDeviceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ReceivedTime {
            get {
                return this.receivedTimeField;
            }
            set {
                this.receivedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Jetstream.TersoSolutions.com/v1.0/SensorReadingEvent")]
    public partial class JetstreamSensorReadingEvent {
        
        private JetstreamSensorReadingEventReadingList readingListField;
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        public JetstreamSensorReadingEventReadingList ReadingList {
            get {
                return this.readingListField;
            }
            set {
                this.readingListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Jetstream.TersoSolutions.com/v1.0/SensorReadingEvent")]
    public partial class JetstreamSensorReadingEventReadingList {
        
        private JetstreamSensorReadingEventReadingListReading[] readingField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reading")]
        public JetstreamSensorReadingEventReadingListReading[] Reading {
            get {
                return this.readingField;
            }
            set {
                this.readingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Jetstream.TersoSolutions.com/v1.0/SensorReadingEvent")]
    public partial class JetstreamSensorReadingEventReadingListReading {
        
        private string nameField;
        
        private string valueField;
        
        private System.DateTime readingTimeField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ReadingTime {
            get {
                return this.readingTimeField;
            }
            set {
                this.readingTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
}
