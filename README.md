# Fractaliser
Create "fractals" from the idea of self-copying images. https://www.youtube.com/watch?v=b-Fa6HtvGtQ

## How it works?
https://www.youtube.com/watch?v=b-Fa6HtvGtQ showcased the idea 
of using a PowerPoint which took objects on a slide showing its own slide. 
In this way, the process shown was recursive; every time PowerPoint needed to 
render the slide, it needed to render the object within it, all the way down to the
base object. 

The concept shown there is applied to Bitmaps in this program. Instead of constantly
re-rendering each Bitmap, a Bitmap is composed of "Copy Regions" and "Shapes". These
Copy Regions can show the "previous" Bitmap, while the Shapes act as something to put
on the Bitmap (rendering nothing wouldn't be fun at all!)

This program is *not* recursive. It stores a previous image in a Bitmap object, and 
creates a new one based on all Copy Regions and Shapes. It then replaces the previous
image with the image created. It takes the same time to create a new image with 100
"Shapes" (that aren't physical objects after application on to the Bitmap) as it does
to create an image with one "Shape".

The program's possibilities are still largely untested, and still undergoing testing.
Features will be added. More shapes will be added. It will be fun.

Thanks, Matt Parker, for your video! It was truly fun!

## Screenshots
![Editing a Copy Region](https://sevr.org/i/a925d28d-5079-4cd0-9b9a-fce066a1da52.png)
![Editing a Shape](https://sevr.org/i/89986ac2-f370-40b4-bcd9-38178513f733.png)
![Initial rendering](https://sevr.org/i/892ea9d1-5ca1-4bd5-8d6d-86e223d9ee38.png)
![Further rendering](https://sevr.org/i/1d1ffade-5f07-4ad6-bbcd-035bab425f6e.png)
