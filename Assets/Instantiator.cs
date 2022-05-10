using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Instantiator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ObjectClone;
    public int cloneAmount;
    public Text txtCloneAmount;
    public void CloneObject()
        
    {
        cloneAmount = int.Parse(txtCloneAmount.text);
        int i = 0;
        while (i<cloneAmount)
        {
            Instantiate(ObjectClone);
            i++;
        }
            

        

    }
}
