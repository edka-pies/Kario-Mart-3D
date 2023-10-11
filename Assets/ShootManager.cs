using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootManager : MonoBehaviour
{
    private PlayerControl playerControl;
    private void Update()
    {
        playerControl.Player.Fire.performed += Fire_performed;
    }

    private void Fire_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
    }
}
