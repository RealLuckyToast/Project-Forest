using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{

    public GameObject Selection;
    private GameObject SCopy;
    private Rigidbody SCopyRB;
    private Collider SCopyCol;

    // Start is called before the first frame update
    public void Start()
    {
        
    }



    // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 prePos = Selection.transform.position;
            SCopy = Instantiate(Selection);
            SCopy.transform.position = prePos;
            SCopy.AddComponent<Rigidbody>();
            SCopyCol = SCopy.GetComponent<Collider>();
            SCopyCol.enabled = true;
            SCopyRB = SCopy.GetComponent<Rigidbody>();
            SCopyRB.mass = 0.25f;
            SCopyRB.drag = 3f;
            SCopyRB.AddForce(Camera.main.transform.forward * 250);
            Debug.Log("Throw!" + prePos);
        }
    }


}