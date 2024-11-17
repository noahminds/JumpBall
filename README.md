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
- Reaching the flag post at the end of the level is the final objective.

### Achieving the Goal
- When you reach the flag post, a success screen will flash up, indicating that you have completed the level and prompting you to play again by pressing the 'R' key.

### Avoiding Stuck States
- The game will reset if you fall off the level or collide with any spikes, ensuring you do not get stuck.
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
    - The player can restart the level by pressing the R key.
- **Level Design**:
    - The initial plan is to build a single level.
    - The level will include moving platforms that the ball can use to reach the objective (a flag post).
    - There will be obstacles such as spikes.
    - Spikes can result in a game over condition where the big red ball breaks into a couple of small red balls, and the game over screen flashes up.
#### Aesthetic Goals
- **Simplicity**: The game should have a simple and clean design. The red ball has a black line to help indicate the direction of movement. The ground will have a simple grass sprite in places to add aesthetic appeal.
- **Success Indicators**: Players progress the ball towards the clearly marked flag post. When they reach the objective a sucess screen flashes up indicating they completed the level and prompting them to play again.
#### Core Loop
- **Core Mechanics**: The player navigates the level, avoiding falling and obstacles, searching for the flag post to reach the end of the level.
- **Aesthetic Goals**: With the camera following the player, the player can focus on the core mechanics of moving the ball through the level without seeing the entire level at once, providing an aspect of discovery as they progress through the level.