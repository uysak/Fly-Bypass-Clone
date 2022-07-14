using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing : MonoBehaviour,Interfaces.ICollectible
{
    WingManager wingManager;
    // Start is called before the first frame update
    void Start()
    {
        wingManager = GameObject.FindGameObjectWithTag("Player").GetComponent<WingManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Collect()
    {
        wingManager.CollectWing(this.gameObject);
    }
}
