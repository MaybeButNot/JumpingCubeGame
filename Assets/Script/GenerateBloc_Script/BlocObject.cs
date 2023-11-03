using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocObject : MonoBehaviour
{
    [SerializeField] private GameObject _bloc;
    [SerializeField] private List<GameObject> _nextBlocList;

    public GameObject Bloc { get { return _bloc; } }
    public List<GameObject> NextBlocList { get {  return _nextBlocList; } }
}
