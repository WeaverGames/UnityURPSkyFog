# Unity URP Sky Fog
A fog implementation for URP that fades to the skybox colour
This particular project is in Unity 2021.1.10f1 and it's important to note it uses the still experimental Render Objects features in the URP Forward Renderer

![alt text](https://github.com/WeaverGames/UnityURPSkyFog/blob/main/githubEmbeds/SkyFog1.png?raw=true)

## To Load the Demo Scene
Navigate to SkyFog > Scenes > FogSceneDemo

## How it Works
It uses the full view depth of the Camera frustum and it linerarly interpolates the fog alpha after an object hits the specified percentage in the fogStartPercent setting in the SkyFog material. 

Eg if your camera has a max view distance of 1000 and SkyFog has fogStartPercent set to 0.5, all objects 0 - 500 units away from the camera will have 0% fog applied to them. At 500+ units they will linearly fade to the sky colour. If you want the fade to happen further back you can increase the fogStartPercent to your needs in relation to your camera view distance.

## How to use
The system works just using cubemaps unfortunately. To capture the procedural skybox there is a reflection probe that captures nothing in the default scene and clears with a skybox. There is a simple script on it called SkyboxCubemapExtractor.cs that will take that cubemap baked in it and set it to the SkyFog material. If you wish to use cubemaps for your skybox instead you can just directly set this property in the SkyFog Material itself.

#### Disclaimer
This example code is provided as is and I make no guarentees it will work for future or past versions of URP.
