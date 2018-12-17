using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour {

    public AudioClip animalCry;
    public AudioSource animal;
    public GameObject[] myCanvases;
    public int sceneIndex;

    private void Start()
    {
        if (animal)
        {
            animal.clip = animalCry;
        }
    }

    public void PlaySound()
    {
        animal.Play(0);
    }

    public void RemovingCanvas()
    {
        foreach (GameObject canvas in myCanvases)
        {
           canvas.SetActive(false);
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
