using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Animator _animator;

    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _animator.SetBool("Run", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            _animator.SetBool("Run", false);
        }
    }
}
