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

    e7afe98a-34a2-406d-9d99-dd709e75a3de

Example Runner Included in folder "DickinsonBros.Guid.Runner"

<h2>Setup</h2>

<h3>Install a windows certificate</h3>

<h3>Add Nuget References</h3>

    https://www.nuget.org/packages/DickinsonBros.Guid/
    https://www.nuget.org/packages/DickinsonBros.Guid.Abstractions

<h3>Create Instance</h3>

```C#    
using DickinsonBros.Guid;

...

var guidService = new GuidService();
```

<h3>Create Instance (With Dependency Injection)</h3>

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
