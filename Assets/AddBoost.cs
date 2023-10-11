using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBoost : MonoBehaviour
{
    private PlayerManager playerManager;
    public bool Active = true;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Car")
            this.gameObject.SetActive(false);
            
    }
}
