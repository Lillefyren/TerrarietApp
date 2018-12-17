using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class OnRecognize : MonoBehaviour, ITrackableEventHandler
{

    private TrackableBehaviour mTrackableBehaviour;
    public GameObject[] myCanvases;
    public GameObject[] otherCanvases;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Do something when target is found
            foreach (GameObject c in myCanvases)
            {
                c.SetActive(true);
            }


            foreach (GameObject canvas in otherCanvases)
            {
                canvas.SetActive(false);
            }
        }
        else
        {
            // Do something when target is lost
            //foreach (GameObject canvas in myCanvases)
            //{
            //    canvas.SetActive(false);
            //}
        }
    }
}
