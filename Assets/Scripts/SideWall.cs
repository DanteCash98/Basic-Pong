using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour
{
    private void OnTriggerExit2D (Collider2D hitInfo) {
        if (hitInfo.name != "Ball") return;
        bool east = hitInfo.transform.position.x > 0;
        GameManager.Score(east);
        hitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
    }
}
