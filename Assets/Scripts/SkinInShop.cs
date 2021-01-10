using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkinInShop : MonoBehaviour
{
    public SSkinInfo skinInfo;
    public Image skinImage;
    public TextMeshProUGUI buttonText;
    //GameObject player;

    public bool isSkinUnlocked = false;

    private void Awake()
    {
        skinImage.sprite = skinInfo.skinSprite;
        IsSkinUnlocked();
    }

    private void Start()
    {
        //player = GameObject.Find("Player");
    }

    public void OnButtonPress()
    {
        if (isSkinUnlocked)
        {
            
        }
        else
        {
            if (true)
            {
                PlayerPrefs.SetInt(skinInfo.skinID.ToString(), 1);
                IsSkinUnlocked();
            }
        }
    }

    void IsSkinUnlocked()
    {
        if(PlayerPrefs.GetInt(skinInfo.skinID.ToString()) == 1)
        {
            isSkinUnlocked = true;
            buttonText.text = "Equip";
        }
    }
}
