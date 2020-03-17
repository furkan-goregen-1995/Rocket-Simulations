using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Ekran : MonoBehaviour {

    public GameObject[] kameralar;
    public int kamerasayi = 0;
    public GUIStyle Koordinatlar;
    public GameObject GameObject;
    public Text text;
    float x;
    float y;

    void Start()
    {
        
        y = GameObject.GetComponent<Transform>().position.y;
        for (int i = 0; i < kameralar.Length; i++)
        {
            kameralar[i].SetActive(false);
        }
        kameralar[kamerasayi].SetActive(true);

    }

    void Update()
    {
        x= (GameObject.GetComponent<Transform>().position.y)-y;
        if (Input.GetKeyDown(KeyCode.E))
        {
            kameralar[kamerasayi].SetActive(false);
            kamerasayi++;
            if (kamerasayi >= kameralar.Length)
            {
                kamerasayi = 0;
            }
            kameralar[kamerasayi].SetActive(true);
        }
    }
    // Update is called once per frame
    void OnGUI()
    {
       
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height),"İrtifa: "+x+""+" m",Koordinatlar);
    }

}
