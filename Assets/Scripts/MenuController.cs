using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
public class MenuController : MonoBehaviour
{
    public Button StartButton;

    private void Start()
    {
        StartButton.onClick.AddListener(StartGame);
        StartButton.onClick.AddListener(() => StartGame(true));
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        
    }

    public void StartGame(bool withItems)
    {
        
    }


}
