using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Configs/PlayerConfings")]
public class PlayerCFGS : ScriptableObject
{
    [SerializeField] PlayerCFG[] CFGs;

    public PlayerCFG GetConfigById(int levelId)
    {
        foreach(PlayerCFG cFG in CFGs)
        {
            if (cFG.levelId == levelId)
                return cFG;
        }

        return null;

    }
}
