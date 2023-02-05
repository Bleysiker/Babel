using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootEvent : MonoBehaviour
{
    [SerializeField] REvents evento;
    public void ShootEvent()
    {
        evento.FireEvent();
    }
}
