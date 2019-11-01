using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace PlayModeTests
{
    public class CollectableMock
    {

        float timer;


        // A UnityTest behaves like a coroutine in Play Mode.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            while (timer < 3)
            {
                Debug.Log("1");
                timer += UnityEngine.Time.deltaTime;
                yield return null;
            }

            Assert.IsTrue(true);
        }

        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses2()
        {

            while (timer < 5)
            {
                Debug.Log("2");
                timer += UnityEngine.Time.deltaTime;
                yield return null;
            }

            Assert.IsTrue(true);
        }
    }
}
