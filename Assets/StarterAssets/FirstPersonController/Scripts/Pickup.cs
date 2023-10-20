using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public GameObject Clipboard;
    public Transform OnHand;
    // Start is called before the first frame update
    void Start()
    {
        Clipboard.GetComponent<Rigidbody>().isKinematic = true;
    }

    void Update()
    {  
        if(Input.GetKey(KeyCode.F)) 
        {
            Drop();
        }
    }

    void Drop()
    {
        OnHand.DetachChildren();
        Clipboard.transform.eulerAngles = new Vector3(Clipboard.transform.position.x,Clipboard.transform.position.y,Clipboard.transform.position.z);
        Clipboard.GetComponent<Rigidbody>().isKinematic=false;
        Clipboard.GetComponent<MeshCollider>().enabled = true;
    }

    void Equip()
    {
        Clipboard.GetComponent <Rigidbody>().isKinematic = true;
       
        Clipboard.transform.position = OnHand.transform.position;
        Clipboard.transform.rotation = OnHand.transform.rotation;

        Clipboard.GetComponent<MeshCollider>().enabled = false;

        Clipboard.transform.SetParent(OnHand);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                Equip();
            }
        }    
    }
}

  