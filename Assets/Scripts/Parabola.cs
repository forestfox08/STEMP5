using UnityEngine;

public class Parabola : MonoBehaviour
{
    [SerializeField] Point point;
    int PointAmount = 10;
    Vector2 minScreen, maxScreen;

    QuadraticFunction f;
    void Start()
    {
        minScreen = Camera.main.ScreenToWorldPoint(Vector2.zero);
        maxScreen = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        
        f = new QuadraticFunction(1, 2, 3);

        
        
        for (int i = 0; i < PointAmount; i++)
        {
            float x_Pos = minScreen.x
            Point copyOfPoint = Instantiate(point);
            copyOfPoint.transform.position = new Vector3(i, 0, 0);
        }
    }
}
