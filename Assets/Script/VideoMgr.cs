using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoMgr : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenVideo(string url)
	{
		Handheld.PlayFullScreenMovie (url);
	}
}
