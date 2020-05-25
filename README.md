# DickinsonBros.Guid
<a href="https://www.nuget.org/packages/DickinsonBros.Guid/">
    <img src="https://img.shields.io/nuget/v/DickinsonBros.Guid">
</a>

A wrapper library for Guid

Features

* Adds extensibility via abstraction
* Allows for unit testing

<a href="https://dev.azure.com/marksamdickinson/DickinsonBros/_build?definitionScope=%5CDickinsonBros.Guid">Builds</a>

<b>Create Instance</b>

<i>Code</i>
    
    using DickinsonBros.Guid
    
    ...
    
    var guidService = new GuidService(options)

<b>Create Instance (With Dependency Injeciton)</b>

<i>Code</i>
    
    using DickinsonBros.Guid.Abstractions;
    using DickinsonBros.Guid.Extensions;
    
    ...  
    
    var services = new ServiceCollection();   
    
    //Add Service
    serviceCollection.AddGuidService();
    
    //Build Service Provider 
    using (var provider = services.BuildServiceProvider())
    {
       var guidService = provider.GetRequiredService<IGuidService>();
    }
    
<b>Example Usage</b>

    var guid = guidService.NewGuid()
