# Mandelbrot-Set-Exploration-in-Python
A simple yet amazing Mandelbrot exploration script in python!

# Prerequisites
- Python (version 3.6 or newer)
- An IDE like PyCharm or VSCode (optional, but recommended for ease of development)

# Step-by-Step Instructions

1. **Clone the Repository**

   Begin by cloning this repository to your local machine using Git:
   ```
   git clone <repository-url>
   ```
   Replace <repository-url> with the actual URL of this GitHub repository.

2. **Install Required Packages**

   Install the necessary packages using pip:
   ```
   pip install -r requirements.txt
   ```

3. **Prepare the Cython Extension**

   Ensure the .pyx Cython file (mandelbrot_cy.pyx) is in your project directory along with the setup.py file for compiling the Cython code.
   Compile the Cython code by running:
   ```
   python setup.py build_ext --inplace
   ```
   (this should be ran inside a terminal in your IDE)

4. **Running the Project**

   Open the Python script (converted from your Jupyter notebook) in your IDE or text editor. If using PyCharm, you can simply open the project directory to access and run the script.
   Ensure your IDE's Python interpreter is set to the one from your virtual environment to access the installed packages.

   NOTE: I have provided some scripts that generate different parts of the set (e.g. startfish.py, elepthantvalley.py etc.) But you can make your own ones by just changing the coordinates

# Additional Notes
In the project, I have provided 
