using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour {

    
    public ParticleSystem par;
    Collision col;
    Rigidbody roket;
    public Vector3 relativeforce;
    public Vector3 relativeTorque;
    public float liftspeed = 50;
    public float turnspeed = 50;
    float a,b,c,d;
    // Use this for initialization
    void Start() {

        a = MainMenü.Aziz * MainMenü.Velocity;
        b = MainMenü.Height / MainMenü.Diameter;
        c = MainMenü.Thrust / MainMenü.Rate;
        
        
        par.Stop();
        roket = GetComponent<Rigidbody>();
        GetComponent<ConstantForce>().force = Vector3.up * a * b * c;
        GetComponent<ConstantForce>().relativeForce = relativeforce;
        GetComponent<ConstantForce>().relativeTorque = new Vector3(0, turnspeed, 0);
        Invoke("Durma", 5);
       
    }

    // Update is called once per frame
    void Update() {
        
        par.transform.position = GetComponent<Transform>().position;
        par.transform.rotation = GetComponent<Transform>().rotation;
        GetComponent<ConstantForce>().force = GetComponent<ConstantForce>().force * (1 / 30);
        GetComponent<ConstantForce>().relativeForce = GetComponent<ConstantForce>().relativeForce * (1 / 3);
        GetComponent<ConstantForce>().relativeTorque = GetComponent<ConstantForce>().relativeTorque * (1 / 3);
        OnCollisionEnter(col);

        

    }

    void Durma()
    {

       
        GetComponent<ParticleSystem>().Stop();
        
        
    }

   

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Terrain" || collision.gameObject.name == "Terrain1" || collision.gameObject.name == "Terrain2" || collision.gameObject.name == "Terrain3" || collision.gameObject.name == "Terrain4" || collision.gameObject.name == "Terrain5" || collision.gameObject.name == "Terrain6" || collision.gameObject.name == "Terrain7" || collision.gameObject.name == "Terrain8" || collision.gameObject.name == "Terrain9" || collision.gameObject.name == "Terrain10" || collision.gameObject.name == "Terrain11" || collision.gameObject.name == "Terrain12" || collision.gameObject.name == "Terrain13" || collision.gameObject.name == "Terrain14" || collision.gameObject.name == "Terrain15")
        {
            
            Destroy(gameObject);
            par.Play();

        }

    }

}
