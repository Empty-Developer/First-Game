# The Release Of My First Project Video Game! :video_game:!
<p>The game was created as a practice. It was made in a week, and all I knew about game development was how to draw objects, and i didn't know how to write triggers and scripts, a lot of things were taken from the internet, but I also used my knowledge of languages!</p>

## Moments that need to be explained
The project is implemented for the first time, everything in it, I am completely satisfied, even if it was written horribly, but it is the first experience. I didn't follow **SOLID** principles and **PATTERNS** because I didn't understand the structure of the project!

**ANY QUESTIONS?**
1. You're gonna finish the project?
    * :negative_squared_cross_mark: No, I'm not going to finish the project, I don't see the point in it, it was made out of an argument to prove that a programmer (*who doesn't know game development*) can make a game in a week. I'm glad I got it at all, and I'm happy with the outcome! 
2. Will you be doing any more projects like this?
    * :white_check_mark: Yes, the plan is to realize a 2D game similar to "*Stardew Valley*". All the design and gameplay I want to realize myself, **use normal system** and **patterns** in order that it would not be shameful to show it!
3. Will you do projects on other development environments? 
    * :white_check_mark: Yes, there is an idea to implement the next game on ***Unreal Engin***, but the development there is much more complicated, I'd rather think about it, dut want to practice in this environment!

## What I didn't like about the project!
Well definitely did not not like the health system, it is so terrible that in subsequent projects, the idea to redo it!
``` C#
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public static int health;
    public GameObject Heart1, Heart2, Heart3;

    private void Start()
    {
        Heart1.SetActive(true);
        Heart2.SetActive(true);
        Heart3.SetActive(true);
        health = 3;
    }

    private void Update()
    {

        switch (health) {
            case 3:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(true);
                break;
            case 2:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(false);
                break;
            case 1:
                Heart1.SetActive(true);
                Heart2.SetActive(false);
                Heart3.SetActive(false);
                break;
            case 0:
                Heart1.SetActive(false);
                Heart2.SetActive(false);
                Heart3.SetActive(false);
                break;



        }
    }
}
``` 
> Otherwise, it's fine (no).
___
© 2025 GitHub 