using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealScript : MonoBehaviour
{
	private void Awake()	{
		Debug.Log("LOL");
	}

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("LMAO");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.X))	{
			Debug.Log("MEOW");
		}
    }
}
