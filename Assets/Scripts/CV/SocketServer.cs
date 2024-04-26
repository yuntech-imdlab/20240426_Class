using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using WebSocketSharp.Server;

public class SocketServer : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        CVManager.instance.PushMessage(e.Data);
    }
}
