using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

[System.Serializable]
public class Level
{
    public int NumberLevel;
    public string LevelName;

    public Level(int number, string scene)
    {
        NumberLevel = number;
        LevelName = scene;
    }
}
