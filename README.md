# JumpBall

## How to Play
### Goal
The goal of the game is to navigate the red ball through the level to reach the flag post.

### Controls
- **Move Left**: Press the left arrow key.
- **Move Right**: Press the right arrow key.
- **Jump**: Press the space bar.

### Progress Indicators
- The camera follows the ball, keeping it centered on the screen, allowing you to see your progress through the level.
- Navigating moving platforms and obstacles such as spikes will indicate that you are progressing through the level. Players need to navigate these obstacles to reach the flag post at the end.
- Hitting spikes or falling off the level will result in a game over condition, resetting the game. A sound effect will play to indicate failure.
- Reaching the flag post at the end of the level is the final objective and will play a success sound effect that indicates you have completed the level.

### Achieving the Goal
- When you reach the flag post, a success screen will flash up, indicating that you have completed the level and prompting you to play again by pressing the 'R' key.

### Avoiding Stuck States
- The game will reset if you fall off the level or collide with any spikes, ensuring you do not get stuck. The game will freeze briefly before resetting and plays a sound effect to indicate failure.
- Once the objective is reached, the player can restart the level by pressing the 'R' key.

### Tips
- Set the screen size to Full HD (1920x1080) for the best viewing experience.
- Set the scale of the Game in the Unity Editor to the minimum for the best viewing experience.

## Preliminary Game Design
- **Inspiration**: This game was inspired by a childhood game called Red Ball. The game was a simple 2D platformer where the player controlled a red ball that could navigate obstacles across 10 levels to reach the goal.
- **Game Concept**: A 2D platformer where the player controls a red ball that can jump to reach the goal.
- **Game Mechanics**:
    - The player can move the ball left and right.
    - The player can jump the ball.
    - The camera pans with the movement of the ball within the scene.
- **Level Design**:
    - The initial plan is to build a single level.
    - The level will include moving platforms that the ball can use to reach the objective (a flag post).
    - There will be obstacles such as spikes.
    - Spikes can result in a game over condition where the big red ball breaks into a couple of small red balls, and the game over screen flashes up.

#### Aesthetic Goals
- **Simplicity**: The game should have a simple and clean design. The red ball has a black line to help indicate the direction of movement. The ground will have a simple grass sprite in places to add aesthetic appeal.
- **Success Indicators**: Players progress the ball towards the clearly marked flag post. When they reach the objective a sucess screen flashes up indicating they completed the level and prompting them to play again.

#### Core Loop
- **Core Mechanics**: The player navigates the level, avoiding falling and obstacles, searching for the flag post to reach the end of the level. Sound effects indicate failure and success.
- **Aesthetic Goals**: With the camera following the player, the player can focus on the core mechanics of moving the ball through the level without seeing the entire level at once, providing an aspect of discovery as they progress through the level.

## Development Log - Final Reflections

### Summary of Initial Goals
Originally, I set out to create a simple 2D platformer inspired by a childhood Flash game that I loved called Red Ball.

### Final Goals
By the end, my goals evolved to include more obstacles and more complex mechanics than I originally envisioned. For example, my moving platforms did not just move up and down, but I actually was able to create them to move between specified positions, making them more dynamic. I also added a crate object that the player could push around to help overcome obstacles.

### Accomplishments
I successfully implemented the core mechanic of the game, added moving platforms, obstacles, a flag post, and sound effects. The game includes a complete and challenging level with a success screen and restart functionality once the player reaches the end. I'm proud of the experience my final game offers.

### What Went Right
- The core mechanics of jumping worked well from the beginning.
- I was quickly able to create the elements of my scene using the Unity editor directly as well as a few simple free sprites that I downloaded (see CREDITS.txt).
- The camera follow script was easy to implement and added to the aesthetics of the game.
- Implementing moving platforms was relatively straight forward however I did encounter bugs with the mechanics of the red ball which I explain below.

### What Went Wrong
- I had significant bugs in the player's movement resulting from the platform interactions:
    - In part this was due to the scales of the objects being different meaning that the red ball would warp when its transfrom was assigned as a child of the moving platform. Resolving this issue required rescaling the sprites. 
    - I seperately observed that the ball was lagging behind the platform when it moved downwards. This was resolved by changing the way that the platform's position was updated - using it's rigidbody2D component instead of transform.
- It was difficult to attach the sound effects to the intended events. Resolving this required refactoring the way I handled win and game over conditions before resetting the game.

### Lessons Learned
- Understanding the importance of consistent object scaling in Unity is crucial to avoid unexpected behavior.
- Using Rigidbody2D for platform movement ensures smoother interactions with other physics objects.
- Mechanics should be designed with sound effects in mind from the beginning to avoid refactoring later on.