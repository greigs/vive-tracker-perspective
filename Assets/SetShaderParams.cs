using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetShaderParams : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame  
    void Update()
    {
        var pos = GameObject.Find("FPSController").gameObject.transform.position;
        var rot = GameObject.Find("FPSController").gameObject.transform.rotation;
        gameObject.GetComponent<Renderer>()
            .sharedMaterial.SetVector("_MyVector", new Vector4(pos.x, pos.y, pos.z, 0f));
        gameObject.GetComponent<Renderer>()
            .sharedMaterial.SetVector("_MyVector2", new Vector4(rot.x, rot.y, rot.z, 0f));

    }
}
