using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;

public class TestInstantiate : Photon.PunBehaviour
{

    [SerializeField]
    private GameObject testObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.I))
        {
            PhotonNetwork.Instantiate("TestCube", Vector3.zero,Quaternion.identity,0);
        }
	}
}
