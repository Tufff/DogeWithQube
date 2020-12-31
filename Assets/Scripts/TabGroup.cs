using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    
    List<TabButton> tabButtons;
    public Color tabIdle;
    public Color tabHover;
    public Color tabActive;
    TabButton selectedTab;
    public List<GameObject> pages;

    public void Subscribe(TabButton button)
    {
        if (tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }
        tabButtons.Add(button);
    }

    public void TabEnter(TabButton button)
    {
        ResetTabs();
        if (selectedTab == null || button != selectedTab)
        {
            button.backgroud.color = tabHover;
        }

    }
    public void TabExit(TabButton button)
    {
        ResetTabs();
    }
    public void TabSelected(TabButton button)
    {
        selectedTab = button;
        ResetTabs();
        button.backgroud.color = tabActive;
        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < pages.Count; i++)
        {
            if (i == index)
            {
                pages[i].SetActive(true);
            }
            else
            {
                pages[i].SetActive(false);
            }
        }
    }

    public void ResetTabs()
    {
        foreach(TabButton button in tabButtons)
        {
            if(selectedTab!=null && button == selectedTab) { continue; }
            button.backgroud.color = tabIdle;
        }
    }
}
