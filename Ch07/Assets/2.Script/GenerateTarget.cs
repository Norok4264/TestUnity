using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTarget : MonoBehaviour
{
    public GameObject targetPrefab;
    float minDistance = 10f;
    Transform player;

    Transform[] destinations;

    // Start is called before the first frame update
    void Start()
    {
        destinations = GetComponentsInChildren<Transform>();
        Debug.Log("Num of children: " + destinations.Length);
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    public void GenerateTargetObject()
    {
        int index;
        Vector3 position;

        // 적절한 위치를 찾을 때까지 반복
        do
        {
            index = Random.Range(1, destinations.Length); // 부모 제외
            position = destinations[index].position;
        } while (Vector3.Distance(position, player.position) < minDistance);

        GameObject target = Instantiate(targetPrefab, position, Quaternion.identity);
        target.transform.SetParent(destinations[index]);
    }
}

