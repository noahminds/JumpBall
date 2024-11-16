# JumpBall
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
- **Success Indicators**: Players progress the ball towards the clearly marked flag post. When they reach the objective a sucess screen flashes up with the option to play again.

## DevLog
#### Entry 1 - Nov 16, 2024
- **Morning**:
    - Created the red ball prefab using the Unity editor.
    - Created ground prefabs of three different sizes so I can build the level using the Unity editor. Included a grass sprite to add aesthetic appeal.
    - Implemented collisions between the ball and the ground using an EdgeCollider2D component.
- **Afternoon**:
    - Implemented the camera follow script to follow the ball.
    - Implemented the ball movement script including jumping and rolling left and right.