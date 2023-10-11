using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private GameManager gameManager;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Car")
            gameManager.Score++;
    }
}
