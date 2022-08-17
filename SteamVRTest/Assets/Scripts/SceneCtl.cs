using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.SceneManagement;

public class SceneCtl : MonoBehaviour
{
    UIElement resetButton;
    UIElement quitButton;
    private void Awake()
    {
        resetButton = GameObject.Find("Reset").GetComponent<UIElement>();
        quitButton = GameObject.Find("Quit").GetComponent<UIElement>();
        resetButton.onHandClick.AddListener(a => SceneManager.LoadScene("BasketballCourt"));
        quitButton.onHandClick.AddListener(a => Application.Quit());
    }
}
