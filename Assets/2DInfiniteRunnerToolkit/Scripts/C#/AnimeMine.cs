using UnityEngine;
using System.Collections;

public class AnimeMine : MonoBehaviour
{
    public Texture2D Bird0;					//The first frame of the animation
    public Texture2D Bird1;					//The second frame of the animation
    
    int currentId = 0;							//The ID of the current frame



    //Called on every frame
    void Update()
    {
        //If the animation is enabled
        //   if (canAnimate)
        //    {
        //Start the animation coroutine
        StartCoroutine(Animate());
        //  }
    }
    //The animation coroutine
    IEnumerator Animate()
    {

        //If the current animation frame is 0
        if (currentId == 0)
        {
            //Wait for 0.1 seconds
            yield return new WaitForSeconds(0.05f);
            //Go to animation frame 1
            this.renderer.material.mainTexture = Bird0;
            currentId = 1;
        }

        if (currentId == 1)
        {
            //Wait for 0.1 seconds
            yield return new WaitForSeconds(0.05f);
            //Go to animation frame 1
            this.renderer.material.mainTexture = Bird1;
            currentId = 2;
        }

        else
        {
            //Wait for 0.1 seconds
            yield return new WaitForSeconds(0.08f);
            //Go to animation frame 0
            this.renderer.material.mainTexture = Bird0;
            currentId = 0;
        }

        //Enable the calling of a new coroutine
        // canAnimate = true;
    }
}
