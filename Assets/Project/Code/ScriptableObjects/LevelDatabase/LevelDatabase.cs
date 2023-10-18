using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "Level/LevelDatabase", fileName = "LevelDatabase")]
public class LevelDatabase : ScriptableObject
{
    public List<Level> Levels;

    public Level GetLevel(int index)
    {
        if (Levels[index] == null)
            throw new IndexOutOfRangeException("No hay niveles en ese index");

        return Levels[index];
    }
}
