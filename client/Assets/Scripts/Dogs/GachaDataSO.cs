using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "GachaData", menuName = "ScriptableObjects/GachaData", order = 1)]
public class GachaDataSO : ScriptableObject
{
    public List<DogData> DogList = new List<DogData>();
    
    public void CreateRandomDogs()
    {
        for (int i = 0; i < 1000; i++)
        {
            DogData dog = new DogData();
            dog.id = i;
            dog.name = "Dog" + i;
            dog.age = Random.Range(1, 10);
            dog.maxLife = Random.Range(1, 10);
            dog.size = (DogData.DogSize)Random.Range(0, 2);
            dog.grade = (DogData.DogGrade)Random.Range(0, 3);
            dog.staminal = (DogData.StaminalLevel)Random.Range(0, 2);
            dog.speed = (DogData.SpeedLevel)Random.Range(0, 2);
            DogList.Add(dog);
            Debug.Log($"dog.size = {dog.size}");
        }
    }

    public DogData GetDog()
    {
        DogData dog = DogList[Random.Range(0, DogList.Count)];

        return dog;
    }
}