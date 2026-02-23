# Matto's Blazor Quiz

This is a quiz that I developed using the Blazor framework. Currentyl it consists of 2 pages

Home - The page that the user is directed to upon loading the application. It gives a brief summary of the quiz and the categories, alongside a 'Play Quiz' button that directs the user to the quiz page. 

Matto's Quiz - This is the main quiz page, the user is directed to a prompt with a 'Begin' button which will load the first question of the quiz. The user should then answer each question by clicking on one of the options. After answering each question, they will be notified on whether their answer is correct or incorrect. If the user's answer is correct, the answer will be highlited in green, the text containing the correct answer will be highlighted in bold and the text 'Correct!' will appear below. If the user's answer is incorrect, their answer will be highlighted in red with text in bold, while the correct answer will be highlighted in green with emboldened text. the text 'Incorrect!' will appear below the options, with the correct answer being displayed below that.

A button labelled 'Next Question' will appear on the bottom left which will take the user to the text question in the quiz. There is also a 'Retry' button on the bottom right which will allow the user to restart the quiz from the beginning. When clicked on an alert that reads 'Are you sure you would like to restart this quiz from the beginning?' will appear with 'OK' and 'Cancel' options (as it is a confirm window). Clicking on 'OK' will direct the user back to the Begin screen while clicking on 'Cancel' will show an alert which reads 'Continue the quiz' and the quiz will resume.

At the end of the quiz, the user will be able to see their score out of 20, with the number of correct answers, incorrect answers, score out of 20 and score as a percentage being visible. There is also a 'Play Again' button which will allow the user to restart the quiz. 
