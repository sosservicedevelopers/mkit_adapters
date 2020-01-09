using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using XRoadLib;
using XRoadLib.Headers;
using XRoadLib.Schema;

namespace AdapterMonListOfTourizm
{
    public class ServiceManager : ServiceManager<XRoadHeader40>
    {
        public ServiceManager()
            : base("4.0", new Myschema("http://producer.xroad.com",
                typeof(ServiceManager).GetTypeInfo().Assembly))
        { }
        //public override void ExportPropertyDefinition(PropertyDefinition propertyDefinition)
        //{
        //    base.ExportPropertyDefinition(propertyDefinition);
        //}
    }
    public class Myschema : DefaultSchemaExporter
    {
        public Myschema(string producerNamespace, Assembly contractAssembly) : base(producerNamespace, contractAssembly)
        {
        }
        public override void ExportProtocolDefinition(ProtocolDefinition protocol)
        {
            //protocol.PortName = "test";
            //protocol.BindingName = "Testt";
            //protocol.SoapAddressLocation = "http://localhost:4011/";
            protocol.SoapAddressLocation = "https://localhost:6007/";
            base.ExportProtocolDefinition(protocol);
        }
    }

}
