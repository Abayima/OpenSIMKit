OPEN SIM KIT v1.0 "GULU"
========================

Open SIM Kit (OSK) is an open source toolkit for modifying the contents of SIM cards. 

OSK consists of 3 major components: the main application, which allows users to gain access to the functionality via its interface, as well as extensions and drivers. Extensions allow developers to extend the functionality of the main Open SIM Kit application, while drivers allow developers to develop wrappers for the various devices that they aim to make Open SIM Kit work for.


INTRODUCTION
------------

Open SIM Kit (OSK) is a technology platform for sharing digital information using feature phones while removing mobile service providers as the ‘middle-man’. The goal is to offer a discreet and resilient means for communication during scenarios where mobile networks have either been compromised or otherwise disrupted.

This document outlines the goals of the project, the potential use cases, and timeline for the release of the open source project.

	Find us on Github - http://github.com/Abayima/OpenSIMKit
	Documentation - http://opensimkit.com/documentation

NOTE: Contact jon@d8a.com with additional questions or feedback.


INSTRUCTIONS
------------

The Zip file contains the following when extracted...

	* OpenSIMKit.jar (JAR file, auto executes on Mac and Windows).
	* lib folder: Dependencies that OpenSIMKit looks for. All dependencies are included.
	* javadoc: A javadoc (This is only for developers who need it.)

To launch OSK...

	* On MacOSX double clicking OpenSIMKit.jar will invoke the application if Java is installed. If it's not OSX will download and install what it needs for the Java runtime. 
	* On Windows Java will have to be downloaded and installed. You can then just double click OpenSIMKit.jar to run it automatically.
	* On Linux the command to be run shall be java -jar ./OpenSIMKit.jar provided JDK is installed on the Linux machine.
	
Setting up OSK....
	
	* Upon the first launch of OpenSIMKit a new folder called 'plugins' will be created. Within that folder there are two other folders, 'drivers' and 'extensions'. These folders are where you may place addons and extension drivers.

The JAR file already has all dependencies compiled within itself.


PROJECT OVERVIEW AND ORIGINS
----------------------------

The primary challenge being addressed is how we might allow citizens to share news and information when communication networks are compromised.  This is particularly relevant to those residing in developing countries.  

There is a secondary challenge that is addressed - turning the SIM-mobile phone combination into a viable publishing platform for content distribution without relying upon mobile networks and SMS. This will allow for the distribution of digital content to feature phone users in a way that does not rely upon a connection to mobile networks. Use cases might include distributing public health information, digital text books, or sports and entertainment news. 


CONTRIBUTORS AND CONTACTS
-------------------------

Developed and maintained by the team at D8A...

Jon Gosier		jon@d8a.com  
Ahmed Maawy		ahmed@d8a.com
Matt Griffiths	matt@d8a.com 


FOLLOW US ON TWITTER
--------------------

@abayima - General Abayima news and information  
@opensimkit - News and updates related to the open source SimKit project  
@OSK_Daemon - Follow our code commits to GitHub  



