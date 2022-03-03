using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aBox;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aBox.transform.Rotate(0, 180 * Time.deltaTime, 0);   
    }
}
