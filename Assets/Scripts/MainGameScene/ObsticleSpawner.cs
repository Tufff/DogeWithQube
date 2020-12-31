using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject obsticle;
    [SerializeField]
    int numberOfObsticles = 4;
    Transform groundTransform;

    // Start is called before the first frame update
    void Start()
    {
        groundTransform = GameObject.Find("Ground").transform;
        SpawnRowOfObsticles(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnRowOfObsticles(int minObsticles = 0)
    {
        int howManyInRow = Random.Range(minObsticles, numberOfObsticles - 1);
        List<int> slotIndexes = new List<int>{ 1, 2, 3, 4 };
        for (int i = 0; i < howManyInRow; i++)
        {
            int randIndex = Random.Range(0, slotIndexes.Count);
            float leftSideX = -1.5f;
            for (int j = 1; j < slotIndexes[randIndex]; j++) { leftSideX += 1f; }
            Instantiate(obsticle, new Vector3(leftSideX, -0.5f, 40f), Quaternion.identity, groundTransform);
            
            slotIndexes.RemoveAt(randIndex);
        }
    }

}
