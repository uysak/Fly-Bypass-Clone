using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingManager : MonoBehaviour
{
    [SerializeField] GameObject WingHolder;

    private float _lerpSpeed = 30f;
    private float _offset = 0.1f;
    private List<GameObject> CollectedWings = new List<GameObject>(); 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for(int index = 0; index < CollectedWings.Count; index++)
        {
            if(index == 0)
            {
                CollectedWings[index].transform.position = Vector3.Lerp(CollectedWings[index].transform.position, WingHolder.transform.position,_lerpSpeed * Time.deltaTime);
            }
            else
            {
                CollectedWings[index].transform.position = Vector3.Lerp(CollectedWings[index - 1].transform.position, new Vector3(WingHolder.transform.position.x,WingHolder.transform.position.y + _offset, WingHolder.transform.position.z), _lerpSpeed * Time.deltaTime);
            }
            
        }
    }

    public void CollectWing(GameObject Wing)
    {
        CollectedWings.Add(Wing);
    }


}
