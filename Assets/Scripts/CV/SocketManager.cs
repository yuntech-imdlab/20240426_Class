using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp.Server;

public class SocketManager : MonoBehaviour
{
    private WebSocketServer m_wssv;

    private void Start()
    {
        m_wssv = new WebSocketServer(8080);
        m_wssv.AddWebSocketService<SocketServer>("/");
        m_wssv.Start();
    }

    private void OnDisable()
    {
        m_wssv.Stop();
    }
}
