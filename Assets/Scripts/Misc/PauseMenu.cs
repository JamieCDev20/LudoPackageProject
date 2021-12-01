using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] private GameObject go_mainCanvas;

    private void OnEnable()
    {
        Time.timeScale = Mathf.Epsilon;
        go_mainCanvas.SetActive(true);
    }

    private void OnDisable()
    {
        Time.timeScale = 1;
        go_mainCanvas.SetActive(false);
    }

}
