using System.Collections;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine;

[CreateAssetMenu(menuName = "Configs/Storage")]
public class Storage : ScriptableObject
{
    static Storage _instance;
    public static Storage instance => _instance;

    [SerializeField] private SkinCFG _skin;
    [SerializeField] private WindowsCFG _windows;
    [SerializeField] private PlayerCFGS _playerConfigs;
    [SerializeField] private AudioCFG _audio;
    [SerializeField] private EndImgCFG _endImg;


    public static void SetInstance(Storage storage)
    {
        _instance = storage;
    }

    public SkinCFG Skin => _skin;
    public WindowsCFG Windows => _windows;
    public PlayerCFGS PlayerConfigs => _playerConfigs; 
    public AudioCFG Audio => _audio;
    public EndImgCFG EndImg => _endImg;
}
[System.Serializable]
public class StorageReference : AssetReferenceT<Storage>
{
    public StorageReference(string guid) : base(guid)
    {
    }
}