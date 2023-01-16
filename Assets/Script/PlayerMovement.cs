using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Exposed
    [SerializeField]
    private float m_speed = 5;

    [SerializeField]
    Rigidbody _rigidboby;

    #endregion

    #region Unity Lifecycle
    // Start is called before the first frame update
    void Start()
    {

        _rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //recuperation des inputs pour le déplacement
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        _direction.x = horizontal;
        _direction.y = vertical;

        //recupération des input pour la rotation

        _orientationInput.x = Input.GetAxisRaw("RightStickX");
        _orientationInput.z = Input.GetAxisRaw("RightStickY");

        Debug.Log(horizontal);
    }
    private void FixedUpdate()
    {
        //Movement
        Vector3 movement = new Vector3(_direction.x, 0, _direction.y);

        _rigidbody.velocity = movement * m_speed;
        //Rotation
       
        if (_orientationInput !=Vector3.zero)
        {
            Quaternion rotation = Quaternion.LookRotation(_orientationInput);
            _rigidbody.MoveRotation(rotation);
        }
        
    }
    #endregion

    #region Methods

    #endregion

    #region Private & Protected

    private Vector2 _direction = new Vector2();

    private Rigidbody _rigidbody;

    private Vector3 _orientationInput = new Vector3();

    #endregion

}
