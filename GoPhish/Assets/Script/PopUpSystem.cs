using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpSystem : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator;
    public TMP_Text popUpText;

    public void PopUp(string text) {
        popUpBox.SetActive(true);
        //popUpText.text = text; -M
        animator.SetTrigger("pop");
        Debug.Log("PopUp ran");

        // if (popUpBox.activeInHierarchy) {
        //     animator.SetTrigger("close");
        //     Debug.Log("PopUp ran");
        // }
    }

}
