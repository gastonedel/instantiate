using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imputfield : MonoBehaviour
{
    public InputField ifUsername;
    public Text txtUsername;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Usergreetings()
    {
        Debug.Log(int.Parse (txtUsername.text) * 2 );
    }
}
