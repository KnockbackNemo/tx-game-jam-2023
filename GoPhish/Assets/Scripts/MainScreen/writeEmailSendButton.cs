using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class writeEmailSendButton : MonoBehaviour
{
    public GameObject setActive;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onSend(){
        this.gameObject.SetActive(false);
        //this.gameObject.GetComponent<Active>() = false;
        //setActive.Visible(true);
        setActive.SetActive(true);
        
    }
}
