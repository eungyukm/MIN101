using UnityEngine;

public class OwnerSystem : MonoBehaviour
{
    public static OwnerSystem Instance;

    [SerializeField] private SaveOwnerSO saveOwnerSO;
    
    [SerializeField] private GameObject buyButtonPrefab;
    [SerializeField] private GameObject gridLayoutRoot;

    private void Awake()
    {
        if (Instance == null)
        {
            // FindObjectOfType은 전체 씬에서 OwnerSystem을 찾는 코드
            Instance = FindObjectOfType<OwnerSystem>();
        }
    }

    private void Start()
    {
        CreateBuyButton();
    }

    private void CreateBuyButton()
    {
        foreach (Owenr owner in saveOwnerSO.ownersData)
        {
            GameObject buyButton = Instantiate(buyButtonPrefab, gridLayoutRoot.transform);
            buyButton.GetComponent<OwnerBuyButton>().SetOwnerData(owner);
        }
    }
}