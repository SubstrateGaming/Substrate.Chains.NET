//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Moonsama.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IMintingStorage interface definition.
    /// </summary>
    public interface IMintingStorage : IStorage
    {
    }
    
    /// <summary>
    /// MintingStorage class definition.
    /// </summary>
    public sealed class MintingStorage : IMintingStorage
    {
        
        /// <summary>
        /// MintingStorage constructor.
        /// </summary>
        public MintingStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
        }
    }
}
