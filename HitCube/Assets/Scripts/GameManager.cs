using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    InputManager inputManager;
    public UIManager uiManager;


    private void Awake()
    {
        inputManager = FindObjectOfType<InputManager>();
        uiManager = FindObjectOfType<UIManager>();
    }


    private void Update()
    {
        inputManager.All_Input();
        uiManager.Level_Complete();
    }
}
