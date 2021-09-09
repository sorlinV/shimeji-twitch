using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStreamlabs;
using WebSocketSharp;
using System.Web;

//DATA https://dev.streamlabs.com/docs/socket-api
//DATA APIKeys.streamlabskey
public class StreamlabsComponent : MonoBehaviour
{
    private void OnEnable()
    {
        WebSocket webSocket = new WebSocket($"wss://sockets.streamlabs.com/socket.io/?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ0b2tlbiI6IjQ2NDIyQ0Q3NjJBNzkwQThFN0NGIiwicmVhZF9vbmx5Ijp0cnVlLCJwcmV2ZW50X21hc3RlciI6dHJ1ZSwidHdpdGNoX2lkIjoiNjAyMjcyMDcifQ.Xzs6_ee_nH-LdiPkMRGSa1oq1_z0WCKTBtZGLgI9vsM&EIO=3&transport=websocket");
        webSocket.EmitOnPing = true;
        webSocket.OnOpen += HandleOpen;
        webSocket.OnClose += HandleClose;
        webSocket.OnError += HandleError;
        webSocket.OnMessage += HandleSocketMessage;
        webSocket.Connect();
    }

    void HandleOpen(object sender, EventArgs evt)
    {
        //Debug.Log("HandleOpen");
    }
    void HandleClose(object sender, CloseEventArgs evt)
    {
        //Debug.Log("HandleClose");
    }
    void HandleError(object sender, ErrorEventArgs evt)
    {
        //Debug.LogError("HandleError");
    }
    void HandleSocketMessage(object sender, MessageEventArgs evt)
    {
        if(evt.Data[0] != '0')
        {
            string[] data = evt.Data.Split('[');
            Debug.Log();
            //var code = evt.Data[0];
            //var data = evt.Data.Substring(1);
            //var obj = JsonUtility.FromJson<Dictionary<string, string>>(data);
            //foreach (KeyValuePair<string, string> kvp in obj)
            //{
            //    Debug.Log("Key = "+ kvp.Key+", Value = "+ kvp.Value);
            //}
        }
    }
}