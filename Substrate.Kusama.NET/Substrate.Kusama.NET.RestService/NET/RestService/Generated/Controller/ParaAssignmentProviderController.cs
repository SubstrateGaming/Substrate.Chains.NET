//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Kusama.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Kusama.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// ParaAssignmentProviderController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ParaAssignmentProviderController : ControllerBase
    {
        
        private IParaAssignmentProviderStorage _paraAssignmentProviderStorage;
        
        /// <summary>
        /// ParaAssignmentProviderController constructor.
        /// </summary>
        public ParaAssignmentProviderController(IParaAssignmentProviderStorage paraAssignmentProviderStorage)
        {
            _paraAssignmentProviderStorage = paraAssignmentProviderStorage;
        }
    }
}