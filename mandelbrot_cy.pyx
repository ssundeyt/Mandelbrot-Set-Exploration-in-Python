# mandelbrot_cy.pyx

from libc.math cimport abs as c_abs  # Use Cython's wrapped function for absolute value

cdef inline double complex c_square(double complex c):
    return c * c

cpdef int mandelbrot(double complex c, int max_iter):
    cdef double complex z = 0
    cdef int n = 0
    while c_abs(z) <= 2 and n < max_iter:  # Use Cython's c_abs for complex numbers
        z = c_square(z) + c
        n += 1
    return n
