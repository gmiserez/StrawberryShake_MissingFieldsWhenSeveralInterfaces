using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Demo
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetVehicles
        : IGetVehicles
    {
        public GetVehicles(
            global::System.Collections.Generic.IReadOnlyList<global::Demo.IVehicle> vehicles)
        {
            Vehicles = vehicles;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::Demo.IVehicle> Vehicles { get; }
    }
}
