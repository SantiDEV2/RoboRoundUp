using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI m_TextMeshProUGUI;

    private int puntuacion = 0;

    private void Awake()
    {
        UpdatePuntuacion();
    }

    public void AddPoint()
    {
        puntuacion++;
        UpdatePuntuacion();
    }

    public void RestarPoint()
    {
        puntuacion--;
        UpdatePuntuacion();
    }

    private void UpdatePuntuacion()
    {
        m_TextMeshProUGUI.text = puntuacion.ToString();
    }
}
