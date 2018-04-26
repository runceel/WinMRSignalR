using UnityEngine;
using System;
using System.Threading;

#if UNITY_UWP
using Microsoft.AspNet.SignalR.Client;
#endif

public class SignalRManager : MonoBehaviour
{
#if UNITY_UWP
    private HubConnection _connection;
    private SynchronizationContext _unityThreadContext;


    private void Start()
    {
        _unityThreadContext = SynchronizationContext.Current;
        InitializeConnection();
    }


    private void InitializeConnection()
    {
        _connection = new HubConnection("http://<your site name>.azurewebsites.net/");
        var createCubeProxy = _connection.CreateHubProxy("createCubeHub");
        createCubeProxy.On<string>("create", Create);
        _connection.Start().ContinueWith(x =>
        {
            UnityEngine.Debug.Log(x.Exception?.Message ?? "Connected");
        });
    }

    private void Create(string name)
    {
        _unityThreadContext.Post(_ =>
        {
            PrimitiveType type;
            if (!Enum.TryParse<PrimitiveType>(name, out type))
            {
                UnityEngine.Debug.LogWarning($"{name} is not defined.");
                return;
            }
            var obj = GameObject.CreatePrimitive(type);
            obj.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 3;
            UnityEngine.Debug.Log($"{name} created at {obj.transform.position}");
        }, null);
    }
#endif
}
