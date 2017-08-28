# AR-test

This is a test augmented reality (AR) application to learn more about how AR works
and what types of things are possible within an AR application. It is a fairly
simple application that allows a user to interact with virtual assets. The targets
for this application are all images, which are set up as image targets in the
project. The application is currently only built to run using a webcam.  

This project was built using Unity and Vuforia.

## Installation and Set Up  
Below are the instructions for installing this application.
*These instructions are valid as of 2017.08.28*

### Environment Set Up  
1. Clone this repository to your local environment.
  1. Fork this Github repo.
    1. In a web browser, visit https://github.com/NFabrizio/AR-test
    2. Click the Fork button in the upper right corner of the screen
    3. In the "Where should we fork this repository?" pop up, select your username.
    Github should create a fork of the repo in your account
  2. Clone your fork of the AR-test repo.
    1. In the terminal on your local environment, navigate to the directory where
    you want to clone the AR-test repo  
      `cd ~/path/to/your/directory`
    2. In the terminal, run:  
      `git clone [clone-url-for-your-fork]`  
      The URL should be in the format git@github.com:YourUsername/AR-test.git
2. Open the project in Unity.

## Application Use
In Unity, start the project in the Unity player. The webcam should turn on and be
viewable in the Unity player window. Bringing the target images into the view of
the webcam, should allow the project to target them and render the virtual assets.

One of the target images will render a zombie walking on grass. This is not an
interactive virtual asset, but is only to demonstrate the basics of AR. The other
target images should render a spinning Pearson logo with text that says, "CLICK HERE".
These assets are interactive and contain a virtual button that can be clicked by
moving your hand in front of the image where the spinning logo is being rendered.
When the virtual button is clicked it will toggle the logo spin animation, so the
spinning will stop/start each time the virtual button is "clicked".

To stop the project from running, simply stop the project in the Unity player by
clicking the play button again.
