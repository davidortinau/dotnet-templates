# Xamarin.Forms Templates

I've added platform projects for 
* Android
* iOS
* macOS
* UWP
* WPF

There are 2 styles of templates, XAML (default) and C# UI.

XAML style:

```terminal
dotnet new xf -n MyApp
```

C# UI style:

```terminal
dotnet new xf -n MyApp --kind sharp
```

## Dependencies

Each template is preloaded with the latest versions of my most commonly used libraries.

* [Xamarin.Forms](https://github.com/xamarin/xamarin.forms)
* [Xamarin.Community.Toolkit](https://github.com/xamarin/XamarinCommunityToolkit)
* [Xamarin.Community.Toolkit.Markup](https://github.com/xamarin/XamarinCommunityToolkit) (C# UI only)
* [Xamarin.Essentials](https://github.com/xamarin/essentials)
* [LiveSharp](https://github.com/OYIon/LiveSharp) (C# UI only)