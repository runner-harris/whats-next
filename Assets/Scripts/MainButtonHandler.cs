using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; 
using UnityEngine.EventSystems;
using TMPro;

public class MainButtonHandler : MonoBehaviour
{
    public GameObject txt;
    
    public void OnPointerEnter(PointerEventData eventData) {
        txt.GetComponent<TextMeshPro>().color = Color.red;

    }
}
