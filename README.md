# in-class-activities
## Devlogs
### W1
Hello World!
Basically what happens when the camera is no longer a parent of the cat anymore it becomes a static stand in place camera. It is no longer attached to the movement of the cat, thereby not allowing you to follow in any perspective of the character you are controling. It is similar to, for example, old Gary's mod animations, where you have control of the character but not the camera. When an object is not the child of another, it does not move with that parent, thereby staying complely stagnant in relation to the game object it was once attached to, or running a completly different type of code all together. they just disconect, parents are like a grouping tool that keep all movements together. 


### W2
Question 1: The R, G, B variables are all floats instead of whole ints because all of those values corrispond to each color values, including intencities, darkness, lighness, and many other things. So all of those values need to be represented by more spescific values instead of just whole numbers, hence the decimal float. 
Question 2: The bounce variable is an int instead of any of those other variables because it is a whole number that corrisponds to the units in which a ball bounces up or down, you don't need fractional jumps in that instance. 
Question 3: The error in that code for that section that unity made me aware of was that a semi colon was expected. The only thing I needed to do in order to fix that issuse was just to add a semi colon at the end of that statement

### W3
1. You would attribute the SetLightDimness to an intiger value, and then you would use a void return type. The reason it would be an int is because the sanity level goes up by whole numbers, attributed to santity (the perameter) which could also be linked to an integer. It is a void return type because the question states that the meathod does not require an output.

2. Classes are like a music box, they are the external shell and format in which a song is placed inside. Components are the pins and gears inside the Classes that define the music it plays. The member variables are the music sheets that change one note (or game object) at a time to really fine tune the sound. All together they make a music box capable of being changes by many variables to sound different based on what the listener wants to hear. (I did no get to talk about this with my group, I had to so this individually since everyone left.)

3. I think it gets extremely bright when it bounnces too many times because of the sussession of the bouncing driving up the average of both x and y velocities. The code is also tied to color values, so as the multiplyer gets pushed exponentially, so does the brightness of the color. Basically (from what I observed) The color just booms because of the velocity ramping up per the bouncing.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 3