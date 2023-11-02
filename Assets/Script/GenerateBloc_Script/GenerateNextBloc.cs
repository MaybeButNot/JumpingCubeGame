using UnityEngine;

public class GenerateNextBloc : MonoBehaviour
{
    [SerializeField] private GenerateBlocController _GBController;
    private GameObject _randomBloc;

    private void Start()
    {
        GetRandomBloc();
        GameObject generatedBlock = Instantiate(_randomBloc, new Vector2(0, transform.position.y - 1), transform.rotation);
        generatedBlock.transform.SetParent(_GBController.tower);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + _GBController.nextTriggerPosition);
            Process();
        }
    }

    private void Process()
    {
        GetRandomBloc();
        GenerateBloc();
    }

    private void GetRandomBloc()
    {
        int random = Random.Range(0, _GBController.blocList.Count);

        while (_randomBloc == _GBController.blocList[random])
        {
            random = Random.Range(0, _GBController.blocList.Count);
        }

        _randomBloc = _GBController.blocList[random];
    }

    private void GenerateBloc()
    {
        GameObject generatedBlock = Instantiate(_randomBloc, new Vector2(0, transform.position.y - 1), transform.rotation);
        generatedBlock.transform.SetParent(_GBController.tower);
    }
}
