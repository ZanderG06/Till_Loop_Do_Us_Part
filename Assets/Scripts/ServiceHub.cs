using UnityEngine;

public class ServiceHub : MonoBehaviour
{
    public static ServiceHub Instance { get; private set; }

    [SerializeField] private UIManager uiManager;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private DialogueManager dialogueManager;
    [SerializeField] private QuestManager questManager;
    [SerializeField] private LevelManager levelManager;

    public UIManager UIManager => uiManager;
    public PlayerController PlayerController => playerController;
    public DialogueManager DialogueManager => dialogueManager;
    public QuestManager QuestManager => questManager;
    public LevelManager LevelManager => levelManager;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }
}
