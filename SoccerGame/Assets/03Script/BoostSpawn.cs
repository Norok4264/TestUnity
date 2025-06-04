using System.Collections;
using UnityEngine;

public class BoostSpawn : MonoBehaviour
{
    public GameObject boostPrefab; // Boost 프리팹
    public Transform groundTransform; // Ground 오브젝트

    void Start()
    {
        StartCoroutine(SpawnBoostRandomly()); // 코루틴 실행
    }

    IEnumerator SpawnBoostRandomly()
    {
        float delay = Random.Range(1f, 15f); 
        yield return new WaitForSeconds(delay); // 1~15초 사이에 랜덤 생성

        SpawnBoost();
    }

    void SpawnBoost()
    {
        Vector3 groundPos = groundTransform.position;
        Vector3 groundScale = groundTransform.localScale;

        // XZ 평면의 랜덤 위치 계산 (Y는 Ground 위에 살짝 띄움)
        float x = Random.Range(-groundScale.x / 2f, groundScale.x / 2f); 
        float z = Random.Range(-groundScale.z / 5f, groundScale.z / 5f); // 부스트가 너무 멀리 생성되지 않도록 수치 조절
        Vector3 spawnPos = new Vector3(x, 1f, z) + groundPos; // 지면에서 1정도 떠있게 생성, groundPos를 더해 월드좌표로 변환

        Instantiate(boostPrefab, spawnPos, Quaternion.identity); // boost 해당 위치에 (Quaternion.identity = 회전 없이)생성 
    }
}