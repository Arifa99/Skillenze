# Anatomic
An unity based AR Project.

The project stimulates a 3D model in AR view by locating it via a ring ground detecting meachanism. 
The sole purpose of the project is to make education more interesting and fun. This project is specific to Medical field but the idea can be extended to any other department.

# Project structure
The project has been modularized via different scripts to tackle each functionality.
The GameManger coordinates the entire working of differnt gameObjects and Scripts. Other scripts include the IndicatorPlacement and ModelGenerator script. 
The IndicatorPlacement scripts helps in detecting a floor to place the model on. A ring structure gets displayed after a floor has been detected.
After the floor has been detected a model an be pressed by selecting it from the scrollBar embedded at the bottom of the page.

Assets folder holds the following subfolders
- Models : This folder holds the 3D models to be used in the app
- Prefabs: This folder holds those gameObjects that are frequently needed in the scene.
- Resources: A helper folder to save some additional resources
- Scenes : Holds the current unity scene.
- Textures : This folder holds all the textures extracted from the different models
- Sprites : This folder holds the sprites(.svg, .png, ,jpg) that are need for the UI/UX.


# Working
The app is highly easy to use, providing an easy to follow navigation throughout the scene.
The first screen is the splash screen that goes away on user's touch. The next screen starts detecting the floor and a scrollBar is placed at the bottom of the screen. All the buttons depict a model(here anatomy models) to be placed on the screen.
Once a model is selected it gets placed onto the ring.
The user can also zoom in the model as well as rotate it. Thus, the models are interactive.

