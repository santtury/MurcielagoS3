using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
//Clase donde se estan los metodos de las pruebas unitarias
namespace Tests {
    public class Test {
        // A Test behaves as an ordinary method

        /*Prueba Cubo
        */

        [Test]
        public void Test1 () {
            GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
            cube.AddComponent<Rigidbody> ();
            cube.transform.position = new Vector3 (5, 5, 0);
            Assert.True (cube != null);
        }
        //Crea un objeto tipo Roca el cual se toma de Prefabs
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
        /*Crea un objeto tipo Enemigo el cual se toma de Prefabs
        La posicion esta definida antes*/
        [UnityTest]
        public IEnumerator Tes3 () {
            GameObject gameGameObject = MonoBehaviour.Instantiate
             (Resources.Load<GameObject> ("Prefabs/Enemy"));
            Enemy game = gameGameObject.GetComponent<Enemy> ();

            Assert.True (game.initialPosition == new Vector3(0,0,0));
            yield return null;
        }

        /*Crea un Game Object
         */
         [UnityTest]
        public IEnumerator Test4 () {
            GameObject gameGameObject = MonoBehaviour.Instantiate
             (Resources.Load<GameObject> ("Prefabs/Enemy"));
            Enemy game = gameGameObject.GetComponent<Enemy> ();
            Assert.True (game.player==null);
            yield return null;
        }

        /*Este metodo prueba el objeto ItemWorld 
          el cual no tiene script  
        */
           [UnityTest]
        public IEnumerator Test5 () {
            GameObject gameGameObject = MonoBehaviour.Instantiate
             (Resources.Load<GameObject> ("Prefabs/ItemWorld"));
            BoxCollider2D b=  gameGameObject.GetComponent<BoxCollider2D> ();
              Debug.Log(b);
            Assert.True (b.isTrigger);
            yield return null;
        }
    }
}