using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ObjectClone;

    public void CloneObject()
    {
        
            Instantiate(ObjectClone);
            Instantiate(ObjectClone);
            Instantiate(ObjectClone);
        

    }
}
