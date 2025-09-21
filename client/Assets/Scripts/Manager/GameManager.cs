using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 싱글톤
    public static GameManager Instance;
    
    public List<Dog> Dogs = new List<Dog>();
    public List<Player> Players = new List<Player>();
    public GachaSystem Gacha;

    public float TotalMoney = 0f;

    public int totalGold = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = FindObjectOfType<GameManager>();
        }
    }

    private void Start()
    {
        Gacha = GetComponent<GachaSystem>();

        Dogs.Add(new Dog("Start Dog", 1.0f, 1.0f));
        Players.Add(new Player());

        // InvokeRepeating(nameof(MiningProcess), 1f, 1f);
    }

    private void MiningProcess()
    {
        foreach (var dog in Dogs)
        {
            if (dog.HasGraduated)
                continue;

            TotalMoney += dog.Mine();
        }

        Debug.Log("Total Money: " + TotalMoney);
    }

    public void RescuePlayer()
    {
        foreach (var player in Players)
        {
            if (!player.IsRescued && TotalMoney >= 100f) // 구출 비용 예시
            {
                player.IsRescued = true;
                TotalMoney -= 100f;

                var graduatingDog = Dogs.Find(d => !d.HasGraduated);
                if (graduatingDog != null)
                    graduatingDog.HasGraduated = true;

                Debug.Log("Player Rescued! Dog Graduated.");

                // Dogs.Add(Gacha.GetRandomDog()); // 새로운 강아지 가챠
                return;
            }
        }

        if (AllPlayersRescued())
        {
            Debug.Log("Game Clear! All players rescued.");
        }
    }

    private bool AllPlayersRescued()
    {
        foreach (var player in Players)
        {
            if (!player.IsRescued)
                return false;
        }
        return true;
    }

    public void AddGold(int amount)
    {
        totalGold += amount;
        Debug.Log("Added Gold: " + totalGold);
        UIManager.Instance.UpdateGold(totalGold);
    }

    public bool SubtractGold(int amount)
    {
        if (totalGold < amount)
        {
            Debug.Log($"구매할 수 없습니다.");
            return false;
        }
        
        totalGold -= amount;
        Debug.Log("Subtracted Gold: " + totalGold);
        UIManager.Instance.UpdateGold(totalGold);
        return true;
    }
}