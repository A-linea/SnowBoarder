using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _playerBody;

    [SerializeField] private float torqueAmount = 8f; 
    // Start is called before the first frame update
    void Start()
    {
       _playerBody =  GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _playerBody.AddTorque(torqueAmount);
        }

       else if ( Input.GetKey(KeyCode.RightArrow))
        {
            _playerBody.AddTorque(-torqueAmount);
        }
    }
}
