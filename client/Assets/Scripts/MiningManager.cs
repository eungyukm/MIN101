using System;
using System.Collections;
using UnityEngine;

public class MiningManager : MonoBehaviour
{
    private void Start()
    {
        Mining();
    }

    private void Mining()
    {
        StartCoroutine(MiningRoutine());
    }

    private IEnumerator MiningRoutine()
    {
        
        while(true)
        {
            // 0.5
            System.Random random = new System.Random((int)Time.time);
            int randomInt = random.Next(1, 3);
            Debug.Log(randomInt);

            if (randomInt <= 1)
            {
                Debug.Log("광물을 캤습니다");
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
