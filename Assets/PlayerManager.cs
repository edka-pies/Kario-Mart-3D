using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using static UnityEngine.GraphicsBuffer;

public class PlayerManager : MonoBehaviour
{
    private PlayerControl playerControl;
    public Rigidbody rb;
    private float currentSpeed = 0f;
    public float moveFactorSpeed = 1f;
    public float rotationspeed = 1f;
    public float accelerationFactor = 0.1f;
    public int boost = 20;
    private int maxBoost = 30;
    public float health = 100;
    private int maxHealth = 100;

    private void Awake()
    {
        playerControl = new PlayerControl();
    }
    private void Start()
    {
        gameObject.tag = "Car";
    }
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        playerControl.Enable();
    }
    private void OnDisable()
    {
        rb = null;
        playerControl.Disable();
    }
    private void Update()
    {
        float rotvalue = (playerControl.Player.Rotation.ReadValue<float>());
        transform.Rotate(Vector3.up * rotvalue * rotationspeed * 0.1f, Space.World);
    }
    private void FixedUpdate()
    {
        float acceleration = playerControl.Player.Move.ReadValue<float>();
        if (currentSpeed > 0 && currentSpeed < 1f)
            currentSpeed -= accelerationFactor * Time.deltaTime * 0.1f;
            currentSpeed += acceleration * Time.deltaTime * accelerationFactor;
        transform.Translate(Vector3.forward * currentSpeed * moveFactorSpeed);
        playerControl.Player.Boost.performed += Boost_performed;
    }
    private void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "Wall")
        {
            transform.Translate(Vector3.back * 2);
            health = health - (20f * currentSpeed);
            currentSpeed = 0f;
            Debug.Log(health);
        }
        if (target.gameObject.tag == "Boost")
        {
            boost += 15;
            Debug.Log($"{boost}");
        }
    }
    private void Boost_performed(InputAction.CallbackContext obj)
    {
        currentSpeed = currentSpeed + 1f;
    }
}
