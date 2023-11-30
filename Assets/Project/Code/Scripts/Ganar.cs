using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganar : MonoBehaviour
{

    public GameObject[] robots;
    public GameObject[] estrellas;
    public GameObject panelWin,panelLose;
    private int p;
    // Start is called before the first frame update
    void Start()
    {
        Chariot.puntuacionpu  = 0;
        HealthSystem.puntuacionMala = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
           
        foreach (GameObject r in robots)
        {
            if (r.activeSelf)
            {
              
                
                
            }
            else
            {
                
                
                if (Chariot.puntuacionpu == 3)
                {
                    panelWin.SetActive(true);
                    estrellas[2].SetActive(true);
                }
                else if (Chariot.puntuacionpu == 2 && HealthSystem.puntuacionMala==1)
                {
                    panelWin.SetActive(true);
                    estrellas[1].SetActive(true);
                }
                else if (Chariot.puntuacionpu == 1 && HealthSystem.puntuacionMala == 2)
                {
                    panelWin.SetActive(true);
                    estrellas[0].SetActive(true);
                }
                else if (HealthSystem.puntuacionMala==3)
                {
                    panelLose.SetActive(true);
                }
            }

        }


       
    }

    
}
