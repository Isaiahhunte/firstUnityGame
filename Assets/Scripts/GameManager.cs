using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool _gameOver = false;
    [SerializeField] GameObject _enemy;
    int _killCount = 0;

    public void AddPoint()
    {
        _killCount++;
        //Debug.Log(_killCount);
    }
}

