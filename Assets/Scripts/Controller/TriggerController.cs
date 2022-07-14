using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if(other.GetComponent<Interfaces.ICollectible>() != null)
        {
            other.GetComponent<Interfaces.ICollectible>().Collect();
        }
    }
}
