using UnityEngine;

namespace Challenge_2.Scripts
{
    public class PlayerControllerX : MonoBehaviour
    {
        public GameObject dogPrefab;
        public float delay;
        private float timer = Mathf.Infinity;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (timer > delay)
                {
                    Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                    timer = 0;
                }
            }

            timer += Time.deltaTime;
        }
    }
}