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
        puntuacion = 0;
    }

    public void AddPoint()
    {
        puntuacion++;
        
        UpdatePuntuacion();
    }

    

    private void UpdatePuntuacion()
    {
        m_TextMeshProUGUI.text = puntuacion.ToString();
        
    }
}
