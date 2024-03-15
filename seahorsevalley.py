#!/usr/bin/env python
# coding: utf-8

# In[16]:


import numpy as np
import matplotlib.pyplot as plt
from mandelbrot_cy import mandelbrot
from matplotlib.colors import LinearSegmentedColormap

def mandelbrot_set(xmin, xmax, ymin, ymax, width, height, max_iter):
    r1 = np.linspace(xmin, xmax, width)
    r2 = np.linspace(ymin, ymax, height)
    mandelbrot_result = np.empty((height, width), dtype=np.int32)
    
    for i in range(height):
        for j in range(width):
            mandelbrot_result[i, j] = mandelbrot(r1[j] + 1j * r2[i], max_iter)
    return mandelbrot_result

# Seahorse valley region
xmin, xmax = -0.748, -0.744
ymin, ymax = 0.1, 0.104
width, height = 2000, 2000
max_iter = 1000 #defines the detail in generation, user can change this to achieve more/less details, sky is the limit

mandelbrot_result = mandelbrot_set(xmin, xmax, ymin, ymax, width, height, max_iter)

fig, ax = plt.subplots(figsize=(20, 20))
ax.imshow(mandelbrot_result.T, origin='lower', cmap='inferno', extent=(xmin, xmax, ymin, ymax))
ax.set_title('Seahorse Valley')
plt.show()


# In[ ]:




