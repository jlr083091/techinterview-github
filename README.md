To sastify the requirements I have uploaded all files to get hub.  They can easily be forked from the repo and ran by opening the solution provided by the asp .net mvc application.

For convience, I've taken advantage of microsoft's trial with azure to publish the website on the net via
http://jamesratcliffghev.azurewebsites.net/

IDE : Visual Studio
asp .net mvc application

This was my first real time application using mvc.  I chose this route for convience and because of its flexibility to run via the web and mobile.

Technical Interview Homework: GitHub Dashboard

##Purpose The purpose of this exercise is to assess the candidate’s ability to build cross platform software clients that satisfy stated requirements. The completed assignment should not only satisfy the requirements outlined below, but also give the candidate an opportunity to show-off their skills.

##Prerequisites

Candidates must have a GitHub account
##Instructions

Fork this repository - https://github.com/Praeses/techinterview-github
Create a client that satisfies the requirements below
Include, at the top of this README, instructions required for the reviewer to run the submission
Include, at the top of this README, any other information that will be useful to the reviewer
Create a pull request prior to the due date to have your submission reviewed
Once the submission is reviewed the candidate will be notified and possibly invited to participate in a follow-up interview where interviewers will collaboratively work with the candidate to review the submission, discuss possible enhancements, and possibly implement a new feature.

#####Additional Notes...

Feel free to ask your point of contact any clarifying questions you might have.
Submissions must be relatively trivial to run as outlined in the candidate's instructions. We suggest that you test the run instructions on a clean clone of your repository. Submissions we can't run per the instructions will be rejected.
Client technology for the submission is at the discretion of the candidate, Preferred platforms include the following...
Xamarin - Xamarin Studio or Visual Studio
HTML/CSS/JS (touch friendly, tablet/phone targeted)
Native iOS - Xcode
Native Android - Android Studio
Windows/Phone - Visual Studio
Third party libraries or packages are acceptable but must be managed via a package manager i.e. Nuget, CocoaPods, npm, bower, etc. Third party components will NOT be manually installed by the reviewer.
##Assessment

Cross platform client development requires a familiarity and aptitude to work with...

Client platforms: iOS, Android, Windows, Web Browsers, etc.
Presentation layer frameworks: Native iOS & Android, Cordova, HTML/CSS/JS, etc.
HTTP based APIs
#####Assessment will focus on the candidate's ability to...

Review and understand API documentation.
Consume an API, and present API content in a client.
Write clear, understandable, and maintainable code. Please use the predominant coding style for whatever language the submission is written in.
Create a simple and understandable user interface and user experience. Note that clear and understandable does NOT mean graphically interesting.
The user experience should be targeted at a mobile screen size, preferably tablet optimized yet functional on a phone sized screen.
#####Exceptional Candidates will...

Submit a solution that will run on both iOS and Android
Have a simple architecture that is easy to enhance and extend
##Requirements - GitHub Dashboard GitHub has a public API that will be used for this assignment. We will be displaying content from the GitHub API in a user "dashboard."

#####Resources

GitHub API
#####Minimum Requirements

The client will have a title clearly indicating the purpose and content of the client.
The client will be touch friendly.
The client will display a feed of GitHub public events available at the following endpoint
Public Events url: https://api.github.com/events
Events Documentation: https://developer.github.com/v3/activity/events/
Each public event displayed in the feed will display user friendly values for...
Username
Event Type
Repository to which the event applies
The client will have a button to refresh the feed of public events.
The client will allow a user to tap the public event and display event details.
#####Optional (stretch) Enhancements

Implement a "pull down" to refresh the feed of public events.
On the public event details screen...
Display a user's avatar next to their name.
Provide a link/button to display in the app or a separate browser window the GitHub repository's main web page.
Authenticate a GitHub user
Display the authenticated user's username and avatar in client-platform typical location
Display a feed of the Events performed by the authenticated user
https://developer.github.com/v3/activity/events/#list-events-performed-by-a-user
Support screen rotation