using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinInShop : MonoBehaviour
{
    public SSkinInfo skinInfo;
    public Image skinImage;

    public bool isSkinUnlocked = false;

    private void Awake()
    {
        skinImage.sprite = skinInfo.skinSprite;
    }

    public void OnButtonPress()
    {
        if (isSkinUnlocked)
        {

        }
        else
        {

        }
    }
}
