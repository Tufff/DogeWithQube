using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleSpawner : MonoBehaviour
{
    [SerializeField]
    protected GameObject obsticle, spawnTriggerObject;
    [SerializeField]
    protected int numberOfObsticles = 3; //new list declaration needed in SpawnRowOfObsticles in case of changed amount (*)
    protected Transform groundTransform;

    // Start is called before the first frame update
    void Start()
    {
        groundTransform = GameObject.Find("Ground").transform;
        SpawnRowOfObsticles(obsticle, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnRowOfObsticles(GameObject obsticle, int minObsticles = 0, float positionZ = 40f)
    {
        Transform triggerTransform = Instantiate(spawnTriggerObject, new Vector3(0f, 1f, positionZ), Quaternion.identity, groundTransform).GetComponent<Transform>();
        int howManyInRow = Random.Range(minObsticles, numberOfObsticles + 1);
        List<int> slotIndexes = new List<int>{ 1, 2, 3, 4 };// (*)
        for (int i = 0; i < howManyInRow; i++)
        {
            int randIndex = Random.Range(0, slotIndexes.Count);
            float leftSideX = -1.5f;
            for (int j = 1; j < slotIndexes[randIndex]; j++) { leftSideX += 1f; }
            Instantiate(obsticle, new Vector3(leftSideX, -0.5f, positionZ), Quaternion.Euler(-90f, 0f, 0f), triggerTransform);
            
            slotIndexes.RemoveAt(randIndex);
        }
    }

}
