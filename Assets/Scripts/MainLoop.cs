using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainLoop : MonoBehaviour
{
	public Text numberStonesDestroyed, numberRingsCaught;
	public GameObject[] stones= new GameObject[5]; // Cantidad de objectos.
	public GameObject[] cercles=new GameObject[2];
	public float torque=5.0f; // Fuerza que provoca la rotacion.
	// Diferentes valores aleatorios para las rocas(stones).
	public float minAntiGravity = 20.0f, maxAntiGravity = 40.0f;
	public float minLateralForce=-15.0f, maxLateralForce=15.0f;
	public float minTimeBetweenStones=0.1f, maxTimeBetweenStones=0.2f;
	public float minX=-500.0f, maxX=500.0f;
	public float minZ=-500.0f, maxZ=500.0f;
	private bool enableStones=true;
	private bool enableRings=true;
	private Rigidbody rigidBody;
	
    // Start is called before the first frame update
    void Start()
    {
		numberStonesDestroyed.text="Stones Thrown: ";
		numberRingsCaught.text="Rings Caught: ";
        StartCoroutine(ThrowStones());
		StartCoroutine(Rings());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	IEnumerator ThrowStones(){
		yield return new WaitForSeconds(0.1f);
		while (enableStones){
			// Valores aleatorios para:  El tipo de roca, valores iniciales de posicion y rotacion.
			GameObject stone=(GameObject) Instantiate(stones[Random.Range(0, stones.Length)]);
			stone.transform.position=new Vector3(Random.Range(transform.position.x+minX,transform.position.x+maxX),transform.position.y+1000.0f,Random.Range(transform.position.z+minZ,transform.position.z+maxZ));
			stone.transform.rotation=Random.rotation;
			
			rigidBody=stone.GetComponent<Rigidbody>();
			rigidBody.AddTorque(Vector3.down*torque, ForceMode.Impulse);
			rigidBody.AddTorque(Vector3.right*torque, ForceMode.Impulse);
			rigidBody.AddTorque(Vector3.forward*torque, ForceMode.Impulse);
			rigidBody.AddForce(Vector3.down*Random.Range(minAntiGravity,maxAntiGravity),ForceMode.Impulse);
			rigidBody.AddForce(Vector3.right*Random.Range(minLateralForce,maxLateralForce),ForceMode.Impulse);
			ShowStonesRingsNumber();
			// La proxima vez ejecuta el coroutine.
			yield return new WaitForSeconds(Random.Range(minTimeBetweenStones, maxTimeBetweenStones));
		}
	}
	
	IEnumerator Rings(){
		yield return new WaitForSeconds(2.0f);
		while(enableRings){
			GameObject cercle=(GameObject) Instantiate(cercles[Random.Range(0,cercles.Length)]);
			cercle.transform.position=new Vector3(Random.Range(transform.position.x-1000, transform.position.x+1000), Random.Range(transform.position.y-1000,transform.position.y+1000),Random.Range(transform.position.z+1000, transform.position.z+1000));
			yield return new WaitForSeconds(Random.Range(5f, 10f));
		}
		
	}
	
	void ShowStonesRingsNumber(){
		numberStonesDestroyed.text="Stones Destroyed: "+GameManager.currentNumberStonesDestroyed;
		numberRingsCaught.text="Rings Caught: "+GameManager.currentNumberRingsCaught;
	}
}
