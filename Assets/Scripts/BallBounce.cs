using UnityEngine;
using System.Collections;

public class BallBounce : MonoBehaviour {
	
	Vector3 basePosition = Vector3.zero;
	
	// Use this for initialization
	void Start () {
		basePosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		// makes a "basePosition" variable increase along the X axis
		basePosition += new Vector3( 1.5f * Time.deltaTime, 0f, 0f );
		
		
		// grabbing basePosition number and adding a sin wave to it (adding the bounce)
		transform.position = basePosition + new Vector3( 0f, Mathf.Abs (Mathf.Sin ( Time.time * 2f ) * 5f), 0f );
		
		
		// if you give sin() the x number it will spit out the same y number
		
		
		// originally telling sin() 1 (below)
		//transform.position = new Vector3 ( 0f, Mathf.Sin(1f), 0f);
		
		
		// giving sin a different value each frame - expressed by time.time
		//if you want it to bounce faster you multiply it
		//transform.position = new Vector3 ( 0f, Mathf.Sin( Time.time * 2f ) * 5f, 0f);
		
		
		//moving the ball in a direction as it bounces (must include the bounce code above)
		//transform.position += new Vector3( 3f * Time.deltaTime, 0f, 0f);
	}
}
