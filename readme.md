# About this

This is a sample code for below blog post.

# How to run

## Server side

Deploy SignalRServer project to your web site.

## Client site

- Open SignalRClient folder using Unity 2017.4.
- Build UWP project to UWP folder.
- Open the project using Visual Studio 2017.
- Install Microsoft.AspNet.SignalR.Client package using NuGet
- Change URL as your server at SignalRManager.cs line 25.

```cs
_connection = new HubConnection("http://<your site name>.azurewebsites.net/");
```