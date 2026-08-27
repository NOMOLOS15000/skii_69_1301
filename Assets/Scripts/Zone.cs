using Unity.VisualScripting;
using UnityEngine;

public class Zone : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        Debug.Log("out");
        if (player == null)
            return;

        player.HP -= 100;

        if (player.HP <= 0)
        {
            player.HP = 0;
            UIManager.Instance.ShowNotiText($"You are DEAD\nPoint: {player.Point}");
            UIManager.Instance.ShowHideRestartButton(true);
            Time.timeScale = 0f;
        }

    }
}
