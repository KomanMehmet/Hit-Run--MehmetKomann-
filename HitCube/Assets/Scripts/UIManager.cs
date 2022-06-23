using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    InputManager inputManager;

    [SerializeField] private GameObject levelCompleted;
    [SerializeField] private GameObject targets;

    private void Start()
    {
        inputManager = FindObjectOfType<InputManager>();
    }



    public void Level_Complete()
    {
        if (targets.transform.childCount == 0)
        {
            levelCompleted.SetActive(true);
            inputManager.isShotAvailable = false;
        }


    }


}
