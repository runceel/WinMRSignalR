# About this

This is a Windows Mixed Reality + SignalR sample code for below blog post(Japanese article).

http://blog.okazuki.jp/entry/2018/04/26/125929

# How to run

## Server side

Deploy SignalRServer project to your web site.

## Client site

- Open SignalRClient folder using Unity 2017.4.
- Build UWP project to UWP folder.
- Open the project using Visual Studio 2017.
- Install Microsoft.AspNet.SignalR.Client package using NuGet
- Change the URL of SignalRManager.cs line 25 to your server.

```cs
_connection = new HubConnection("http://<your site name>.azurewebsites.net/");
```