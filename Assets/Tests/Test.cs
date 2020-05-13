using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests {
    public class Test {
        // A Test behaves as an ordinary method
        [Test]
        public void Test1 () {
            //Este test no tiene sentido solo se criea un cubo y ya jajajaj
            GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
            cube.AddComponent<Rigidbody> ();
            cube.transform.position = new Vector3 (5, 5, 0);
            Assert.True (cube != null);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator Test2 () {
            GameObject gameGameObject = MonoBehaviour.Instantiate
             (Resources.Load<GameObject> ("Prefabs/Rock"));
            Rock game = gameGameObject.GetComponent<Rock> ();

            Assert.True (game.player == null);
            yield return null;
        }
        [UnityTest]
        public IEnumerator Tes3 () {
            GameObject gameGameObject = MonoBehaviour.Instantiate
             (Resources.Load<GameObject> ("Prefabs/Enemy"));
            Enemy game = gameGameObject.GetComponent<Enemy> ();

            Assert.True (game.initialPosition == new Vector3(0,0,0));
            yield return null;
        }
         [UnityTest]
        public IEnumerator Test4 () {
            GameObject gameGameObject = MonoBehaviour.Instantiate
             (Resources.Load<GameObject> ("Prefabs/Enemy"));
            Enemy game = gameGameObject.GetComponent<Enemy> ();
//que prueba se le ocuurre? Yo tenia pensado esta
            Assert.True (game.player==null);
            yield return null;
        }
           [UnityTest]
        public IEnumerator Test5 () {
            GameObject gameGameObject = MonoBehaviour.Instantiate
             (Resources.Load<GameObject> ("Prefabs/ItemWorld"));
            BoxCollider2D b=  gameGameObject.GetComponent<BoxCollider2D> ();
              Debug.Log(b);
// pues no se como obtener una colision sin un script,pero se puede verificar que el boxcoll
//ider de ese gameobject sea un trigger
            Assert.True (b.isTrigger);
            yield return null;
        }
    }
}