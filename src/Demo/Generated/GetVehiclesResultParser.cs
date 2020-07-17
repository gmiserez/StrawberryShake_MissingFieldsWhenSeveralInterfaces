using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using StrawberryShake;
using StrawberryShake.Configuration;
using StrawberryShake.Http;
using StrawberryShake.Http.Subscriptions;
using StrawberryShake.Transport;

namespace Demo
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetVehiclesResultParser
        : JsonResultParserBase<IGetVehicles>
    {

        public GetVehiclesResultParser(IValueSerializerCollection serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
        }

        protected override IGetVehicles ParserData(JsonElement data)
        {
            return new GetVehicles
            (
                ParseGetVehiclesVehicles(data, "vehicles")
            );

        }

        private global::System.Collections.Generic.IReadOnlyList<global::Demo.IVehicle> ParseGetVehiclesVehicles(
            JsonElement parent,
            string field)
        {
            JsonElement obj = parent.GetProperty(field);

            int objLength = obj.GetArrayLength();
            var list = new global::Demo.IVehicle[objLength];
            for (int objIndex = 0; objIndex < objLength; objIndex++)
            {
                JsonElement element = obj[objIndex];
                string type = element.GetProperty(TypeName).GetString();

                switch(type)
                {
                    case "SportsCar":
                        list[objIndex] = new SportsCar
                        (
                        );
                        break;

                    case "FamilyCar":
                        list[objIndex] = new FamilyCar
                        (
                        );
                        break;

                    default:
                        throw new UnknownSchemaTypeException(type);
                }

            }

            return list;
        }

    }
}
