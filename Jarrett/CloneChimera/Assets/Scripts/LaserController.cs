﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    public float lifeTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, this.lifeTime);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        Destroy(this.gameObject);
    }
}
