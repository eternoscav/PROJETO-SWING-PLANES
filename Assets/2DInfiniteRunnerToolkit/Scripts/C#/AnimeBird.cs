using UnityEngine;
using System.Collections;

public class AnimeBird : MonoBehaviour
{
    public Texture2D Bird0;					//The first frame of the animation
    public Texture2D Bird1;					//The second frame of the animation
    public Texture2D Bird2;		
    public Texture2D Bird3;		
    public Texture2D Bird4;			
    public Texture2D Bird5;		
    public Texture2D Bird6;			
    public Texture2D Bird7;		
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
            yield return new WaitForSeconds(0.08f);
            //Go to animation frame 1
            this.renderer.material.mainTexture = Bird0;
            currentId = 1;
        }

        if (currentId == 1)
        {
            //Wait for 0.1 seconds
            yield return new WaitForSeconds(0.08f);
            //Go to animation frame 1
            this.renderer.material.mainTexture = Bird1;
            currentId = 2;
        }

        if (currentId == 2)
        {
            //Wait for 0.1 seconds
            yield return new WaitForSeconds(0.08f);
            //Go to animation frame 1
            this.renderer.material.mainTexture = Bird2;
            currentId = 3;
        }
        if (currentId == 3)
        {
            //Wait for 0.1 seconds
            yield return new WaitForSeconds(0.08f);
            //Go to animation frame 1
            this.renderer.material.mainTexture = Bird3;
            currentId = 4;
        }
        if (currentId == 4)
        {
            //Wait for 0.1 seconds
            yield return new WaitForSeconds(0.08f);
            //Go to animation frame 1
            this.renderer.material.mainTexture = Bird4;
            currentId = 5;
        }
        if (currentId == 5)
        {
            //Wait for 0.1 seconds
            yield return new WaitForSeconds(0.08f);
            //Go to animation frame 1
            this.renderer.material.mainTexture = Bird5;
            currentId = 6;
        }
        if (currentId == 6)
        {
            //Wait for 0.1 seconds
            yield return new WaitForSeconds(0.08f);
            //Go to animation frame 1
            this.renderer.material.mainTexture = Bird6;
            currentId = 7;
        }
        //If the current animation frame is 1
        else
        {
            //Wait for 0.1 seconds
            yield return new WaitForSeconds(0.08f);
            //Go to animation frame 0
            this.renderer.material.mainTexture = Bird7;
            currentId = 0;
        }

        //Enable the calling of a new coroutine
       // canAnimate = true;
    }
}
