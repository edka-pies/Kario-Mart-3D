using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Car;
    private int BoostCounter;
    private int ScoreCounter;
    private PlayerManager playerManager;
    public int Score = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        Initializer();
    }
    public void Update()
    {
        if (ScoreCounter != Score) 
        {
            ScoreCounter = Score;
            Debug.Log(ScoreCounter);
        }
    }
    private void Initializer() 
    { 
        var car = Instantiate(Car, new Vector3(-18.8f, 12f, -21.2f), Quaternion.identity);
    }
}
