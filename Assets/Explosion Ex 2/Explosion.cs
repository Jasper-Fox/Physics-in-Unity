using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Explosion : MonoBehaviour
{
    private const float TimeBeforeExplosion = 5;
    private const float StrenghtMult = 40;
    
    public float Strenght = 1;
    
    private GameObject[] actives;
    private Vector3 coordinates;
    private Vector3 Force;
    private Rigidbody _rigidbody;
    private float _timer = TimeBeforeExplosion + 1;
    
    private void Awake()
    {
        actives = GameObject.FindGameObjectsWithTag("Activ");
        Debug.Log("Press Space to plant a bomb!");
    }
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || _timer < TimeBeforeExplosion + 1)
        {
            Countdown();
            if ((int)_timer == 0)
            {
                Explo();
            }  
        }
    }

    
    public void Countdown()
    {
        if (_timer > 1)
        {
            Debug.Log("Bomb has been planted");
            _timer -= Time.deltaTime;
            Debug.Log((int)_timer);
        }  
    }
    
    public void Explo()
    {
        Debug.Log("BAAAAAH!!!");
        foreach (GameObject VARIABLE in actives)
        {
            coordinates = VARIABLE.transform.position - transform.position;
            Force.x = 1 / coordinates.x;
            Force.y = 1 / coordinates.y;
            Force.z = 1 / coordinates.z;
            _rigidbody = VARIABLE.GetComponent<Rigidbody>();
            _rigidbody.AddForce(Force*StrenghtMult*Strenght, ForceMode.Impulse);
            gameObject.SetActive(false);
            _timer = -1;
        }
    }
}