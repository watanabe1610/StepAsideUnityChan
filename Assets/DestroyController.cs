using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject unitychan = GameObject.Find("unitychan");

        if (unitychan.transform.position.z - 10 > this.transform.position.z)
        {
            Destroy(this.gameObject);
        }
        
    }
}
