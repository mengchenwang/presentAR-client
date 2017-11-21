# PresentAR
#### An augmented reality presentation aid.   
Presentar allows you to harness the power of AR, and display 3D models which can be manipulated in real-time, wherever you are. 3D models and their assosiated Image Targets are uploaded to [the companion website](https://presentar.herokuapp.com/) and can then be accessed through this client app. The Image Targets are recognised using Vuforia Cloud Recognition and the 3D models are downloaded on-the-fly in the app using the AWS link stored in the image target metadata. This allows the user to add new models and image targets without having to interact directly with either Unity or the Vuforia Developer Portal.


## Technologies used
----  
<img src="https://unity3d.com/profiles/unity3d/themes/unity/images/company/brand/logos/primary/unity-master-black.svg" width="60">

Unity is a cross-platform game engine that enables Programmers to develop video games for PC, Consoles, Mobile devices, Tablets and Websites. Here it is used to build the client app and integrate Vuforia AR functionality. Since it is cross-platform, the client app can be built for any device supported by Unity.


![Vuforia](https://www.vuforia.com/content/dam/vuforia/hompage/singles/Vuforia%20Logo%20OLx2a896.png)

Vuforia is an Augmented Reality Software Development Kit (SDK) for mobile devices that enables the creation of Augmented Reality applications. It uses Computer Vision technology to recognize and track planar images (Image Targets) and simple 3D objects, such as boxes, in real-time.

## How to use this app  
----  
Currently this project must be built onto a phone or other device using Unity. Due to the limitations around storing entire Unity projects on GitHub, the project must be rebuilt using the files stored here, although the GameObjects and their relationships must be set up manually in the Unity Project. We hope to eventually release a version on the app store to enable anyone to download and use the app.
