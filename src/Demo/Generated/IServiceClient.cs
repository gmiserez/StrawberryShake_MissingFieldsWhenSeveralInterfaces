using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace Demo
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IServiceClient
    {
        Task<IOperationResult<global::Demo.IGetVehicles>> GetVehiclesAsync(
            CancellationToken cancellationToken = default);

        Task<IOperationResult<global::Demo.IGetVehicles>> GetVehiclesAsync(
            GetVehiclesOperation operation,
            CancellationToken cancellationToken = default);
    }
}
