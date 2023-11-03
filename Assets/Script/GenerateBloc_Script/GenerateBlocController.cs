using System;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBlocController : MonoBehaviour
{
    [SerializeField] private Transform _tower;
    [SerializeField] private int _nextTriggerPosition;
    [SerializeField] private List<BlocObject> _blocListUltimate;

    private List<GameObject> _blocList;


    private void Awake()
    {
        GenerateBlocList();
    }

    private void GenerateBlocList()
    {
        _blocList = new List<GameObject>();

        for (int i = 0; i < _blocListUltimate.Count; i++)
        {
            _blocList.Add(_blocListUltimate[i].Bloc);
        }
    }

    public List<GameObject> BlocList { get { return _blocList; } }
    public Transform Tower { get { return _tower; } }
    public int NextTriggerPosition { get {  return _nextTriggerPosition; } }
    public List<BlocObject> BlocListUltimate { get { return _blocListUltimate;} }
}