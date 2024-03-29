//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Aventus.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Aventus.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// OffencesController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class OffencesController : ControllerBase
    {
        
        private IOffencesStorage _offencesStorage;
        
        /// <summary>
        /// OffencesController constructor.
        /// </summary>
        public OffencesController(IOffencesStorage offencesStorage)
        {
            _offencesStorage = offencesStorage;
        }
        
        /// <summary>
        /// >> Reports
        ///  The primary structure that holds all offence records keyed by report identifiers.
        /// </summary>
        [HttpGet("Reports")]
        [ProducesResponseType(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_staking.offence.OffenceDetails), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.OffencesStorage), "ReportsParams", typeof(Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetReports(string key)
        {
            return this.Ok(_offencesStorage.GetReports(key));
        }
        
        /// <summary>
        /// >> ConcurrentReportsIndex
        ///  A vector of reports of the same kind that happened at the same time slot.
        /// </summary>
        [HttpGet("ConcurrentReportsIndex")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H256>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.OffencesStorage), "ConcurrentReportsIndexParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Aventus.NET.NetApiExt.Generated.Types.Base.Arr16U8, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>))]
        public IActionResult GetConcurrentReportsIndex(string key)
        {
            return this.Ok(_offencesStorage.GetConcurrentReportsIndex(key));
        }
        
        /// <summary>
        /// >> ReportsByKindIndex
        ///  Enumerates all reports of a kind along with the time they happened.
        /// 
        ///  All reports are sorted by the time of offence.
        /// 
        ///  Note that the actual type of this mapping is `Vec<u8>`, this is because values of
        ///  different types are not supported at the moment so we are doing the manual serialization.
        /// </summary>
        [HttpGet("ReportsByKindIndex")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Aventus.NET.NetApiExt.Generated.Storage.OffencesStorage), "ReportsByKindIndexParams", typeof(Substrate.Aventus.NET.NetApiExt.Generated.Types.Base.Arr16U8))]
        public IActionResult GetReportsByKindIndex(string key)
        {
            return this.Ok(_offencesStorage.GetReportsByKindIndex(key));
        }
    }
}
