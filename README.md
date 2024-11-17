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
    - Implemented the camera follow script to follow the ball. This adds to the aesthetics of the game by keeping the ball in the center of the screen and allowing the player to navigate a larger level.
    - Implemented the ball movement script including jumping and rolling left and right.
- **Afternoon**:
    - Added a vertically moving platform object.
        - Experienced difficulties with interactions between the ball and the moving platform. When the moving platform moved downwards, the ball would lag behind. This issue was resolved by changing the way that the platform's position was updated - using it's rigidbody2D component instead of transform.
    - Added a horizontally moving platform object - changing the movement script to move the platform between specified positions (transforms).
    - Added a spike object that results in the game resetting when the ball collides with it.
        - I made the decision to reset the game when the ball collides with the spike object rather than breaking the ball into smaller balls. This was a design decision to keep the game simple.
- **Evening**:
    - Added a flag post object that the ball can reach to complete the level.
    - Added a success screen that flashes up when the ball reaches the flag post and prompts the player to restart the game.
    - Implemented the GameManager script to allow the player to complete the level upon reaching the flag (the objective) and restart the game by pressing the R key.
    - Also allow the user to reset the level at any time by pressing the ESC key.

    