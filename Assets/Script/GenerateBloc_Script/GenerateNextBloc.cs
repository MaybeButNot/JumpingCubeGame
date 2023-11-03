using UnityEngine;

public class GenerateNextBloc : MonoBehaviour
{
    [SerializeField] private GenerateBlocController _GBController;

    private int _lastBlocIndex;
    private GameObject _nextBloc;

    private void Start()
    {
        SetupStartingBloc();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + _GBController.NextTriggerPosition);
            Process();
        }
    }

    private void SetupStartingBloc()
    {
        _lastBlocIndex = Random.Range(0, _GBController.BlocListUltimate.Count - 1);
        GetRandomBloc();
        GenerateBloc();
    }

    private void Process()
    {
        GetRandomBloc();
        GenerateBloc();
    }

    private void GetRandomBloc()
    {
        int random = Random.Range(0, _GBController.BlocListUltimate[_lastBlocIndex].NextBlocList.Count - 1);

        _nextBloc = _GBController.BlocListUltimate[_lastBlocIndex].NextBlocList[random];
        _lastBlocIndex = _GBController.BlocList.IndexOf(_nextBloc);
    }

    private void GenerateBloc()
    {
        GameObject generatedBlock = Instantiate(_nextBloc, new Vector2(0, transform.position.y - 1), transform.rotation);
        generatedBlock.transform.SetParent(_GBController.Tower);
    }
}