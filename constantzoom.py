#!/usr/bin/env python
# coding: utf-8

# In[1]:


import numpy as np
import matplotlib.pyplot as plt
import imageio
import os
import shutil
from matplotlib.colors import LinearSegmentedColormap

from mandelbrot_cy import mandelbrot

def mandelbrot_set(xmin, xmax, ymin, ymax, width, height, max_iter):
    r1 = np.linspace(xmin, xmax, width)
    r2 = np.linspace(ymin, ymax, height)
    mandelbrot_result = np.empty((height, width), dtype=np.int32)
    
    for i in range(height):
        for j in range(width):
            mandelbrot_result[i, j] = mandelbrot(r1[j] + 1j * r2[i], max_iter)
    return (r1, r2, mandelbrot_result)

def mandelbrot_zoom_animation(xmin, xmax, ymin, ymax, width, height, max_iter, zoom_center, zoom_factor, steps, cmap='hot', output='mandelbrot_zoom.gif'):
    temp_dir = 'mandelbrot_zoom_frames'
    if os.path.exists(temp_dir):
        shutil.rmtree(temp_dir)
    os.makedirs(temp_dir)

    filenames = []
    for i in range(steps):
        x_center, y_center = zoom_center
        x_range = xmax - xmin
        y_range = ymax - ymin

        xmin = x_center - x_range / zoom_factor / 2
        xmax = x_center + x_range / zoom_factor / 2
        ymin = y_center - y_range / zoom_factor / 2
        ymax = y_center + y_range / zoom_factor / 2

        fig, ax = plt.subplots()
        x, y, mandelbrot_result = mandelbrot_set(xmin, xmax, ymin, ymax, width, height, max_iter)
        ax.imshow(mandelbrot_result.T, origin='lower', cmap=cmap, extent=(xmin, xmax, ymin, ymax))
        filename = f'{temp_dir}/step_{i+1:03}.png'
        filenames.append(filename)

        fig.canvas.draw()
        
        plt.savefig(filename)
        plt.close()

    with imageio.get_writer(output, mode='I') as writer:
        for filename in filenames:
            image = imageio.imread(filename)
            writer.append_data(image)

    shutil.rmtree(temp_dir)
    
colors = [(0, 0, 0), (0, 0, 1), (0, 1, 0), (1, 0, 0), (1, 1, 1)]  
n_bins = [3, 6, 10, 100]
cmap_name = 'cccmap'
custom_cmap = LinearSegmentedColormap.from_list(cmap_name, colors, N=100)

mandelbrot_zoom_animation(
    xmin=-2.0, xmax=1.0, ymin=-1.5, ymax=1.5,  
    width=600, height=600,  
    max_iter=256,  
    zoom_center=(-0.743643887037151, 0.131825904205330), 
    zoom_factor=1.15, 
    steps=100,  
    cmap=custom_cmap, 
    output='mandelbrot_zoom.gif'  
)


# In[ ]:




