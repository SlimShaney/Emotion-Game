using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagementScript : MonoBehaviour {

    public static void KillPlayer (GameObject Player)
    {
        Destroy(Player);
    }


}
