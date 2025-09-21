using UnityEngine;

public class ActionManager : MonoBehaviour
{
    private ConditionManager conditionManager;

    void Awake()
    {
        Debug.Log("Awake");
        conditionManager = GetComponent<ConditionManager>();
    }
    
    void Start()
    {
        Debug.Log("Start");
        RunAction();
    }

    void RunAction()
    {
        conditionManager.GoToRun();
    }
}
