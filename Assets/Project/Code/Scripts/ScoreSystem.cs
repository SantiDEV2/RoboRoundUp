using System.Collections;
using System.Collections.Generic;
using RacTools.Variables;
using Unity.Mathematics;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public Variable<int> robots;
    public Variable<int> vidas;
    public Variable<int> disparos;
    public GameObject[] stars;

    private int _maxRobots;
    private int _maxVidas;
    private int _maxDisparos;
    private void Awake()
    {
        vidas.Value = 0;
    }
    private void Start() {
        _maxRobots = robots.Value;
        _maxVidas = vidas.Value;
        _maxDisparos = disparos.Value;
    }

    private void Update() {
        
    }
    public void Score(){
        int _leftRobots = robots.Value;
        int _leftVidas = vidas.Value;
        int _leftDisparos = disparos.Value;

        int _totalRobots = _maxRobots - _leftRobots;
        int _totalVidas = _maxVidas - _leftVidas;
        int _totalDisparos = _maxDisparos - _leftDisparos;

        float _percentage = float.Parse (_totalRobots.ToString() + _totalDisparos.ToString() + _totalVidas.ToString())/float.Parse(_maxRobots.ToString() + _maxDisparos.ToString() + _maxVidas.ToString()) * 100;
        
        if(_percentage >= 33 && _percentage< 66){
            stars[0].SetActive(true);
        }
        else if (_percentage >= 66 && _percentage< 70){
            stars[0].SetActive(true);
            stars[1].SetActive(true);
        }
        else{
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
        }
    }

    
    


}
