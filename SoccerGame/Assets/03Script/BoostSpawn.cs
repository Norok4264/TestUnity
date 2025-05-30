using System.Collections;
using UnityEngine;

public class BoostSpawn : MonoBehaviour
{
    public GameObject boostPrefab; // Boost 프리팹
    public Transform groundTransform; // Ground 오브젝트

    void Start()
    {
        StartCoroutine(SpawnBoostRandomly());
    }

    IEnumerator SpawnBoostRandomly()
    {
        float delay = Random.Range(1f, 15f);
        yield return new WaitForSeconds(delay);

        SpawnBoost();
    }

    void SpawnBoost()
    {
        Vector3 groundPos = groundTransform.position;
        Vector3 groundScale = groundTransform.localScale;

        // XZ 평면의 랜덤 위치 계산 (Y는 Ground 위에 살짝 띄움)
        float x = Random.Range(-groundScale.x / 2f, groundScale.x / 2f);
        float z = Random.Range(-groundScale.z / 5f, groundScale.z / 5f);
        Vector3 spawnPos = new Vector3(x, 1f, z) + groundPos;

        Instantiate(boostPrefab, spawnPos, Quaternion.identity);
    }
}