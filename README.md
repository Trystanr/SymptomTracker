# Interaction Development 300

<h3 align="center">Trystan Rivers 2020</h3>
<br />
<br />
<p align="center">
  
  <h3 align="center">SymptomTracker</h3>

  <p align="center">
    daily symptom tracking
    <br />
    <a href="#about-the-project"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://youtu.be/2GKO030cIpA">View Demo</a>
    ·
    <a href="https://www.youtube.com/watch?v=fu3nwZ_8Yvw">Advert Spot</a>
  </p>
</p>

## Table of Contents

* [About the Project](#about-the-project)
  * [Built With](#built-with)
* [App Features](#app-features)
* [User Guide](#user-guide)
  * [Installing and running the project](#installing-and-running-the-project)
  * [Install Prerequisites](#install-prerequisites)
  * [Migrate the Database](#migrate-the-Database)
  * [Update the Database](#update-the-database)
  * [Using the app](#using-the-app)
* [Demo Video](#demo-video)
* [Extremely helpful projects](#extremely-helpful-projects)


## About The Project

Are you interested in logging your COVID symptoms daily?

SymptomTracker is a serverside .NET application which allows a user to create an account and log their symtpms for the day.

The brief for this project was to create a COVID-19 Relief App with CRUD functionality.

### Built With

#### Frameworks
* EntityFrameWorkCore
* SqlServer
* Identity
* Bootstrap
* FullCalender
* Browserlink
* Timeago
* Fontawesome 5
* jQuery

#### Languages
* C#
* CSHTML
* Javascript
* CSS


### App Features:
* Model View Controller
* Authentication
* CRUD
* COVID-19 Symptom Input
* Full landing website for marketing and brand development
* Calendar view
* Reactive language (timeago)
* UX Experiences
* Microinteractions


### User Guide
#### Installing and running the project

1. Clone this repo to your local Windows machine.
1. Open SymptomTracker.sln in Visual Studio.
1. Install prerequisite Nuget packages (see below). 
1. Migrate and initialize the database (see below). 
1. Select SymptomTracker as your run target.
1. Ensure BrowserLink is set up to your browser.
1. Run (Ctrl+F5).
1. The project will be running on your web browser.

#### Install Prerequisites
`Install-Package Microsoft.EntityFrameworkCore.SqlServer`

`Install-Package Microsoft.EntityFrameworkCore.Tools`

`Install-Package Microsoft.VisualStudio.Web.BrowserLink`

#### Migrate the Database
`Add-Migration InitialCreate`

#### Update the Database
`Update-Database`

### User Guide
#### Using the app

1. Create an account by clicking on Register.
1. Fill in the Registration form.
1. Log in using your email and password from registration.
1. Click on log symptom and fill in the form to log your symptoms for the day.
1. You will see logged symptoms as cards.


### Demo Video
[Advert Spot](https://www.youtube.com/watch?v=fu3nwZ_8Yvw)

[Project Demo](https://youtu.be/2GKO030cIpA)


### Extremely helpful projects: 
I couldn't have completed my own project without the core principles and frameworks these apps taught.


[DotNetCore Example Todo](https://gitlab.com/RuanDeNecker/dotnetcore-example-todo/) - Provided a framework for Dot Net Core MVC.

[Apple Covid Tool](https://www.apple.com/covid19/) - Provided a framework of Covid related questions.