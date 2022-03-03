using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _03NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BOX;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKey(KeyCode.W)) {
        BOX.transform.Translate(0, 0, 6 * Time.deltaTime);
    }
    }
}
