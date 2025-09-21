using UnityEngine;

public class GachaSystem : MonoBehaviour
{
    [SerializeField] private GachaDataSO gachaData;
    
    public static GachaSystem Instance { get; private set; }

    private void Awake()
    {
        gachaData.CreateRandomDogs();

        if (Instance == null)
        {
            Instance = FindObjectOfType<GachaSystem>();
        }
    }

    public void PrintGachaData()
    {
        Debug.Log(gachaData.GetDog().name);
    }
}