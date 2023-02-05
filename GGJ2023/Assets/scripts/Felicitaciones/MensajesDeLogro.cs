using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MensajesDeLogro : MonoBehaviour
{
    [SerializeField] string mensaje;
    [SerializeField] REvents changeMessage;
    [SerializeField] TextMeshProUGUI texto;
    void Start()
    {
        changeMessage.GEvent += ChangeMessage;
    }

    void ChangeMessage()
    {
        texto.text = mensaje;
    }
    private void OnDestroy()
    {
        changeMessage.GEvent -= ChangeMessage;
    }
}
