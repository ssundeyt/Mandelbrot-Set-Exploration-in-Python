# Mandelbrot-Set-Exploration-in-Python
MAJOR UPDATE!!!

The installation process is now 100% automated! I have build a C# UI to setup, load and modify the scripts automatically, no coding experience needed!!

Here is the download for the entire thing: https://www.mediafire.com/file/2yx3p5helllcrsd/Mandelbrot-Set-UI.zip/file

Just unzip it and go!

The C# forms app is included in the repo.

# Work in progress: Currently working on implementing a 'create' section for the C# app. The purpose is to let the user select an area of interest in the set and change the amount of iterations, color etc. That will generate a .py script than will be run on command. Preview of the function:

![alt text](https://i.gyazo.com/c1d03e1e83dd4fbec53b76897f779f55.png)

# Prerequisites
- Python (version 3.6 or newer)
- An IDE like PyCharm or VSCode (optional, but recommended for ease of development)

# Video Guide !
https://www.youtube.com/watch?v=3EavsWr0UMQ

# Step-by-Step Instructions

1. **Clone the Repository**

   Begin by cloning this repository to your local machine using Git:
   ```
   git clone <repository-url>
   ```
   Replace <repository-url> with the actual URL of this GitHub repository.

   You can also download the code from GitHub, doesnt matter.

2. **Install Build Tools**

   To build the Cython module, you need the correct build tools.

   You can get VS Build tool from here: https://visualstudio.microsoft.com/visual-cpp-build-tools/

   Run the installer and select the "C++ build tools" workload. (top left option)

3. **CD Inside the Install Location**
   
   Open CMD and cd inside the location where you installed the script, e.g:
   ```
   cd C:\Users\yourUser\Mandelbrot-Set-Exploration-in-Python
   ```

4. **Install Required Packages**

   Install the necessary packages using pip:
   ```
   pip install -r requirements.txt
   ```

5. **Prepare the Cython Extension**

   Ensure the .pyx Cython file (mandelbrot_cy.pyx) is in your project directory along with the setup.py file for compiling the Cython code.
   Compile the Cython code by running:
   ```
   python setup.py build_ext --inplace
   ```

6. **Running the Project**

   Now just run one of the scripts (but not the 'Setup.py' file)

   You can either just start them as are inside the folder without using an IDE, or you can launch them in an IDE. BE PATIENT, some of the scripts may take time to generate a picture, be patient. Shouldnt take more than a minute

   NOTE: I have provided some scripts that generate different parts of the set (e.g. startfish.py, elepthantvalley.py etc.) But you can make your own ones by just changing the coordinates

# Additional Notes
In the project, I have provided constantzoom.py. That, when ran, will create a folder inside the main file called "mandelbrot-zoom..." LET THAT SCRIPT RUN if you want a zooming GIF of the set. The script will, when done, remove the folder and export all the images to a GIF that you can open and watch the zoom!

I have also provided a few other scripts (e.g. elephantvalley.py starfish.py and many more). When ran, these will output a single image of that sequence. The image should be displayed within you IDE (you dont need to open them manually as with the GIF)

You, as a user, can change a lot of stuff in the script, e.g. the color coding. In this line:
```
ax.imshow(mandelbrot_result.T, origin='lower', extent=(xmin, xmax, ymin, ymax), cmap='magma')
```
Replace cmap='magma' with another color coding from matplotlib. Here are some examples:
```
Blues, Greens, Greys, Oranges, Purples, Reds, viridis, PiYG, PRGn, BrBG, PuOr, RdGy, RdBu, twilight, twilight_shifted, Pastel1, Pastel2, Paired, Accent, Dark2, Set1, Set2, Set3, viridis, plasma, inferno, hot, magma, cividis
```
THEY ARE CASE SENSITIVE so dont mess that up. There are many more and you can play around with them.
