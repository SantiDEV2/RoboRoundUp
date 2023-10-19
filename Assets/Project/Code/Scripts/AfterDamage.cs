using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterDamage : MonoBehaviour
{
    private Renderer[] _allChildRenderers;
    private Material[] _allMaterials;
    public SpriteRenderer[] hearts;
    public GameObject follow;
    
    private void Start()
    {
        _allChildRenderers = GetComponentsInChildren<Renderer>();
        _allMaterials = new Material[_allChildRenderers.Length];
        for (int i = 0; i < _allChildRenderers.Length; i++)
        {
            _allMaterials[i] = _allChildRenderers[i].GetComponent<Renderer>().material;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
             /*var color = hearts[i].GetComponent<Renderer>().material;
             color.SetColor("Green",Color.green);*/
        }
    }

    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].transform.SetParent(follow.transform);
            hearts[i].transform.Rotate(0,0,0);
        }
        if (Input.GetMouseButton(0))
        {
            StartCoroutine(ColorChanger());
        }
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
