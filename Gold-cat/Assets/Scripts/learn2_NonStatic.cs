using UnityEngine;

public class learn2_NonStatic : MonoBehaviour
{
    // 儲存場景上物件或元件
    public GameObject cat;

    public Transform catTran;

    public Camera cam;

    public ParticleSystem ps;

    // 靜態與非靜態差異
    // 非靜態需要有物件或元件

    // 存取
    // 非靜態屬性

    private void Start()
    {
        // 取得
        print(cat.tag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
