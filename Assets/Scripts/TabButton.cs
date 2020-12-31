using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public TabGroup tabGroup;

    public Image backgroud;

    

    void Start()
    {
        backgroud = GetComponent<Image>();
        tabGroup.Subscribe(this);
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        tabGroup.TabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabGroup.TabExit(this);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroup.TabSelected(this);
    }
}
