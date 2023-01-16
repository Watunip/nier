using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMovement : MonoBehaviour
{
    #region Exposed

    [SerializeField] float m_speed = 5f;
    [SerializeField] float m_rotationspeed = 5f;

    #endregion

    #region Unity Lifecycle
    private void Awake()
    {

    }


    void Start()
    {
        _rigidbody= GetComponent<Rigidbody>();

        _playerTransform = GameObject.Find("Joueur").GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 directionToPlayer = _playerTransform.position - transform.position;
        Quaternion rotationToPlayer = Quaternion.LookRotation(directionToPlayer);
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, rotationToPlayer, m_rotationspeed * Time.deltaTime);

        _rigidbody.velocity = transform.forward * m_speed;
        _rigidbody.MoveRotation(rotation);
    }

    private void OnCollisionEnter(Collision collision)
    {
    }
    #endregion

    #region Methods

    #endregion

    #region Private & Protected

    private Rigidbody _rigidbody;

    private Transform _playerTransform;

    #endregion
}
