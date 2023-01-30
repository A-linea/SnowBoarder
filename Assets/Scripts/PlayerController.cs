using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _playerBody;
    private SurfaceEffector2D SurfaceEffector2D;    

    [SerializeField] private float torqueAmount = 8f;
    [SerializeField] private float boostSpeed = 1f;
    [SerializeField] private float baseSpeed = 15f;
    private bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        _playerBody = GetComponent<Rigidbody2D>();
        SurfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();    
        }
    }

    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            SurfaceEffector2D.speed += boostSpeed;
        }
        else
        {
            SurfaceEffector2D.speed = baseSpeed;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _playerBody.AddTorque(torqueAmount);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _playerBody.AddTorque(-torqueAmount);
        }
    }

    public void DisableControlls()
    {
        canMove = false;
    }
}