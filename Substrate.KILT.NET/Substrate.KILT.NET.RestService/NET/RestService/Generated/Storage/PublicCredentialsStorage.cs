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


namespace Substrate.KILT.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IPublicCredentialsStorage interface definition.
    /// </summary>
    public interface IPublicCredentialsStorage : IStorage
    {
        
        /// <summary>
        /// >> Credentials
        ///  The map of public credentials already attested.
        ///  It maps from a (subject id + credential id) -> the creation
        ///  details of the credential.
        /// </summary>
        Substrate.KILT.NET.NetApiExt.Generated.Model.public_credentials.credentials.CredentialEntry GetCredentials(string key);
        
        /// <summary>
        /// >> CredentialSubjects
        ///  A reverse index mapping from credential ID to the subject the credential
        ///  was issued to.
        /// 
        ///  It it used to perform efficient lookup of credentials given their ID.
        /// </summary>
        Substrate.KILT.NET.NetApiExt.Generated.Model.runtime_common.assets.AssetDid GetCredentialSubjects(string key);
    }
    
    /// <summary>
    /// PublicCredentialsStorage class definition.
    /// </summary>
    public sealed class PublicCredentialsStorage : IPublicCredentialsStorage
    {
        
        /// <summary>
        /// _credentialsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.KILT.NET.NetApiExt.Generated.Model.public_credentials.credentials.CredentialEntry> _credentialsTypedStorage;
        
        /// <summary>
        /// _credentialSubjectsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.KILT.NET.NetApiExt.Generated.Model.runtime_common.assets.AssetDid> _credentialSubjectsTypedStorage;
        
        /// <summary>
        /// PublicCredentialsStorage constructor.
        /// </summary>
        public PublicCredentialsStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.CredentialsTypedStorage = new TypedMapStorage<Substrate.KILT.NET.NetApiExt.Generated.Model.public_credentials.credentials.CredentialEntry>("PublicCredentials.Credentials", storageDataProvider, storageChangeDelegates);
            this.CredentialSubjectsTypedStorage = new TypedMapStorage<Substrate.KILT.NET.NetApiExt.Generated.Model.runtime_common.assets.AssetDid>("PublicCredentials.CredentialSubjects", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _credentialsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.KILT.NET.NetApiExt.Generated.Model.public_credentials.credentials.CredentialEntry> CredentialsTypedStorage
        {
            get
            {
                return _credentialsTypedStorage;
            }
            set
            {
                _credentialsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _credentialSubjectsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.KILT.NET.NetApiExt.Generated.Model.runtime_common.assets.AssetDid> CredentialSubjectsTypedStorage
        {
            get
            {
                return _credentialSubjectsTypedStorage;
            }
            set
            {
                _credentialSubjectsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await CredentialsTypedStorage.InitializeAsync("PublicCredentials", "Credentials");
            await CredentialSubjectsTypedStorage.InitializeAsync("PublicCredentials", "CredentialSubjects");
        }
        
        /// <summary>
        /// Implements any storage change for PublicCredentials.Credentials
        /// </summary>
        [StorageChange("PublicCredentials", "Credentials")]
        public void OnUpdateCredentials(string key, string data)
        {
            CredentialsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Credentials
        ///  The map of public credentials already attested.
        ///  It maps from a (subject id + credential id) -> the creation
        ///  details of the credential.
        /// </summary>
        public Substrate.KILT.NET.NetApiExt.Generated.Model.public_credentials.credentials.CredentialEntry GetCredentials(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CredentialsTypedStorage.Dictionary.TryGetValue(key, out Substrate.KILT.NET.NetApiExt.Generated.Model.public_credentials.credentials.CredentialEntry result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for PublicCredentials.CredentialSubjects
        /// </summary>
        [StorageChange("PublicCredentials", "CredentialSubjects")]
        public void OnUpdateCredentialSubjects(string key, string data)
        {
            CredentialSubjectsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> CredentialSubjects
        ///  A reverse index mapping from credential ID to the subject the credential
        ///  was issued to.
        /// 
        ///  It it used to perform efficient lookup of credentials given their ID.
        /// </summary>
        public Substrate.KILT.NET.NetApiExt.Generated.Model.runtime_common.assets.AssetDid GetCredentialSubjects(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CredentialSubjectsTypedStorage.Dictionary.TryGetValue(key, out Substrate.KILT.NET.NetApiExt.Generated.Model.runtime_common.assets.AssetDid result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
