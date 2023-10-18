using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevelButton : MonoBehaviour
{
    [SerializeField]
    private Button buttonLoad;

    [SerializeField] private LevelDatabase levelDatabase;
    [SerializeField] private int levelToLoad;

    private void LoadLevel()
    {
        var level = levelDatabase.GetLevel(levelToLoad);

        SceneManager.LoadScene(level.LevelName);
    }
    
    private void OnEnable()
    {
        buttonLoad.onClick.AddListener(LoadLevel);
    }

    private void OnDisable()
    {
        buttonLoad.onClick.RemoveListener(LoadLevel);
    }
}
