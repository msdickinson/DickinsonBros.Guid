# DickinsonBros.Guid
<a href="https://www.nuget.org/packages/DickinsonBros.Guid/">
    <img src="https://img.shields.io/nuget/v/DickinsonBros.Guid">
</a>

A wrapper library for Guid

Features

* Adds extensibility via abstraction
* Allows for unit testing

<a href="https://dev.azure.com/marksamdickinson/DickinsonBros/_build?definitionScope=%5CDickinsonBros.Guid">Builds</a>

<h2>Example Usage</h2>

```C#

    var guid = guidService.NewGuid();
    Console.WriteLine(guid);

```
![Alt text](https://raw.githubusercontent.com/msdickinson/DickinsonBros.Guid/master/GuidSampleOutput.PNG)

Example Runner Included in folder "DickinsonBros.Guid.Runner"

<h2>Setup</h2>

<i>Install a windows certificate</i>

<i>Add Nuget References</i>

    https://www.nuget.org/packages/DickinsonBros.Guid/
    https://www.nuget.org/packages/DickinsonBros.Guid/Abstractions

<h3>Create Instance</h3>

<i>Code</i>

```C#    
    using DickinsonBros.Guid;
  
    ...
    
    var guidService = new GuidService()
```

<h3>Create Instance (With Dependency Injection)</h3>

<i>Code</i>
```C#        
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
```    
