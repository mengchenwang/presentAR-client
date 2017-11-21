# PresentAR
#### An augmented reality presentation aid.   
Presentar allows you to harness the power of AR, and display 3D models which can be manipulated in real-time, wherever you are. 3D models and their assosiated Image Targets are uploaded to [the companion website](https://presentar.herokuapp.com/) and can then be accessed through this client app. The Image Targets are recognised using Vuforia Cloud Recognition and the 3D models are downloaded on-the-fly in the app using the AWS link stored in the image target metadata. This allows the user to add new models and image targets without having to interact directly with either Unity or the Vuforia Developer Portal.


Technologies used
----
- Unity
- Vuforia

About the Technologies
----

Unity is a cross-platform game engine that enables Programmers to develop video games for PC, Consoles, Mobile devices, Tablets and Websites.<br>

Unity provides a multi platform game development tool with customisable and ready to use editor, graphical pipelines to DirectX and OpenGL, advanced physics engine, 2D and 3d physics, C# and JavaScript scripting, built in code editor.<br><br>

Vuforia is an Augmented Reality Software Development Kit (SDK) for mobile devices that enables the creation of Augmented Reality applications. It uses Computer Vision technology to recognize and track planar images (Image Targets) and simple 3D objects, such as boxes, in real-time.<br>

Tested using:
----
- NUnit
