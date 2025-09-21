using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class DogBase : MonoBehaviour
{
    private float waitTime = 100.0f;
    protected DogSO dogSO;
    
    
    public void InitializeDog(DogSO dogSO)
    {
        // TODO : 데이터 Init
        this.dogSO = dogSO;
    }
    
    public void DoWork()
    {
        StartCoroutine(CO_Work());
    }
    
    IEnumerator CO_Work()
    {
        float time = waitTime / dogSO.GetSpeed();
        while (true)
        {
            Debug.Log(time);
            yield return new WaitForSeconds(time);
            Work();
        }
    }

    public void Work()
    {
        float mineChance = 0.5f;
        if (Random.value < mineChance)
        {
            Debug.Log("골드 획득!");
            GameManager.Instance.AddGold(10);
        }
    }
}