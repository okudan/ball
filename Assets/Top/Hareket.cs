using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Buraya da bi şeyler gelecek

public class Hareket : MonoBehaviour
{
    public Vector3 hareket;

    //text objelerini buralarda olacak

    private bool yerde;
    
    void Start()
    {
        yerde = true;
    }
    
    void Update()
    {
        Getinput();
        //!!!!!!!!!!!!!KODU BURAYA YAZIN!!!!!!!!!!!!!!!!!
    }

    private void Getinput()
    {
        hareket = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Yer")
        {
            yerde = true;
        }
    }
}
