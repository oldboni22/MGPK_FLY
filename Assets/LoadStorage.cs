using System.Collections;
using UnityEngine.AddressableAssets;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class LoadStorage : MonoBehaviour
{
    [SerializeField] private StorageReference _storageReference;

    [SerializeField] private LoadingWheel _wheel;
    private void Awake()
    {

        AsyncOperationHandle<Storage> storageHandler = _storageReference.LoadAssetAsync<Storage>();
        storageHandler.Completed += (x) =>
        {
            _wheel.Stop();
            Storage.SetInstance(storageHandler.Result);
        };
    }
}
