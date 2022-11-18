using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; 
using UnityEngine.EventSystems;
using TMPro;

public class MainButtonHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject txt;
    private bool mouse_over = false;

    public void OnPointerEnter(PointerEventData eventData) {
        mouse_over = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
    }

    void Update() {
        if (mouse_over) {
            txt.transform.Translate(new Vector3(10, 0));
        }
    }

}
