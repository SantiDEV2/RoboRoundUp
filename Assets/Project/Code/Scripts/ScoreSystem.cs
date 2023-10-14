using System.Collections;
using System.Collections.Generic;
using RacTools.Variables;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public Variable<int>[] robots;
    public Variable<int>[] vidas;
    public Variable<int>[] disparos;

    private int _maxRobots;
    private int _maxVidas;
    private int _maxDisparos;

    private void Start() {
        _maxRobots = robots.Length;
        _maxVidas = vidas.Length;
        _maxDisparos = disparos.Length;
    }

    
    


}
