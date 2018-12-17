using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fadeout : MonoBehaviour {

    public CanvasGroup toFade;
    private float timer;
    private bool clamp;

	// Use this for initialization
	void Start () {
        timer = 5f;
	}
	
	// Update is called once per frame
	void Update () {
        if (clamp == false && isActiveAndEnabled)
        {
            timer -= Time.deltaTime;
            Mathf.Clamp(timer, 0.2f, 5f);
            toFade.alpha = timer;
        }

        if (timer <= 0.3f)
        {
            clamp = true;
        }
	}

    public void Refresh()
    {
        timer = 5f;
        clamp = false;
    }
}
