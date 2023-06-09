# Substrate Chains .NET API Extensions
*Substrate Chains .NET API Extensions for Relay-, Para- and Solochains in the Substrate ecosystem*  

## Substrate NuGet Packages
[![GitHub issues](https://img.shields.io/github/issues/SubstrateGaming/Substrate.Chains.NET.svg)](https://github.com/SubstrateGaming/Substrate.Chains.NET/issues)
[![license](https://img.shields.io/github/license/SubstrateGaming/Substrate.Chains.NET)](https://github.com/SubstrateGaming/Substrate.Chains.NET/blob/origin/LICENSE)
[![contributors](https://img.shields.io/github/contributors/SubstrateGaming/Substrate.Chains.NET)](https://github.com/SubstrateGaming/Substrate.Chains.NET/graphs/contributors)  

- Ajuna Network .NET SDK ([Link](https://github.com/SubstrateGaming/Substrate.Chains.NET/tree/main/Substrate.Ajuna.NET))  
  - Substrate Ajuna .NET API Extension   
[![Nuget](https://img.shields.io/nuget/v/Substrate.Ajuna.NET.Extension)](https://www.nuget.org/packages/Substrate.Ajuna.NET.Extension/)
![Nuget](https://img.shields.io/nuget/dt/Substrate.Ajuna.NET.Extension)  
![Build](https://github.com/SubstrateGaming/Substrate.Chains.NET/actions/workflows/publish_ajuna.yml/badge.svg)
- Astar Network .NET SDK ([Link](https://github.com/SubstrateGaming/Substrate.Chains.NET/tree/main/Substrate.Astar.NET))  
  - Substrate Astar .NET API Extension  
[![Nuget](https://img.shields.io/nuget/v/Substrate.Astar.NET.Extension)](https://www.nuget.org/packages/Substrate.Astar.NET.Extension/)
![Nuget](https://img.shields.io/nuget/dt/Substrate.Astar.NET.Extension)  
![Build](https://github.com/SubstrateGaming/Substrate.Chains.NET/actions/workflows/publish_astar.yml/badge.svg)  
- Bajun Network .NET SDK ([Link](https://github.com/SubstrateGaming/Substrate.Chains.NET/tree/main/Substrate.Bajun.NET))  
  - Substrate Bajun .NET API Extension  
[![Nuget](https://img.shields.io/nuget/v/Substrate.Bajun.NET.Extension)](https://www.nuget.org/packages/Substrate.Bajun.NET.Extension/)
![Nuget](https://img.shields.io/nuget/dt/Substrate.Bajun.NET.Extension)  
![Build](https://github.com/SubstrateGaming/Substrate.Chains.NET/actions/workflows/publish_bajun.yml/badge.svg)  
- Kusama Network .NET SDK ([Link](https://github.com/SubstrateGaming/Substrate.Chains.NET/tree/main/Substrate.Kusama.NET))  
  - Substrate Kusama .NET API Extension  
[![Nuget](https://img.shields.io/nuget/v/Substrate.Kusama.NET.Extension)](https://www.nuget.org/packages/Substrate.Kusama.NET.Extension/)
![Nuget](https://img.shields.io/nuget/dt/Substrate.Kusama.NET.Extension)  
![Build](https://github.com/SubstrateGaming/Substrate.Chains.NET/actions/workflows/publish_kusama.yml/badge.svg)  
- Polkadot Network .NET SDK ([Link](https://github.com/SubstrateGaming/Substrate.Chains.NET/tree/main/Substrate.Polkadot.NET))  
  - Substrate Polkadot .NET API Extension  
[![Nuget](https://img.shields.io/nuget/v/Substrate.Polkadot.NET.Extension)](https://www.nuget.org/packages/Substrate.Polkadot.NET.Extension/)
![Nuget](https://img.shields.io/nuget/dt/Substrate.Polkadot.NET.Extension)  
![Build](https://github.com/SubstrateGaming/Substrate.Chains.NET/actions/workflows/publish_polkadot.yml/badge.svg)  
- Statemine Network .NET SDK ([Link](https://github.com/SubstrateGaming/Substrate.Chains.NET/tree/main/Substrate.Statemine.NET))  
  - Substrate Statemine .NET API Extension  
[![Nuget](https://img.shields.io/nuget/v/Substrate.Statemine.NET.Extension)](https://www.nuget.org/packages/Substrate.Statemine.NET.Extension/)
![Nuget](https://img.shields.io/nuget/dt/Substrate.Statemine.NET.Extension)  
![Build](https://github.com/SubstrateGaming/Substrate.Chains.NET/actions/workflows/publish_statemine.yml/badge.svg)  
- Statemint Network .NET SDK ([Link](https://github.com/SubstrateGaming/Substrate.Chains.NET/tree/main/Substrate.Statemint.NET))  
  - Substrate Statemint .NET API Extension  
[![Nuget](https://img.shields.io/nuget/v/Substrate.Statemint.NET.Extension)](https://www.nuget.org/packages/Substrate.Statemint.NET.Extension/)
![Nuget](https://img.shields.io/nuget/dt/Substrate.Statemint.NET.Extension)  
![Build](https://github.com/SubstrateGaming/Substrate.Chains.NET/actions/workflows/publish_statemint.yml/badge.svg)  

## Add or update Package

Make sure you have .NET installed ([Linux, macOS & Windows .NET Install](https://learn.microsoft.com/en-us/dotnet/core/install/))
- git clone https://github.com/SubstrateGaming/Substrate.Chains.NET.git
- create directory Substrate.<chain_name>.NET
- go into the directory
- make sure you have ```dotnet new --install Substrate.DotNet.Template``` installed
- create a new solution ```dotnet new sln```
- create the SDK 

ex. for Substrate.Statemint.NET
```
dotnet new sln
dotnet new substrate \
        --sdk_version 0.4.0 \
        --rest_service Substrate.Statemint.NET.RestService \
        --net_api Substrate.Statemint.NET.NetApiExt \
        --rest_client Substrate.Statemint.NET.RestClient \
        --metadata_websocket wss://statemint-rpc.polkadot.io \
        --force \
        --allow-scripts yes
```
Create a PR, make sure to have the following versioning for the NuGet package,   
```<Version>1.9370.0</Version>``` 1 = prod / 9370 = spec_version / 0 = iteration

## Generated by

- [Substrate .NET API](https://github.com/SubstrateGaming/Substrate.NET.API)  
  Substrate .NET API Core for substrate-based nodes

- [Substrate .NET Toolchain](https://github.com/SubstrateGaming/Substrate.NET.Toolchain)  
  Substrate .NET Toolchain model-driven SDK generator for substrate-based nodes
