using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
   
    [SerializeField] private TMPro.TextMeshProUGUI m_TextMeshProUGUI;

    private int puntuacion = 0;
    public static int puntuacionpu;

    private void Awake()
    {
        UpdatePuntuacion();
    }

    public void AddPoint()
    {
        puntuacion++;
        puntuacionpu = puntuacion;
        UpdatePuntuacion();
    }

    public void RestarPoint()
    {
        puntuacion--;
        puntuacionpu = puntuacion;
        UpdatePuntuacion();
    }

    private void UpdatePuntuacion()
    {
        m_TextMeshProUGUI.text = puntuacion.ToString();
        
    }
}
