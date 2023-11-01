using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class AfterDamage : MonoBehaviour
{
    private Renderer[] _allChildRenderers;
    private Material[] _allMaterials;
    public GameObject[] hearts;
    public GameObject follow;
    private int index=0;
    
    private void Start()
    {
        _allChildRenderers = GetComponentsInChildren<Renderer>();
        _allMaterials = new Material[_allChildRenderers.Length];
        for (int i = 0; i < _allChildRenderers.Length; i++)
        {
            _allMaterials[i] = _allChildRenderers[i].GetComponent<Renderer>().material;
        }
    }

    private void Update()
    {
        hearts[3].transform.position = follow.transform.position;
    }

    public void Damage()
    {
       

        
        StartCoroutine(ColorChanger());
        if (index>= 3) return;
        hearts[index].SetActive(false);
        index++;
    }


    IEnumerator ColorChanger()
    {
        for (int i = 0; i < this._allMaterials.Length; i++)
        {
            this._allMaterials[i].SetColor("_Color", Color.red);
        }
        yield return new WaitForSeconds(.25f);

        for (int i = 0; i < this._allMaterials.Length; i++)
        {
            this._allMaterials[i].SetColor("_Color", Color.white);
        }
    }
}
