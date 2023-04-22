using System;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps) 
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private Transform _transform;
    private void Awake()
    {
        Instantiate(_gameObject, _transform);
    }
}