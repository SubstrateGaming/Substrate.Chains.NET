//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Unique.NET.NetApiExt.Generated.Storage
{
    
    
    public sealed class StructureStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public StructureStorage(SubstrateClientExt client)
        {
            this._client = client;
        }
    }
    
    public sealed class StructureCalls
    {
    }
    
    public sealed class StructureConstants
    {
    }
    
    public enum StructureErrors
    {
        
        /// <summary>
        /// >> OuroborosDetected
        /// While nesting, encountered an already checked account, detecting a loop.
        /// </summary>
        OuroborosDetected,
        
        /// <summary>
        /// >> DepthLimit
        /// While nesting, reached the depth limit of nesting, exceeding the provided budget.
        /// </summary>
        DepthLimit,
        
        /// <summary>
        /// >> BreadthLimit
        /// While nesting, reached the breadth limit of nesting, exceeding the provided budget.
        /// </summary>
        BreadthLimit,
        
        /// <summary>
        /// >> TokenNotFound
        /// Couldn't find the token owner that is itself a token.
        /// </summary>
        TokenNotFound,
        
        /// <summary>
        /// >> CantNestTokenUnderCollection
        /// Tried to nest token under collection contract address, instead of token address
        /// </summary>
        CantNestTokenUnderCollection,
    }
}