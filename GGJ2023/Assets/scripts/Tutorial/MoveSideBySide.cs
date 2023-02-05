using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSideBySide : MonoBehaviour
{
    [SerializeField] Vector2 posicionf;
    [SerializeField] float transicion;
    void Start()
    {
        transform.LeanMoveLocal(posicionf, transicion).setEaseOutQuart().setLoopPingPong();
    }
}
