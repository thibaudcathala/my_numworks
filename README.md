# my_numworks - NumWorks Emulator on Unity
Numworks is a graphical calculator where you can write python like program to create graphical experience only by modiffing the color of the pixel of the screen and getting the color of a pixel.
The screen resolution of the numworks is 320x222 pixels.

## How to use

1. clone the repository
2. launch the unity project

![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/529cce57-08e8-4fc0-b7f4-0c921fc5c719)

3. Now that you have launched the project you can :
  - launch the emulator and execute an example program

  ![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/7f431c17-a8e3-4484-9221-3ba5f882d6bb)

  - create a new script in the `Programs` folder and code your own program that you can execute by launching the emulator and selecting your program in the menu

  ![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/51788c7e-1f0d-4d8b-8b07-2514e98b9e45)

---------
## How to create a simple program

1. create a new .cs script
2. remove the default content of the public class of your script :

  ![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/5e74e237-4951-4fca-a7fc-d2378c8e1d2f)

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

  ![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/cef9dcd5-aca0-4515-8c3c-261f83dc0ee8)

- and then use modules :

  ![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/9889c17b-ddd7-41f9-8ed8-8f9b1d671afe)

-------
## Example program

There is 2 example program for now

### Mandelbrot

This is a program that draw the mandelbrot fractal

![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/19526921-cd8d-4c5a-a980-11331c37a142)

### Clock

This is program that draw a clock showing the current hour, minute and seconde

![image](https://github.com/thibaudcathala/my_numworks/assets/114906947/25b6c954-8313-4d29-93db-00eca8c58dc4)
