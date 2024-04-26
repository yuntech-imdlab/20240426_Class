using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Card
{
    public string uuid;
    public Color color;
}

public class ArduinoManager : MonoBehaviour
{
    public Image image;
    public List<Card> cardList;

    private SerialController m_serialController;

    private void Start()
    {
        m_serialController = GetComponent<SerialController>();
    }

    private void Update()
    {
        var msg = m_serialController.ReadSerialMessage();
        if (string.IsNullOrEmpty(msg))
            return;

        Debug.Log(msg);

        var card = cardList.FirstOrDefault(x => x.uuid == msg);
        if (card is null)
            return;

        image.color = card.color;
    }
}
