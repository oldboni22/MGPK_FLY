using UnityEngine;


[CreateAssetMenu(menuName = "Configs/EndIMG")]
public class EndImgCFG : ScriptableObject
{
    [SerializeField] Sprite[] images;

    public Sprite GetById(int Id) => images[Id - 1];
}
