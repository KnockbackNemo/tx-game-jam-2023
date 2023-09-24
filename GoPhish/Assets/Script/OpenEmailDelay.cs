using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OpenEmailDelay : MonoBehaviour
{

    public string popUpString;
    public PopUpSystem pop;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("startPopUp", 3);
    }

    public void startPopUp() {
        PopUpSystem pop = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<PopUpSystem>();
        pop.PopUp("");
    }
    
}
