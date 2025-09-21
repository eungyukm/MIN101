using System.Collections.Generic;
using UnityEngine;

public class DogManager : MonoBehaviour
{
    public static DogManager Instance;
    
    [SerializeField] private GameObject dogPrefab;
    
    public Dictionary<int, DogBase> DicDogs = new Dictionary<int, DogBase>();
    int dogIndex = 0;
    
    public List<DogSO> DogList = new List<DogSO>(); 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = FindObjectOfType<DogManager>();
        }
    }

    private void Start()
    {
        CreateDog();
        // CreateDog();
    }

    void CreateDog()
    {
        // 예외처리
        if (dogIndex >= DogList.Count)
        {
            return;
        }
        
        GameObject dog = Instantiate(dogPrefab, transform);
        DogBase dogBase = dog.GetComponent<DogBase>();
        dogBase.InitializeDog(DogList[dogIndex]);
        DicDogs.Add(dogIndex, dogBase);
        dogIndex++;
    }

    public void WorkAllDogs()
    {
        foreach (DogBase dogBase in DicDogs.Values)
        {
            dogBase.DoWork();
        }
    }
}