using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cercle : MonoBehaviour
{
	private const float pos=3000.0f;
	public GameObject player;
	private Vector3 offset;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		offset=transform.position-player.transform.position;
        if((offset.x<-pos) || (offset.x>pos) || (offset.z<-pos) || (offset.z>pos)){
			Destroy(gameObject);
		}
    }
}
