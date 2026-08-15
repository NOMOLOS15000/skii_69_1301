using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;
    public static UIManager Instance;

    [SerializeField]
    private GameObject restartButton;

    [SerializeField]
    private Player player;
    internal static object instance;

    void Awake()
    {
        Instance = this;
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }

    public void RestartGame()
    {
        player.transform.position = new Vector3(0f, 88f, -86.25f);
        player.HP = 100;
        ShowNotiText("Restart");
        Time.timeScale = 1f;
        ShowHideRestartButton(false);
    }


    public void ShowHideRestartButton(bool flag)
    {
        restartButton.SetActive(flag);
    } 



}
