using UnityEngine;
using System.Collections;

public class Debugging : MonoBehaviour {

    private void Awake()
    {
        int from = 0;
        int to = 100000000;

        for(float factor = 0.0f; factor <= 1.0f; factor += 0.1f)
        {
            int result = (int)(from * (1.0f - factor) + to * factor);

            DevDebug.Log.Normal(result);
        }
    }
}
