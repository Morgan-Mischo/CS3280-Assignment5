# CS3280-Assignment5
Assignment 5 from CS 3280 - Object Oriented Windows using C# at Weber State University with Shawn Crowder

Create a math game for young kids in WPF.  This game should be themed with material a small child would enjoy.  For instance, if you had a son/daughter that liked Star Wars, use pictures and sounds from the Star Wars movies.  Or you could do a sports themed game so that when they get an answer correct, they see and hear a crowd cheering.  The Game will consist of 3 Windows, which will be the main menu window, the game window, and the final score window.
Main Menu Window
            When the game first starts the main menu window will be displayed.  This window will allow the user to enter their information, choose the game type, and begin playing the game.  The user’s information will consist of their name and age.  The game type options the user may choose from are Add, Subtract, Multiply, and Divide.  These options must be displayed using radio buttons.  The window will also have a “Begin Game” button.  When the user clicks this button, the entered information must be validated.  If the name is blank, or the age is not a valid number between 3 and 10, or a game type has not been selected, then a red error label describing what the user needs to fix will be displayed.  For instance, if the user didn’t enter a name, then a label with red text will appear telling the user “Please enter your name to continue”.
Game Window
            If the user’s entered information is valid, then the main menu window is hidden and the game window displayed.  As the game is being played the user should have the option to cancel the current game and return to the main menu.  The game will consist of ten randomly generated questions.  The random numbers should be kept between 1 and 10 so that the game is easy to play for a young child.  So, based on the game type, each question must be randomly generated.  For instance, if the game is addition, then two random numbers will need to be generated (between 1 and 10) for each question and displayed to the user. 
The game window will have a “Start” button that will begin the game.  When the “Start” button is clicked a timer, which goes off every second, will begin.  This timer is used to time how long it takes the player to answer all ten questions.  When the user answers the final question, this timer is stopped, and that is the game time.  As the user is playing the game, the game timer will be displayed to the user so they know how many seconds has elapsed.
When the game starts, the first randomly generated question will appear.  So the first question may be “1 + 2 = ___”.  At this point the program waits for the user to enter their answer, then click a “Submit” button.  The user may also press the “Enter” key to submit their answer.  When the user submits their answer, they are told, via a label, whether or not their answer was correct.  At this point, the current question and answer are cleared away and the next question is displayed.  This will continue until all ten questions have been guessed (right or wrong).  Do not force the user to get answers correct before moving to the next question.
After all ten questions have been answered the final score window should be automatically displayed, and the game window hidden. 
Final Score Window
When the final score window is displayed, the following information should be displayed: user’s name, age, number of correct answers, number of incorrect answers, and time took to complete the game.  The background for final score window should be changed based on the number of correct answers.  If the user gets between 0 and 4 correct answers, display an image that conveys a low score.  If the user gets between 5 and 7 correct answers, display an image that conveys an average score.   If the user gets between 8 and 10 correct answers, display an image that conveys a high score.
When the user closes the final score window, they will be taken back to the main menu window where they can choose to play again.
 
 
General Guidelines
            Be careful when choosing questions for the user.  Remember that this is for small children.  You want the questions to have random numbers (between 1 and 10), but you also want them to make sense.  For instance, if the subtraction game is being played, the answer should not be negative.  If the game being played is division, then the answer should be a whole number (10 / 2 = __).
            The purpose of this game is to become more familiar with the use of classes.  You will need to create classes of at least types “User” and “Game”.  Make sure to keep all your business logic out of the UI.  This means no logic behind the UI for generating or answering questions.
The “User” class will hold all of the user’s information (Name and age).  The “Game” class will be used to create the game questions.  The type of game will be passed into this class so that the class can generate the appropriate questions.  Also, the answer to each question will be passed into this class and the class will determine if the answer was correct or not.
All methods need to have exception handling.  Top level methods need to handle the exception and alert the user to the exception, and lower level called methods need to raise the exception up to calling methods.  See example “Chapter 13 Exceptions”.
 
How to play a sound (use only .wav files):
Put the .wav files in the same folder as the exe.  If you get an exception playing the file make sure it is a .wav file.  If you find other file types, such as .mp3, that you want to play, you will have to convert them to .wav files, there are websites that can do this for you.
 
SoundPlayer simpleSound = new SoundPlayer("My.wav");
simpleSound.Play();
 
To set an Image as the background in XMAL:
1. Create a folder called "Images" in the project.
2. Right click on the folder, select "add", "existing item", then select your image.
3. Select the image, then in the properties window for "Build Action", select "Content".
4. Next select your main window in the XAML, then in the properties window, select "Brush", "Background", select a "Tile Brush”, then for "ImageSource" click on the drop down and selected the image.
 
To set an Image as the background in XAML in the code at runtime:
1. Do steps above 1 through 3, then use this code:
ImageBrush myBrush = new ImageBrush(new BitmapImage(new Uri(@"Images/MyImage.jpg", UriKind.Relative)));
wndMain.Background = myBrush;
 
EXTRA CREDIT for Math Game (10 Points)
The extra credit for the math game is to create a high score feature in the math game.  This will consist of converting the final scores screen into a top 10 high scores screen. 
Once the user has completed a game, the user should be taken to the top 10 high scores screen.  The user’s score should be displayed on the high score screen along with whether or not they made the top ten high scores.  The score will consist of the number of correct answers, the number of incorrect answers, and their time.  The high score list will be based off of the number of correct answers, then time.  So, if two scores have the same number of correct answers, then the score with the lowest time will decide which one is a higher score.  After the high score screen is displayed the user may return to the main screen to play the next game of their choice
The “Scores” class will be used to keep track of the top ten high scores.  This class should have the current score passed into it, and it should sort the top ten scores.
Commonly Missed Items
- Didn't meet the requirement "red error label describing what the user needs to fix will be displayed"
- Didn't meet the requirement to validate the user's age "If the name is blank, or the age is not a valid number between 3 and 10".
- Requirement to theme the game for children.
- The division part of the program, questions need to divide evenly.
- The requirements state that there should be 10 timed questions, not that each question should be timed.
- Timer Should display just number of seconds, not a date/time.
- Program crashes if invalid data is entered in user info screen.
- Program crashes if invalid data is entered for the user's guess.
- Didn’t meet requirement to allow the user to press "enter" to submit an answer
- Didn’t meet requirement “The user is then told whether the answer is correct or not, and the current answer is cleared away.”
- Final score screen requirements not implemented.
- Didn't meet requirement "a Timer will appear, showing elapsed seconds"
- Didn’t meet requirement “After all ten questions have been answered the final score screen should be displayed. “
- Didn't meet requirement "After the final score screen is displayed the user may return to the main screen to play the next game of their choice"
- Didn't meet requirement "If the user gets between 0 and 4 correct answers, display an image that conveys a low score.  If the user gets between 5 and 7 correct answers, display an image that conveys an average score.   If the user gets between 8 and 10 correct answers, display an image that conveys a high score."
- Final score screen not displaying the user's data and the user's score.
- Game doesn't allow the user to play more than one game
- Before the game is started, the user may press "enter" in the answer textbox and questions start appearing.
- User can submit an answer before the game is started.
- All class attributes and methods need a XML comment.
- All methods need a try catch.
- Try catch not implemented correctly.  Top level methods need to handle the exception and calling methods need to throw the exception with meaningful information.
- A requirement was to have all logic in “User” and “Game” classes.
