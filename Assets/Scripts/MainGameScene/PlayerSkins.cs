using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkins : MonoBehaviour
{
    public List<SSkinInfo> skinList;

    private MeshFilter meshFilter;
    private MeshRenderer meshRenderer;
    private MeshFilter playerMeshFilter;
    private MeshRenderer playerMeshRenderer;
    private int equipedSkinId;

    private void Awake()
    {
        playerMeshFilter = gameObject.GetComponent<MeshFilter>();
        playerMeshRenderer = gameObject.GetComponent<MeshRenderer>();
        meshFilter = skinList[PlayerPrefs.GetInt("equipedSkin", 0) - 1].skin.GetComponent<MeshFilter>();
        meshRenderer = skinList[PlayerPrefs.GetInt("equipedSkin", 0) - 1].skin.GetComponent<MeshRenderer>();
        if (PlayerPrefs.GetInt("equipedSkin", 0) != 0)
        {
            playerMeshFilter.mesh = meshFilter.sharedMesh;
            playerMeshRenderer.materials = meshRenderer.sharedMaterials;
        }
    }
}
