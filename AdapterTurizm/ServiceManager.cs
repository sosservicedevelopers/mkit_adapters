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
            protocol.SoapAddressLocation = "http://localhost:6003/";
            //protocol.SoapAddressLocation = "https://localhost:44328/";
            base.ExportProtocolDefinition(protocol);
        }
    }

}
