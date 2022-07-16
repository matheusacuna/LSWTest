using UnityEngine;


namespace Managers
{
    public class InputManager : MonoBehaviour
    {
        public MyInputs input;

        private void Awake()
        {
            input = new MyInputs();
        }

        private void OnEnable()
        {
            input.Enable();
        }

        private void OnDisable()
        {
            input.Disable();
        }
    }

}
