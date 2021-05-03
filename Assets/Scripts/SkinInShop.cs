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

    private MeshFilter meshFilter;
    private MeshRenderer meshRenderer;
    GameObject player;
    GameManager gameManager;
    private MeshFilter playerMeshFilter;
    private MeshRenderer playerMeshRenderer;

    public bool isSkinUnlocked = false;

    private void Awake()
    {
        skinImage.sprite = skinInfo.skinSprite;
        
        IsSkinUnlocked();
    }

    private void Start()
    {
        player = GameObject.Find("Player");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        meshFilter = skinInfo.skin.GetComponent<MeshFilter>();
        meshRenderer = skinInfo.skin.GetComponent<MeshRenderer>();
        playerMeshFilter = player.GetComponent<MeshFilter>();
        playerMeshRenderer = player.GetComponent<MeshRenderer>();
    }

    public void OnButtonPress()
    {
        if (isSkinUnlocked)
        {
            EquipSkin();
        }
        else
        {
            if (gameManager.GetMoney() >= skinInfo.skinPrice)
            {
                PlayerPrefs.SetInt(skinInfo.skinID.ToString(), 1);
                IsSkinUnlocked();
                gameManager.RemoveMoney(skinInfo.skinPrice);
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
        else
        {
            buttonText.text = skinInfo.skinPrice.ToString();
        }
    }

    void EquipSkin()
    {
        PlayerPrefs.SetInt("equipedSkin", skinInfo.skinID);

        //Debug.Log(PlayerPrefs.GetInt("skinEquiped", 0));

        playerMeshFilter.mesh = meshFilter.sharedMesh;
        playerMeshRenderer.materials = meshRenderer.sharedMaterials;
      
    }
}
