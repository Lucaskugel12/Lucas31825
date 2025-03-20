using UnityEngine;

public class scriptScript : MonoBehaviour
{
    public Rigidbody myRigidbody;
    //private float horizontalimput;
    //private float vertalimput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            print("sdfg");
            myRigidbody.linearVelocity = Vector3.up * 10;

        }
    }
  
}