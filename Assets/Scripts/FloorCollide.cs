using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollide : MonoBehaviour
{
    private void OnTriggerExit2D (Collider2D hitInfo) {
        if (hitInfo.name != "Ball") return;
        hitInfo.gameObject.SendMessage("ReverseDirection", SendMessageOptions.RequireReceiver);
    }
}
