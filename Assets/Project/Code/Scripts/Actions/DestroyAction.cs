using System.Collections;
using UnityEngine;

namespace Project.Actions
{
    [DefaultExecutionOrder(1)]
    public class DestroyAction : MonoBehaviour
    {
        [SerializeField] private GameObject _objectToDestroy = null;
        
        private Coroutine _destroyCoroutine = null;
        private float _passedSeconds = 0;
        
        public void DestroyObject(float delaySeconds)
        {
            if (_destroyCoroutine == null)
                _destroyCoroutine = StartCoroutine(DestroyCoroutine(delaySeconds));
        }

        private IEnumerator DestroyCoroutine(float delaySeconds)
        {
            do
            {
                _passedSeconds += Time.deltaTime;
                yield return null;
            } while (_passedSeconds < delaySeconds);
            
            var destroyable = _objectToDestroy == null ? gameObject : _objectToDestroy;
            Destroy(destroyable);
        }

    }
}