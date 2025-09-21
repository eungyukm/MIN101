using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // 싱글톤
    public static UIManager Instance;
    
    [SerializeField] private TMP_Text GoldText;
    [SerializeField] private TMP_Text DateText;
    [SerializeField] private TMP_Text TimeText;
    [SerializeField] private TMP_Text MiningText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = FindObjectOfType<UIManager>();
        }
    }

    private void Start()
    {
        InitText();
    }

    void InitText()
    {
        GoldText.text = $"Gold : 0";
        DateText.text = $"Date : 2025";
        TimeText.text = $"Time : 00:00";
        MiningText.text = $"Mining : 100";
    }

    public void UpdateGold(int gold)
    {
        GoldText.text = $"Gold : {gold}";
    }
}
