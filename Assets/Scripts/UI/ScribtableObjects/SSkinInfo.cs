using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName = "New Skin", menuName = "Create New Skin")]
public class SSkinInfo : ScriptableObject
{
    public int skinID;
    public GameObject skin;
    public Sprite skinSprite;
    public int skinPrice;
}
