using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour {


    public Transform hedef;
    public Vector3 mesafe;
	
	// Update is called once per frame
	private void LateUpdate () {

        transform.LookAt(hedef.position + Vector3.up * 2f);

	}
}
