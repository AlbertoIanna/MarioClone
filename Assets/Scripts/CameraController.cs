using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public BasePlayer PlayerToFollow;
    public Camera MainCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MainCamera.orthographicSize = 8;
        transform.position = new Vector3(PlayerToFollow.transform.position.x, PlayerToFollow.transform.position.y, -10 );
	}
}
