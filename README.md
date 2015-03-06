TutorQ Suite
============

This is the TutorQ program used by the al-Kwarizmi Math Advising Resource Center at Tacoma Community College for issueing and responding to tutoring requests. 

TutorQ
------

Central program that processes and displays requests from computers and radio frequency remotes. It also logs all relevant data about each request.

TutorQConfig
------------

Configuration program for the central TutorQ application. Can place TutorQ in testing mode so the RF reciever and remotes are not needed during development. The configuration program also sets registry keys directing TutorQ to csv files for keypad mappings and data logging.

TutorQClient
------------

The computer client used to issue user requests in place of an RF remote.

TutorQClientConfig
------------------

Points the client towards the shared directories used to communicate with the central TutorQ program.

Compilation Notes
-----------------

Compile for x86, the program throws errors when compiled for x64. Open the projects from the .sln files and this should already be preconfigured.

### Credits

Created by David Straayer. Being maintained by Joshua Ogden.