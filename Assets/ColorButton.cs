using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButton : MonoBehaviour
{
    public Color color;

    private void OnMouseDown()
    {
        Painter.color = color;
    }
}
