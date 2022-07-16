using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class PlayerController : MonoBehaviour
{
    [SerializeField] InputManager myInputs;

    private Rigidbody2D rig;

    private Vector2 movement;
    private Vector2 currentMovement;
    private Vector2 smoothMovement;
    private float speed = 1f;

    public float speedPlayer;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        Inputs();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void Inputs()
    {
        movement = myInputs.input.Player.Movement.ReadValue<Vector2>().normalized;
        //currentMovement = Vector2.SmoothDamp(currentMovement, movement, ref smoothMovement, speed);
    }

    private void MovePlayer()
    {
        rig.velocity = new Vector2(movement.x * speedPlayer, movement.y * speedPlayer);
    }
}
