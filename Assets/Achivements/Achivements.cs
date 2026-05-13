using UnityEngine;

[CreateAssetMenu(menuName = "Achivement")]
///<summary>
/// Charlie Dobson
/// 
/// This is a script that makes Achivements a scriptable object, rather than fully hardcoded. 
///</summary>
public class Achivements : ScriptableObject
{
    public string achivementName;
    public string achivementDescription;
    public int achivementID;

    bool hasAchivementBeenGotten;


}
