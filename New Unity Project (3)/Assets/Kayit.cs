using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.IO;
using UnityEngine;

public class Kayit : MonoBehaviour {

    float r;
    float p;
    float h;
    float g;
    float t;
    float z;
    public GameObject GameObject5;
    string[] bilgiler = { "Motor Tipi:" + MainMenü.Aziz, "Roket Hızı:" + MainMenü.Velocity, "Roket Uzunluğu" + MainMenü.Height+"cm", "Roket Çapı:" + MainMenü.Diameter+"cm", "İtme Gücü:" + MainMenü.Thrust+"kN", "Kütle Akış Hızı:" + MainMenü.Rate };

    // Use this for initialization
    void Start () {
        t = GameObject5.GetComponent<Transform>().position.y;
        r = GameObject5.GetComponent<Transform>().position.x;
        h = GameObject5.GetComponent<Transform>().position.z;

        File.WriteAllLines(@"C:\Users\FURKAN\Documents\New Unity Project (3)\Assets\Kayıt.txt", bilgiler);


    }

    // Update is called once per frame
    void Update () {

        
        z = (GameObject5.GetComponent<Transform>().position.y) - t;
        p = (GameObject5.GetComponent<Transform>().position.x) - r;
        g = (GameObject5.GetComponent<Transform>().position.z) - h;
        Ekle();


    }

    void Ekle()
    {
        StreamWriter veriler = new StreamWriter(@"C:\Users\FURKAN\Documents\New Unity Project (3)\Assets\Kayıt.txt",true);
        veriler.WriteLine("x:"+p+" y:"+z+" z:"+g);
        veriler.Close();
    }

   
}
