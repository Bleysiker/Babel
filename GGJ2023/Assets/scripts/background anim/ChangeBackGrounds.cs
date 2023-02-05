using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackGrounds : MonoBehaviour
{
    [SerializeField] Sprite[] fondo;
    [SerializeField] SpriteRenderer imagen;
    [SerializeField] REvents changeBackground;
    [SerializeField] int f;
    void Start()
    {
        changeBackground.GEvent += ChangeImage;
    }
    void ChangeImage()
    {
        if (f < 2)
        {
            imagen.sprite = fondo[f];
            f++;
        }
    }
    private void OnDestroy()
    {
        changeBackground.GEvent -= ChangeImage;
    }
}
