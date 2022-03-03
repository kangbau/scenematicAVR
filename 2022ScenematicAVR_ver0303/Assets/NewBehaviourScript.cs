using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //建立元件
    GameObject aBox;


    // Start is called before the first frame update
    void Start()
    {
        //連結元件
        aBox = GameObject.Find("Cube01");
       
    }

    // Update is called once per frame
    void Update()
    {
        //建立事件
        aBox.transform.Rotate(0, 180 * Time.deltaTime, 0);
    }
}
