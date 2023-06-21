# my_numworks - NumWorks Emulator on Unity
Numworks is a graphical calculator where you can write python like program to create graphical experience only by modiffing the color of the pixel of the screen and getting the color of a pixel.
The screen resolution of the numworks is 320x222 pixels.

## How to use

1. clone the repository
2. launch the unity project

![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/917006e5-b2c5-4753-9b1d-2cbad67eb8a5)

3. Now that you have launch the project you can :
  - launch the emulator and execute a example program

  ![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/18e954f7-405c-4fc7-b2a7-ac6c9b24dc71)

  - create a new script in the `Programs` folder and code your own program that you can execute by launching the emulator and selecting your program in the menu

  ![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/e2915313-7059-4a44-b66e-3d1538aedd25)

---------
## How to create a simple program

1. create a new .cs script
2. remove the default content of the public class of your script :

  ![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/1834193d-d951-4a67-922c-18de744fc31a)

3. now that you have and empty program copy past this code snippets in your program :

```cs
void Start()
{
    StartCoroutine(main_func());
}

IEnumerator main_func()
{
    // code here
    yield return null;
}
```

4. you can now code in the "main_func" that you can rename if you want, the line `yield return null;` is there to control the flow of the program
- You can use :
  -
```cs
yield return null;
```
To pause the program and continue in the next frame
```cs
yield return new WaitForSeconds(2f);
```
To pause the program for 2 seconds
```cs
yield break;
```
To completly end the program

take a look at the default program included in the progect to see how to use the in real case

------
## How to use Default Module

- With the emulator is given 3 default module that contain multiple function for different purpose :
    - kandinsky
    - math
    - random

- to import those module you have to simply put those line at the top of your program :

  ![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/7925e01a-041b-4b85-b20e-35f848fcf621)

- and then use modules :

  ![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/7f046566-328b-4dc2-9324-16632e0a77e4)

-------
## Example program

There is 2 example program for now

### Mandelbrot

This is a program that draw the mandelbrot fractal

![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/c4e398ad-8bd7-4889-af9d-947e2ec80fed)

### Clock

This is program that draw a clock showing the current hour, minute and seconde

![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/973d424c-090c-44d6-9898-afdc83ba5e78)

