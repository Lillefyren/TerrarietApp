using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasChanging : MonoBehaviour {

    public GameObject nextCanvas;
    public GameObject thisCanvas;

    public void ChangeCanvas()
    {
        nextCanvas.SetActive(true);
        thisCanvas.SetActive(false);
    }
}
