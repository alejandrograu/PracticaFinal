using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	
	private void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag=="Cercle"){
			Destroy(collision.gameObject);
			GameManager.currentNumberRingsCaught++;
		}
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
