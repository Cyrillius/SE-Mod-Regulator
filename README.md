# SE-Mod-Regulator
a regulator mod for SpaceEngineer

## Software used
- Autodesk Inventor (to create a 3D model)
	
	http://www.autodesk.com/education/free-software/inventor-professional

- Blender 2.73a (to apply texture and convert in .fbx)

	http://www.blender.org/
	
- FBX Converter (to convert into the new version of fbx)

	http://usa.autodesk.com/adsk/servlet/pc/item?siteID=123112&id=22694909
	
- Adobe Photoshop CS6

- Visual Studio Community 2013

	http://www.visualstudio.com/fr-fr/products/visual-studio-community-vs
	
## Tasks done

1) create a 3d model with inventor

2) export the model in .stl

3) configure Blender

http://youtu.be/rX6ghqPKXiE
	
4) unwrap model 

http://youtu.be/9VxIFLqgHcY

5) modify texture with Photoshop

6) apply texture to the model and export in .fbx

http://youtu.be/SU-jd8fF6ss
	
7) convert the fbx into the new version

8) put regulator.fbx and regulator.xml into the mwmBuilder directory

9) build .mwm in executing this command:   

mwmbuilder /s:"regulator.fbx" /o:"regulator.mwm" /f /c:Models$

10) convert texture.png in texture texture_test_de.dds with visual studio

11) create texture_test_ns.dds as a transparent picture

12) create an icon in .dds

13) create into C:\Users\$username\AppData\Roaming\SpaceEngineers\Mods a directory as you can in release/[mod]Regulator-cyrillius-v0.0

14) Test if it works

15) create a visual studio project

http://youtu.be/gAh1bNfRLPw
	
## Tasks in progress
implement the pid regulator script
	
